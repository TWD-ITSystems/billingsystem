using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.IO;
using System.Collections;

namespace BillingSystem
{
    public partial class formDataRepair : Form
    {
        public string username = "";
        public int userID = 0;
        MySqlConnection myCon = new MySqlConnection();
        DataSet dsReadingsToSQL = new DataSet();
        string my_constr = "server={0};uid=root;pwd=root;database=mrs_tagumwd;default command timeout=0;";
        GlobalFunctions global_func = new GlobalFunctions();
        string billmonth = "";
        string zonebook = "";
        string ip_add = "";
        int record_save = 0;
        string strsave = "";
        int billingID = 0;
        dbCommercialEntities gcontext = new dbCommercialEntities();
        DBRemix dbfData;
        int counter = 0;
        string tablename = "";
        string[] dbParams = { "REF", "NAME", "ACCTNO", "ZONE", "CURRENT", "DATE", "SOURCE", "COLLECTED" };
        int accntsPaid = 0;
        List<string> paidAccounts = new List<string>();
        List<string> repairedAccounts = new List<string>();

        public formDataRepair()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            billmonth = txtBillmonth.Text;
            zonebook = txtZoneBook.Text;
            strsave = string.Format(@"D:\repair\{0}-AEL transferred_accounts.txt", txtZoneBook.Text);
            record_save = 0;
            transferReadings();

        }

        private void formDataRepair_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLedger.tbLedger' table. You can move, or remove it, as needed.
          //  this.tbLedgerTableAdapter.Fill(this.dsLedger.tbLedger);

