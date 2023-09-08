using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BillingSystem
{
    public partial class formGenerateWizard : Form
    {


        dbCommercialEntities dbContext;
        MySqlConnection myCon = new MySqlConnection();
        DataSet dsReadingsToSQL = new DataSet();
        GlobalFunctions global_func = new GlobalFunctions();
        decimal mtr_mtn = 0;

        string my_constr = "server={0};uid=root;pwd=root;database=mrs_tagumwd;default command timeout=0;";
        string zone_book = "";
        string bill_month = "";
        int userID = 0;
        int next_billproc_id = 0;
        int billID = 0;
        int mtr_reader_id = 0;

        public formGenerateWizard()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                DialogResult result = MessageBox.Show("Do you want to cancel the loading?", "Close", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    backgroundWorker1.CancelAsync();
                    Close();
                }
            }else{
                Close();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext.Text.Equals("Generate"))
            {
                bill_month = cmbBilling.Text;
                progressPanel1.Visible = true;
                label7.Text = string.Format("[  Zone/Book : {0}   Bill Month : {1}  ]", cmbZone.Text, bill_month);
                backgroundWorker1.RunWorkerAsync();
                btnNext.Enabled = false;
            }
            else if (btnNext.Text.Equals("Save"))
            {
                mtr_mtn = global_func.getMeterMtn();
                panel1.Show();
                billID = checkNullInt(billing_idTextBox.Text);
                backgroundWorker2.RunWorkerAsync();
                btnNext.Hide();

            }

        }

        private void saveBillingDetails( DataSet ds)
        {
            int cntr = 0, max = 0;
            max = ds.Tables[0].Rows.Count;
            saveBillProc();
            next_billproc_id = dbContext.tbBillProcessings.Select(a => a.bill_process_id).Max();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                cntr++;
                tbBillingDetail reading = new tbBillingDetail();
                reading = setReadingsToVar(row);
                dbContext.tbBillingDetails.AddObject(reading);
                backgroundWorker2.ReportProgress(cntr, max);
            }
            //tbBilling currBill = dbContext.tbBillings.First(i => i.billing_id == current_bill_id);           
        }


        private void saveBillProc()
        {
            tbBillProcessing billproc = new tbBillProcessing();
            billproc.date_processed = DateTime.Now;
            billproc.processed_by = Convert.ToByte(userID);
            string zbook = zone_book;
            var mReader = (from z in dbContext.tbZones
                           join o in dbContext.tbMeterReaders on z.mtr_reader equals o.mr_id
                           where z.zone_name.Equals(zbook)
                           select o).Select(a => new { a.mr_name, a.mr_id }).Single();


            billproc.zone_book = zbook;
            billproc.meter_reader = mReader.mr_name;
            billproc.billing_id = billID;
            mtr_reader_id =mReader.mr_id;
            //billproc.mrs_controls = bill_proc.mrs_controls;
            dbContext.tbBillProcessings.AddObject(billproc);
            dbContext.SaveChanges();
        }

        private tbBillingDetail setReadingsToVar(DataRow dr)
        {
            tbBillingDetail temp = new tbBillingDetail();

            temp.mrs_ref = dr["mrs_control"].ToString();
            temp.ave_vol = checkNullInt(dr["ave_vol"].ToString());
            temp.volume = checkNullInt(dr["volume"].ToString());

            temp.master_id = getMasterID(dr["account_no"].ToString());

            try
            {
                temp.date_pres = Convert.ToDateTime(string.Format("{0:MM/dd/yyyy}", dr["curdate"].ToString()));
            }catch{}

            //temp.current = checkNullDec(dr["bill_amt"].ToString());
            if (temp.date_pres.HasValue)
            {
                temp.current = global_func.processCurrent(temp.master_id, (int)temp.volume) + mtr_mtn;
            }
            else
            {
                temp.current = 0;
            }            
            try
            {
                temp.date_prev = Convert.ToDateTime(string.Format("{0:MM/dd/yyyy}", dr["prevdate"].ToString()));
            }
            catch { }
            
            temp.penalty = checkNullDec(dr["penalty"].ToString());
            temp.mtr_mtn = checkNullDec(dr["mrental"].ToString());
            temp.rdg_pres = checkNullInt(dr["curread"].ToString());
            temp.rdg_prev = checkNullInt(dr["prevread"].ToString());
            temp.readtime = dr["readtime"].ToString();
            temp.arrears = checkNullDec(dr["arrears"].ToString());
            temp.remarks = dr["remark"].ToString();
            
            temp.mtr_read_by = mtr_reader_id;
            temp.billproc_id = next_billproc_id;

            //compute Installation Fee here

            //compute Seniors here

            //compute Meter Damage here

            return temp;
        }

        private int checkNullInt(string str)
        {
            try
            {
                return Convert.ToInt32(str);
            }
            catch
            {
                return 0;
            }
        }

        private decimal checkNullDec(string str)
        {
            try
            {
                return Convert.ToDecimal(str);
            }
            catch
            {
                return 0;
            }
        }

        private void getReadings(DataSet dsReadingsToSQL)
        {
            string qry = "SELECT a.seq1,a.account_no,a.batch,a.bill_month,b.curread,b.readtime,b.curdate,a.prevread,a.prevdate,b.mrs_control," +
                        "b.mr_control,b.remark,b.arrears,b.penalty,b.mrental,b.volume,b.ave_vol,b.bill_amt " +
                        "FROM download_log AS a LEFT JOIN reading_log AS b ON b.account_no = a.account_no ";
            qry = qry + string.Format("AND b.bill_month='{0}' WHERE a.batch = '{1}' AND a.bill_month = '{2}'", bill_month,zone_book, bill_month);
            openMySqlConnection();

            MySqlDataAdapter myAdap = new MySqlDataAdapter(qry, my_constr);
            MySqlCommandBuilder myCB = new MySqlCommandBuilder(myAdap);
            
            int record_count = myAdap.Fill(dsReadingsToSQL, "reading_log");
            if (record_count <= 0)
            {
                MessageBox.Show("No Records found. Please check the bill period.");
            }
        }     

        private int getMasterID(string acctno)
        {
            int id = 0;

            var query = (from master in dbContext.tbMasters
                        where master.acctno == acctno
                        select master).Select(a=>a.master_id).Single();                        
            id = checkNullInt(query.ToString());
            return id;
        }
     
        private void formGenerateWizard_Load(object sender, EventArgs e)
        {

            string ip_add = global_func.getMRS_IPADDRESS();
            my_constr = string.Format(my_constr, ip_add);

            dbContext = new dbCommercialEntities();
            tbBillingBindingSource.DataSource = dbContext.tbBillings.Where(i => i.loaded_to_zones == true).OrderByDescending(a => a.billing_id);
            tbBillingScheduleBindingSource.DataSource = dbContext.tbBillingSchedules;
            setBillingSched();
            tbZoneBindingSource.DataSource = dbContext.tbZones;
            tbMeterReaderBindingSource.DataSource = dbContext.tbMeterReaders;           
            MainForm mainF = (MainForm)this.MdiParent;
            userID = mainF.userID;
            setZone();                      
        }

        private void tbBillingBindingSource_PositionChanged(object sender, EventArgs e)
        {
            setBillingSched();
            try
            {
                setZone();
            }
            catch { }
            
        }

        private void setBillingSched()
        {
            int im = 0;
            im = billing_idTextBox.Text.Length != 0 ? checkNullInt(billing_idTextBox.Text) : im;
            tbBillingScheduleBindingSource.DataSource = dbContext.tbBillingSchedules.Where(m => m.billing_id == im);                              

        }

        private void tbZoneBindingSource_PositionChanged(object sender, EventArgs e)
        {
            setZone();           
        }

        private void setZone()
        {
            tbZone rw = (tbZone)tbZoneBindingSource.Current;
            zone_book = rw.zone_name;

            int billID = checkNullInt(billing_idTextBox.Text);

            try
            {
                int qry = (from re in dbContext.tbBillProcessings
                           where re.billing_id == billID && re.zone_book.Equals(zone_book)
                           select re).Select(a => a.bill_process_id).Single();
                if (qry <= 0)
                {
                }
                else
                {
                    labelStatus.ForeColor = Color.Black;
                    labelStatus.Text = "Processed";
                    btnNext.Visible = false;
                }
            }
            catch
            {

                    if (checkReadings())
                    {
                        labelStatus.ForeColor = Color.BlueViolet;
                        labelStatus.Text = "Ready for processing";
                        btnNext.Visible = true;
                    }
                    else
                    {
                        labelStatus.ForeColor = Color.Red;
                        labelStatus.Text = "No Readings found!!!";
                        btnNext.Visible = false;
                    }

            }                      
        }

        private bool checkReadings()
        {
            DataSet tbReading = new DataSet();
            bool retval = false;
            string query = "";
                query = "Select rl_uid from reading_log ";                
                query = query + string.Format("where bill_month='{0}' And batch='{1}'", cmbBilling.Text, cmbZone.Text );

                openMySqlConnection();
                MySqlDataAdapter myAdap = new MySqlDataAdapter(query, my_constr);
                MySqlCommandBuilder myCB = new MySqlCommandBuilder(myAdap);
                
                try
                {
                    myAdap.Fill(tbReading, "reading");
                }
                catch
                {
                    MessageBox.Show("Error on adapter fill");
                }

                if (!(tbReading.Tables[0].Rows.Count > 0))
                {
                    retval = false;
                }
                else
                {
                    retval = true;
                }                
                this.myCon.Close();
                tbReading.Dispose();
            return retval;
        }

        private void openMySqlConnection()
        {
            try
            {
                if (myCon.State == ConnectionState.Open) myCon.Close();
                myCon.ConnectionString = my_constr;
                myCon.Open();
            }
            catch
            {
                MessageBox.Show("Connection to the MRS Server failed. Please check your network connection.");
            }
        } 

        private int getLastBillProc()
        {
            int qry = (from en in dbContext.tbBillProcessings
                       select en.bill_process_id).Max();
            return qry + 1;           
        }
    
        private int getBillingID()
        {
            tbBilling bill = (tbBilling)tbBillingBindingSource.Current;
            return bill.billing_id;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            getReadings(dsReadingsToSQL);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressPanel1.Visible = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dsReadingsToSQL;
            dataGridView1.Columns[0].DataPropertyName = "account_no";
            dataGridView1.Columns[1].DataPropertyName = "seq1";
            dataGridView1.Columns[2].DataPropertyName = "prevread";

            dataGridView1.Columns[3].DataPropertyName = "curread";
            dataGridView1.Columns[4].DataPropertyName = "volume";
            dataGridView1.DataMember = "reading_log";
            this.xtraTabControl1.TabPages.TabControl.SelectedTabPage = xtraTabPage2;
            int numrec = dsReadingsToSQL.Tables[0].Rows.Count;
            labelTotal.Text = numrec.ToString();
            btnNext.Enabled = true;
            if (numrec > 0)
            {
                btnNext.Text = "Save";
            }
            else
            {
                btnNext.Enabled = false;
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {           
            saveBillingDetails(dsReadingsToSQL);
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int max = checkNullInt(e.UserState.ToString());
            progressBar1.Value = e.ProgressPercentage;
            //this.lblProgProcessing.Text = String.Format("Processing ... {0}%", ((e.ProgressPercentage * 100) / max) + 1);
            progressBar1.Maximum = checkNullInt(e.UserState.ToString());
            this.labelSave.Text  = String.Format("Record {0} of {1}", e.ProgressPercentage.ToString(), e.UserState.ToString());
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dbContext.SaveChanges();
            panel1.Visible = false;
            MessageBox.Show("Bill Processing Finished.You can now check the bills.");
        }
    }
}
