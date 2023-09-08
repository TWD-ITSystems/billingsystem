using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BillingSystem
{
    public partial class formMRSDownload : Form
    {
        public string username = "";
        dbCommercialEntities dbContext = new dbCommercialEntities();
        int ZoneID = 0;
        int billingID = 0;
        int zoneUID = 0;
        MRSData mrsUploadData;
        GlobalFunctions globFunc = new GlobalFunctions();
        string colagent = "";
        int totalRec = 0;
        string zonebook = "";

        public formMRSDownload()
        {
            InitializeComponent();
        }

        private void centerToForm(Control control)
        {
            control.Left = (this.Width - control.Width) / 2;
            control.Top = ((this.Height - control.Height) / 2) - 30;
        }

        private void formMRSUpload_Load(object sender, EventArgs e)
        {
            tbBillingBindingSource.DataSource = dbContext.tbBillings.Where(i => i.loaded_to_zones == true).OrderByDescending(a => a.billing_id);
            tbZoneBindingSource.DataSource = dbContext.tbZones;
            colagent = dbContext.tbSettings.Select(a => a.collecting_agents).First();
            bindingSource1.DataSource = dbContext.tbMRSDownloadHistories.OrderByDescending(a => a.dl_historyID);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ZoneID = Convert.ToInt32(cmbZone.SelectedValue);
            billingID = Convert.ToInt32(cmbBillMonth.SelectedValue);
            zoneUID = globFunc.getZoneUID(ZoneID);
            var query = dbContext.tbMasters.Where(a => a.zone_id == ZoneID);
            if (query == null)
            {
                MessageBox.Show("No Records found..");
                return;
            }
            var qCount = query.Where(x=>!x.status.Equals("X"));
            labelRecNo.Text = qCount.Count().ToString();
            setDueDates();
            button1.Show();
            button1.Enabled = true;
            zonebook = cmbZone.Text;
            MessageBox.Show( "Please check the dates carefully before downloading.","Warning");
        }

        private void setDueDates()
        {
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                tbBillingSchedule query = (from em in context.tbBillingSchedules
                                           where em.billing_id == billingID && em.zone == zoneUID
                                           select em).SingleOrDefault();
                if (query != null)
                {
                    dtCurrentAgents.Value = Convert.ToDateTime(query.date_due_bank);
                    dtCurrentTWD.Value = Convert.ToDateTime(query.date_due_office);
                    dtDisco.Value = Convert.ToDateTime(query.date_due_disco_noarrears);
                    dtDiscoArrears.Value = Convert.ToDateTime(query.date_due_disco_arrears);
                    dtGovDueDate.Value = dtCurrentAgents.Value.AddDays(15);
                }
            }
        }

        private bool checkifProcessed()
        {
            bool retval = false;

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbPrepareAcctHistories.Where(x=>x.prepare_billing_of.Equals(cmbBillMonth.Text)).SingleOrDefault();
                if (query == null)
                {
                    retval = false;
                }
                else
                {
                    retval = true;
                }
            }
            return retval;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkifProcessed())
            {
                centerToForm(groupBox1);
                groupBox1.Show();
                btnLoad.Enabled = false;
                button1.Enabled = false;
                progressBar1.Maximum = Convert.ToInt32(labelRecNo.Text);
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Billmonth is not yet processed. Please process it first.");
                button1.Hide();
            }
        }

        private void saveHistory()
        {
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                tbMRSDownloadHistory historyData = new tbMRSDownloadHistory();
                historyData.dl_billmonth = cmbBillMonth.Text;
                historyData.dl_date = DateTime.Now;
                historyData.dl_doneby = username;
                historyData.dl_zonebook = cmbZone.Text;
                historyData.dl_numrecords = totalRec;
                context.AddTotbMRSDownloadHistories(historyData);
                context.SaveChanges();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
   
            var queryMaster = (from em in dbContext.tbMasters
                               join en in dbContext.tbMasterAccts on em.master_id equals en.master_id
                               where em.zone_id == ZoneID && !em.status.Equals("X")
                               select new
                               {
                                   //tbMaster
                                   masterID = em.master_id,
                                   acctno = em.acctno,
                                   name = em.name,
                                   address = em.address,
                                   zone = em.zone_id,       // get actual description
                                   ctgry = em.category,
                                   metno = em.meter_id,     // get actual description
                                   cardno = em.cardno,
                                   status = em.status,
                                   recodate = em.last_reco_date,
                                   instdate = em.date_installed,
                                   //tbMasterAcct
                                   ave_vol = en.ave_vol,
                                   senior = en.isSenior,
                                   senior_expire = en.senior_expiry,
                                   mon_arr = en.bill_arrears_months,
                                   arrears = en.bill_balance,
                                   arr_curr = en.arrears_curr_yr,
                                   arr_prev = en.arrears_prev_yrs,
                                   IFBalance= en.IFBalance,
                                   IFArrears = en.IFArrears,
                                   IFMonthly = en.IFMonthlyPay, 
                                   dmgmeter = en.isMtrDmg,
                                   dmtrBal = en.MtrDmg_Balance,
                                   dmtrArrears = en.MtrDmg_Arrears,
                                   dmtrMonthly = en.MtrDmg_Monthly,
                                   datepres = em.last_read_date,
                                   dateprev = em.prev_read_date,
                                   prevrdg = en.rdg_pres
                               });
            int rec_counter = 0;       
            int rec_total =  Convert.ToInt32(labelRecNo.Text);
            decimal senior_percentage = globFunc.getSENIOR_PERCENTAGE();
            dbContext.ExecuteStoreCommand("DELETE FROM tbMrsDownload WHERE md_zone={0}", zonebook);
            foreach (var mData in queryMaster)
            {

                
                mrsUploadData = new MRSData();

                string acctno = mData.acctno.TrimEnd();                
                mrsUploadData.acctno = acctno;                
                mrsUploadData.masterID = mData.masterID;
                mrsUploadData.cardno = Convert.ToInt32(mData.cardno);
                mrsUploadData.ave = Convert.ToInt32(mData.ave_vol);     
                mrsUploadData.status = mData.status;
                mrsUploadData.zone = zonebook;
                if (mData.senior == true)
                {
                    DateTime expiry = Convert.ToDateTime(mData.senior_expire);
                    if (expiry > DateTime.Today)
                    {
                        mrsUploadData.senior = senior_percentage;
                    }
                    else
                    {
                        mrsUploadData.senior = 0;
                    }
                }
                else
                {
                    mrsUploadData.senior = 0;
                }
                if (mData.dmgmeter == true)
                {
                    if (mData.dmtrBal > 0)
                    {
                        decimal monthly_dmtr = decimal.TryParse(mData.dmtrMonthly.ToString(), out monthly_dmtr) ? monthly_dmtr : 0;
                        if (monthly_dmtr > mData.dmtrBal)
                        {
                            mrsUploadData.dam_met = Convert.ToDecimal(mData.dmtrBal);
                        }
                        else
                        {
                            mrsUploadData.dam_met = monthly_dmtr;
                        }
                    }
                    else
                    {
                        mrsUploadData.dam_met = 0;
                    }

                }

                mrsUploadData.name = mData.name;
                mrsUploadData.address = mData.address;
                mrsUploadData.metno = globFunc.getMeterNumber(mData.metno).Substring(0,11);
                mrsUploadData.ctgry = mData.ctgry.ToString();



                mrsUploadData.arrears = Convert.ToDecimal(mData.arrears);
//Dont allow negative arrears
                /**
                if (mData.arrears > 0)
                {
                    mrsUploadData.arrears = Convert.ToDecimal(mData.arrears);
                }
                else { 
                    mrsUploadData.arrears = 0; 
                }*/
//end
                if (mrsUploadData.arrears > 0)
                {
                    mrsUploadData.mon_arr = Convert.ToDecimal(mData.mon_arr) + 1;
                }
                else
                {
                    mrsUploadData.mon_arr = 0;
                }

                if (mData.IFBalance > 0)
                {
                    if (mData.IFBalance >= mData.IFMonthly)
                    {
                        mrsUploadData.instfee = Convert.ToDecimal(mData.IFMonthly);
                    }
                    else
                    {
                        mrsUploadData.instfee = Convert.ToDecimal(mData.IFBalance); 
                    }
                }
                else
                {
                    mrsUploadData.instfee = 0;
                }

                if (mData.datepres.HasValue)
                {
                    if (mData.recodate.HasValue)
                    {
                        if (mData.datepres > mData.recodate)
                        {
                            mrsUploadData.datepres = Convert.ToDateTime(mData.datepres);
                        }
                        else
                        {
                            mrsUploadData.datepres = Convert.ToDateTime(mData.recodate);
                        }
                    }
                    else
                    {
                        mrsUploadData.datepres = Convert.ToDateTime(mData.datepres);
                    }
                }else
                {
                    mrsUploadData.datepres = Convert.ToDateTime(mData.instdate);
                }

                //clear tbMasterAcct penalty,senior
                /**
                using (dbCommercialEntities abcontext = new dbCommercialEntities())
                {
                    tbMasterAcct mAcct = abcontext.tbMasterAccts.FirstOrDefault(x => x.master_id == mData.masterID);
                    mAcct.bill_arrears = mrsUploadData.arrears;                    
                    mAcct.bill_arrears_months = Convert.ToInt16(mrsUploadData.mon_arr);
                    mAcct.arrears_curr_yr = mrsUploadData.arrears;
                    mAcct.penalty = 0;
                    mAcct.senior_amt = 0;
                    mAcct.bill_current = 0;
                    mAcct.IFArrears = mrsUploadData.instfee;
                    abcontext.SaveChanges();
                }
                */

                mrsUploadData.dateprev = Convert.ToDateTime(mData.dateprev);

                mrsUploadData.prevrdg = Convert.ToInt32(mData.prevrdg);
                uploadToMRS(mrsUploadData);                
                backgroundWorker1.ReportProgress(rec_counter);
                rec_counter++;
            }
        }

        private void setDiscoMarkX(int masterID, int zoneID)
        {


        }

        private void uploadToMRS(MRSData upData)
        {
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                
                    ////////// Add tbMrsDownload Entry  ////////////////////////////
                    tbMrsDownload recMRSDownload = new tbMrsDownload();
                    recMRSDownload.md_masterID = upData.masterID;
                    recMRSDownload.md_ave = upData.ave;
                    recMRSDownload.md_status = "A";

                    recMRSDownload.md_acctno = upData.acctno;
                    recMRSDownload.md_zone = upData.zone;
                    if (upData.senior > 0)
                    {
                        recMRSDownload.md_senior = upData.senior;
                    }
                    recMRSDownload.md_name = upData.name.Substring(0,40);
                    recMRSDownload.md_address = upData.address.Substring(0,50);
                    recMRSDownload.md_metno = upData.metno.TrimEnd();
             //       int xxy = recMRSDownload.md_name.Length;
             //       int meow = recMRSDownload.md_address.Length;
             //       int zzz = recMRSDownload.md_metno.Length;
                    recMRSDownload.md_ctgry = upData.ctgry.TrimEnd();
                    recMRSDownload.md_cardno = upData.cardno;
                    recMRSDownload.md_mon_arr = upData.mon_arr;
                    recMRSDownload.md_arrears = upData.arrears;
                    recMRSDownload.md_datepres = null;
                    recMRSDownload.md_dateprev = upData.datepres;   ///////// set DatePrev to datepres
                    recMRSDownload.md_prevrdg = Convert.ToInt32(upData.prevrdg);
                    if (upData.instfee > 0)
                    {
                        recMRSDownload.md_instfee = globFunc.getIF2(upData.masterID);
                    }
                    else
                    {
                        recMRSDownload.md_instfee = 0;
                    }

                    if (upData.dam_met > 0)
                    {
                        //recMRSDownload.md_dam_met = globFunc.getDmgMtr(upData.masterID);
                        recMRSDownload.md_dam_met = upData.dam_met;
                    }
                    else
                    {
                        recMRSDownload.md_dam_met = 0;
                    }

                    recMRSDownload.md_collagents = colagent.TrimEnd();
                    int test = colagent.Length;
                    if (upData.arrears > 0)
                    {
                        recMRSDownload.md_discdate = dtDiscoArrears.Value;
                        recMRSDownload.md_duedate = dtCurrentTWD.Value;
                    }
                    else
                    {
                        recMRSDownload.md_discdate = dtDisco.Value;
                        recMRSDownload.md_duedate = dtCurrentTWD.Value;
                        recMRSDownload.md_duedateAgents = dtCurrentAgents.Value;
                    }
                    if (Convert.ToInt32(upData.ctgry) == 22)
                    {
                        recMRSDownload.md_discdate = dtDiscoArrears.Value;
                        recMRSDownload.md_duedate = dtGovDueDate.Value;
                    }
                    context.AddTotbMrsDownloads(recMRSDownload);
                    context.SaveChanges();
                }
                                  

            }
     



        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            labelCounter.Text = string.Format("Downloading Record : {0}", e.ProgressPercentage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            totalRec = Convert.ToInt32(labelRecNo.Text);
            groupBox1.Hide();
            MessageBox.Show("Downloading to MRS is finished.","MRS Download");
            saveHistory();
            btnLoad.Enabled = true;
            button1.Hide();
            button3.Show();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                bindingSource1.DataSource = dbContext.tbMRSDownloadHistories.OrderByDescending(a=>a.dl_historyID);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string xlsFile = "";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                xlsFile = openFileDialog1.FileName;
            }else{
                return;
            }

            string adaptStr = "";
            var connStr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;data source={0};Extended Properties=Excel 8.0;", xlsFile);
            adaptStr = string.Format("Select * from [BILL{0}$]", cmbZone.Text);

            var adapter = new OleDbDataAdapter(adaptStr, connStr);
            var ds = new DataSet();
            adapter.Fill(ds, "tbMRSDL");

            var data = ds.Tables["tbMRSDL"].AsEnumerable();

            var query = data.Where(x => x.Field<string>("ACCTNO") != string.Empty).Select(x =>
                new
                {
                    acctno = x.Field<string>("ACCTNO"),
                    ave_vol = x["AVE"]
                });

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                foreach (var mrsData in query)
                {
                    var ave_vol = mrsData.ave_vol;
                    var acctno = mrsData.acctno;
                    int masterID = new GlobalFunctions().getMasterID(acctno.ToString());

                    tbMrsDownload mrsDownload = (from en in context.tbMrsDownloads
                                                 where en.md_acctno.Equals(acctno)
                                                 select en).SingleOrDefault();

                    tbMasterAcct mrsAcct = context.tbMasterAccts.First(x => x.master_id == masterID);

                    if (mrsDownload != null)
                    {
                        mrsDownload.md_ave =  Convert.ToInt32(mrsData.ave_vol);
                    }

                    mrsAcct.ave_vol = Convert.ToInt32(mrsData.ave_vol);
                }
                context.SaveChanges();
                MessageBox.Show("Saving of Ave Volume done.");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            formCheckDownload frmCheck = new formCheckDownload();
            frmCheck.zonebook = cmbZone.Text;
            frmCheck.zoneID = ZoneID;
            frmCheck.Show();

            button3.Hide();
        }
    }
}