            // ip_add = global_func.getMRS_IPADDRESS();
            ip_add = "192.168.1.240"; // Mark MRS
            //ip_add = "192.168.1.35"; // Edgar MRS
            //ip_add = "192.168.1.110";  // Server MRS
            // tbBillingDetailBindingSource.DataSource = gcontext.tbBillingDetails;

        }

        private void openMySqlConnection()
        {
            try
            {
                if (myCon.State == ConnectionState.Open) myCon.Close();
                string tx = string.Format(my_constr, ip_add);
                my_constr = tx;
                myCon.ConnectionString = tx;
                myCon.Open();
            }
            catch
            {
                MessageBox.Show("Connection to the MRS Server failed. Please check your network connection.");
            }
        }

        private void transferReadings()
        {
            DataSet tbReading = new DataSet();
            string query = "";

            query = "Select `bill_date`,`name`,`batch`,`bill_no`,`bill_month`,`account_no`,`sc`,`ff_code`,`prevread`,`curread`,`readtime`,`volume`,`bill_amt` from reading_log ";
            query = query + string.Format("where bill_month='{0}' And batch='{1}'", billmonth, zonebook);

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

            var dsRecords = tbReading.Tables[0].AsEnumerable().Select(x => x);
            int counter = 0;
            int recCount = dsRecords.Count();
            string txtold = this.Text;
            int countPresent = 0;
            string str = "";
            str = string.Format(@"D:\repair\{0}-AEL accts_present_in_sql.txt", txtZoneBook.Text);
            foreach (var dRows in dsRecords)
            {
                if (checkAccountinTbUploads(dRows["account_no"].ToString()))
                {
                    global_func.saveLogFile(str, dRows["account_no"].ToString());
                    countPresent++;
                    continue;
                }

                tbMRSUpload upRec = new tbMRSUpload();
                this.Text = string.Format("[Total Rec : {1}] -Transferring ... {0}", dRows["name"].ToString(),counter);
                upRec.md_billmonth = dRows["bill_month"].ToString();
               
                upRec.md_acctno = dRows["account_no"].ToString();
                upRec.md_zone = dRows["batch"].ToString();
                 
                upRec.md_ctgry = dRows["sc"].ToString();
                upRec.md_prevrdg = dRows["prevread"].ToString();
                upRec.md_presrdg = dRows["curread"].ToString();
                upRec.md_volume = dRows["volume"].ToString();
                
                upRec.md_ffcode = getFFCode(dRows["ff_code"].ToString());
                upRec.md_mccode = "repaired";
                upRec.md_readtime = dRows["readtime"].ToString();
               


                
                upRec.md_billno = dRows["bill_no"].ToString();                           
                upRec.md_encoder = global_func.getMtrReaderByZone(dRows["batch"].ToString());              
                upRec.md_billamount = dRows["bill_amt"].ToString();
               
              


                upRec.md_dateuploaded = Convert.ToDateTime(dRows["bill_date"].ToString()).ToShortDateString();
                upRec.md_masterID = null;

                saveRecordinTbUploads(upRec);
                counter++;

            }
            this.Text = txtold;
            MessageBox.Show(string.Format("{0} of records transferred", counter));
            global_func.saveLogFile(str, string.Format("Count: {0}", countPresent));
            global_func.saveLogFile(strsave, string.Format("Count: {0}", record_save));
            this.myCon.Close();
            tbReading.Dispose();
        }

        private bool checkAccountinTbUploads(string acctno)
        {
            bool retval = false;

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMRSUploads.FirstOrDefault(x => x.md_acctno.Equals(acctno) && x.md_billmonth.Equals(billmonth));

                if (query != null)
                {
                    retval = true;
                }
                else
                {
                    retval = false;
                }
            }
            return retval;
        }

        private void saveRecordinTbUploads(tbMRSUpload upRec)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
               // strsave = string.Format(@"D:\repair\{0}-transferred_accounts.txt", txtZoneBook.Text);
               // global_func.saveLogFile(strsave, upRec.md_acctno);
                record_save++;
                dbcontext.AddTotbMRSUploads(upRec);
                dbcontext.SaveChanges();
            }

        }

        private string getFFCode(string ffcode)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbServiceRequestCodes.Where(x => x.sr_code.Equals(ffcode)).Select(x => x.code_desc).SingleOrDefault();
                if (query != null)
                {
                    return query.ToString();
                }
                else
                {
                    return "OK";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string logfile = string.Format("E:\\repair\\repairzone-{0}.txt", textBox1.Text);
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = (from em in dbcontext.tbMRSUploads
                             where em.md_zone.Equals(textBox1.Text) && em.md_billmonth.Equals(textBox2.Text)
                             select em);

                MessageBox.Show("Zone: " + textBox1.Text + " --- billmonth" + textBox2.Text + " Count: "+query.Count());
                if (query != null)
                {


                    foreach (var dsRec in query)
                    {
                        int masterid = global_func.getMasterID(dsRec.md_acctno);
                        int vol = Convert.ToInt32(dsRec.md_volume);
                        // full repair
                        
                        if (dsRec.md_remark.Length > 0)
                        {
                            string oldbill = dsRec.md_billno;
                            dsRec.md_billno = dsRec.md_remark;
                            dsRec.md_billamount = global_func.processCurrent(masterid, vol).ToString();
                            //    dsRec.md_billmonth = "05-2014";
               //             global_func.saveLogFile(logfile, string.Format("{0}-{1} new:{2} old:{3}", dsRec.md_zone, dsRec.md_acctno, dsRec.md_billno, oldbill));
                            counter++;
                        }
                        // end full repair
                        //  slight repair
                        //if (Convert.ToInt32(dsRec.md_billno) == 0)
                        /**
                        if (dsRec.md_billno.Equals("0"))
                        {
                            dsRec.md_billno = dsRec.md_remark;
                            dsRec.md_billamount = global_func.processCurrent(masterid, vol).ToString();
                            //dsRec.md_billmonth = "05-2014";
                            global_func.saveLogFile(@"D:\repair1004.txt", dsRec.md_acctno);
                           counter++; 
                        }
                         */
                        // end slight repair
                    }
                }

                dbcontext.SaveChanges();
               // global_func.saveLogFile(@logfile, "Count : " + counter.ToString());
                MessageBox.Show(string.Format("Repair to Zone/Book: {0} is finished..Total Records: {1}", textBox1.Text, counter.ToString()));
            }

        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            string pathfile = Path.GetDirectoryName(openFileDialog1.FileName);
            string fileName = openFileDialog1.SafeFileName;
            zonebook = textBox3.Text;
            billmonth = textBox4.Text;
            decimal mtrmtn = global_func.getMeterMtn();
            //string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};User Id=admin;Password=;", fileName);
            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", pathfile);
            if (result == DialogResult.OK)
            {
                textBox3.Text = fileName.Substring(4, 4);


                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = string.Format("Select [NAME],[ACCTNO],[ZONE],[CURRENT],[CARDNO],[ARREARS],[PRESRDG],[REF],[DATEPRES],[VOLUME],[PREVRDG],[PENALTY],[AVE],[OTHERS],[DATEPREV],[ENCODER] from [{0}]", fileName);
                    using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet myDataset = new DataSet();
                        myAdapter.Fill(myDataset, fileName);

                        var dTable = myDataset.Tables[0].AsEnumerable();
                        var dRows = dTable.Select(x => x);
                        int billproc_id = 0;

                        int rowcount = dRows.Count();
                        string oldtext = this.Text;
                        int counter = 0;
                        foreach (var drow in dRows)
                        {
                            /**
                            int ave_vol = Convert.ToInt32(drow["AVE"].ToString());
                            string acctno = drow["ACCTNO"].ToString();
                            string zonebook = drow["ZONE"].ToString();
                            string cardno = drow["CARDNO"].ToString();
                            updateMaster(ave_vol, acctno, zonebook, cardno);
                             */
                            string zone = drow["ZONE"].ToString();
                            string temp = drow["ACCTNO"].ToString();


                          //  if (!temp.Equals("018632")) continue;

                            if (billproc_id == 0)
                            {
                              billproc_id = saveBillProcessing(global_func.getMtrReaderByZone(zone), "Manual", textBox3.Text);
                            }

                            ReadLog rData = new ReadLog();

                            rData.master_id = global_func.getMasterID(drow["ACCTNO"].ToString());
                            rData.mrs_ref = textBox4.Text;
                            try
                            {
                                rData.ave_vol = Convert.ToInt32(drow["AVE"].ToString());
                            }
                            catch { rData.ave_vol = 0; }

                           // rData.current = Convert.ToDecimal(drow["CURRENT"].ToString()) - mtrmtn;
                            rData.current = Convert.ToDecimal(drow["CURRENT"].ToString());
                            rData.date_pres = Convert.ToDateTime(drow["DATEPRES"].ToString());
                            try
                            {
                                rData.date_prev = Convert.ToDateTime(drow["DATEPREV"].ToString());
                            }
                            catch { rData.date_prev = null; };
                            rData.volume = Convert.ToInt32(drow["VOLUME"].ToString());
                            //rData.penalty = Convert.ToDecimal(drow["PENALTY"].ToString());
                            rData.mtr_mtn = mtrmtn;
                            rData.rdg_pres = Convert.ToInt32(drow["PRESRDG"].ToString());
                            int prev_rdg = Int32.TryParse(drow["PREVRDG"].ToString(), out prev_rdg) ? prev_rdg : 0;
                            rData.rdg_prev = prev_rdg;
                            rData.billing_id = billproc_id;
                            try
                            {
                                rData.arrears = Convert.ToDecimal(drow["ARREARS"].ToString());
                            }
                            catch { rData.arrears = 0; };
                            try
                            {
                                rData.inst_fee = Convert.ToDecimal(drow["OTHERS"].ToString());
                            }
                            catch { rData.inst_fee = 0; };
                            rData.bill_ref_num = drow["REF"].ToString();
                            rData.encoder = drow["ENCODER"].ToString();
                            UpdateMasterAndAccounts(rData);
                            counter++;
                            this.Text = string.Format("Processing record [#{0} - Zone: {2} ] - {1} ", counter, drow["NAME"].ToString(), zone);


                        }
                        this.Text = oldtext;
                        MessageBox.Show(string.Format("{0} has been updated to master", fileName));
                        listBox1.Items.Add(fileName);
                    }
                }

            }
            else
            {
                return;
            }
        }

        private void saveToBillDetails(ReadLog rData)
        {

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbBillingDetail rBill = new tbBillingDetail();

                rBill.arrears = rData.arrears;
                //rBill.arrears_month = rData.
                rBill.ave_vol = rData.ave_vol;
                rBill.bill_ref_num = rData.bill_ref_num;
                rBill.billproc_id = rData.billing_id; // billproc_id
                rBill.current = rData.current;
                rBill.date_pres = rData.date_pres;
                rBill.date_prev = rData.date_prev;
                rBill.inst_fee = rData.inst_fee;
                rBill.master_id = rData.master_id;
                //rBill.mrs_ref = upID.ToString();
                //rBill.mtr_dmg = rData.mtr_dmg;
                rBill.mtr_mtn = rData.mtr_mtn;
                rBill.mrs_ref = billmonth;
                rBill.mtr_read_by = global_func.getMeterReaderID(rData.encoder);
                //rBill.other_fee_code = rData.
                //rBill.other_fees = 
                rBill.penalty = rData.penalty;
                rBill.rdg_pres = rData.rdg_pres;
                rBill.rdg_prev = rData.rdg_prev;
                //rBill.readtime = rData.readtime;
                rBill.remarks = "OK";
                //rBill.senior = (rData.current * (rData.senior / 100)) * -1;         
                rBill.volume = rData.volume;

                dbcontext.AddTotbBillingDetails(rBill);
                dbcontext.SaveChanges();
            }

        }

        private int saveBillProcessing(string encoder, string repair_mode, string zonebook)
        {
            int lastrec = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {

                tbBillProcessing dBillProc = new tbBillProcessing();
                dBillProc.mrs_controls = repair_mode;
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

        private void UpdateMasterAndAccounts(ReadLog rData)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMaster masterData = dbcontext.tbMasters.Where(x => x.master_id == rData.master_id).Select(x => x).SingleOrDefault();
                tbMasterAcct masterAcct = dbcontext.tbMasterAccts.Where(x => x.master_id == rData.master_id).Select(x => x).SingleOrDefault();

                masterData.prev_read_date = rData.date_prev;
                masterData.last_read_date = rData.date_pres;
                //  masterAcct.penalty = rData.current * ((penalty_percent / 100));
                masterAcct.penalty = rData.penalty;
                masterAcct.bill_current = rData.current;
                masterAcct.rdg_pres = rData.rdg_pres;
                masterAcct.rdg_prev = rData.rdg_prev;

                if (masterAcct.bill_balance > 0)
                {
                    masterAcct.bill_arrears = masterAcct.bill_balance;
                    masterAcct.bill_arrears_months++;
                    masterAcct.bill_balance = rData.current + rData.mtr_mtn + masterAcct.bill_arrears;

                    if (billmonth.Substring(3, 4).Equals(DateTime.Today.Year.ToString()))
                    {
                        if (masterAcct.arrears_curr_yr.HasValue)
                        {
                            if (!(masterAcct.bill_arrears == masterAcct.arrears_curr_yr))
                            {
                                masterAcct.arrears_curr_yr = masterAcct.arrears_curr_yr + masterAcct.bill_arrears;
                            }                            
                        }
                        else
                        {
                            masterAcct.arrears_curr_yr = masterAcct.bill_arrears;
                        }
                    }
                    else
                    {
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
                    masterAcct.bill_arrears_months = 0;
                }

                int bill_ID = dbcontext.tbBillings.First(x => x.billing_desc.Equals(textBox4.Text)).billing_id;

                tbLedger ledgerData = new tbLedger();
                ledgerData.code = "BILL";
                ledgerData.@ref = rData.bill_ref_num;
                //ledgerData.trans_date = rData.date_pres;
                ledgerData.trans_date = DateTime.Today;
                ledgerData.remarks = "Billed " + rData.date_pres.ToShortDateString();
                ledgerData.volume = rData.volume;
                ledgerData.symbol = "+";
                ledgerData.encoder = rData.encoder.Substring(0, 3);
                ledgerData.master_id = rData.master_id;
                ledgerData.billing_id = bill_ID;
                ledgerData.presrdg = rData.rdg_pres;
                ledgerData.amount = rData.current + rData.mtr_mtn;
                ledgerData.balance = masterAcct.bill_balance;
                ledgerData.zoneuid = global_func.getZoneUIDbyMaster(rData.master_id);
                dbcontext.AddTotbLedgers(ledgerData);

                if (rData.inst_fee > 0)
                {
                    //masterAcct.bill_balance = masterAcct.bill_balance + rData.inst_fee;
                    masterAcct.IFArrears = masterAcct.IFArrears + rData.inst_fee;

                    ledgerData = new tbLedger();
                    ledgerData.code = "IF";
                    ledgerData.@ref = rData.bill_ref_num;
                    ledgerData.trans_date = DateTime.Today;
                    //ledgerData.symbol = "";
                    ledgerData.encoder = rData.encoder.Substring(0, 3);
                    ledgerData.master_id = rData.master_id;
                    //  ledgerData.billing_id = billingID;
                    ledgerData.other = rData.inst_fee;
                    dbcontext.AddTotbLedgers(ledgerData);
                }

                if (masterAcct.isSenior == true)
                {
                    if (rData.volume < 30)
                    {
                        decimal senior_amt = 0;
                        senior_amt = rData.current * (rData.senior / 100);
                        masterAcct.bill_balance = masterAcct.bill_balance - senior_amt;

                        ledgerData = new tbLedger();
                        ledgerData.code = "SNR";
                        ledgerData.@ref = rData.bill_ref_num;
                        ledgerData.trans_date = DateTime.Today;
                        ledgerData.symbol = "-";
                        ledgerData.encoder = rData.encoder.Substring(0, 3);
                        ledgerData.master_id = rData.master_id;
                        // ledgerData.billing_id = billingID;
                        ledgerData.amount = -Math.Abs(senior_amt);
                        ledgerData.balance = masterAcct.bill_balance;
                        dbcontext.AddTotbLedgers(ledgerData);
                    }
                }



                dbcontext.SaveChanges();

            } // end using
        }



        private void updateMaster(int ave_vol, string acctno, string zonebook, string cardno)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMaster query = dbcontext.tbMasters.First(x => x.acctno.Equals(acctno));
                if (query != null)
                {
                    int zoneID = getZoneID(zonebook);
                    query.cardno = Convert.ToInt32(cardno);
                    query.zone_id = zoneID;
                    tbMasterAcct mAcct = dbcontext.tbMasterAccts.First(x => x.master_id == query.master_id);
                    mAcct.ave_vol = ave_vol;
                    dbcontext.SaveChanges();
                }
            }
        }

        private int getZoneID(string zonebook)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbZones.Where(x => x.zone_name.Equals(zonebook)).SingleOrDefault();
                if (query != null)
                {
                    return query.zone_id;
                }
                else
                {
                    return 0;
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
          
        }


        private void btnDpay_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog();

            string pathfile = Path.GetDirectoryName(openFileDialog1.FileName);
            string fileName = openFileDialog1.SafeFileName;
           

            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", pathfile);
            if (result == DialogResult.OK)
            {

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    //string query = string.Format("Select [NAME],[CURRENT],[ACCTNO],[DATE],[REF],[INSTFEE],[COLLECTED],[SVFEE],[SDRCODE],[SDRAMT],[ENCODER],[TFFEE],[PENALTY],[AR_CURR],[AR_PRI],[ROYALTY],[ZONE] from [{0}]", fileName);
                    string query = string.Format("Select [NAME],[CURRENT],[ACCTNO],[DATE],[REF],[INSTFEE],[COLLECTED],[SVFEE],[SDRCODE],[SDRAMT],[ENCODER],[TFFEE],[PENALTY],[AR_CURR],[AR_PRI],[ROYALTY] from [{0}]", fileName);
                    using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet myDataset = new DataSet();
                        myAdapter.Fill(myDataset, fileName);

                        var dTable = myDataset.Tables[0].AsEnumerable();
                        var dRows = dTable.Select(x => x);
                        

                        int rowcount = dRows.Count();
                        string oldtext = this.Text;
                        int counter = 0;
                        using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                        {
                            foreach (var drow in dRows)
                            {
                                tbLedger ledgerData;
                                string acctno = drow["ACCTNO"].ToString();
                                decimal collected = decimal.TryParse(drow["COLLECTED"].ToString(), out collected) ? collected : 0;
                                decimal current = decimal.TryParse(drow["CURRENT"].ToString(), out current) ? current : 0;
                                decimal sdramt = decimal.TryParse(drow["SDRAMT"].ToString(), out sdramt) ? sdramt : 0;
                                string sdrcode = drow["SDRCODE"].ToString();
                                decimal AmtToDeduct = collected;
                                decimal svfee = decimal.TryParse(drow["SVFEE"].ToString(), out svfee) ? svfee : 0;
                                decimal tffee = decimal.TryParse(drow["TFFEE"].ToString(), out tffee) ? tffee : 0;
                           //string zone = drow["ZONE"].ToString();

                                bool isIF = false;
                                bool isSVFEE = false;
                                bool is439 = false;
                                bool isTFFEE = false;
                                decimal ifamt = 0;
                                decimal amt439 = 0;
                                decimal svfeeamt = 0;
                                decimal tfeeamt = 0;
                                DateTime trans_date = new DateTime();
                               //if (!sdrcode.Equals("IF2")) continue;
                               //if (!acctno.Equals("012689")) continue;
                               // if (zone.Length > 2) continue;
                                

                                if (collected == 0) continue;
                                int masterID = global_func.getMasterID(acctno);
                                if ((acctno.Length != 6) || (masterID == 0))
                                {
                                    //MessageBox.Show(string.Format("acctno {0} not found", acctno));
                                    string logfile = @"D:\repair\pay\repair_pay.txt";
                                    string datatxt = string.Format("{0} - {1} - {2}", fileName, acctno, collected);
                                    global_func.saveLogFile(logfile, datatxt);
                                    continue;
                                }

                                tbMasterAcct mastAcct = dbcontext.tbMasterAccts.FirstOrDefault(x => x.master_id == masterID);
                                trans_date = Convert.ToDateTime(drow["DATE"].ToString());

                                if (sdrcode.Equals("IF2"))
                                {
                                  
                                        if (sdramt > 0)
                                        {
                                            AmtToDeduct = AmtToDeduct - sdramt;


                                            if (mastAcct.IFArrears > 0)
                                            {
                                                mastAcct.IFArrears = mastAcct.IFArrears - sdramt;
                                            }
                                            decimal chkbal = 2500 - sdramt;

                                            if (!(chkbal == mastAcct.IFBalance))
                                            {
                                                mastAcct.IFBalance = mastAcct.IFBalance - sdramt;
                                            }   

                                            if (sdramt == collected)
                                            {

                                                ledgerData = new tbLedger();
                                                ledgerData.code = "IFPd";
                                                ledgerData.@ref = drow["REF"].ToString();
                                                ledgerData.trans_date = DateTime.Today;
                                                ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                                                ledgerData.symbol = "";
                                                ledgerData.encoder = drow["ENCODER"].ToString();
                                                ledgerData.master_id = masterID;
                                                ledgerData.other = sdramt;
                                                dbcontext.AddTotbLedgers(ledgerData);
                                                dbcontext.SaveChanges();
                                                continue;
                                            }

                                            isIF = true;
                                            ifamt = sdramt;
                                        }
                         

                                }

                                if (sdrcode.Equals("439"))
                                {
                                    

                                    if (sdramt > 0)
                                    {
                                        AmtToDeduct = AmtToDeduct - sdramt;
                                        if (sdramt == collected)
                                        {
                                            ledgerData = new tbLedger();
                                            ledgerData.code = "439";
                                            ledgerData.@ref = drow["REF"].ToString();
                                            ledgerData.trans_date = DateTime.Today;
                                            ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                                            ledgerData.symbol = "";
                                            ledgerData.encoder = drow["ENCODER"].ToString();
                                            ledgerData.master_id = masterID;
                                            ledgerData.other = sdramt;
                                            dbcontext.AddTotbLedgers(ledgerData);
                                            dbcontext.SaveChanges();
                                            continue;
                                        }
                                        is439 = true;
                                        amt439 = sdramt;
                                    }
                                }

                                if (svfee > 0)
                                {
                                    AmtToDeduct = AmtToDeduct - svfee;
                                        if (sdramt == collected)
                                        {
                                            ledgerData = new tbLedger();
                                            ledgerData.code = "RFEE";
                                            ledgerData.@ref = drow["REF"].ToString();
                                            ledgerData.trans_date = DateTime.Today;
                                            ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                                            ledgerData.encoder = drow["ENCODER"].ToString();
                                            ledgerData.master_id = masterID;
                                            ledgerData.other = svfee;
                                            dbcontext.AddTotbLedgers(ledgerData);
                                            dbcontext.SaveChanges();
                                            continue;
                                        }
                                        isSVFEE = true;
                                        svfeeamt = svfee;
                                }

                                if (tffee > 0)
                                {
                                    AmtToDeduct = AmtToDeduct - tffee;
                                    if (sdramt == collected)
                                    {
                                        ledgerData = new tbLedger();
                                        ledgerData.code = "TFEE";
                                        ledgerData.@ref = drow["REF"].ToString();
                                        ledgerData.trans_date = DateTime.Today;
                                        ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                                        ledgerData.encoder = drow["ENCODER"].ToString();
                                        ledgerData.master_id = masterID;
                                        ledgerData.other = tffee;
                                        dbcontext.AddTotbLedgers(ledgerData);
                                        dbcontext.SaveChanges();
                                        continue;
                                    }
                                    isTFFEE = true;
                                    tfeeamt = tffee;
                                }

                                ledgerData = new tbLedger();
                                ledgerData.code = "PAID";
                                ledgerData.@ref = drow["REF"].ToString();
                                ledgerData.trans_date = DateTime.Today;
                                ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                                ledgerData.symbol = "-";
                                ledgerData.encoder = drow["ENCODER"].ToString();
                                ledgerData.master_id = masterID;
                                ledgerData.amount = AmtToDeduct;
                                ledgerData.balance = mastAcct.bill_balance - AmtToDeduct;
                                dbcontext.AddTotbLedgers(ledgerData);

                                if (isIF)
                                {
                                    ledgerData = new tbLedger();
                                    ledgerData.code = "IFPd";
                                    ledgerData.@ref = drow["REF"].ToString();
                                    ledgerData.trans_date = DateTime.Today;
                                    ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                                    ledgerData.symbol = "";
                                    ledgerData.encoder = drow["ENCODER"].ToString();
                                    ledgerData.master_id = masterID;
                                    ledgerData.other = ifamt;
                                    dbcontext.AddTotbLedgers(ledgerData);
                                }

                                if (is439)
                                {
                                    ledgerData = new tbLedger();
                                    ledgerData.code = "439";
                                    ledgerData.@ref = drow["REF"].ToString();
                                    ledgerData.trans_date = DateTime.Today;
                                    ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                                    ledgerData.symbol = "";
                                    ledgerData.encoder = drow["ENCODER"].ToString();
                                    ledgerData.master_id = masterID;
                                    ledgerData.other = amt439;
                                    dbcontext.AddTotbLedgers(ledgerData);
                                }

                                if (isSVFEE)
                                {
                                    ledgerData = new tbLedger();
                                    ledgerData.code = "RFEE";
                                    ledgerData.@ref = drow["REF"].ToString();
                                    ledgerData.trans_date = DateTime.Today;
                                    ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                                    ledgerData.encoder = drow["ENCODER"].ToString();
                                    ledgerData.master_id = masterID;
                                    ledgerData.other = svfeeamt;
                                    dbcontext.AddTotbLedgers(ledgerData);
                                }

                                if (isTFFEE)
                                {
                                    ledgerData = new tbLedger();
                                    ledgerData.code = "TFEE";
                                    ledgerData.@ref = drow["REF"].ToString();
                                    ledgerData.trans_date = DateTime.Today;
                                    ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                                    ledgerData.encoder = drow["ENCODER"].ToString();
                                    ledgerData.master_id = masterID;
                                    ledgerData.other = tfeeamt;
                                    dbcontext.AddTotbLedgers(ledgerData);
                                }

                                decimal curr_arr = decimal.TryParse(drow["AR_CURR"].ToString(), out curr_arr) ? curr_arr : 0;
                                decimal pri_arr = decimal.TryParse(drow["AR_PRI"].ToString(), out pri_arr) ? pri_arr : 0;

                                if (curr_arr > 0)
                                {
                                    if (mastAcct.arrears_curr_yr > 0)
                                    {
                                      //  if (curr_arr >= mastAcct.arrears_curr_yr)
                                      //  {
                                            mastAcct.bill_arrears = mastAcct.bill_arrears - curr_arr;
                                            mastAcct.arrears_curr_yr = mastAcct.arrears_curr_yr - curr_arr;
                                            mastAcct.bill_arrears_months--;
                                      //  }
                                    }
                                }

                                if (pri_arr > 0)
                                {
                                    if (mastAcct.arrears_prev_yrs > 0)
                                    {
                                        if (pri_arr >= mastAcct.arrears_prev_yrs)
                                        {
                                            mastAcct.bill_arrears = mastAcct.bill_arrears - pri_arr;
                                            mastAcct.arrears_prev_yrs = mastAcct.arrears_prev_yrs - pri_arr;
                                        }
                                    }
                                }

                                decimal balance = Convert.ToDecimal(mastAcct.bill_balance);

                                mastAcct.bill_balance = balance - AmtToDeduct;
                               

                                decimal installfee = decimal.TryParse(drow["INSTFEE"].ToString(), out installfee) ? installfee : 0;
                                if (installfee > 0)
                                {
                                    decimal instfee = Convert.ToDecimal(drow["INSTFEE"].ToString());
                                    ledgerData = new tbLedger();
                                    ledgerData.code = "IFDn";
                                    ledgerData.@ref = drow["REF"].ToString();
                                    ledgerData.trans_date = DateTime.Today;
                                    ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                                    ledgerData.symbol = "-";
                                    ledgerData.encoder = drow["ENCODER"].ToString();
                                    ledgerData.master_id = masterID;
                                    ledgerData.amount = instfee;


                                    if (mastAcct != null)
                                    {
                                        mastAcct.IFAmount = 2500;
                                        mastAcct.IFDownpayment = instfee;
                                        mastAcct.IFPayableMonths = 12;
                                        mastAcct.IFBalance = 2500 - instfee;
                                        mastAcct.IFMonthlyPay = 150;
                                    }
                                    global_func.saveLogFile(string.Format(@"D:\repair\pay\{0}.txt", fileName), acctno);
                                    dbcontext.AddTotbLedgers(ledgerData);
                                }

                                this.Text = drow["NAME"].ToString();

                                dbcontext.SaveChanges();

                            } // foreach end
                            listBox2.Items.Add(fileName);
                            MessageBox.Show("Dpay update is finished.");
                        } //using end

                    }
                }
            }
        }

        private void btnBankPayments_Click(object sender, EventArgs e)
        {
            string xlsFile = "";
            DialogResult result = openFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {
                xlsFile = openFileDialog1.FileName;
            }
            else
            {
                return;
            }

            string adaptStr = "";
            string xls = openFileDialog1.SafeFileName;
            var connStr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;data source={0};Extended Properties=Excel 8.0;", xlsFile);
            adaptStr = string.Format("Select * from [{0}$]", "Sheet1");

            var adapter = new OleDbDataAdapter(adaptStr, connStr);
            var ds = new DataSet();
            adapter.Fill(ds, "tbPay");

            var data = ds.Tables["tbPay"].AsEnumerable();
            var query = data.Select(x => new
            {
                date = x["DATE"],
                acctno = x["ACCTNO"],
                amount = x["AMOUNT"],
                refnum = x["REF"],
                agent = x["BANK_CODE"]
            });

            string oldtext = this.Text;
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                foreach (var mrsData in query)
                {
                    DateTime transdate = Convert.ToDateTime(mrsData.date);
                    string acctno = mrsData.acctno.ToString();
                    decimal amount = decimal.TryParse(mrsData.amount.ToString(), out amount) ? amount : 0;
                    string refnum = mrsData.refnum.ToString();
                    string agent = mrsData.agent.ToString();
                    int masterID = 0;
                    int zoneID = 0;
                    int zone = 0;
                    decimal amtToDeduct = 0;
                    decimal current = 0;
                    decimal ifamt = 0;


                    this.Text = string.Format("Processing..[{0}]", acctno);
                    if (acctno.ToString().Length > 6)
                    {
                        continue;
                    }
                    else
                    {
                        masterID = global_func.getMasterID(acctno.ToString());
                        zoneID = context.tbMasters.First(x => x.master_id == masterID).zone_id;
                        zone = global_func.getZoneUID(zoneID);


                    }
                    if (masterID > 0)
                    {
                        var ifLook = context.tbLedgers.Where(x => x.master_id == masterID).Select(x => x);


                        if (ifLook != null)
                        {

                            if (ifLook.Count() > 1)
                            {

                                foreach (var ifData in ifLook)
                                {
                                    string code = ifData.code.ToString().Trim();
                                    if (code.Equals("BILL"))
                                    {
                                        current = Convert.ToDecimal(ifData.amount);
                                        if (refnum.Length == 0)
                                        {
                                            refnum = ifData.@ref;
                                        }
                                    }

                                    if (code.Equals("IF"))
                                    {
                                        ifamt = Convert.ToDecimal(ifData.amount);
                                        amtToDeduct = ifamt;
                                    }
                                }
                            }
                            else
                            {
                                try
                                {
                                    tbLedger tbL = ifLook.First();
                                    refnum = tbL.@ref;
                                    amtToDeduct = amount;
                                }
                                catch
                                {
                                    string logfile = @"D:\repair\pay\agent_noledger.txt";
                                    string datatxt = string.Format("{0} - {1} - {2}", xls, acctno, amount);
                                    global_func.saveLogFile(logfile, datatxt);

                                }
                            }



                            tbLedger ledgerData;
                            tbMasterAcct mastAcct = context.tbMasterAccts.FirstOrDefault(x => x.master_id == masterID);


                            ledgerData = new tbLedger();
                            ledgerData.code = "PAID";
                            ledgerData.@ref = refnum;
                            ledgerData.trans_date = Convert.ToDateTime(transdate);
                            ledgerData.symbol = "-";
                            ledgerData.encoder = agent.ToString();
                            ledgerData.master_id = masterID;
                            ledgerData.amount = amount;
                            ledgerData.balance = mastAcct.bill_balance - (current + amtToDeduct);
                            ledgerData.zoneuid = global_func.getZoneUIDbyMaster(masterID);
                            context.AddTotbLedgers(ledgerData);

                            decimal balance = Convert.ToDecimal(mastAcct.bill_balance);
                            mastAcct.bill_balance = balance - (current + amtToDeduct);

                            if (ifamt > 0)
                            {
                                if (mastAcct.IFArrears > 0)
                                {
                                    mastAcct.IFArrears = mastAcct.IFArrears - ifamt;
                                }

                                mastAcct.IFBalance = mastAcct.IFBalance - ifamt;

                                ledgerData = new tbLedger();
                                ledgerData.code = "IFPd";
                                ledgerData.@ref = refnum;
                                ledgerData.trans_date = Convert.ToDateTime(transdate); ;
                                ledgerData.symbol = "-";
                                ledgerData.encoder = agent.ToString();
                                ledgerData.master_id = masterID;
                                ledgerData.amount = ifamt;
                                ledgerData.zoneuid = global_func.getZoneUIDbyMaster(masterID);
                                context.AddTotbLedgers(ledgerData);
                            }


                        }
                        else
                        {
                            string logfile = @"D:\repair\pay\agent_noledger.txt";
                            string datatxt = string.Format("{0} - {1} - {2}", xls, acctno, amount);
                            global_func.saveLogFile(logfile, datatxt);
                        }
                    }


                }
                context.SaveChanges();
                this.Text = oldtext;
                MessageBox.Show("Updating is Done");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            string pathfile = Path.GetDirectoryName(openFileDialog1.FileName);
            string fileName = openFileDialog1.SafeFileName;

            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", pathfile);
            if (result == DialogResult.OK)
            {

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = string.Format("Select [YRMON],[NAME],[CURRENT],[ACCTNO],[DATE],[REF],[INSTFEE],[COLLECTED],[SVFEE],[SDRCODE],[SDRAMT],[ENCODER],[TFFEE],[PENALTY],[AR_CURR],[AR_PRI],[ROYALTY] from [{0}]", fileName);
                    using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet myDataset = new DataSet();
                        myAdapter.Fill(myDataset, fileName);

                        var dTable = myDataset.Tables[0].AsEnumerable();
                        var dRows = dTable.Select(x => new
                        {
                            svfee = x["SVFEE"],
                            acctno = x["ACCTNO"],
                            refnum = x["REF"],
                            transdate = x["DATE"],
                            encoder = x["ENCODER"],
                            name = x["NAME"],
                            amount = x["COLLECTED"],
                            yrmon = x["YRMON"]

                        }).Where(x => x.refnum.ToString().Length > 0 && !x.acctno.Equals("B") && x.yrmon.ToString().Length>0 );

                        var svQuery = dRows.Where(x => Convert.ToDecimal(x.svfee) > 0).Select(x => x);

                        int svCount = svQuery.Count();
                        int rowcount = dRows.Count();
                        string oldtext = this.Text;
                        int counter = 0;
                        using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                        {
                            foreach (var drow in svQuery)
                            {
                                tbLedger ledgerData;
                                string acctno = drow.acctno.ToString();
                                decimal svfee = decimal.TryParse(drow.svfee.ToString(), out svfee) ? svfee : 0;
                                decimal collected = decimal.TryParse(drow.amount.ToString(), out collected) ? collected : 0;
                                DateTime transdate = DateTime.TryParse(drow.transdate.ToString(), out transdate) ? transdate : new DateTime(1900, 01, 01);


                                int masterID = global_func.getMasterID(acctno);
                                string remarks = transdate.ToShortDateString();

                                tbMasterAcct mastAcct = dbcontext.tbMasterAccts.FirstOrDefault(x => x.master_id == masterID);

                               
                                ledgerData = new tbLedger();
                                ledgerData.code = "RPR1";
                                ledgerData.@ref = drow.refnum.ToString();
                                //ledgerData.trans_date = Convert.ToDateTime(drow.transdate.ToShortDateString());
                                ledgerData.trans_date = DateTime.Today;
                                ledgerData.symbol = "+";
                                ledgerData.encoder = drow.encoder.ToString();
                                ledgerData.master_id = masterID;
                                ledgerData.other = svfee;
                                ledgerData.remarks = string.Format("RFEE-{0}", remarks);
                                ledgerData.balance = mastAcct.bill_balance + svfee;
                                ledgerData.zoneuid = global_func.getZoneUIDbyMaster(masterID);
                                dbcontext.AddTotbLedgers(ledgerData);
                                mastAcct.bill_balance = ledgerData.balance;
                                
                               // tbLedger billLedger = dbcontext.tbLedgers.First(x => x.master_id == masterID && x.code.Equals("RPR1"));
                                //billLedger.balance = billLedger.balance + svfee;                                
                                //billLedger.symbol = "+";
                                

                                this.Text = drow.acctno.ToString();
                                dbcontext.SaveChanges();

                            } // foreach end
                            this.Text = oldtext;
                            MessageBox.Show("RFEE processing is done");
                            listBox2.Items.Add(fileName);

                        } //using end

                    }
                }
            }
        }

        private void btnPrintProcess_Click(object sender, EventArgs e)
        {

        }

        private void btnProcessData_Click(object sender, EventArgs e)
        {

            string oldtext = this.Text;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var exceptionlist = new List<string> { "X", "x" };

                var qMaster = dbcontext.tbMasters.Select(x => x).Where(x => !exceptionlist.Contains(x.status));
                string filepath = @"D:\repair\noLedger.txt";
                string data = "";
                foreach (tbMaster qData in qMaster)
                {
                    var qLedger = dbcontext.tbLedgers.FirstOrDefault(x => x.master_id == qData.master_id && x.code.Equals("BILL"));
                    if (qLedger == null)
                    {
                        //master_id,acctno,name,address,cardno,status,zone
                        data = string.Format("{0};{1};{2};{3};{4};{5};{6};", qData.master_id, qData.acctno.TrimEnd(), qData.name.TrimEnd(), qData.address.TrimEnd(), qData.cardno, qData.status, global_func.getZoneName(qData.zone_id));
                        global_func.saveLogFile(filepath, data);
                    }
                    this.Text = qData.name;
                }
                MessageBox.Show("Done");

            }

        }

        private void saveToDBF(AgentClass agentData)
        {
            ArrayList dbValues = new ArrayList();
            dbValues.Add(agentData.@ref);
            dbValues.Add(agentData.name);
            dbValues.Add(agentData.acctno);
            dbValues.Add(agentData.zone);
            dbValues.Add(agentData.current);
            dbValues.Add(agentData.date);
            dbValues.Add(agentData.agent);
            dbValues.Add(agentData.current);
            dbfData.SaveToOLEDatabase(tablename, dbValues, dbParams);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string fileName = "";
            MessageBox.Show("Select BILLFILE.dbf to save.");
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = openFileDialog1.SafeFileName;
                tablename = fileName;
                dbfData = new DBRemix(Path.GetDirectoryName(openFileDialog1.FileName), false);
                dbfData.DeleteDatabase(tablename);  // clear database

            }
            else
            {
                return;
            }

            string xlsFile = "";

            MessageBox.Show("Now Select the source bank.xls");
            result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                xlsFile = openFileDialog1.FileName;
            }
            else
            {
                return;
            }

            string adaptStr = "";
            string xls = openFileDialog1.SafeFileName;
            var connStr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;data source={0};Extended Properties=Excel 8.0;", xlsFile);
            adaptStr = string.Format("Select * from [{0}$]", "Sheet1");

            var adapter = new OleDbDataAdapter(adaptStr, connStr);
            var ds = new DataSet();
            adapter.Fill(ds, "tbPay");

            var data = ds.Tables["tbPay"].AsEnumerable();
            var query = data.Select(x => new
            {
                date = x["DATE"],
                acctno = x["ACCTNO"],
                amount = x["AMOUNT"],
                refnum = x["REF"],
                agent = x["BANK_CODE"],
                name = x["NAME"]
            });

            string oldtext = this.Text;
            string name = "";
            int masterID = 0;
            decimal amount = 0;
            string refnum = "";
            string zonebook = "";
            string agent = "";
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                foreach (var drows in query)
                {
                    string acctno = drows.acctno.ToString();
                    if ((acctno.Length > 6) || (acctno.Length <= 0)) continue;
                    tbMaster mast = dbcontext.tbMasters.FirstOrDefault(x => x.acctno.Equals(acctno));
                    zonebook = global_func.getZoneName(mast.zone_id);
                    masterID = mast.master_id;
                    agent = drows.agent.ToString();
                    if (drows.name.ToString().Length <= 0)
                    {
                        name = mast.name;
                    }
                    else
                    {
                        name = drows.name.ToString();
                    }

                    DateTime june = new DateTime(2014, 06, 03);

                    DateTime transdate = Convert.ToDateTime(drows.date);

                    amount = decimal.TryParse(drows.amount.ToString(), out amount) ? amount : 0;
                    refnum = drows.refnum.ToString();
                    // search ledger
                    var ledger = dbcontext.tbLedgers.Where(x => x.trans_date < june && x.code.Equals("BILL") && x.master_id == masterID).Select(x => x);
                    if (ledger != null)
                    {
                        var ledgeArray = ledger.ToArray();
                        if (ledger.Count() == 2)
                        {
                            decimal Amt1 = 0;

                            Amt1 = Convert.ToDecimal(ledgeArray[0].amount);
                            if (amount == Amt1)
                            {
                                refnum = ledgeArray[0].@ref;
                            }
                            else
                            {
                                refnum = ledgeArray[1].@ref;
                            }
                            string datastr = string.Format("{0} - {1}", zonebook, drows.acctno);
                            global_func.saveLogFile(@"D:\repair\doublebill.txt", datastr);
                        }
                        else if (ledger.Count() > 2)
                        {
                            refnum = ledgeArray[0].@ref;
                            global_func.saveLogFile(@"D:\repair\morethan2ledger.txt", drows.acctno.ToString());
                        }
                        else if (ledger.Count() == 1)
                        {
                            refnum = ledgeArray[0].@ref;
                        }

                    }
                    this.Text = acctno;

                    //string[] dbParams = { "REF", "NAME", "ACCTNO", "ZONE", "CURRENT", "DATE" };

                    AgentClass ncDBF = new AgentClass();
                    ncDBF.@ref = (refnum.Length > 7) ? refnum.Substring(0, 7) : refnum;
                    ncDBF.name = name;
                    ncDBF.acctno = acctno;
                    ncDBF.zone = zonebook;
                    ncDBF.current = amount;
                    ncDBF.date = transdate;
                    ncDBF.agent = agent;
                    saveToDBF(ncDBF);
                    counter++;
                }
                MessageBox.Show(string.Format("{0} records processed", counter));

            }
        }


        private void UpdateTransdate(string acctno, string refnum, DateTime transdate)
        {
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var qLedger = context.tbLedgers.Where(x => x.@ref.Equals(refnum)).Select(x => x);
                if (qLedger != null)
                {
                    foreach (var Ldata in qLedger)
                    {
                        Ldata.trans_date = transdate;
                    }
                    context.SaveChanges();
                }
            }

        }

        private void btnChangeTransdate_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var qMRSUploads = dbcontext.tbMRSUploads.Where(x => x.md_billmonth.Equals("05-2014"));
                string refnum = "";
                string dateReadStr = "";
                string acctno = "";
                int counter = 0;
                DateTime dateRead = new DateTime();
                DateTime dateNull = new DateTime(1900, 01, 01);
                foreach (var qData in qMRSUploads)
                {
                    acctno = qData.md_acctno;
                    refnum = qData.md_billno.ToString();
                    dateReadStr = qData.md_dateuploaded.ToString();
                    dateRead = DateTime.TryParse(dateReadStr.ToString(), out dateRead) ? dateRead : new DateTime(1900, 01, 01);
                    UpdateTransdate(acctno, refnum, dateRead);
                    this.Text = string.Format("[{0}] Updating acctno {1}", counter, acctno);
                    counter++;
                }
                MessageBox.Show("Processing done.");

            }
        }

        private void btnMasterUpdate_Click(object sender, EventArgs e)
        {
            string[] dbParams = { "STATUS", "ZONE", "CTGRY", "METNO", "CARDNO", "PRESRDG", "DATEPRES", "VOLUME", "DT_INSTL", "DISCO_DATE", "RECO_DATE" };
            DialogResult result = openFileDialog1.ShowDialog();

            counter = 0;
            string fileName = "";
            if (result == DialogResult.OK)
            {
                fileName = openFileDialog1.SafeFileName;
                tablename = fileName;
                dbfData = new DBRemix(Path.GetDirectoryName(openFileDialog1.FileName), false);
                //dbfData.DeleteDatabase(fileName);  // clear database
            }
            else
            {
                return;
            }


            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                //{"STATUS","ACCTNO","ZONE","CTGRY","METNO","CARDNO","PRESRDG","DATEPRES","VOLUME","DT_INSTL","DISCO_DATE","RECO_DATE" }
                var qMaster = (from em in dbcontext.tbMasters
                               join en in dbcontext.tbMasterAccts on em.master_id equals en.master_id
                               select new
                               {
                                   status = em.status,
                                   ctgry = em.category,
                                   cardno = em.cardno,
                                   datepres = em.last_read_date,
                                   volume = en.bill_volume,
                                   dt_instl = em.date_installed,
                                   disco_date = em.last_disco_date,
                                   reco_date = em.last_reco_date,
                                   zoneid = em.zone_id,
                                   meterid = em.meter_id,
                                   acctno = em.acctno,
                                   pres_rdg = en.rdg_pres
                               });

                DateTime nulldate = new DateTime(1900, 01, 01);
                foreach (var mData in qMaster)
                {
                    string status = mData.status;
                    string ctgry = mData.ctgry.ToString();
                    string cardno = mData.cardno.ToString();
                    DateTime datepres = DateTime.TryParse(mData.datepres.ToString(), out datepres) ? datepres : nulldate;
                    int volume = Convert.ToInt32(mData.volume);
                    DateTime dt_instl = DateTime.TryParse(mData.dt_instl.ToString(), out dt_instl) ? dt_instl : nulldate;
                    DateTime disco_date = DateTime.TryParse(mData.disco_date.ToString(), out disco_date) ? disco_date : nulldate;
                    string zone = global_func.getZoneName(mData.zoneid);
                    string meterno = global_func.getMeterNumber(mData.meterid);
                    string acctno = mData.acctno;
                    int pres_rdg = Convert.ToInt32(mData.pres_rdg);
                    DateTime reco_date = DateTime.TryParse(mData.reco_date.ToString(), out reco_date) ? reco_date : nulldate;


                    //{"STATUS","ACCTNO","ZONE","CTGRY","METNO","CARDNO","PRESRDG","DATEPRES","VOLUME","DT_INSTL","DISCO_DATE","RECO_DATE" }
                    string wherestr = string.Format("[ACCTNO] = '{0}'", acctno);

                    ArrayList dbValues = new ArrayList();
                    dbValues.Add(status);
                    dbValues.Add(zone);
                    dbValues.Add(ctgry);
                    dbValues.Add(meterno);
                    dbValues.Add(cardno);
                    dbValues.Add(pres_rdg);
                    dbValues.Add(datepres);
                    dbValues.Add(volume);
                    dbValues.Add(dt_instl);
                    dbValues.Add(disco_date);
                    dbValues.Add(reco_date);

                    dbfData.OLEDBUpdateToDatabase(fileName, wherestr, dbValues, dbParams);
                    this.Text = acctno;
                    //dbfData.OLEDBUpdateToDatabase();
                }
            }

        }

        private void btnUpdateDBFtoDBF_Click(object sender, EventArgs e)
        {
            string[] dbParams = { "STATUS", "ZONE", "CTGRY", "METNO", "CARDNO", "PRESRDG" };

            DialogResult result = openFileDialog1.ShowDialog();

            string pathfile = Path.GetDirectoryName(openFileDialog1.FileName);
            string fileName = openFileDialog1.SafeFileName;

            //string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};User Id=admin;Password=;", fileName);
            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", pathfile);

            if (result == DialogResult.OK)
            {

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = string.Format("Select [STATUS],[ACCTNO],[NAME],[ADDRESS],[ZONE],[CTGRY],[METNO],[CARDNO],[CURRENT],[PENALTY],[AR_CURR], " +
                        "[AR_PRI],[BALANCE],[PRESRDG],[DATEPRES],[VOLUME],[DT_INSTL],[DISCO_DATE],[RECO_DATE] from [{0}]", fileName);
                    using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet myDataset = new DataSet();
                        myAdapter.Fill(myDataset, fileName);
                        
                        var dTable = myDataset.Tables[0].AsEnumerable();
                        var dRows = dTable.Select(x => new
                        {
                            STATUS = x["STATUS"],
                            ZONE = x["ZONE"],
                            CTGRY = x["CTGRY"],
                            METNO = x["METNO"],
                            CARDNO = x["CARDNO"],
                            PRESRDG = x["PRESRDG"],
                            DATEPRES = x["DATEPRES"],
                            DT_INSTL = x["DT_INSTL"],
                            DISCO_DATE = x["DISCO_DATE"],
                            RECO_DATE = x["RECO_DATE"],
                            ACCTNO = x["ACCTNO"]
                        }
                            );


                        int rowcount = dRows.Count();
                        string oldtext = this.Text;
                        int counter = 0;
                        
                     result = openFileDialog1.ShowDialog();

                     string targetpathfile = Path.GetDirectoryName(openFileDialog1.FileName);
                     string targetfileName = openFileDialog1.SafeFileName;

                    

                     if (result == DialogResult.OK)
                     {
                         
                         tablename = targetfileName;
                         dbfData = new DBRemix(Path.GetDirectoryName(openFileDialog1.FileName), false);


                         DateTime nulldate = new DateTime(1900, 01, 01);
                         foreach (var dSource in dRows)
                         {
                             string acctno = dSource.ACCTNO.ToString();
                             string status = dSource.STATUS.ToString();
                             string ctgry = dSource.CTGRY.ToString();
                             string cardno = dSource.CARDNO.ToString();
                             DateTime datepres = DateTime.TryParse(dSource.DATEPRES.ToString(), out datepres) ? datepres : nulldate;
                             DateTime dt_instl = DateTime.TryParse(dSource.DT_INSTL.ToString(), out dt_instl) ? dt_instl : nulldate;
                             DateTime disco_date = DateTime.TryParse(dSource.DISCO_DATE.ToString(), out disco_date) ? disco_date : nulldate;
                             string zone = dSource.ZONE.ToString();
                             string meterno = dSource.METNO.ToString();
                             int pres_rdg = Convert.ToInt32(dSource.PRESRDG);
                             DateTime reco_date = DateTime.TryParse(dSource.RECO_DATE.ToString(), out reco_date) ? reco_date : nulldate;

                             string wherestr = string.Format("[ACCTNO] = '{0}'", acctno);
                             //{ "STATUS", "ZONE", "CTGRY", "METNO", "CARDNO", "PRESRDG", "DATEPRES", "DT_INSTL", "DISCO_DATE", "RECO_DATE" };
                             ArrayList dbValues = new ArrayList();
                             dbValues.Add(status);
                             dbValues.Add(zone);
                             dbValues.Add(ctgry);
                             dbValues.Add(meterno);
                             dbValues.Add(cardno);
                             dbValues.Add(pres_rdg);                            

                             dbfData.OLEDBUpdateToDatabase(tablename, wherestr, dbValues, dbParams);

                             if (datepres != nulldate)
                             {
                                 dbValues.Clear();
                                 dbValues.Add(datepres);
                                 dbfData.OLEDBUpdateToDatabase(tablename, wherestr, dbValues,"DATEPRES" );
                             }

                             if (dt_instl != nulldate)
                             {
                                 dbValues.Clear();
                                 dbValues.Add(dt_instl);
                                 dbfData.OLEDBUpdateToDatabase(tablename, wherestr, dbValues, "DT_INSTL");
                             }

                             if (disco_date != nulldate)
                             {
                                 dbValues.Clear();
                                 dbValues.Add(disco_date);
                                 dbfData.OLEDBUpdateToDatabase(tablename, wherestr, dbValues, "DISCO_DATE");
                             }

                             if (reco_date != nulldate)
                             {
                                 dbValues.Clear();
                                 dbValues.Add(reco_date);
                                 dbfData.OLEDBUpdateToDatabase(tablename, wherestr, dbValues, "RECO_DATE");
                             }

                             this.Text = acctno;
                         }
                         MessageBox.Show("Processing Done");
                     }
                    }
                }
            }

        }

        private int saveNewMaster(tbMaster mastData)
        {
            int retval = 0;
            using(dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                dbcontext.AddTotbMasters(mastData);
                dbcontext.SaveChanges();
                retval = mastData.master_id;
                tbMasterAcct newRec = new tbMasterAcct();
                newRec.master_id = mastData.master_id;
                dbcontext.AddTotbMasterAccts(newRec);
                dbcontext.SaveChanges();
            }
            return retval;
        }


        private void btnUpdateZoneCard_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            string pathfile = Path.GetDirectoryName(openFileDialog1.FileName);
            string fileName = openFileDialog1.SafeFileName;

            //string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};User Id=admin;Password=;", fileName);
            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", pathfile);
          
            if (result == DialogResult.OK)
            {

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = string.Format("Select [STATUS],[ACCTNO],[NAME],[ADDRESS],[ZONE],[CTGRY],[METNO],[CARDNO],[CURRENT],[PENALTY],[AR_CURR], " +
                        "[AR_PRI],[BALANCE],[PRESRDG],[DATEPRES],[VOLUME],[DT_INSTL],[DISCO_DATE],[RECO_DATE],[REMARK],[OTBAL],[OTBALINS] from [{0}]", fileName);
                    using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet myDataset = new DataSet();
                        myAdapter.Fill(myDataset, fileName);

                        var dTable = myDataset.Tables[0].AsEnumerable();
                        var dRows = dTable.Select(x => new
                        {
                            STATUS = x["STATUS"],
                            ZONE = x["ZONE"],
                            CTGRY = x["CTGRY"],
                            METNO = x["METNO"],
                            CARDNO = x["CARDNO"],
                            PRESRDG = x["PRESRDG"],
                            DATEPRES = x["DATEPRES"],
                            DT_INSTL = x["DT_INSTL"],
                            DISCO_DATE = x["DISCO_DATE"],
                            RECO_DATE = x["RECO_DATE"],
                            ACCTNO = x["ACCTNO"],
                            ADDRESS = x["ADDRESS"],
                            NAME = x["NAME"],
                            BALANCE = x["BALANCE"],
                            REMARK = x["REMARK"],
                            OTBAL = x["OTBAL"],
                            OTBALINS = x["OTBALINS"]
                        }
                        );
                        
                        DateTime nulldate = new DateTime(1900, 01, 01);
                        int counter = 0;
                        int salardaCounter = 0;
                        Boolean filtered = (textBox6.TextLength == 0) ? false : true;
                        int acctnoFilter = 0;
                        foreach (var rData in dRows)
                        {
                            string acctno = rData.ACCTNO.ToString();
                            string status = rData.STATUS.ToString();
                            if (filtered)
                            {
                                this.Text = "Accno." + acctno;
                                int acnoINT = Int32.TryParse(acctno, out acnoINT) ? acnoINT : 0;
                                acctnoFilter = Convert.ToInt32(textBox6.Text);
                                if ((acnoINT >= acctnoFilter) && (acnoINT < 81763))
                                {
                                }
                                else { continue; }
                            }
                            int ctgry = Int32.TryParse(rData.CTGRY.ToString(),out ctgry)?ctgry:0;
                            int cardno = Int32.TryParse(rData.CARDNO.ToString(),out cardno)?cardno:0;
                            DateTime datepres = DateTime.TryParse(rData.DATEPRES.ToString(), out datepres) ? datepres : nulldate;
                            DateTime dt_instl = DateTime.TryParse(rData.DT_INSTL.ToString(), out dt_instl) ? dt_instl : nulldate;
                            DateTime disco_date = DateTime.TryParse(rData.DISCO_DATE.ToString(), out disco_date) ? disco_date : nulldate;
                            int zone = getZoneID(rData.ZONE.ToString());
                            string meterno = rData.METNO.ToString();
                            int pres_rdg = Convert.ToInt32(rData.PRESRDG);
                            DateTime reco_date = DateTime.TryParse(rData.RECO_DATE.ToString(), out reco_date) ? reco_date : nulldate;
                            string name = rData.NAME.ToString().TrimEnd();
                            decimal balance = !Convert.IsDBNull(rData.BALANCE)?Convert.ToDecimal(rData.BALANCE):0;
                            int masterid = 0;
                            int meterid = 0;
                            string remarks = rData.REMARK.ToString();
                            decimal otbal = Decimal.TryParse(rData.OTBAL.ToString(),out otbal)?otbal:0;
                            decimal otbalins = Decimal.TryParse(rData.OTBALINS.ToString(),out otbalins)?otbalins:0;
                            string address = rData.ADDRESS.ToString().TrimEnd();

                            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                            {
                                tbMaster masterData = dbcontext.tbMasters.FirstOrDefault(x => x.acctno.Equals(acctno));

                                if (masterData == null) 
                                {
                                    

                                    tbMaster newRecord = new tbMaster();
                                    newRecord.name = name;
                                    newRecord.acctno = acctno.TrimEnd();
                                    newRecord.address = address;
                                    newRecord.status = status.ToUpper();
                                    newRecord.category = ctgry;
                                    newRecord.zone_id = zone;
                                    newRecord.cardno = cardno;
                                    newRecord.remarks = remarks;
                                    if (datepres != nulldate) newRecord.last_read_date = datepres;
                                    if (dt_instl != nulldate) newRecord.date_installed = dt_instl;
                                    if (disco_date != nulldate) newRecord.last_disco_date = disco_date;
                                    if (reco_date != nulldate) newRecord.last_reco_date = reco_date;
                                    newRecord.zone_id = zone;
                                    masterid = saveNewMaster(newRecord);
                                    meterid = global_func.saveNewMeterNo(masterid, meterno);
                                    tbMaster updateRec = dbcontext.tbMasters.First(x =>x.master_id==masterid);
                                    updateRec.meter_id = meterid;

                                    tbMasterAcct updateAccts = dbcontext.tbMasterAccts.First(x => x.master_id == masterid);
                                    updateAccts.rdg_pres = pres_rdg;
                                    if (otbal > 0)
                                    {
                                        updateAccts.isIF = true;
                                        updateAccts.IFAmount = 2500;
                                        updateAccts.IFBalance = otbal;
                                        updateAccts.IFMonthlyPay = otbalins;
                                    }

                                 //   if (balance > 0){
                                        updateAccts.bill_balance = balance;

                                        tbLedger ledger = new tbLedger();
                                        ledger.amount = balance;
                                        ledger.balance = balance;
                                        ledger.code = "FBAL";
                                        ledger.encoder = "GPC";
                                        ledger.trans_date = DateTime.Today;
                                        ledger.remarks = "forwarded balance";
                                        ledger.master_id = masterid;
                                        using (dbCommercialEntities mContext = new dbCommercialEntities())
                                        {
                                            mContext.AddTotbLedgers(ledger);
                                            mContext.SaveChanges();
                                        }

                                    //  }  //if (balance > 0){
                                    
                                }
                                else
                                {
                                  //uncomment to enable add only new accounts..
                                    if (checkBox1.Checked)continue;
                                    if (salardaCounter == 1)
                                    {
                                        salardaCounter = 0;
                                        continue;
                                    }
                                    masterData.remarks = remarks;
                                    if (masterData.acctno.Equals("019356"))
                                    {
                                        meterno = "A-0815996";
                                        salardaCounter = 1;
                                    }  

                                  
                                    masterid = global_func.getMasterID(acctno);
                                    masterData.zone_id = zone;
                                    masterData.name = name;
                                    masterData.address = address;
                                    if (masterData.acctno.Equals("019356"))
                                    {
                                        meterno = "A-0815996";
                                        salardaCounter=1;
                                    }                                                                       
                                    masterData.meter_id = global_func.updateMeterNo(masterData.master_id, meterno);
                                    //masterData.status = status.ToUpper();
                                    masterData.category = ctgry;
                                    
                                    masterData.cardno = cardno;
                                    /**
                                    if (datepres != nulldate)
                                    {
                                        if (datepres > masterData.last_read_date) masterData.last_read_date = datepres;
                                    }*/
                                     
                                    if (dt_instl != nulldate)
                                    {
                                        //if (dt_instl > masterData.date_installed)
                                       // {
                                            masterData.date_installed = dt_instl;
                                        //}
                                    }

                                    if (disco_date != nulldate)
                                    {
                                        if (disco_date > masterData.last_disco_date)
                                        {
                                            masterData.last_disco_date = disco_date;
                                        }
                                    }
                                    if (reco_date != nulldate)
                                    {
                                        if (reco_date > masterData.last_reco_date)
                                        {
                                            masterData.last_reco_date = reco_date;
                                        }
                                    }
                                    /**
                                    tbMasterAcct mastAcct = dbcontext.tbMasterAccts.First(x => x.master_id == masterData.master_id);
                                    //if (pres_rdg > mastAcct.rdg_pres) mastAcct.rdg_pres = pres_rdg;
                                    mastAcct.rdg_pres = pres_rdg;
                                    mastAcct.bill_balance = balance;
                                    mastAcct.bill_arrears = 0;
                                    mastAcct.bill_arrears_months = 0;
                                    mastAcct.arrears_curr_yr = 0;
                                    mastAcct.arrears_prev_yrs = 0;
                                    mastAcct.bill_current = 0;
                                    mastAcct.bill_volume = 0;
                                    mastAcct.IFAmount = 0;
                                    mastAcct.IFArrears = 0;
                                    mastAcct.IFBalance = 0;
                                    mastAcct.IFCurrentPayMonth = 0;
                                    mastAcct.IFDownpayment = 0;
                                    mastAcct.IFMonthlyPay = 0;
                                    mastAcct.IFPayableMonths = 0;

                                    mastAcct.MtrDmg_Amount = 0;
                                    mastAcct.MtrDmg_Arrears = 0;
                                    mastAcct.MtrDmg_Balance = 0;
                                    mastAcct.MtrDmg_Downpayment = 0;
                                    mastAcct.MtrDmg_MonthsPayable = 0;
                                    mastAcct.MtrDmg_Monthly = 0;
                                    mastAcct.penalty = 0;

                                    if (balance > 0)
                                    {
                                        
                                        tbLedger ledger = new tbLedger();
                                        ledger.amount = balance;
                                        ledger.balance = balance;
                                        ledger.code = "FBAL";
                                        ledger.encoder = "GPC";
                                        ledger.trans_date = DateTime.Today;
                                        ledger.remarks = "forwarded balance";
                                        ledger.master_id = masterid;
                                        using (dbCommercialEntities lContext = new dbCommercialEntities())
                                        {
                                            lContext.AddTotbLedgers(ledger);
                                            lContext.SaveChanges();
                                        }
                                    }
                                     */
                                  
                                } 

                                dbcontext.SaveChanges();
                                this.Text = string.Format("[{0}] - {1}", counter, acctno);
                                counter++;
                            }
                            
                        }
                        MessageBox.Show("Update finished");
                    }
                }
            }
        }

        private void btnFillDataBillfile_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            string fileName = "";
            string tablename = "";
            string filePath = "";

            if (result == DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] Files = dir.GetFiles("*.dbf");

                
                filePath = folderBrowserDialog1.SelectedPath;
                string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", filePath);
                foreach (FileInfo file in Files)
                {

                    fileName = file.Name;
                    string test = file.DirectoryName;

                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        conn.Open();
                        string query = string.Format("Select [ACCTNO] from [{0}]", fileName);
                        using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                        {
                            DataSet myDataset = new DataSet();
                            myAdapter.Fill(myDataset, fileName);

                            var dTable = myDataset.Tables[0].AsEnumerable();
                            var dRows = dTable.Select(x => new { ACCTNO = x["ACCTNO"] });

                            foreach (var row in dRows)
                            {
                                string acctno = row.ACCTNO.ToString();
                                string cardno = "";
                                string name = "";
                                string refnum = "";
                                int masterID = 0;
                                string address = "";
                                string metno = "";
                                string zonebook = "";
                                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                                {
                                    tbMaster mast = dbcontext.tbMasters.FirstOrDefault(x => x.acctno.Equals(acctno));
                                    if (mast != null)
                                    {
                                     
                                       // cardno = mast.cardno.ToString().Trim();
                                        name = mast.name.ToString().Trim();                                        
                                        masterID = mast.master_id;
                                        address = mast.address.ToString().Substring(0,30);
                                       // metno = global_func.getMeterNumber(acctno).Trim();
                                         
                                       // masterID = mast.master_id;
                                       // zonebook = global_func.getZoneName(global_func.getZoneID(masterID));

                                        /**
                                        tbBillingDetail billDetail = dbcontext.tbBillingDetails.FirstOrDefault(x => x.master_id == masterID && x.mrs_ref.Equals("05-2014"));
                                        if (billDetail != null)
                                        {
                                            refnum = billDetail.bill_ref_num.ToString();
                                        }*/
                                    }
                                }
                                //string[] dbParams = { "CARDNO", "NAME","ADDRESS","METNO" };
                                string[] dbParams = {"NAME","ADDRESS"};



                                string fpath = string.Format("{0}\\processed\\",file.DirectoryName);
                                tablename = fileName;
                                if (refnum.Length <= 0)
                                {
                                    refnum = "";
                                }
                                else
                                {
                                    refnum = refnum.Substring(0, 7);
                                }
                                dbfData = new DBRemix(fpath, false);

                                string wherestr = string.Format("[ACCTNO] = '{0}'", acctno);
                                ArrayList dbValues = new ArrayList();

                                dbValues.Add(name);
                                dbValues.Add(address);
                              /**
                                dbValues.Add(cardno);
                                dbValues.Add(metno);
                                dbValues.Add(zonebook);
                                */
                                dbfData.OLEDBUpdateToDatabase(tablename, wherestr, dbValues, dbParams);
                                this.Text = string.Format("[{0}]-[{1}]", fileName, acctno);
                            }

                            //tablename = fileName;
                            //dbfData = new DBRemix(Path.GetDirectoryName(openFileDialog1.FileName), false);

                        }
                    }
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var qMay = dbcontext.tbMRSUploads.Where(x => x.md_billmonth.Equals("05-2014") && x.md_zone.Equals("1107"));

                foreach (tbMRSUpload qRow in qMay)
                {
                    DateTime dPres = new DateTime();
                    int masterid = 0;

                    dPres = Convert.ToDateTime(qRow.md_dateuploaded);
                    masterid = global_func.getMasterID(qRow.md_acctno.ToString());

                    tbMaster qMaster = dbcontext.tbMasters.FirstOrDefault(x => x.master_id == masterid);
                    if (qMaster != null)
                    {
                        qMaster.last_read_date = dPres;
                    }
                    
                    this.Text = qRow.md_acctno.ToString();
                }
                dbcontext.SaveChanges();
                MessageBox.Show("DOne");
            }
        }

        private void btnRepairIF_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            string pathfile = Path.GetDirectoryName(openFileDialog1.FileName);
            string fileName = openFileDialog1.SafeFileName;

            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", pathfile);
            if (result == DialogResult.OK)
            {

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = string.Format("Select [YRMON],[NAME],[CURRENT],[ACCTNO],[DATE],[REF],[INSTFEE],[COLLECTED],[SVFEE],[SDRCODE],[SDRAMT],[ENCODER],[TFFEE],[PENALTY],[AR_CURR],[AR_PRI],[ROYALTY] from [{0}]", fileName);
                    using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet myDataset = new DataSet();
                        myAdapter.Fill(myDataset, fileName);

                        var dTable = myDataset.Tables[0].AsEnumerable();
                        var dRows = dTable.Select(x => new
                        {
                            svfee = x["SVFEE"],
                            acctno = x["ACCTNO"],
                            refnum = x["REF"],
                            transdate = x["DATE"],
                            encoder = x["ENCODER"],
                            name = x["NAME"],
                            amount = x["COLLECTED"],
                            yrmon = x["YRMON"],
                            sdrcode = x["SDRCODE"],
                            sdramt = x["SDRAMT"]

                        }).Where(x => x.refnum.ToString().Length > 0 && !x.acctno.Equals("B") && x.yrmon.ToString().Length > 0);

                        var svQuery = dRows.Where(x => x.sdrcode.Equals("IF2")).Select(x => x);

                        int svCount = svQuery.Count();
                        int rowcount = dRows.Count();
                        string oldtext = this.Text;
                        int counter = 0;
                        using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                        {
                            foreach (var drow in svQuery)
                            {
                                tbLedger ledgerData;
                                string acctno = drow.acctno.ToString();
                                decimal if2 = decimal.TryParse(drow.sdramt.ToString(), out if2) ? if2 : 0;
                                decimal collected = decimal.TryParse(drow.amount.ToString(), out collected) ? collected : 0;
                                DateTime transdate = DateTime.TryParse(drow.transdate.ToString(), out transdate) ? transdate : new DateTime(1900, 01, 01);

                                if (if2 == collected) continue;

                                int masterID = global_func.getMasterID(acctno);
                                string remarks = transdate.ToShortDateString();

                                tbMasterAcct mastAcct = dbcontext.tbMasterAccts.FirstOrDefault(x => x.master_id == masterID);
                               // tbLedger rData = dbcontext.tbLedgers.


                                ledgerData = new tbLedger();
                                ledgerData.code = "RPR2";
                                ledgerData.@ref = drow.refnum.ToString();
                                //ledgerData.trans_date = Convert.ToDateTime(drow.transdate.ToShortDateString());
                                ledgerData.trans_date = DateTime.Today;
                                ledgerData.symbol = "-";
                                ledgerData.encoder = "GPC";
                                ledgerData.master_id = masterID;
                                ledgerData.amount = 150;
                                ledgerData.remarks = string.Format("IF2-{0}", remarks);
                                ledgerData.balance = mastAcct.bill_balance - 150;
                                ledgerData.zoneuid = global_func.getZoneUIDbyMaster(masterID);
                                dbcontext.AddTotbLedgers(ledgerData);
                                mastAcct.bill_balance = ledgerData.balance;

                                // tbLedger billLedger = dbcontext.tbLedgers.First(x => x.master_id == masterID && x.code.Equals("RPR1"));
                                //billLedger.balance = billLedger.balance + svfee;                                
                                //billLedger.symbol = "+";


                                this.Text = drow.acctno.ToString();
                                dbcontext.SaveChanges();

                            } // foreach end
                            this.Text = oldtext;
                            MessageBox.Show("IF2 repair is done");
                            listBox2.Items.Add(fileName);

                        } //using end

                    }
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            tbLedger ledgerData;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var qBillDetails = dbcontext.tbBillingDetails.Where(x => x.mrs_ref.Equals("05-2014")) ;
                
                if (qBillDetails != null)
                {
                    foreach (tbBillingDetail rowDetail in qBillDetails)
                    {
                        string refnum = rowDetail.bill_ref_num.TrimEnd();
                        
                        int masterID = rowDetail.master_id;

                        var searchRPR3 = dbcontext.tbLedgers.FirstOrDefault(x => x.code.Equals("RPR3") && x.master_id == masterID);
                        if (searchRPR3 != null) continue;
                        
                        var searchLedger = dbcontext.tbLedgers.Where(x => x.@ref.Equals(refnum) && x.master_id==masterID);
                        if (searchLedger != null)
                        {
                            int cmtp = searchLedger.Count();
                            if (searchLedger.Count() > 1)
                            {
                                decimal amtToDeduct = 0;
                                var countbill = searchLedger.Where(x => x.code.Equals("BILL    "));
                                int xxx = countbill.Count();
                                if (countbill.Count() > 1)
                                {
                                    foreach (tbLedger ledgerRow in searchLedger)
                                    {
                                        decimal amount = Convert.ToDecimal(ledgerRow.amount);
                                        amtToDeduct = amtToDeduct + amount;
                                        break;
                                    }
                                }

                                var countIF = searchLedger.Where(x => x.code.Equals("IF      "));
                                int xyx = countIF.Count();
                                if (countIF.Count() > 1)
                                {
                                    foreach (tbLedger ifRow in countIF)
                                    {
                                        decimal amountIF = Convert.ToDecimal(ifRow.other);
                                        amtToDeduct = amtToDeduct + amountIF;
                                        break;
                                    }
                                }

                                var countSR = searchLedger.Where(x => x.code.Equals("SNR     "));
                                if (countSR.Count() > 1)
                                {
                                    foreach (tbLedger srRow in countSR)
                                    {
                                        decimal amountSR = Convert.ToDecimal(srRow.amount);
                                        amtToDeduct = amtToDeduct - amountSR;
                                        break;
                                    }
                                }

                                if (amtToDeduct > 0)
                                {
                                    using (dbCommercialEntities context = new dbCommercialEntities())
                                    {
                                        tbMasterAcct mastAcct = context.tbMasterAccts.First(x => x.master_id == masterID);

                                        ledgerData = new tbLedger();
                                        ledgerData.code = "RPR3";
                                        ledgerData.@ref = refnum;
                                        //ledgerData.trans_date = Convert.ToDateTime(drow.transdate.ToShortDateString());
                                        ledgerData.trans_date = DateTime.Today;
                                        ledgerData.symbol = "-";
                                        ledgerData.encoder = "GPC";
                                        ledgerData.master_id = masterID;
                                        ledgerData.amount = amtToDeduct;
                                        ledgerData.remarks = string.Format("Double-{0}", refnum);
                                        ledgerData.balance = mastAcct.bill_balance - amtToDeduct;
                                        context.AddTotbLedgers(ledgerData);
                                        mastAcct.bill_balance = ledgerData.balance;
                                        context.SaveChanges();
                                    }
                                    
                                }

                            }
                        }
                        this.Text = refnum;
                    }
                    dbcontext.SaveChanges();
                    MessageBox.Show("repair done");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var vLedger = dbcontext.tbLedgers.Where(x => x.billing_id == null && x.code.Equals("IF      "));

             
                foreach (tbLedger lData in vLedger)
                {
                    string refnum = lData.@ref.ToString().TrimEnd();
                    int masterid = lData.master_id;
                    decimal amount = Convert.ToDecimal(lData.amount);

                    this.Text = refnum;
                    if (refnum.Length > 7) continue;

                    string acctno = global_func.getAcctNo(masterid);
                    global_func.saveLogFile(@"D:\repair\0517.txt", string.Format("{0} - {1} - {2}", acctno, refnum, amount));

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var lData = dbcontext.tbLedgers.Where(x => !x.code.Equals("BILL    ") && !x.code.Equals("SNR     ")).Select(x=>x);

                string code = "";
                int masterid = 0;
                string refnum = "";
                decimal amount = 0;
                decimal deduct_to_bill_balance = 0;
                decimal others = 0;
                int zoneID = 0;
                int zoneUID = 0;
                string zonebook = "";

                foreach (tbLedger data in lData)
                {
                     code = data.code.TrimEnd();
                     masterid = data.master_id;
                     refnum = data.@ref.TrimEnd();
                     amount = Convert.ToDecimal(data.amount);
                     deduct_to_bill_balance = 0;
                     others = Convert.ToDecimal(data.other);
                     zoneID = global_func.getZoneID(masterid);
                     zoneUID = global_func.getZoneUID(zoneID);
                     zonebook = global_func.getZoneName(zoneID);

                   
                     if (zoneUID == 12)
                     {
                         if (zonebook.Equals("1202")) continue;
                         tbLedger sRPR4 = dbcontext.tbLedgers.FirstOrDefault(x => x.code.Equals("RPR4") && x.master_id == masterid && x.@ref.Equals(refnum));
                         if (sRPR4 != null) continue;

                         if (code.Equals("IF"))
                         {
                             if (data.amount > 0)
                             {
                                 deduct_to_bill_balance = Convert.ToDecimal(data.amount);
                                 data.other = data.amount;
                                 data.amount = 0;
                             }
                             else
                             {
                                 deduct_to_bill_balance = Convert.ToDecimal(data.other);
                             }

                             /**
                             var gL = dbcontext.tbLedgers.Where(x => x.@ref.Equals(refnum) && x.code.Equals("BILL    ") && x.master_id==masterid);
                             if (gL != null)
                             {
                                 if (gL.Count() > 1)
                                 {
                                     global_func.saveLogFile(@"D:\repair\acctsDoubleLedger.txt", string.Format("{0} - {1}", global_func.getAcctNo(masterid), refnum));
                                 }

                             }*/



                             this.Text = refnum;
                             editLedger(masterid, deduct_to_bill_balance, refnum);
                         }
                     }                
                }

                dbcontext.SaveChanges();
                
                MessageBox.Show("Done");
            }

        }

        private void editLedger(int masterid,decimal deduct_amount,string refnum)
        {
            //RPR4
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMasterAcct mastacc = dbcontext.tbMasterAccts.FirstOrDefault(x => x.master_id == masterid);

                if (mastacc != null)
                {
                    decimal bill_balance = Convert.ToDecimal(mastacc.bill_balance);
                    decimal newbalance = bill_balance - deduct_amount;
                    if (newbalance < 0)
                    {
                        mastacc.bill_balance = 0;
                        newbalance = 0;
                    }
                    else
                    {
                        mastacc.bill_balance = newbalance;
                    }

                    if (deduct_amount > bill_balance)
                    {
                        deduct_amount = deduct_amount - bill_balance;
                    }
                    tbLedger ledg = new tbLedger();
                    ledg.code = "RPR4";
                    ledg.@ref = refnum;
                    //ledg.trans_date = Convert.ToDateTime(drow.transdate.ToShortDateString());
                    ledg.trans_date = DateTime.Today;
                    ledg.symbol = "-";
                    ledg.encoder = "GPC";
                    ledg.master_id = masterid;
                    ledg.amount = deduct_amount;
                    ledg.remarks = string.Format("IFrpr{0}", refnum);
                    ledg.balance = newbalance;
                    dbcontext.AddTotbLedgers(ledg);
                }
                dbcontext.SaveChanges();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
        

            DialogResult result = openFileDialog1.ShowDialog();

            string pathfile = Path.GetDirectoryName(openFileDialog1.FileName);
            string fileName = openFileDialog1.SafeFileName;

            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", pathfile);
            if (result == DialogResult.OK)
            {

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = string.Format("Select [ACCTNO],[DATE],[AMOUNT] from [{0}]", fileName);
                    using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet myDataset = new DataSet();
                        myAdapter.Fill(myDataset, fileName);

                        var dTable = myDataset.Tables[0].AsEnumerable();
                        var dRows = dTable.Select(x => x);


                        int rowcount = dRows.Count();
                        string oldtext = this.Text;
                        int counter = 0;
                        DateTime nullDate = new DateTime(1900,1,1);
                        using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                        {
                            tbBilling tbBill = dbcontext.tbBillings.FirstOrDefault(x=>x.billing_desc.Equals(textBox5.Text));
                            if (tbBill == null)
                            {
                                MessageBox.Show("BillMonth not found.");
                                return;
                            }
                            else
                            {
                                billingID = tbBill.billing_id;
                            }
                            foreach (var drow in dRows)
                            {
                                tbLedger ledgerData;
                                string acctno = drow["ACCTNO"].ToString().TrimEnd();
                                decimal AMOUNT = decimal.TryParse(drow["AMOUNT"].ToString(), out AMOUNT) ? AMOUNT : 0;
                                DateTime transdate = DateTime.TryParse(drow["DATE"].ToString(),out transdate)?transdate:new DateTime(1900,1,1);

                                if (acctno.Length !=6) continue;
                                int masterID = global_func.getMasterID(acctno);


                                 tbMasterAcct mastAcct = dbcontext.tbMasterAccts.FirstOrDefault(x => x.master_id == masterID);

                                ledgerData = new tbLedger();
                                ledgerData.code = "PNLT";
                                //ledgerData.@ref = drow["REF"].ToString();
                                ledgerData.trans_date = transdate;
                                ledgerData.symbol = "+";
                                ledgerData.encoder = "GPC";
                                ledgerData.master_id = masterID;
                                ledgerData.amount = AMOUNT;
                                ledgerData.balance = mastAcct.bill_balance + AMOUNT;
                                ledgerData.remarks = fileName;
                                ledgerData.billing_id = billingID;
                                dbcontext.AddTotbLedgers(ledgerData);
                                mastAcct.bill_balance=ledgerData.balance;

                                this.Text = acctno;
                            }
                            dbcontext.SaveChanges();
                            listBox4.Items.Add(fileName);
                            MessageBox.Show("Import Done");
                        }
                    }
                }
            }
        }//private void button9_Click(object sender, EventArgs e)

        private void button10_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                //var qUploads = dbcontext.tbMRSUploads.Select(x => x).Where(x=>x.md_billno.Contains("C4AE050155"));
                var qUploads = dbcontext.tbMRSUploads.Select(x => x).Where(x=>x.md_masterID.HasValue);
                foreach (tbMRSUpload upData in qUploads)
                {
                    string refnum = "";
                    refnum = !string.IsNullOrEmpty(upData.md_billno)?upData.md_billno.TrimEnd():"";
                    int masterID = global_func.getMasterID(upData.md_acctno);
                    string acctno = upData.md_acctno.TrimEnd();
                    decimal amt = Convert.ToDecimal(upData.md_billamount);
                    int uploadID = upData.mrsUP_ID;
                    int procID = Int32.TryParse(upData.md_masterID.ToString(),out procID)?procID:0;

                    tbBillingDetail bDetails = getBillDetails(refnum);
                    if (bDetails == null)  continue;
                    int bMasterID = bDetails.master_id;
                    if (bMasterID != masterID)
                    {
                        global_func.saveLogFile(@"D:\repair\checkreadings.txt",string.Format("[{2}] upload-{0}------billdetails-{1}",masterID,bMasterID,refnum));
                     //   bDetails.master_id = masterID;
                    }

                    /**
                    var qLedger = dbcontext.tbLedgers.Where(x => x.@ref.Equals(refnum));
                    foreach (tbLedger ledge in qLedger)
                    {
                        ledge.master_id = masterID;
                    }
                     * */
                    this.Text = acctno;
                }
                //dbcontext.SaveChanges();
                MessageBox.Show("processing done");

            }
        } //private void button10_Click(object sender, EventArgs e)
        
        private tbBillingDetail getBillDetails(string refnum)
        {
            tbBillingDetail retval = new tbBillingDetail();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var qBillDetails = dbcontext.tbBillingDetails.Where(x => x.bill_ref_num.Equals(refnum));
                if (qBillDetails != null)
                {                    
                    foreach (tbBillingDetail bDetail in qBillDetails)
                    {
                        retval = bDetail;
                        if (qBillDetails.Count() == 1)
                        {
                            break;
                        }
                        global_func.saveLogFile(@"D:\repair\2inBillDetails.txt", string.Format("{0}-{1}", bDetail.master_id, refnum));
                    }
                    
                }
                return retval;
             }
          
        }//private tbBillingDetail getBillDetails(string refnum)

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            string fileName = "";
            string tablename = "";
            string filePath = "";

            if (result == DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] Files = dir.GetFiles("*.dbf");


                filePath = folderBrowserDialog1.SelectedPath;
                string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", filePath);
                foreach (FileInfo file in Files)
                {

                    fileName = file.Name;
                    string test = file.DirectoryName;

                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        conn.Open();
                        string query = string.Format("Select [AVE],[CTR],[ACCTNO],[ZONE],[LEDGRP],[NAME],[ADDRESS],[METNO],[CTGRY],[CARDNO],[CURRENT],[DAYS30],[DAYS60],[DAYS90],[MON_ARR],[ARREARS],[PENALTY],[DATEPRES],[DATEPREV],[PRESRDG],[PREVRDG],[VOLUME],[METDEP],[OTHERS],[REMARK],[REF],[DUEDATE],[ENCODER],[DATE],[REMARK1] from [{0}]", fileName);
                        using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                        {
                            DataSet myDataset = new DataSet();
                            myAdapter.Fill(myDataset, fileName);

                            var dTable = myDataset.Tables[0].AsEnumerable();
                           // var forSearch = dTable.Select(x => new { ACCTNO = x.Field<string>("ACCTNO") });
                            var dRows = dTable.Select(x => new
                            {
                                AVE=x["AVE"],CTR=x["CTR"],ACCTNO=x.Field<string>("ACCTNO"),
                                ZONE=x["ZONE"],LEDGRP=x["LEDGRP"],NAME=x["NAME"],ADDRESS=x["ADDRESS"],
                                METNO=x["METNO"],CTGRY=x["CTGRY"],CARDNO=x["CARDNO"],CURRENT=x["CURRENT"],
                                DAYS30=x["DAYS30"],DAYS60=x["DAYS60"],DAYS90=x["DAYS90"],MON_ARR=x["MON_ARR"],ARREARS=x["ARREARS"],
                                PENALTY=x["PENALTY"],DATEPRES=x["DATEPRES"],DATEPREV=x["DATEPREV"],
                                PRESRDG=x["PRESRDG"],PREVRDG=x["PREVRDG"],VOLUME=x["VOLUME"],
                                METDEP=x["METDEP"],OTHERS=x["OTHERS"],REMARK=x["REMARK"],
                                REF=x["REF"],DUEDATE=x["DUEDATE"],ENCODER=x["ENCODER"],
                                DATE=x["DATE"],REMARK1=x["REMARK1"]
                            });

                            List<string> doubleAccts = new List<string>();
                            foreach (var row in dRows)
                            {
                                string acctno = row.ACCTNO.ToString();                          
                                string refnum = "";
                                string zone = row.ZONE.ToString();

                
                                int isDouble = dRows.Count(x => x.ACCTNO.Equals(acctno));
                                
                                this.Text = string.Format("[Zone-{0}] - {1}", zone, acctno);
                                if (isDouble == 1) continue;
                                bool isFound = doubleAccts.Contains(acctno);
                                if (isFound) continue;

                              


                                string fpath = string.Format("{0}\\processed\\", file.DirectoryName);
                                tablename = fileName;
                                if (refnum.Length <= 0)
                                {
                                    refnum = "";
                                }
                                else
                                {
                                    refnum = refnum.Substring(0, 7);
                                }

//"AVE","CTR","ACCTNO","ZONE","LEDGRP","NAME","ADDRESS","METNO","CTGRY","CARDNO","CURRENT","DAYS30",
//"DAYS60","DAYS90","MON_ARR","ARREARS","PENALTY","DATEPRES","DATEPREV","PRESRDG","PREVRDG","VOLUME",
//"METDEP","OTHERS","REMARK","REF","DUEDATE","ENCODER","DATE","REMARK1"
                              
                                string[] dbParams = {"AVE","CTR","ACCTNO","ZONE","LEDGRP","NAME","ADDRESS","METNO","CTGRY","CARDNO","CURRENT","DAYS30","DAYS60","DAYS90","MON_ARR","ARREARS","PENALTY","DATEPRES","DATEPREV","PRESRDG","PREVRDG","VOLUME","METDEP","OTHERS","REMARK","REF","DUEDATE","ENCODER","DATE","REMARK1"};
                                dbfData = new DBRemix(fpath, false);
                              //  dbfData.DeleteDatabase(tablename);  // clear database

                                ArrayList dbValues = new ArrayList();
                                dbValues.Add(row.AVE);
                                dbValues.Add(row.CTR);
                                dbValues.Add(row.ACCTNO);
                                dbValues.Add(row.ZONE);
                                dbValues.Add(row.LEDGRP);
                                dbValues.Add(row.NAME);
                                dbValues.Add(row.ADDRESS);
                                dbValues.Add(row.METNO);
                                dbValues.Add(row.CTGRY);
                                dbValues.Add(row.CARDNO);
                                dbValues.Add(row.CURRENT);
                                dbValues.Add(row.DAYS30);
                                dbValues.Add(row.DAYS60);
                                dbValues.Add(row.DAYS90);
                                dbValues.Add(row.MON_ARR);
                                dbValues.Add(row.ARREARS);
                                dbValues.Add(row.PENALTY);
                                dbValues.Add(row.DATEPRES);
                                dbValues.Add(row.DATEPREV);
                                dbValues.Add(row.PRESRDG);
                                dbValues.Add(row.PREVRDG);
                                dbValues.Add(row.VOLUME);
                                dbValues.Add(row.METDEP);
                                dbValues.Add(row.OTHERS);
                                dbValues.Add(row.REMARK);
                                dbValues.Add(row.REF);
                                dbValues.Add(row.DUEDATE);
                                dbValues.Add(row.ENCODER);
                                dbValues.Add(row.DATE);
                                dbValues.Add(row.REMARK1);

                                dbfData.SaveToOLEDatabase(tablename, dbValues, dbParams);
                                doubleAccts.Add(acctno);
                            }

                            //tablename = fileName;
                            //dbfData = new DBRemix(Path.GetDirectoryName(openFileDialog1.FileName), false);
                            MessageBox.Show("Double processing done.");
                        }
                    }
                }

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            string fileName = "";
            string tablename = "";
            string filePath = "";

            if (result == DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] Files = dir.GetFiles("*.dbf");


                filePath = folderBrowserDialog1.SelectedPath;
                string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", filePath);
                foreach (FileInfo file in Files)
                {

                    fileName = file.Name;

                    string appPath = Application.StartupPath;
                    string sourceFile = string.Format(@"{0}\templates\DPAY0000.DBF", appPath);
                    string newFile = string.Format(@"{0}\processed\DPAYJUN.DBF", filePath);
                    string save_filename = "DPAYJUN.DBF";
                    if (!File.Exists(newFile))
                    {
                        File.Copy(sourceFile, newFile);                    
                    }
                    

                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        conn.Open();
                        string query = string.Format("Select [YRMON],[ZONE],[ACCTNO],[NAME],[DATE],[REF],[COLLECTED],[CURRENT],[PENALTY],[AR_CURR],[AR_PRI],[SDRCODE],[SDRAMT],[ENCODER],[TIME_PD] from [{0}]", fileName);
                        using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                        {
                            DataSet myDataset = new DataSet();
                            myAdapter.Fill(myDataset, fileName);
                            var dTable = myDataset.Tables[0].AsEnumerable();
                            var dRows = dTable.Select(x => new { 
                                YRMON = x["YRMON"],
                                ZONE = x["ZONE"],
                                ACCTNO = x["ACCTNO"],
                                NAME = x["NAME"],
                                DATE = x["DATE"],
                                REF = x["REF"],
                                COLLECTED = x["COLLECTED"],
                                CURRENT = x["CURRENT"],
                                PENALTY = x["PENALTY"],
                                AR_CURR = x["AR_CURR"],
                                AR_PRI = x["AR_PRI"],
                                SDRCODE = x["SDRCODE"],
                                SDRAMT = x["SDRAMT"],
                                ENCODER=x["ENCODER"],
                                TIME_PD = x["TIME_PD"]
                            });

                            var dIF2 = dRows.Where(x => x.SDRCODE.Equals("IF2"));
                            int if2 = dIF2.Count();
                            foreach (var row in dIF2)
                            {
                                string acctno = row.ACCTNO.ToString();
                                string yrmon = row.YRMON.ToString();
                                string name = row.NAME.ToString();
                                string refnum = row.REF.ToString();
                                decimal collected = decimal.TryParse(row.COLLECTED.ToString(), out collected) ? collected : 0;
                                decimal current = decimal.TryParse(row.CURRENT.ToString(), out current) ? current : 0;
                                decimal penalty = decimal.TryParse(row.PENALTY.ToString(), out penalty) ? penalty : 0;
                                decimal ar_curr = decimal.TryParse(row.AR_CURR.ToString(), out ar_curr) ? ar_curr : 0;
                                decimal ar_pri = decimal.TryParse(row.AR_PRI.ToString(), out ar_pri) ? ar_pri : 0;
                                string sdrcode = row.SDRCODE.ToString();
                                decimal sdramt = decimal.TryParse(row.SDRAMT.ToString(), out sdramt) ? sdramt : 0;
                                string encoder = row.ENCODER.ToString();
                                string time_pd = row.TIME_PD.ToString();
                                string zone = row.ZONE.ToString();
                                DateTime date_pd = Convert.ToDateTime(row.DATE.ToString());
                                if (sdramt <= 0) continue;
                                
                        string[] dbParams = {"YRMON","ZONE","ACCTNO","NAME","DATE","REF","COLLECTED","CURRENT","PENALTY","AR_CURR","AR_PRI","SDRCODE","SDRAMT","ENCODER","TIME_PD" };


                                string fpath = string.Format("{0}\\processed\\", file.DirectoryName);
                                tablename = save_filename;

                                dbfData = new DBRemix(fpath, false);

                                
                                ArrayList dbValues = new ArrayList();
                                dbValues.Add(yrmon);
                                dbValues.Add(zone);
                                dbValues.Add(acctno);
                                dbValues.Add(name);
                                dbValues.Add(date_pd);
                                dbValues.Add(refnum);
                                dbValues.Add(collected);
                                dbValues.Add(current);
                                dbValues.Add(penalty);
                                dbValues.Add(ar_curr);
                                dbValues.Add(ar_pri);
                                dbValues.Add(sdrcode);
                                dbValues.Add(sdramt);
                                dbValues.Add(encoder);
                                dbValues.Add(time_pd);

                                dbfData.SaveToOLEDatabase(tablename, dbValues, dbParams);
                                this.Text = string.Format("[{0}]-[{1}]", fileName, acctno);
                            }

                            //tablename = fileName;
                            //dbfData = new DBRemix(Path.GetDirectoryName(openFileDialog1.FileName), false);
                            
                        }
                          
                    }
                }
                MessageBox.Show("Saving to DPAYMAY.DBF is done");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string xlsFile = "";

            MessageBox.Show("Now Select the source bank.xls");
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                xlsFile = openFileDialog1.FileName;
            }
            else
            {
                return;
            }

            string adaptStr = "";
            string xls = openFileDialog1.SafeFileName;
            var connStr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;data source={0};Extended Properties=Excel 8.0;", xlsFile);
            adaptStr = string.Format("Select * from [{0}$]", "june 2014");

            var adapter = new OleDbDataAdapter(adaptStr, connStr);
            var ds = new DataSet();
            adapter.Fill(ds, "tbPay");

            var data = ds.Tables["tbPay"].AsEnumerable();
            var query = data.Select(x => new
            {
                acctno = x["ACCTNO"]
            });

            string name="";
            string dbffilePath = @"D:\shared\bank_xls";
            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", dbffilePath);
            DBRemix dbfData = new DBRemix(dbffilePath, false);
            string tablename = "JUNE14";
            int cnt = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                foreach (var drows in query)
                {
                    string acctno = drows.acctno.ToString().TrimEnd();

                    if ((acctno.Length != 6) || (acctno.Length <= 0)) continue;
                    tbMaster mast = dbcontext.tbMasters.FirstOrDefault(x => x.acctno.Equals(acctno));
                    name = mast.name.TrimEnd();

                    string wherestr = string.Format("[ACCTNO] = '{0}'", acctno);
                    ArrayList dbValues = new ArrayList();
                    dbValues.Add(name);

                    dbfData.OLEDBUpdateToDatabase(tablename, wherestr, dbValues, "NAME");
                    cnt++;
                    this.Text = string.Format("[{1}] - {0}", name,cnt);
                    
                }
                MessageBox.Show("Processing done.!!!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                int counter = 0;
                var billDetails = dbcontext.tbBillingDetails.Where(x => x.inst_fee > 0);
                foreach (tbBillingDetail bill in billDetails)
                {
                    int masterID = bill.master_id;

                    tbMasterAcct mAcct = dbcontext.tbMasterAccts.Single(x => x.master_id == masterID);
                    mAcct.IFArrears = bill.inst_fee;
                    
                    counter++;
                    this.Text = counter.ToString();
                }
                dbcontext.SaveChanges();
                MessageBox.Show("Copy inst_fee to IFArrears is done.");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var ledger = dbcontext.tbLedgers.Where(x => x.code.Equals("FBAL"));
                int counter = 0;
                foreach (tbLedger lData in ledger)
                {
                    int masterID = lData.master_id;
                    decimal fbal = Convert.ToDecimal(lData.amount);

                    tbMasterAcct mAcct = dbcontext.tbMasterAccts.First(x => x.master_id == masterID);
                    decimal balance = Convert.ToDecimal(mAcct.bill_balance);

                    if (fbal == balance)
                    {
                        mAcct.arrears_curr_yr = fbal;
                        mAcct.bill_arrears = fbal;
                    }
                    else if(mAcct.arrears_curr_yr < fbal)
                    {
                        tbLedger led = dbcontext.tbLedgers.FirstOrDefault(x => x.code.Equals("PAID") && x.master_id == masterID);
                        mAcct.arrears_curr_yr = fbal - led.amount;
                        mAcct.bill_arrears = fbal - led.amount;
                    }
                    counter++;
                    this.Text = string.Format("[{0}] - {1} ", counter, masterID);
                   
                }
                dbcontext.SaveChanges();
                MessageBox.Show("Processing done.");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var qLedger = dbcontext.tbLedgers.Where(x => x.code.Equals("SNR") && x.amount == 0);
                foreach (tbLedger ledger in qLedger)
                {
                    string refnum = ledger.@ref.ToString();
                    decimal current = 0;
                    decimal senior = 0;
                    decimal balance = Convert.ToDecimal(ledger.balance);
                    int masterID = ledger.master_id;

                    tbLedger bill = dbcontext.tbLedgers.FirstOrDefault(x => x.@ref.Equals(refnum));
                    current = Convert.ToDecimal(bill.amount) - 5;
                    senior = (current * (decimal)0.05) * -1;
                    balance = balance + senior;

                    ledger.amount = senior;
                    ledger.balance = balance;

                    tbMasterAcct masAcct = dbcontext.tbMasterAccts.First(x => x.master_id == masterID);
                    masAcct.bill_balance = balance;

                    this.Text = "Processing master " + masterID.ToString();
                    
                }
                dbcontext.SaveChanges();
                MessageBox.Show("Processing Done");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var qLedger = dbcontext.tbLedgers.Where(x => x.code.Equals("SNR") && x.amount == 0);
                foreach (tbLedger ledger in qLedger)
                {
                    string refnum = ledger.@ref.ToString();
                    decimal current = 0;
                    decimal senior = 0;
                    decimal balance = Convert.ToDecimal(ledger.balance);
                    int masterID = ledger.master_id;
                    decimal amount = Convert.ToDecimal(ledger.amount);

                    tbLedger bill = dbcontext.tbLedgers.FirstOrDefault(x => x.@ref.Equals(refnum));
                    current = Convert.ToDecimal(bill.amount) - 5;
                    senior = (current * (decimal)0.05) * -1;
                    balance = balance + senior;

                    ledger.amount = senior;
                    ledger.balance = balance;

                    tbMasterAcct masAcct = dbcontext.tbMasterAccts.First(x => x.master_id == masterID);
                    masAcct.bill_balance = balance;

                    this.Text = "Processing master " + masterID.ToString();

                }
                dbcontext.SaveChanges();
                MessageBox.Show("Processing Done");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var dRows = dbcontext.tbBankCollections.Where(x=>x.updated==null);
                //var dRows = dbcontext.tbBankCollections.Where(x => x.master_id==27927);
                int dcount = dRows.Count();
                foreach (tbBankCollection drow in dRows)
                {
                    tbLedger ledgerData;
                    int masterID = Convert.ToInt32(drow.master_id);
                    decimal collected = Convert.ToDecimal(drow.totalamt);
                    decimal current = decimal.TryParse(drow.current.ToString(), out current) ? current : 0;
                    decimal if2 = Convert.ToDecimal(drow.others);
                    decimal arrears = Convert.ToDecimal(drow.arrears);
                    decimal senior = Convert.ToDecimal(drow.senior);
                    decimal AmtToDeduct = collected - if2;
                    //string zone = drow["ZONE"].ToString();

                    bool isIF = false;
                    DateTime trans_date = new DateTime();
                    //if (!sdrcode.Equals("IF2")) continue;
                    //if (acctno.Equals("026896")) sdrcode = "IF2";
                    // if (zone.Length > 2) continue;

                    if (collected == 0) continue;
                    tbMasterAcct mastAcct = dbcontext.tbMasterAccts.FirstOrDefault(x => x.master_id == masterID);
                    trans_date = Convert.ToDateTime(drow.date_collected);



                    if (if2 > 0)
                    {
                        //AmtToDeduct = AmtToDeduct - sdramt;

                        if (mastAcct.IFArrears > 0)
                        {
                            mastAcct.IFArrears = mastAcct.IFArrears - if2;
                        }
                        mastAcct.IFBalance = mastAcct.IFBalance - if2;

                        if (if2 == collected)
                        {

                            ledgerData = new tbLedger();
                            ledgerData.code = "IFPd";
                            ledgerData.@ref = drow.refnum.ToString();
                            ledgerData.trans_date = DateTime.Today;
                            ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                            ledgerData.symbol = "";
                            ledgerData.encoder = drow.collect_agent.ToString();
                            ledgerData.master_id = masterID;
                            ledgerData.other = if2;
                            dbcontext.AddTotbLedgers(ledgerData);
                            //dbcontext.SaveChanges();
                            drow.updated = "Y";
                            continue;
                        }

                        isIF = true;
                    }

                    ledgerData = new tbLedger();
                    ledgerData.code = "PAID";
                    ledgerData.@ref = drow.refnum.ToString();
                    ledgerData.trans_date = DateTime.Today;
                    ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                    ledgerData.symbol = "-";
                    ledgerData.encoder = drow.collect_agent.ToString();
                    ledgerData.master_id = masterID;
                    ledgerData.amount = AmtToDeduct;
                    ledgerData.balance = mastAcct.bill_balance - AmtToDeduct;
                    dbcontext.AddTotbLedgers(ledgerData);

                    if (isIF)
                    {
                        ledgerData = new tbLedger();
                        ledgerData.code = "IFPd";
                        ledgerData.@ref = drow.refnum.ToString();
                        ledgerData.trans_date = DateTime.Today;
                        ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                        ledgerData.symbol = "";
                        ledgerData.encoder = drow.collect_agent.ToString();
                        ledgerData.master_id = masterID;
                        ledgerData.other = if2;
                        dbcontext.AddTotbLedgers(ledgerData);
                    }


                    decimal curr_arr = decimal.TryParse(drow.arrears.ToString(), out curr_arr) ? curr_arr : 0;
                    if (mastAcct.bill_current <= 0) curr_arr = Convert.ToDecimal(drow.current);

                    if (curr_arr > 0)
                    {
                        if (mastAcct.arrears_curr_yr > 0)
                        {
                            //  if (curr_arr >= mastAcct.arrears_curr_yr)
                            //  {
                            mastAcct.bill_arrears = mastAcct.bill_arrears - curr_arr;
                            mastAcct.arrears_curr_yr = mastAcct.arrears_curr_yr - curr_arr;
                            mastAcct.bill_arrears_months--;
                            //  }
                        }
                    }


                    cnt++;
                    decimal balance = Convert.ToDecimal(mastAcct.bill_balance);
                    if (mastAcct.bill_current >= current)
                    {
                        mastAcct.bill_current = mastAcct.bill_current - current;
                    }
                    mastAcct.bill_balance = balance - AmtToDeduct;
                    drow.updated = "Y";
                    this.Text = string.Format("[Total: {0}] {1}", cnt, drow.master_id.ToString());

                    

                } // foreach end
                dbcontext.SaveChanges();
                MessageBox.Show("tbPay update is finished.");
            } //using end


        }

        private void button19_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                string oldtxt = this.Text;
                var query = dbcontext.tbPays.Where(x => x.encoder.Equals("MVA") && x.yrmon.Equals("20140721") && x.current > 100);
                foreach (tbPay pay in query)
                {
                    pay.current -= 5;
                    this.Text = pay.acctno;
                }
                this.Text = "Saving ...";
                dbcontext.SaveChanges();
                MessageBox.Show("Repair of tbPay Maris is done.");
                this.Text = oldtxt;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbPays.Where(x => x.pay_id >= 2742 && x.pay_id <= 2798);

                foreach (tbPay data in query)
                {
                    data.@ref += 1;
                }
                dbcontext.SaveChanges();
                MessageBox.Show("repair done");
            }
        }

        private void btnUploadBills_Click(object sender, EventArgs e)
        {

            ProcessLedger("BILL");
        } // private void btnUploadBills_Click(object sender, EventArgs e)


        private void ProcessLedger(string mode)
        {

            openFileDialog1.Title = string.Format("Please select {0} dbf..", mode);
            DialogResult result = openFileDialog1.ShowDialog();

            string pathfile = Path.GetDirectoryName(openFileDialog1.FileName);
            string fileName = openFileDialog1.SafeFileName;

            //string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};User Id=admin;Password=;", fileName);
            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", pathfile);
            string oldtext = this.Text;
            if (result == DialogResult.OK)
            {

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    //trans_date	volume	symbol	encoder	remarks	amount	balance	other

                    string query = string.Format("Select [acctno],[ref],[presrdg],[trans_date],[volume],[symbol],[encoder],[remarks],[amount],[balance],[other] from [{0}]", fileName);
                    using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet myDataset = new DataSet();
                        myAdapter.Fill(myDataset, fileName);

                        var dTable = myDataset.Tables[0].AsEnumerable();
                        var dRows = dTable.Select(x => new
                        {
                            acctno = x["acctno"],
                            refnum = x["ref"],
                            presrdg = x["presrdg"],
                            trans_date = x["trans_date"],
                            volume = x["volume"],
                            symbol = x["symbol"],
                            encoder = x["encoder"],
                            remarks = x["remarks"],
                            amount = x["amount"],
                            balance = x["balance"],
                            other = x["other"]
                        }
                        );
                        DateTime nulldate = new DateTime(1900, 1, 1);
                        using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                        {
                            foreach (var row in dRows)
                            {
                                this.Text = string.Format("Adding to Ledger : {0}", row.acctno);
                                int masterID = global_func.getMasterID(row.acctno.ToString());
                                int presrdg = Int32.TryParse(row.presrdg.ToString(), out presrdg) ? presrdg : 0;
                                DateTime transdate = DateTime.TryParse(row.trans_date.ToString(), out transdate) ? transdate : nulldate;
                                int volume = Int32.TryParse(row.volume.ToString(), out volume) ? volume : 0;
                                decimal amount = decimal.TryParse(row.amount.ToString(), out amount) ? amount : 0;

                                tbMasterAcct updateAccts = dbcontext.tbMasterAccts.First(x => x.master_id == masterID);
                                decimal balance = Convert.ToDecimal(updateAccts.bill_balance);
                                decimal new_balance = balance + amount;
                                updateAccts.bill_balance = new_balance;

                                tbLedger ledger = new tbLedger();
                                ledger.amount = amount;
                                ledger.balance = new_balance;
                                ledger.code = mode;
                                ledger.encoder = row.encoder.ToString(); ;
                                ledger.trans_date = transdate;
                                ledger.@ref = row.refnum.ToString();
                                ledger.remarks = row.remarks.ToString();
                                ledger.master_id = masterID;
                                dbcontext.AddTotbLedgers(ledger);
                            }
                            this.Text = "Saving entries...";
                            dbcontext.SaveChanges();
                            this.Text = oldtext;
                            MessageBox.Show(string.Format("Upload of {0} dbf to ledger is done.", mode));

                        }
                    }
                }
            }
        }

        private void btnSenior_Click(object sender, EventArgs e)
        {
            ProcessLedger("SNR");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ProcessLedger("PNLT");
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }


        private void ProcessPayment()
        {

            openFileDialog1.Title = "Please select payment dbf";
            DialogResult result = openFileDialog1.ShowDialog();

            string pathfile = Path.GetDirectoryName(openFileDialog1.FileName);
            string fileName = openFileDialog1.SafeFileName;

            //string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};User Id=admin;Password=;", fileName);
            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", pathfile);
            string oldtext = this.Text;
            if (result == DialogResult.OK)
            {

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    //trans_date	volume	symbol	encoder	remarks	amount	balance	other

                    string query = string.Format("Select [acctno],[ref],[presrdg],[trans_date],[volume],[symbol],[encoder],[remarks],[amount],[balance],[other] from [{0}]", fileName);
                    using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet myDataset = new DataSet();
                        myAdapter.Fill(myDataset, fileName);

                        var dTable = myDataset.Tables[0].AsEnumerable();
                        var dRows = dTable.Select(x => new
                        {
                            acctno = x["acctno"],
                            refnum = x["ref"],
                            presrdg = x["presrdg"],
                            trans_date = x["trans_date"],
                            volume = x["volume"],
                            symbol = x["symbol"],
                            encoder = x["encoder"],
                            remarks = x["remarks"],
                            amount = x["amount"],
                            balance = x["balance"],
                            other = x["other"]
                        }
                        );
                        DateTime nulldate = new DateTime(1900, 1, 1);
                        using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                        {
                            foreach (var row in dRows)
                            {
                                this.Text = string.Format("Adding to Ledger : {0}", row.acctno);
                                int masterID = global_func.getMasterID(row.acctno.ToString());
                                int presrdg = Int32.TryParse(row.presrdg.ToString(), out presrdg) ? presrdg : 0;
                                DateTime transdate = DateTime.TryParse(row.trans_date.ToString(), out transdate) ? transdate : nulldate;
                                int volume = Int32.TryParse(row.volume.ToString(), out volume) ? volume : 0;
                                decimal amount = decimal.TryParse(row.amount.ToString(), out amount) ? amount : 0;

                                tbMasterAcct updateAccts = dbcontext.tbMasterAccts.First(x => x.master_id == masterID);
                                decimal balance = Convert.ToDecimal(updateAccts.bill_balance);
                                decimal new_balance = balance - amount;
                                updateAccts.bill_balance = new_balance;

                                tbLedger ledger = new tbLedger();
                                ledger.amount = amount;
                                ledger.balance = new_balance;
                                ledger.code = "PAID";
                                ledger.encoder = row.encoder.ToString(); ;
                                ledger.trans_date = transdate;
                                ledger.@ref = row.refnum.ToString();
                                ledger.remarks = row.remarks.ToString();
                                ledger.master_id = masterID;
                                dbcontext.AddTotbLedgers(ledger);
                            }
                            this.Text = "Saving entries...";
                            dbcontext.SaveChanges();
                            this.Text = oldtext;
                            MessageBox.Show("Upload of payment dbf to ledger is done.");

                        }
                    }
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ProcessPayment();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            int count = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                
                var queryZone14 = dbcontext.tbMasters.Where(x => x.zone_id >= 107 && x.zone_id <= 114).Select(x=>x.master_id);
                foreach (int mast in queryZone14)
                {
                    var queryLedger = dbcontext.tbLedgers.Where(x => x.code.Equals("PNLT") && x.master_id == mast && x.billing_id == 24).SingleOrDefault();
                    if (queryLedger != null)
                    {
                        count++;
                        this.Text = string.Format("Accounts Affected : {0}", count);
                        queryLedger.trans_date = new DateTime(2014, 09, 30);
                    }
                }
                dbcontext.SaveChanges();
                MessageBox.Show("Processing Done..");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            string pathfile = Path.GetDirectoryName(openFileDialog1.FileName);
            string fileName = openFileDialog1.SafeFileName;
            zonebook = textBox3.Text;
            billmonth = textBox4.Text;
            //string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};User Id=admin;Password=;", fileName);
            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", pathfile);
            if (result == DialogResult.OK)
            {
                textBox3.Text = fileName.Substring(4, 4);


                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = string.Format("Select [ACCTNO] from [{0}] where [STATUS]='X'", fileName);
                    using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet myDataset = new DataSet();
                        myAdapter.Fill(myDataset, fileName);

                        var dTable = myDataset.Tables[0].AsEnumerable();
                        var dRows = dTable.Select(x => x);

                        int rowcount = dRows.Count();
                        string oldtext = this.Text;
                        using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                        {
                            foreach (var drow in dRows)
                            {
                                /**
                                int ave_vol = Convert.ToInt32(drow["AVE"].ToString());
                                string acctno = drow["ACCTNO"].ToString();
                                string zonebook = drow["ZONE"].ToString();
                                string cardno = drow["CARDNO"].ToString();
                                updateMaster(ave_vol, acctno, zonebook, cardno);
                                 */
                                string acctno = drow["ACCTNO"].ToString();


                                var mast_query = dbcontext.tbMasters.FirstOrDefault(x => x.acctno.Equals(acctno));
                                if (mast_query != null)
                                {
                                    this.Text = acctno;
                                    mast_query.status = "X";
                                }
                            }
                            dbcontext.SaveChanges();
                            this.Text = oldtext;
                            MessageBox.Show("Process Done");
                        }
                    }
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

            int num = 0;
            int added = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                List<int> dbMaster = dbcontext.tbMasters.Select(x=>x.master_id).ToList();
                foreach (int masterID in dbMaster)
                {
                    var qMeter = dbcontext.tbMeters.Where(x => x.master_id == masterID).Select(x=>x);
                    int cnt = qMeter.Count();

                    if (cnt > 1)
                    {
                        List<tbMeter> mLast = qMeter.OrderByDescending(x=>x.meter_id).ToList();
                        ListViewItem lvM = new ListViewItem(mLast[0].master_id.ToString());
                        string test = mLast[0].master_id.ToString();
                        string temp = mLast[0].meter_id.ToString();
                        lvM.SubItems.Add(mLast[0].meter_id.ToString());
                        lvMeters.Items.Add(lvM);
                        added++;
                    }
                    this.Text = string.Format("Processing[{0}]...found[{1}]", num++,added);
                }
            }
            MessageBox.Show("Done");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            GlobalFunctions gfunc = new GlobalFunctions();
            int masterID = 0;
            int meterID = 0;
            int i = 0;
            foreach (ListViewItem lv in lvMeters.Items)
            {
                masterID = int.TryParse(lv.SubItems[0].Text, out masterID) ? masterID : 0;
                meterID = int.TryParse(lv.SubItems[1].Text, out meterID) ? meterID : 0;
                gfunc.setActiveMeter(masterID, meterID);
                this.Text = string.Format("Processing[{0}/{1}]...", i++, lvMeters.Items.Count);
            }
            MessageBox.Show("Done");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                int cnt = 0;
                var mast_accts = dbcontext.tbMasterAccts.Where(x => x.arrears_curr_yr > 0);
                foreach (tbMasterAcct m_acct in mast_accts)
                {
                    cnt++;
                    m_acct.arrears_prev_yrs += m_acct.arrears_curr_yr;
                    m_acct.arrears_curr_yr = 0;
                    this.Text = cnt.ToString();
                }
                dbcontext.SaveChanges();

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string zonetorepair = textBox1.Text;
            List<string> ctgy = new List<string>{"12", "32", "22"};
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                foreach (string cty in ctgy)
                {
                    accntsPaid = 0;
                    var data_to_repair = dbcontext.tbMRSUploads.Where(x => x.md_zone.Equals(zonetorepair) && x.md_billmonth.Equals("01-2017") && x.md_ctgry.Contains(cty)).Select(x => x);
                    //var data_to_repair = dbcontext.tbMRSUploads.Where(x => x.md_zone.Equals("1204") && x.md_billmonth.Equals("01-2017") && x.md_ctgry.Contains("12") && x.md_acctno.Equals("028928")).Select(x => x);                
                    if (data_to_repair == null) continue;
                    foreach (tbMRSUpload updata in data_to_repair)
                    {
                        
                        int vol = 0;
                        int masterID = 0;
                        decimal current = 0;
                        string acctno = updata.md_acctno;
                        int billingID = 0;
                        if (updata.md_volume.Length != 0)
                            vol = Convert.ToInt32(updata.md_volume);
                        if (updata.md_acctno.Length != 0)
                            masterID = global_func.getMasterID(updata.md_acctno);
                        if (masterID != 0)
                        {
                            billingID = global_func.getBillingID(updata.md_billmonth);
                            current = global_func.processCurrent(masterID, vol);
                            processLedger(masterID, billingID, current);

                        }
                    }
                    listBox5.Items.AddRange(paidAccounts.ToArray());
                    listBox6.Items.AddRange(repairedAccounts.ToArray());
                }
                saveToFile();
                MessageBox.Show(string.Format("No. of Repaird: {0} ---- No. of Paids : {1}",listBox6.Items.Count,accntsPaid));

            }
        }


        private void processLedger(int masterID, int billingID,decimal current)
        {
            decimal old_amt = 0;
            decimal run_balance = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var ledgerData = dbcontext.tbLedgers.Where(x => x.master_id == masterID && x.billing_id == billingID && x.code.Equals("BILL")).Select(x => x);
                if (ledgerData != null)
                {
                    foreach (tbLedger lData in ledgerData)
                    {
                        int ledgerID = lData.ledger_id;
                        old_amt = Convert.ToDecimal(lData.amount);
                        if (old_amt == (current+5)) return;
                        run_balance = Convert.ToDecimal(lData.balance);
                        decimal amtAddToBalance = 0;
                        amtAddToBalance = (current + 5) - old_amt;
                        lData.amount = current + 5;
                        lData.balance += amtAddToBalance;
                        var paidData = dbcontext.tbLedgers.Where(x => x.ledger_id > ledgerID && x.code.Equals("PAID") && x.master_id == masterID).Select(x => x);
                        int pcount = paidData.Count();
                        if (paidData.Count() > 0)
                        {
                            foreach(tbLedger p in paidData)
                                {
                                    paidAccounts.Add(global_func.getAcctNo(p.master_id));
                                    accntsPaid++;
                                }
                            
                        }
                        processMasterAcct(masterID, current, Convert.ToDecimal(lData.balance),amtAddToBalance);
                       
                        repairedAccounts.Add(string.Format("{0}---{1}---{2}---{3}",global_func.getAcctNo(lData.master_id),lData.volume,old_amt,current));
                    }
                }
                dbcontext.SaveChanges();
               
            }
        }

        private void processMasterAcct(int masterID, decimal current, decimal balance, decimal amtToAdd)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMasterAcct mastAcct = dbcontext.tbMasterAccts.FirstOrDefault(x => x.master_id == masterID);
                if (mastAcct != null)
                {
                    mastAcct.bill_current = current;
                    if (mastAcct.bill_balance >= 0)
                    {
                        mastAcct.bill_balance = balance;
                    }
                    else
                    {
                        mastAcct.bill_balance += amtToAdd;
                            
                    }
                }
                dbcontext.SaveChanges();
            }
        }   


        private void saveToFile()
        {
            foreach (string str in repairedAccounts)
            {
                global_func.saveLogFile(@"D:\repair\ledgerRepair.txt", str);
            }

            foreach (string strPaid in paidAccounts)
            {
                global_func.saveLogFile(@"D:\repair\ledgerRepairPaid.txt",strPaid);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
          

            DialogResult result = openFileDialog1.ShowDialog();

            string pathfile = Path.GetDirectoryName(openFileDialog1.FileName);
            string fileName = openFileDialog1.SafeFileName;
            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};User Id=admin;Password=;", pathfile+"\\"+fileName);
            string tbname = "tbMRSDownloads";

            if (result == DialogResult.OK)
            {
                
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = string.Format("Select * from [{0}] ", tbname);
                    using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet myDataset = new DataSet();
                        myAdapter.Fill(myDataset, tbname);

                        var dTable = myDataset.Tables[0].AsEnumerable();
                        var dRows = dTable.Select(x => x);

                        int rowcount = dRows.Count();
                        int reccount = 0;

                        string oldtext = this.Text;
                        using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                        {
                            foreach (var drow in dRows)
                            {
                                reccount++;
                                int masterID = Convert.ToInt32(drow[1].ToString());
                                string acctno = drow["amrsdwn_acctno"].ToString().Trim();
                                string name = drow[3].ToString().Trim();
                                string address = drow[4].ToString().Trim();
                                string metnum = drow[5].ToString().Trim();
                                int ctgy = Convert.ToInt32(drow[6].ToString());
                                int cardno = Convert.ToInt32(drow[7].ToString());
                                string zonebook = drow[8].ToString().Trim();
                                decimal senior = Convert.ToDecimal(drow.IsNull(9) ? "0" : drow[9].ToString());
                                string refnum = "";
                                if (!checkfornull(drow[11])){
                                    refnum=drow[11].ToString().Substring(0, 10);
                                    refnum = "000000" + refnum;
                                }
                                int avevol = Convert.ToInt32(drow[12].ToString());
                                int prevrdg = Convert.ToInt32(drow[13].ToString());
                                                         
                                int volume = Convert.ToInt32(drow.IsNull(15) ? "0" : drow[15].ToString());
                                decimal current = Convert.ToDecimal(drow.IsNull(16) ? "0" : drow[16].ToString());
                                decimal arrears = Convert.ToDecimal(drow.IsNull(17) ? "0" : drow[17].ToString());
                                decimal penalty = Convert.ToDecimal(drow.IsNull(18) ? "0" :drow[18].ToString());
                                //int arrearsmonth = Convert.ToInt32(drow.IsNull(19) ? "0" :drow[19].ToString());
                                decimal dgmmet = Convert.ToDecimal(drow.IsNull(20) ? "0" :drow[20].ToString());
                                decimal others = Convert.ToDecimal(drow.IsNull(21) ? "0" :drow[21].ToString());
                                decimal instfee = Convert.ToDecimal(drow.IsNull(22) ? "0" :drow[22].ToString());
                                DateTime presdate = Convert.ToDateTime(drow.IsNull(24) ? null : drow[24].ToString());
                                DateTime prevdate = Convert.ToDateTime(drow.IsNull(26) ? null :drow[26].ToString());
                                string remarks = drow.IsNull(29) ? null : drow[29].ToString().Trim();
                                string encoder = textBox7.Text.Trim();
                                string billmonth = textBox8.Text.Trim();

                                tbMRSUpload mrsUpload = new tbMRSUpload();
                                
                                if (!drow.IsNull(14))
                                {
                                    int presrdg = 0;
                                    presrdg = Convert.ToInt32(drow[14].ToString());
                                    mrsUpload.md_presrdg = Convert.ToString(presrdg);
                                    mrsUpload.md_dateuploaded = presdate.ToShortDateString();
                                }      
                                                                
                                mrsUpload.md_billmonth = billmonth;
                                mrsUpload.md_billno = refnum;
                                mrsUpload.md_acctno = acctno;
                                mrsUpload.md_zone = zonebook;
                                mrsUpload.md_ctgry = Convert.ToString(ctgy);
                                mrsUpload.md_prevrdg = Convert.ToString(prevrdg);                                
                                mrsUpload.md_volume = Convert.ToString(volume);
                                mrsUpload.md_billamount = Convert.ToString(current);
                                mrsUpload.md_remark = remarks;
                                mrsUpload.md_encoder = encoder;
                                mrsUpload.md_masterID = null;          
                                
                                dbcontext.AddTotbMRSUploads(mrsUpload);
                              
                                this.Text = String.Format(" Record : {0} / {1}", reccount, rowcount);
                            }
                            dbcontext.SaveChanges();
                            this.Text = oldtext;
                            MessageBox.Show("Process Done of "+ reccount);
                        }
                    }
                }
            }



        }


        private bool checkfornull(object value)
        {
            bool result = false;
            if (value == DBNull.Value)
            {
                result = true;
            }
           
            return result;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string bMonth = textBox11.Text;
            string zBook = textBox12.Text;
            int recordcount = 0;


            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryTbUploads = dbcontext.tbMRSUploads.Where(x=>x.md_billmonth.Equals(bMonth) &&
                    x.md_zone.Equals(zBook) && x.mrsUP_ID>=3670321 && x.md_encoder.Contains("AEL") && x.md_billamount.Contains("0.00")).Select(x=>x);
                
                //int recCount = queryTbUploads.Count();
                //MessageBox.Show("Total Records " + recCount.ToString());

                foreach (tbMRSUpload upData in queryTbUploads)
                {
                    upData.md_billno = "2018091200RP" + zBook;
                    int masterID = global_func.getMasterID(upData.md_acctno);
                    int volume = Convert.ToInt32(upData.md_volume);
                    decimal current = global_func.processCurrent(masterID,volume);
                    upData.md_billamount = Convert.ToString(current);
                    this.Text = "Processing ..." + upData.md_acctno;
                    recordcount++;
                }
                
                dbcontext.SaveChanges();
                this.Text = "Total Records Processed " + recordcount;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //this.tbLedgerTableAdapter.Fill(this.dsLedger.tbLedger);
            this.tbLedgerTableAdapter.FillByBilling(this.dsLedger.tbLedger, 94);
            gridControl1.RefreshDataSource();
            
        }

        private void button32_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
            
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            int mastID = Convert.ToInt32(gridView1.GetListSourceRowCellValue(rowIndex, "master_id"));
            if (e.Column.FieldName == "AcctNo")
            {           
                string acctno = global_func.getAcctNo(mastID);
                e.Value = acctno;
            }
            if (e.Column.FieldName == "BillAmt")
            {
                int vol = Convert.ToInt32(gridView1.GetListSourceRowCellValue(rowIndex, "volume"));
                decimal curr_amt = Convert.ToDecimal(gridView1.GetListSourceRowCellValue(rowIndex, "amount"));
                decimal amt = global_func.processCurrent(mastID, vol);
                e.Value = amt+5;                
            }
           
        }

        //Update ID#04272020   Start
        private void button33_Click(object sender, EventArgs e)
        {
            this.tbLedgerTableAdapter.FillPenalizedByBilling(this.dsLedger.tbLedger, 94);
            gridControl2.RefreshDataSource();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int countRec = 0;   
            int updatedRec = 0;

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryPenalized = dbcontext.tbLedgers.Where(x => x.billing_id == 94 && x.code.Equals("PNLT")).Select(x => x);
                countRec = queryPenalized.Count();

                foreach (tbLedger ledger in queryPenalized)
                {
                    int masterID = ledger.master_id;
                    decimal account_balance = global_func.getBalance(masterID);
                    decimal penalty_amt = Convert.ToDecimal(ledger.amount);

                    if (penalty_amt > 0)
                    {
                        decimal newBalance = account_balance - penalty_amt;
                        tbLedger newData = new tbLedger();
                        newData.master_id = masterID;
                        newData.code = "CMPN";
                        newData.symbol = "-";
                        newData.amount = penalty_amt;
                        newData.balance = newBalance;
                        newData.trans_date = DateTime.Today;
                        newData.encoder = "GPC";
                        newData.remarks = "Auto-BAM Covid-19";
                        dbcontext.AddTotbLedgers(newData);

                        tbMasterAcct mast_acct = dbcontext.tbMasterAccts.Where(x => x.master_id == masterID).FirstOrDefault();
                        mast_acct.bill_balance = newBalance;

                       

                      updatedRec++;  
                    }
                  
                    countRec++;
                }

                dbcontext.SaveChanges();
                
            }
            MessageBox.Show("Total Process Records:"+countRec.ToString() + " [ Total Updated Records:"+updatedRec.ToString()+" ]");
        }

        private void gridView2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

            int rowIndex = e.ListSourceRowIndex;
            int mastID = Convert.ToInt32(gridView2.GetListSourceRowCellValue(rowIndex, "master_id"));
            if (e.Column.FieldName == "AcctNo")
            {           
                string acctno = global_func.getAcctNo(mastID);
                e.Value = acctno;
            }
            if (e.Column.FieldName == "AcctName")
            {
                string acctno = global_func.getAcctNo(mastID);
                e.Value = global_func.getAcctName(acctno);
            }
            if (e.Column.FieldName == "ActBalance")
            {                              
                decimal amt = global_func.getBalance(mastID);      
                e.Value = amt;
            }
            if (e.Column.FieldName == "NewBalance")
            {
                decimal pntl_amt = 0;
                decimal old_bal = 0;
                decimal newbal = 0;
                pntl_amt = Convert.ToDecimal(gridView2.GetListSourceRowCellValue(rowIndex, "amount"));
                old_bal = Convert.ToDecimal(gridView2.GetListSourceRowCellValue(rowIndex, "ActBalance"));
                if (pntl_amt > 0)
                {

                    newbal = old_bal - pntl_amt;
                    e.Value = newbal;
                }
            }
        
        }

        private void button35_Click(object sender, EventArgs e)
        {
            gridControl2.ShowPrintPreview();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbLedgerTableAdapter.FillBy(this.dsLedger.tbLedger);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button36_Click(object sender, EventArgs e)
        {
            //tbLedgerTableAdapter.Adapter.SelectCommand.CommandTimeout = 300;
            this.tbLedgerTableAdapter.FillBy(this.dsLedger.tbLedger);
         
            gridControl3.RefreshDataSource();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            decimal balance = 0;
            int mID = 0;
            int meow = 0;

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                for (int i = 0; i < gridView3.RowCount; i++)
                {
                    mID = Convert.ToInt32(gridView3.GetRowCellValue(i, "master_id"));
                    balance = Convert.ToDecimal(gridView3.GetRowCellValue(i, "balance"));
                    tbMasterAcct tbMAcct = dbcontext.tbMasterAccts.SingleOrDefault(x => x.master_id == mID);
                    tbMAcct.bill_balance = balance;
                    meow++;
                }
                MessageBox.Show("Number of Records:" + meow.ToString());
                dbcontext.SaveChanges();
            }
        }

        //Update ID#04272020   End
        

    } // end class
   
 } // end namespace
