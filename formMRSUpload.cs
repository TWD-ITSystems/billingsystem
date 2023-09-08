using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace BillingSystem
{
    public partial class formMRSUpload : Form
    {
        public string username = "";
        public int userID=0;
        public int access_code = 0;
        dbCommercialEntities dbContext = new dbCommercialEntities();
        GlobalFunctions globFunc = new GlobalFunctions();
        string billmonth = "";
        string zonebook = "";
        decimal penalty_percent = 0,mtr_mtn=0;
        int billingID = 0;
        string nme = "";
        int mrsUPid = 0;

        public formMRSUpload()
        {
            InitializeComponent();
        }

        private void formMRSUpload_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMRSUploadView.vwMRSUpload' table. You can move, or remove it, as needed.
            //this.vwMRSUploadTableAdapter.Fill(this.dsMRSUploadView.vwMRSUpload);

            cmbBillMonth.DataSource = dbContext.tbBillings.Where(i => i.loaded_to_zones == true).OrderByDescending(a => a.billing_id);
            cmbZoneBook.DataSource = dbContext.tbZones;
            labelDownload.Text = "";
            btnUpdate.Enabled = (access_code == 101) || (access_code == 102);
        }

        private void btnReadings_Click(object sender, EventArgs e)
        {
            int billing_id = Convert.ToInt32(cmbBillMonth.SelectedValue);
            int zone_id = Convert.ToInt32(cmbZoneBook.SelectedValue);

            billingID = billing_id;
            zonebook = cmbZoneBook.Text;
            
            //int recnum = this.vwMRSUploadTableAdapter.FillByZone(this.dsMRSUploadView.vwMRSUpload,cmbBillMonth.Text, cmbZoneBook.Text);
            int recnum = this.pMRSDownloadUploadTableAdapter.Fill(dsMRSDownUpload.pMRSDownloadUpload, cmbZoneBook.Text, cmbBillMonth.Text);
            
            if (recnum < 0)
            {
                MessageBox.Show(string.Format("No readings found for Zone:{0} of Bill Month:{1}", cmbZoneBook.Text, cmbBillMonth.Text));
                btnPrint.Hide();
                btnUpdate.Hide();
                btnSaveDBF.Hide();
                btnSaveManualBill.Hide();
                labelDownload.Text = "";
            }
            else
            {
                MessageBox.Show(string.Format("There are {0} records uploaded.", recnum),"Total Records");
                billmonth = cmbBillMonth.Text;
                penalty_percent = globFunc.getPenaltyPercent();
                mtr_mtn = globFunc.getMeterMtn();
                btnPrint.Show();
                btnUpdate.Show();
                btnSaveDBF.Show();
                btnSaveManualBill.Show();
                labelDownload.Text = string.Format("Records Downloaded : {0}",getDownloadTotal());
            }
        }

        private void btnSaveDBF_Click(object sender, EventArgs e)
        {

            string filepath = "";
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            string filename = "";
            string msg_txt = "";

            if (result == DialogResult.OK)
            {
                filepath = folderBrowserDialog1.SelectedPath;
                string appPath = Application.StartupPath;
                string sourceFile = string.Format(@"{0}\templates\BILL0000.DBF", appPath);
                string newFile = string.Format(@"{0}\BILL{1}99.DBF", filepath, cmbZoneBook.Text.Substring(0,2));              
                filename = string.Format("BILL{0}99.DBF", cmbZoneBook.Text.Substring(0, 2));
                if (File.Exists(newFile))
                {
                    DialogResult resultEx = MessageBox.Show(string.Format("{0} already exists. Do you want to append?", filename), "File Exist", MessageBoxButtons.YesNoCancel);
                    msg_txt = "has been updated.";
                    if (resultEx == DialogResult.No)
                    {
                        File.Copy(sourceFile, newFile, true);
                        msg_txt = "has been created.";

                    }
                    else if (resultEx == DialogResult.Cancel)
                    {
                        return;
                    }           
                
                }
                else
                {
                    File.Copy(sourceFile, newFile);
                    msg_txt = "has been created.";
                }

                 
            }
            else
            {
                return;
            }

            //var ds = dsMRSUploadView.Tables[0].AsEnumerable().Select(x => x);
            var ds = dsMRSDownUpload.Tables[0].AsEnumerable().Select(x => x);
            int cnt = ds.Count();
         
            DBRemix saveDBF = new DBRemix(filepath,true);
            
            ArrayList saveData = new ArrayList();
            string[] paramList = { "AVE", "ACCTNO", "ZONE", "NAME", "ADDRESS", "METNO", "CTGRY", "CARDNO","DATEPREV", "PREVRDG","ENCODER","OTHERS","ARREARS"};
            foreach (var upRec in ds)
            {
                string billno = upRec["md_billno"].ToString();
                int volume = Int32.TryParse(upRec["md_volume"].ToString(),out volume)?volume:0;


                if (billno.Length >= 3)
                {
                    continue;
                }
                /**
                if (volume > 0) 
                {
                    continue;
                }*/
//"AVE","ACCTNO", "ZONE", "NAME", "ADDRESS", "METNO", "CTGRY", "CARDNO",
//"DATEPREV",  "PREVRDG","ENCODER","OTHERS"

                
                string acctno = upRec["md_acctno"].ToString().TrimEnd();
                int prevrdg = Convert.ToInt32(upRec["md_prevrdg"].ToString());
                //int md_presrdg = Convert.ToInt32(upRec["md_presrdg"].ToString());
                string md_encoder = globFunc.getUserInitials(userID).Substring(0,3);
                int ave = Int32.TryParse(upRec["md_ave"].ToString(), out ave) ? ave : 0;
                string name = upRec["md_name"].ToString().TrimEnd();
                string address = upRec["md_address"].ToString().Substring(0, 30).TrimEnd();
                string metno = upRec["md_metno"].ToString().Substring(0,10).Trim();
                string ctgry = upRec["md_ctgry"].ToString().TrimEnd();
                string cardno = upRec["md_cardno"].ToString();
                DateTime datePrev = Convert.ToDateTime(upRec["md_dateprev"].ToString());
                string zone = cmbZoneBook.Text;
                int masterid = globFunc.getMasterID(acctno);
                decimal if2 = globFunc.getIF2(masterid);
                decimal arrears = globFunc.getArrears(masterid);

                this.Text = string.Format("[Processing Acctno {0}]", acctno);
                saveData.Clear();
                saveData.Add(ave);
                saveData.Add(acctno);
                saveData.Add(zone);
                saveData.Add(name);
                saveData.Add(address);
                saveData.Add(metno);
                saveData.Add(ctgry);
                saveData.Add(cardno);
                saveData.Add(datePrev);
                saveData.Add(prevrdg);
                saveData.Add(md_encoder);
                saveData.Add(if2);
                saveData.Add(arrears);

                saveDBF.SaveToOLEDatabase(filename, saveData, paramList);
            }
            MessageBox.Show(string.Format("{0} {1}", filename,msg_txt));
           // MessageBox.Show(vwMRSUploadBindingSource.Count.ToString());
        }
         
        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private int getDownloadTotal()
        {

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMrsDownloads.Where(x => x.md_zone.Equals(zonebook)).Select(x=>x);

                if (query != null)
                {
                    return query.Count();
                }
                else
                {
                    return 0;
                }
            }

        }

        private void cmbZoneBook_TextChanged(object sender, EventArgs e)
        {
            btnPrint.Hide();
            btnUpdate.Hide();
            btnSaveDBF.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will only update the Master File of records with Ref. Nos. only.\n Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string formTitle = this.Text;

            if (result == DialogResult.Yes)
            {
                
                //var dTable = dsMRSUploadView.Tables[0].AsEnumerable();
                //var dTable = dsMRSDownUpload.Tables[0].AsEnumerable();
                var dTable = dsMRSDownUpload.Tables[0].AsEnumerable().Distinct();
                //var dRecords = dTable.Where(x => x.Field<string>("md_billno") != null && x.Field<string>("md_billno").Length == 10
                //    && x.Field<int?>("md_masterID").Equals(null)).Select(x => x);

              //  IEnumerable<string> dDownload = dbContext.tbMrsDownloads.Where(x => x.md_zone.Equals(zonebook)).Select(x=>x.md_acctno);
              //  IEnumerable<string> dUpload = dbContext.tbMRSUploads.Where(x => x.md_zone.Equals(zonebook) && x.md_billmonth.Equals(billmonth)).Select(x => x.md_acctno);
              //  int meow = dDownload.Count();
              //  int lion = dUpload.Count();

                var dRecords = dTable.Where(x => x.Field<string>("md_billno") != null && x.Field<string>("md_billno").Length >= 10
                    && x.Field<int?>("md_masterID").Equals(null)).Select(x => new
                    {
                        md_acctno = x["md_acctno"],
                        md_billno = x["md_billno"],
                        md_billmonth = x["md_billmonth"],
                        md_zone = x["md_zone"],
                        md_ctgry = x["md_ctgry"],
                        md_prevrdg = x["md_prevrdg"],
                        md_presrdg = x["md_presrdg"],
                        md_name = x["md_name"]                        
                        //mrsUP_ID = x["mrsUP_ID"]
                    });

                //var mln = dRecords.Select(x=>x.Field<string>("md_acctno")).Distinct();
                var distinct_records = dRecords.Distinct();
                //int mmm = dTable.Count();
                //int smile= dRecords.Count();
                int numrec = distinct_records.Count();
                
             
               //var inRec = dTest.Intersect(dSamp);
               //var exRec = disRec.Except(inRec);

                int billproc_id = 0;
                int counter = 0;
                if (numrec > 0)
                {
                    
                    MessageBox.Show("Starting update process.This will take for a while.","Processing");
                    
                    foreach (var dsData in distinct_records)
                    {
                        int master_id = globFunc.getMasterID(dsData.md_acctno.ToString());
                        if (checkIfUploaded(master_id,dsData.md_billmonth.ToString()))
                        {
                            continue;
                        } 
                        /**
                        if (checkIfPostedToLedger(master_id))
                        {
                            continue;
                        }
                        */
                        if (billproc_id == 0)
                        {
                            billproc_id = saveBillProcessing(globFunc.getMtrReaderByZone(zonebook));
                        }
                        counter++;
                        this.Text = formTitle + string.Format("  [ Processing Record ... {0}]", dsData.md_name.ToString().TrimEnd());
                        ReadLog billDetails = new ReadLog();
                        billDetails = GetReadDetails(dsData.md_acctno.ToString());
                        UpdateMasterAndAccounts(billDetails);
                        int mrsuid = getMRSUI_ID(dsData.md_acctno.ToString()); 
                        saveToBillDetails(billDetails,mrsuid,billproc_id);
                    }

                    saveUploadHistory(counter);
                    MessageBox.Show(string.Format("Readings of {0} for {1} billing month is now updated to master file and ledger.",zonebook,billmonth),string.Format("Done Processing {0} records",counter));
                    int discoMark = ProcessDisconnectedAccounts();
                    MessageBox.Show(string.Format("{0} disconnected accounts marked X.",discoMark));
                    this.pMRSDownloadUploadTableAdapter.Fill(dsMRSDownUpload.pMRSDownloadUpload, cmbZoneBook.Text, cmbBillMonth.Text);
                    btnPrint.Hide();
                    btnUpdate.Hide();
                    this.Text = formTitle;
                }
                else
                {
                    MessageBox.Show("No valid records found for processing or these Zone reading is already processed.","Error");
                }
            }
           
            
        }

        private Boolean checkIfUploaded(int masterID, string billmonth)
        {
            int recCount = 0;
            
            
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
              
                var query = dbcontext.tbBillingDetails.Where(x => x.master_id == masterID && x.mrs_ref.Equals(billmonth));
                if (query != null)
                {
                    try
                    {
                        recCount = query.Count();
                    }catch
                    {
                        recCount = 0;
                    }
                }
            }
            return recCount > 0 ? true : false;
        }


        private Boolean checkIfPostedToLedger(int masterID)
        {
            int recCount = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbLedgers.Where(x => x.master_id == masterID && x.code.Equals("BILL") && x.billing_id == billingID);
                if (query != null)
                {

                    try
                    {
                        recCount = query.Count();
                    }
                    catch
                    {
                        recCount = 0;
                    }
                }
            }
            return recCount > 0 ? true : false;
        }



        private int ProcessDisconnectedAccounts()
        {
            int retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                int zoneID = (int)cmbZoneBook.SelectedValue;
                var queryDisco = dbcontext.tbDiscoEntries.Where(x => x.processed == 0 && x.zoneid == zoneID);
                if ((queryDisco != null) || (queryDisco.Count() > 0))
                {
                    foreach (tbDiscoEntry rDisco in queryDisco)
                    {
                        int masterID = Convert.ToInt32(rDisco.master_id);
                        DateTime recoDate = globFunc.getRecoDate(masterID);
                        DateTime discoDate = Convert.ToDateTime(rDisco.disco_date);

                        if ((!(recoDate >= discoDate)) || (recoDate == new DateTime(1900, 1, 1)))
                        {
                            markDisconnected(masterID);
                            retval++;
                            rDisco.processed = 1;
                            rDisco.processed_by = globFunc.getUserInitials(userID);
                            rDisco.processed_date = DateTime.Today;
                        }
                    }
                    
                    dbcontext.SaveChanges();
                }
            }
            return retval;
        }


        private int getMRSUI_ID(string acctno)
        {
            int retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMRSUploads.FirstOrDefault(x => x.md_acctno.Equals(acctno) && x.md_billmonth.Equals(billmonth));
                if (query != null)
                {
                    retval = query.mrsUP_ID;
                }
            }
            return retval;
        }

        private void saveUploadHistory(int numrec)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMRSUploadHistory upHistory = new tbMRSUploadHistory();

                upHistory.up_billmonth = billmonth;
                upHistory.up_date = DateTime.Now;
                upHistory.up_doneby = username;
                upHistory.up_numrecords = numrec;
                upHistory.up_zonebook = zonebook;

                dbContext.AddTotbMRSUploadHistories(upHistory);
                dbContext.SaveChanges();
            }
        }

        private int saveBillProcessing(string encoder)
        {
            int lastrec = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                
                tbBillProcessing dBillProc = new tbBillProcessing();
                dBillProc.mrs_controls = "PSION";
                dBillProc.meter_reader = encoder;
                dBillProc.zone_book = zonebook;
                dBillProc.processed_by = (short)userID;
                dBillProc.date_processed = DateTime.Now;
                dBillProc.billing_id = billingID;
                dBillProc.checked_by = (short)userID;
                dBillProc.date_checked = DateTime.Now;
                dBillProc.printed_by = (short)new GlobalFunctions().getMeterReaderID(encoder);

                dbcontext.AddTotbBillProcessings(dBillProc);
                dbcontext.SaveChanges();
                lastrec = dBillProc.bill_process_id;
            }
            return lastrec;
        }

        private void saveToBillDetails(ReadLog rData,int upID,int billproc_id)
        {
           
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbBillingDetail rBill = new tbBillingDetail();
               
                rBill.arrears = rData.arrears;
                //rBill.arrears_month = rData.
                rBill.ave_vol = rData.ave_vol;
                rBill.bill_ref_num = rData.bill_ref_num;
                rBill.billproc_id = billproc_id;
                rBill.current = rData.current;
                rBill.date_pres = rData.date_pres;
                rBill.date_prev = rData.date_prev;
                rBill.inst_fee = rData.inst_fee;
                rBill.master_id = rData.master_id;
               //rBill.mrs_ref = upID.ToString();
                rBill.mtr_dmg = rData.mtr_dmg;
                rBill.mtr_mtn = rData.mtr_mtn;
                rBill.mrs_ref = billmonth;
                rBill.mtr_read_by = globFunc.getMeterReaderID(rData.encoder);
                //rBill.other_fee_code = rData.
                //rBill.other_fees = 
                rBill.penalty = rData.penalty;
                rBill.rdg_pres = rData.rdg_pres;
                rBill.rdg_prev = rData.rdg_prev;
                rBill.readtime = rData.readtime;
                rBill.remarks = rData.remarks;
                //rBill.senior =  globFunc.roundOff((rData.current*(rData.senior/100))) * -1;
                rBill.senior = (rData.current * (rData.senior / 100)) * -1;
                if (!string.IsNullOrEmpty(rData.remarks))
                {
                   
                    if (!rData.remarks.ToUpper().Equals("OK") || !rData.remarks.ToUpper().Equals(""))
                    {
                        if (rData.remarks.Length > 0)
                        {
                            rBill.sr_id = makeServiceRequest(rData.remarks, rData, rData.billmonth + "-" + rData.zonebook);
                        }
                    }
                }
                rBill.volume = rData.volume;

                

                dbcontext.AddTotbBillingDetails(rBill);
                tbMRSUpload uploadedData = dbcontext.tbMRSUploads.First(x => x.mrsUP_ID == upID);
                uploadedData.md_masterID = billproc_id;
              // DISABLED FOR DELETION OF RECORD IN tbMRSUploads
              // tbMRSUploads mrsUpdata = dbcontext.tbMRSUploads.First(x => x.mrsUP_ID == mrsupID);
              // dbcontext.tbMRSUploads.DeleteObject(mrsUpdata);
              // end code
                dbcontext.SaveChanges();
            }

        }

        private int makeServiceRequest(string complain, ReadLog rData, string billfile)
        {
            int sr_id = 0;
        
            
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                int srcode_id = 0;
                string sr_no = "";
                int mast = rData.master_id;
                        
           
                var sr_code = context.tbServiceRequestCodes.FirstOrDefault(p => p.code_desc.Contains(complain.TrimStart()));
                if (sr_code != null)
                {
                    srcode_id = sr_code.srcode_id;
                }
                else
                {
                    srcode_id = 0;
                }

                try
                {

                        var lastsr = (from tb_sr in context.tbServiceRequests
                                      orderby tb_sr.sr_id descending
                                      select tb_sr).First();
                        sr_id = lastsr.sr_id;
                        sr_no = lastsr.sr_no;
      
                }
                catch
                {
                    sr_id = 0;
                    sr_no = "0";
                }


                    tbServiceRequest sr_rec = new tbServiceRequest();
                    sr_rec.master_id = mast;
                    sr_rec.complain_id = srcode_id;
                    sr_rec.requested_by = billfile;
                    sr_rec.request_recd_date = DateTime.Now;
                    //sr_rec.billdetails_id = billdetail_rec.billingdetails_id;
                    sr_rec.encoder_id = userID;
                    //sr_rec.status = 0;
                    sr_rec.sr_no = (Convert.ToInt32(sr_no) + 1).ToString();
                    context.tbServiceRequests.AddObject(sr_rec);
                    context.SaveChanges();
  
            }
            return sr_id + 1;
        }  //end makeServiceRequest

        private void UpdateMasterAndAccounts(ReadLog rData)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMaster masterData = dbcontext.tbMasters.Where(x => x.master_id == rData.master_id).Select(x => x).SingleOrDefault();
                tbMasterAcct masterAcct = dbcontext.tbMasterAccts.Where(x => x.master_id == rData.master_id).Select(x => x).SingleOrDefault();

                masterData.prev_read_date = rData.date_prev;
                masterData.last_read_date = rData.date_pres;
                //masterAcct.penalty = rData.current * ((penalty_percent/100));
                masterAcct.bill_current = rData.current;
                masterAcct.rdg_pres = rData.rdg_pres;
                masterAcct.rdg_prev = rData.rdg_prev;
                masterAcct.senior_amt = 0;
                masterAcct.bill_volume = rData.volume;
                decimal old_bill_balance = decimal.TryParse(masterAcct.bill_balance.ToString(),out old_bill_balance)?old_bill_balance:0;
                
                if (masterAcct.bill_balance > 0)
                {
                    masterAcct.bill_arrears = masterAcct.bill_balance;                    
                    masterAcct.bill_arrears_months++;
                    masterAcct.bill_balance = rData.current + rData.mtr_mtn + masterAcct.bill_arrears;

                    if (billmonth.Substring(3,4).Equals(DateTime.Today.Year.ToString()))
                    {
                            masterAcct.arrears_curr_yr = masterAcct.bill_arrears;

                    }else{
                        if (masterAcct.arrears_prev_yrs.HasValue)
                        {
                            masterAcct.arrears_prev_yrs = masterAcct.arrears_prev_yrs + masterAcct.arrears_curr_yr;
                        }
                        else
                        {
                            masterAcct.arrears_prev_yrs = masterAcct.arrears_curr_yr;
                        }
                        masterAcct.arrears_curr_yr = 0;
                    }
                }
                else
                {
                    decimal billbal = Convert.ToDecimal(masterAcct.bill_balance.HasValue ? masterAcct.bill_balance : 0);
                    masterAcct.bill_balance = billbal + rData.current + rData.mtr_mtn;
                    masterAcct.bill_current = rData.current;
                    masterAcct.bill_arrears_months=0;
                    masterAcct.bill_arrears = 0;
                    masterAcct.arrears_curr_yr = 0;
                    masterAcct.arrears_prev_yrs = 0;
                }

                
                tbLedger ledgerData = new tbLedger();
                ledgerData.code = "BILL";
                ledgerData.@ref = rData.bill_ref_num;
                ledgerData.trans_date = DateTime.Today.Date;
                ledgerData.remarks = string.Format("Read {0:d}", rData.date_pres);
                ledgerData.volume = rData.volume;
                ledgerData.symbol = "+";
                ledgerData.encoder = rData.encoder.Substring(0,3);
                ledgerData.master_id = rData.master_id;
                ledgerData.billing_id = billingID;
                ledgerData.presrdg = rData.rdg_pres;
                ledgerData.amount = rData.current+rData.mtr_mtn;
                ledgerData.balance = masterAcct.bill_balance;
                ledgerData.zoneuid = globFunc.getZoneUIDbyMaster(rData.master_id);
                dbcontext.AddTotbLedgers(ledgerData);

                //Reflect current to master accounts w/ deduction from negative advance payment
                if (old_bill_balance < 0)
                {
                    decimal newcurrent = rData.current + old_bill_balance;
                    if (newcurrent < 0)
                    {
                        masterAcct.bill_current = 0;
                    }
                    else if (newcurrent > 0)
                    {
                        masterAcct.bill_current = newcurrent;
                    }
                }
                if (rData.inst_fee > 0)
                {
                    //masterAcct.bill_balance = masterAcct.bill_balance + rData.inst_fee;

                    ledgerData = new tbLedger();
                    ledgerData.code = "IF";
                    ledgerData.@ref = rData.bill_ref_num;
                    ledgerData.trans_date = DateTime.Today;
                    ledgerData.symbol = "+";
                    ledgerData.encoder = rData.encoder.Substring(0, 3);
                    ledgerData.master_id = rData.master_id;
                    ledgerData.billing_id = billingID;
                    ledgerData.other = rData.inst_fee;
                    //ledgerData.balance = masterAcct.bill_balance;
                    dbcontext.AddTotbLedgers(ledgerData);

                    masterAcct.IFArrears = rData.inst_fee;
                }

                if (rData.mtr_dmg > 0)
                {
                    ledgerData = new tbLedger();
                    ledgerData.code = "DMTR";
                    ledgerData.@ref = rData.bill_ref_num; 
                    ledgerData.trans_date = DateTime.Today;
                    ledgerData.symbol = "+";
                    ledgerData.encoder = rData.encoder.Substring(0, 3);
                    ledgerData.master_id = rData.master_id;
                    ledgerData.billing_id = billingID;
                    ledgerData.other = rData.mtr_dmg;
                    //ledgerData.balance = masterAcct.bill_balance;
                    dbcontext.AddTotbLedgers(ledgerData);
                }

                if (masterAcct.isSenior == true)
                {
                    
                    int volcap = globFunc.getSeniorCap();

                    if (rData.volume <= volcap)
                    {
                        DateTime expiry = Convert.ToDateTime(masterAcct.senior_expiry);
                        if (expiry > DateTime.Today)
                        {
                            decimal senior_amt = 0; 
                            // Edited 8/6/2018 to fix incosistencies with the PSION computation of senior
                            //senior_amt = globFunc.roundOff(rData.current * (rData.senior / 100));

                            //senior_amt = rData.current * (rData.senior / 100);
                            //edited 3/1/2019 to use the Math rounding of decimal
                            senior_amt = Math.Round(rData.current * (rData.senior / 100), 2);

                            //edited 5/7/2019 from 
                            //masterAcct.bill_balance = masterAcct.bill_balance - senior_amt; to
                            masterAcct.bill_balance = masterAcct.bill_balance - Math.Abs(senior_amt);

                            ledgerData = new tbLedger();
                            ledgerData.code = "SNR";
                            ledgerData.@ref = rData.bill_ref_num;
                            ledgerData.trans_date = DateTime.Today;
                            ledgerData.symbol = "-";
                            ledgerData.encoder = rData.encoder.Substring(0, 3);
                            ledgerData.master_id = rData.master_id;
                            ledgerData.billing_id = billingID;
                            ledgerData.amount = -Math.Abs(senior_amt);
                            ledgerData.balance = masterAcct.bill_balance;
                            dbcontext.AddTotbLedgers(ledgerData);
                            masterAcct.senior_amt = senior_amt;
                        }
                    }
                }
                                               
                dbcontext.SaveChanges();
                    
            } // end using
        }

        private ReadLog GetReadDetails(string acctno)
        {
            ReadLog readData=new ReadLog();
            using(dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var mrsDownload = (from em in dbcontext.tbMRSUploads
                                   join en in dbcontext.tbMrsDownloads on em.md_acctno equals en.md_acctno
                                   //edited 09/4/2018
                                   //where em.md_acctno.Equals(acctno)
                                   where em.md_acctno.Equals(acctno) && em.md_billmonth.Equals(billmonth)
                                   select new {
                                       acctno = em.md_acctno,
                                       ave_vol = en.md_ave,
                                       vol = em.md_volume,
                                       current = em.md_billamount,
                                       date_pres = em.md_dateuploaded,
                                       date_prev = en.md_dateprev,
                                       rdg_pres = em.md_presrdg,
                                       rdg_prev = em.md_prevrdg,
                                       master_id = en.md_masterID,
                                       arrears = en.md_arrears,
                                       readtime = em.md_readtime,
                                       billrefnum = em.md_billno,
                                       senior = en.md_senior,
                                       instfee = en.md_instfee,
                                       mdmg = en.md_dam_met,
                                       mon_arrear = en.md_mon_arr,
                                       billmonth = em.md_billmonth,
                                       readby = em.md_encoder,
                                       remark = em.md_ffcode,
                                       zonebook = em.md_zone
                                   });

                if (mrsDownload != null)
                {
                    foreach (var dataDL in mrsDownload)
                    {
                        readData.master_id = Convert.ToInt32(dataDL.master_id);
                        readData.bill_ref_num = dataDL.billrefnum.Substring(10, 6);
                        readData.ave_vol = Convert.ToInt32(dataDL.ave_vol);
                        readData.current = Convert.ToDecimal(dataDL.current);
                        readData.date_pres = Convert.ToDateTime(dataDL.date_pres);
                        readData.date_prev = Convert.ToDateTime(dataDL.date_prev);
                        readData.volume = Convert.ToInt32(dataDL.vol);
                        readData.penalty = globFunc.computePenalty(readData.current);
                        readData.mtr_mtn = globFunc.getMeterMtn();
                        readData.rdg_pres = Convert.ToInt32(dataDL.rdg_pres);
                        readData.rdg_prev = Convert.ToInt32(dataDL.rdg_prev);
                        readData.billing_id = globFunc.getBillingID(dataDL.billmonth);
                        readData.readtime = dataDL.readtime;
                        readData.arrears = Convert.ToDecimal(dataDL.arrears);
                        readData.senior = Convert.ToDecimal(dataDL.senior);
                        readData.inst_fee = Convert.ToDecimal(dataDL.instfee);
                        readData.mtr_dmg = Convert.ToDecimal(dataDL.mdmg);
                        readData.encoder = dataDL.readby;
                        readData.remarks = dataDL.remark;
                        readData.zonebook = dataDL.zonebook;
                        readData.billmonth = dataDL.billmonth;
                    }
                }
            }
            return readData;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (gridControl1.Views[0].RowCount > 0)
            {
                //contextMenuStrip1.Items[0].Text = colmrsUP_ID
                //this.Text = gridView1.GetFocusedRowCellValue(colmd_acctno).ToString();
                //this.Text = gridView1.GetFocusedRowCellValue(colmrsUP_ID).ToString();
               nme = gridView1.GetFocusedRowCellValue(colmd_name).ToString().TrimEnd();
               mrsUPid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colmrsUP_ID));
               editRefNoToolStripMenuItem.Text = string.Format("Exclude [{0}] from updating.",nme);                
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void editRefNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string refnum = gridView1.GetFocusedRowCellValue(colmd_billno).ToString().TrimEnd();
            int mrsID=  Int32.TryParse(gridView1.GetFocusedRowCellValue(colmrsUP_ID).ToString(),out mrsID)?mrsID:0;
            
            DialogResult result = MessageBox.Show(string.Format("Do you want to exclude Ref No.:{0} from automated billing.",refnum), "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    try
                    {
                        tbMRSUpload query = dbcontext.tbMRSUploads.First(x => x.mrsUP_ID == mrsID);
                        query.md_billno = "";
                        query.md_remark = string.Format("Cancelled by {0}", username);
                        dbcontext.SaveChanges();
                        btnReadings.PerformClick();
                        MessageBox.Show("Bill Cancellation is successful");
                    }
                    catch
                    {
                        MessageBox.Show("Error Cancelling bill. Please consult RemixAdmin");
                    }
                    //btnReadings_Click(object sender, EventArgs e)
                }
            }
        }

        private void markDisconnected(int masterid)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMasters.FirstOrDefault(x => x.master_id == masterid);
                if (query != null)
                {
                    query.status = "X";
                }
                dbcontext.SaveChanges();
            }
        }

        private void btnSaveManualBill_Click(object sender, EventArgs e)
        {
            int rec_count = 0;
            var ds = dsMRSDownUpload.Tables[0].AsEnumerable().Select(x => x);
            int cnt = ds.Count();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                foreach (var upRec in ds)
                {
                    string billno = upRec["md_billno"].ToString();
                    int volume = Int32.TryParse(upRec["md_volume"].ToString(), out volume) ? volume : 0;

                    if (billno.Length >= 3)
                    {
                        continue;
                    }

                    rec_count++;
                    string acctno = upRec["md_acctno"].ToString().TrimEnd();
                    int prevrdg = Convert.ToInt32(upRec["md_prevrdg"].ToString());
                    //int md_presrdg = Convert.ToInt32(upRec["md_presrdg"].ToString());
                    string md_encoder = globFunc.getUserInitials(userID).Substring(0, 3);
                    int ave = Int32.TryParse(upRec["md_ave"].ToString(), out ave) ? ave : 0;
                    string name = upRec["md_name"].ToString().Substring(0,30).TrimEnd();
                    string address = upRec["md_address"].ToString().Substring(0, 30).TrimEnd();
                    string metno = upRec["md_metno"].ToString().Substring(0, 10).Trim();
                    string ctgry = upRec["md_ctgry"].ToString().TrimEnd();
                    string cardno = upRec["md_cardno"].ToString();
                    DateTime datePrev = Convert.ToDateTime(upRec["md_dateprev"].ToString());
                    string zone = cmbZoneBook.Text;
                    int masterid = globFunc.getMasterID(acctno);
                    decimal if2 = globFunc.getIF2(masterid);
                    decimal arrears = globFunc.getArrears(masterid);
                    decimal dmgmtr = globFunc.getDmgMtr(masterid);
                    decimal septagefee = 0; // globFunc.getSeptageFee() to be implemented
                    decimal mtrmtn = globFunc.getMeterMtn();

               
                    tbManualBill tbmanual = new tbManualBill();
                    tbmanual.master_id = masterid;
                    tbmanual.prev_rdg = prevrdg;
                    tbmanual.prev_rdg_date = datePrev;
                    tbmanual.ave_vol = ave;                 
                    tbmanual.name = name;
                    tbmanual.address = address;                    
                    tbmanual.ctgy = Convert.ToInt32(ctgry);
                    tbmanual.cardno = Convert.ToInt32(cardno);
                    tbmanual.zone = zone;
                    tbmanual.instfee = if2;
                    tbmanual.arrears = arrears;
                    tbmanual.dmgmtr = dmgmtr;
                    tbmanual.septagefee = septagefee;
                    tbmanual.mtrmaintenance = mtr_mtn;
                    tbmanual.date_added = DateTime.Today;
                    tbmanual.meter_num = metno;
                    tbmanual.billmonth = cmbBillMonth.Text;
                    tbmanual.acctno = acctno;
                    dbcontext.AddTotbManualBills(tbmanual);
                }

                dbcontext.SaveChanges();
                MessageBox.Show(string.Format("{0} records transferred to Manual Billing Module",rec_count));
            }
        }   
    }
}
