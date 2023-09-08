using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Data;

namespace BillingSystem
{
    public partial class formManualEntry : Form
    {
      

        dbCommercialEntities dbContext;
        int userID = 0;
        int billing_id = 0;
        int billproc_id = 0;
        int billdetails_id = 0;

        ArrayList errorList = new ArrayList();
        bool errorToggle = false;

        string strBillPeriod = "";
        string strBillZone = "";

        int zone_id = 0;
        bool isFinalized = false;
        

        GlobalFunctions globFunc = new GlobalFunctions();
      
        public formManualEntry()
        {
            InitializeComponent();
        }

        private void formManualEntry_Load(object sender, EventArgs e)
        {
            this.Width = 1150;
            dbContext = new dbCommercialEntities();
            tbbillingBindingSource.DataSource = dbContext.tbBillings.OrderByDescending(a=>a.billing_id);            
            getBillProcess();
            userID = getUserID();           
        }

        private void getBillProcess()
        {
            billing_id = getBillingID();
            tbBillProcBindingSource.DataSource = dbContext.tbBillProcessings.Where(a => a.billing_id == billing_id).OrderByDescending(b=>b.bill_process_id);
        }

        private int getBillingID()
        {
            tbBilling temp = (tbBilling)tbbillingBindingSource.Current;
            return temp.billing_id;
        }

        private int getBillProcID()
        {
            tbBillProcessing temp = (tbBillProcessing)tbBillProcBindingSource.Current;
            return temp.bill_process_id;
        }

        private void tbbillingBindingSource_PositionChanged(object sender, EventArgs e)
        {
            getBillProcess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int billID = Convert.ToInt32(cmbBilling.SelectedValue);
            if (globFunc.checkBillFinalized(billID, cmbZone.Text) > 0)
            {
                MessageBox.Show("This billfile is already been finalized. Opening in read-only mode.");
                isFinalized = true;
                toggleFinalized();

                
            }
            else
            {
                isFinalized = false;
                toggleFinalized();
            }

            errorList.Clear();
            setGridDataSource();            
            strBillPeriod = cmbBilling.Text;
            strBillZone = cmbZone.Text;
            if (tbBillingDetailBindingSource.Count > 0)
            {
                if (isFinalized)
                {
                    toggleFinalized();
                    button3.Show();
                    btnView.Show();
                }
                else
                {
                    btnDelete.Show();
                    btnProcess.Enabled = true;
                    btnEdit.Hide();
                    button3.Hide();
                    btnEditCard.Show();
                    btnFinalize.Hide();
                    fillSRCodes();
                }
            }            
        }

        private void toggleFinalized()
        {
            btnEditCard.Visible = !isFinalized;
            btnDelete.Visible = !isFinalized;
            btnEdit.Visible = !isFinalized;
            btnFinalize.Visible = !isFinalized;
            btnProcess.Visible = !isFinalized;
            btnSR.Visible = !isFinalized;
        }

        private void setGridDataSource()
        {            
            zone_id = dbContext.tbZones.First(i => i.zone_name == cmbZone.Text).zone_id;
            billproc_id = getBillProcID();
            dbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins,dbContext.tbBillingDetails);
            tbBillingDetailBindingSource.DataSource = dbContext.tbBillingDetails.Where(a => a.billproc_id == billproc_id);       
            panel1.Enabled = true;
            if (tbBillingDetailBindingSource.Count > 0)
            {
                btnProcess.Show();                
            }
        }
    
        private int getBillDetailID()
        {
            tbBillingDetail temp = (tbBillingDetail)tbBillingDetailBindingSource.Current;
            return temp.billingdetails_id;
        }

        private int getPresReading()
        {
            tbBillingDetail temp = (tbBillingDetail)tbBillingDetailBindingSource.Current;
            return Convert.ToInt32(temp.rdg_pres);
        }
    
        private int getUserID()
        {
            MainForm mainF = (MainForm)this.MdiParent;
            return mainF.userID;
        }      
     
        private void btnEditCard_Click(object sender, EventArgs e)
        {
            txtNewCardNo.Clear();
            txtNewCardNo.Focus();         
            editCardNo();
            disableControls(false);            
        }

        private void disableControls(bool mode)
        {
            panel1.Enabled = mode;
            panel2.Enabled = mode;
            btnLoad.Enabled = mode;
        }

        private void editCardNo()
        {
            string name = "";
            string acctno = "";
            int cardno = 0;
            centerToForm(groupEditCardNo);
            groupEditCardNo.Show();
            name = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, coltbMaster2);
            acctno = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, coltbMaster);
            cardno = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, coltbMaster1);
            this.lblCardName.Text = string.Format("Name : {0}", name);
            this.lblCardAcctNo.Text = string.Format("Account No. : {0}", acctno);
            this.labelCurrentCardno.Text = string.Format("{0}", cardno);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupEditCardNo.Hide();
            disableControls(true);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (txtNewCardNo.Text.Length <= 0)
            {
                DialogResult result = MessageBox.Show("Blank Card no. detected. Proceed ?", "New Card No", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
            }
            string acctno = lblCardAcctNo.Text.Substring(lblCardAcctNo.Text.Length-6,6);
            tbMaster temp = dbContext.tbMasters.First(a => a.acctno.Equals(acctno));
            temp.cardno = int.Parse(txtNewCardNo.Text);
            dbContext.tbMasters.Context.SaveChanges();

            tbBillingDetail tempbill = (tbBillingDetail)tbBillingDetailBindingSource.Current;
            tempbill.read_edit_by = userID;
            dbContext.tbBillingDetails.Context.SaveChanges();

            MessageBox.Show("Card No. has been updated successfully");
            button2.PerformClick();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmReport rptBillfile = new frmReport();
            rptBillfile.rptMode = 1;
            ArrayList rptVal = new ArrayList();
            rptVal.Add(cmbZone.Text);
            rptVal.Add(cmbBilling.Text);
            rptVal.Add(billproc_id);
            rptBillfile.param = rptVal;
            rptBillfile.Show();

        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("Proceed Finalizing Billfile {0} of Zone {1} ?",cmbBilling.Text,cmbZone.Text ), "Finalize", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                decimal minimum_pay = globFunc.getMinimumPay();
                int st = 0;
                //var xm = tbBillingDetailBindingSource.List.OfType<tbBillingDetail>().ToList().Find(f => f.current == 0);
                var xm = tbBillingDetailBindingSource.List.OfType<tbBillingDetail>().ToList().Find(f => f.current < minimum_pay);
                try
                {
                    st = (int)xm.master_id;
                }
                catch { }
                if (st > 0)
                {
                    MessageBox.Show("There are records with below the minimum charge. Please check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                centerToForm(progressPanel2);
                progressPanel2.Show();
                backgroundWorker2.RunWorkerAsync();              
            }

        }   //end btnFinalize_Click


        private void updateMasterAccts(tbBillingDetail billrec)
        {
            tbMasterAcct mast_acct = dbContext.tbMasterAccts.First(a => a.master_id == billrec.master_id);

            int? old_reading = 0;
            old_reading = billrec.rdg_prev;
            int tst = mast_acct.master_id; 
            mast_acct.bill_current = billrec.current;
            mast_acct.bill_volume = billrec.volume;
            mast_acct.bill_last_bill_id = billrec.billproc_id;
            if ((mast_acct.bill_balance.HasValue) && (mast_acct.bill_balance != 0))
            {

                mast_acct.bill_arrears = mast_acct.bill_balance;
                mast_acct.bill_balance = checkDecimal(mast_acct.bill_balance) + billrec.current + checkDecimal(billrec.senior);
                                         
                mast_acct.bill_arrears_months = ++mast_acct.bill_arrears_months;
                if (isCurrentBillingYear())
                {
                    mast_acct.arrears_curr_yr = mast_acct.bill_arrears;
                }else
                {
                    mast_acct.arrears_prev_yrs = mast_acct.arrears_prev_yrs + mast_acct.arrears_curr_yr;
                    mast_acct.arrears_curr_yr = 0;
                }
            }
            else
            {
                mast_acct.bill_balance = billrec.current + checkDecimal(billrec.senior);
                mast_acct.bill_arrears_months = 1;
                //mast_acct.bill_arrears = checkDecimal(billrec.arrears);
            }
            
            mast_acct.bill_balance = mast_acct.bill_balance + checkDecimal(billrec.inst_fee) + checkDecimal(billrec.mtr_dmg);

            if (mast_acct.IFCurrentPayMonth.HasValue)
            {
                mast_acct.IFCurrentPayMonth += 1;
            }
            else
            {
                mast_acct.IFCurrentPayMonth = 0;
            }
            mast_acct.MtrDmg_Arrears = billrec.mtr_dmg;
            mast_acct.IFArrears = billrec.inst_fee;
            mast_acct.rdg_prev = old_reading;
            mast_acct.rdg_pres = billrec.rdg_pres;
            mast_acct.bill_delivery_date = new GlobalFunctions().getBillDeliveryDate(billing_id,zone_id);
            mast_acct.bill_reading_period = billrec.date_prev.Value.ToShortDateString() + " - " + billrec.date_pres.Value.ToShortDateString();
        }

        private bool isCurrentBillingYear()
        {
            bool retval = true;
            string[] str_temp;
            int current_mon;

            str_temp = strBillPeriod.Split('-');
            current_mon = Convert.ToInt32(str_temp[0]);
            if (current_mon == 1)
            {
                retval = false;
            }
            return retval;
        }

        private decimal checkDecimal(decimal? decValue)
        {
            decimal retVal = 0;

            try
            {
                retVal = (decimal)decValue;
            }
            catch { retVal = 0; }
            return retVal;
        } // end checkValuesDecimal

        private void saveToLedger(tbBillingDetail billrec,decimal mtrMtn)
        {
            decimal bill_balance = 0;
            string encoder = "";
            try
            {
                bill_balance = (decimal)(from en in dbContext.tbMasterAccts
                                                 where en.master_id == billrec.master_id
                                                 select en.bill_balance).FirstOrDefault();
            }
            catch {}
            decimal balance = 0;
            encoder = new GlobalFunctions().getMtrReaderEncoderName(1, userID);

            tbLedger rec = new tbLedger();
            
            // save current bill
            rec.billing_id = billing_id;         
            rec.code = "Bill";
            rec.master_id = billrec.master_id;
            if (!billrec.mtr_read_by.HasValue)
            {
                int encode_id = billrec.read_edit_by.HasValue ? (int)billrec.read_edit_by : 0;
                rec.encoder = new GlobalFunctions().getMtrReaderEncoderName(1, encode_id);
            }
            else
            {
                if (billrec.read_edit_by.HasValue)
                {
                    int encode_id = billrec.read_edit_by.HasValue ? (int)billrec.read_edit_by : 0;
                    rec.encoder = new GlobalFunctions().getMtrReaderEncoderName(1, encode_id);
                }
                else
                {
                    int encode_id = billrec.mtr_read_by.HasValue ? (int)billrec.mtr_read_by : 0;
                    rec.encoder = new GlobalFunctions().getMtrReaderEncoderName(0, encode_id);
                }
            }            
            rec.trans_date = billrec.date_pres;
            rec.symbol = "+";
            rec.presrdg = billrec.rdg_pres;
            rec.amount = billrec.current;
            rec.balance = billrec.current + bill_balance;
            balance = (decimal)rec.balance;
            rec.volume = billrec.volume;
            dbContext.tbLedgers.AddObject(rec);
            // end current bill
            

            //save IF2
            if (billrec.inst_fee > 0)
            {
                rec = new tbLedger();
                rec.billing_id = billing_id;
                rec.code = "IF2";
                rec.master_id = billrec.master_id;
                rec.trans_date = billrec.date_pres;
                rec.symbol = "+";
                rec.amount = billrec.inst_fee;
                rec.balance = (decimal)rec.amount + balance;
                balance = (decimal)rec.balance;
                rec.encoder = encoder;
                dbContext.tbLedgers.AddObject(rec);
            }
            // end IF2

            // save Senior
            if (billrec.senior < 0)
            {
                rec = new tbLedger();
                rec.billing_id = billing_id;
                rec.code = "SNR";
                rec.master_id = billrec.master_id;
                rec.trans_date = billrec.date_pres;
                rec.symbol = "-";
                rec.amount = billrec.senior;
                rec.balance = (decimal)rec.amount + balance;
                balance = (decimal)rec.balance;
                rec.encoder = encoder;
                dbContext.tbLedgers.AddObject(rec);
            }
            // end Senior

            // save Damage Meter
            if (billrec.mtr_dmg > 0)
            {
                rec = new tbLedger();
                rec.billing_id = billing_id;
                rec.code = "MDMG";
                rec.master_id = billrec.master_id;
                rec.trans_date = billrec.date_pres;
                rec.symbol = "+";
                rec.amount = billrec.mtr_dmg;
                rec.balance = (decimal)rec.amount + balance;
                balance = (decimal)rec.balance;
                rec.encoder = encoder;
                dbContext.tbLedgers.AddObject(rec);
            }
            // end Damage Meter



        } // end  saveToLedger

        private void updateMaster(int master_id,string status,DateTime last_read)
        {
            tbMaster updateMast = (from en in dbContext.tbMasters
                              where en.master_id == master_id
                              select en).Single();
            updateMast.status = status;
            updateMast.last_read_date = last_read;
        } // end updateMaster

        private int makeServiceRequest(string complain, tbBillingDetail billdetail_rec,string billfile)
        {
            int sr_id = 0;

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                int srcode_id = 0;
                string sr_no = "";
                int mast = billdetail_rec.master_id;
                var sr_code = context.tbServiceRequestCodes.Where(p => p.code_desc.Contains(complain.TrimStart())).Single();
                srcode_id = sr_code.srcode_id;

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
                sr_rec.master_id = billdetail_rec.master_id;
                sr_rec.complain_id = srcode_id;
                sr_rec.requested_by = billfile;
                sr_rec.request_recd_date = DateTime.Now;
                sr_rec.billdetails_id = billdetail_rec.billingdetails_id;
                sr_rec.encoder_id = userID;
                //sr_rec.status = 0;
                sr_rec.sr_no = (Convert.ToInt32(sr_no) + 1).ToString();
                context.tbServiceRequests.AddObject(sr_rec);
                context.SaveChanges(); 
            }
            return sr_id + 1;
        }  //end makeServiceRequest

        private void btnProcess_Click(object sender, EventArgs e)
        {
            btnProcess.Enabled = false;
            centerToForm(progressPanel1);
            progressPanel1.Show();
            backgroundWorker1.RunWorkerAsync();           
        }

        private void processArrears()
        {
            int master_id = 0;
            string acctno = "";
            byte arrears_months = 1;
            decimal balance = 0, arrears = 0;
            var query = from mAcct in dbContext.tbMasterAccts
                        join en in dbContext.tbMasters on mAcct.master_id equals en.master_id
                        where en.zone_id == zone_id && (!en.status.Equals("X") || en.status == null || en.status.Equals("E"))
                        && (mAcct.bill_balance != 0 || mAcct.bill_balance != null)
                        select new
                        {
                            master_id = mAcct.master_id,
                            acctno = en.acctno,
                            balance = mAcct.bill_balance,
                            arrears = mAcct.bill_arrears,
                            arrears_months = mAcct.bill_arrears_months,
                            current = mAcct.bill_current
                        };

            if (query.Count() == 0) return;

            foreach (var recArrears in query)
            {
                master_id = recArrears.master_id;
                acctno = recArrears.acctno;
                try
                {
                    arrears_months = (byte)recArrears.arrears_months;
                }
                catch { };
                balance = (decimal)recArrears.balance;

                try { arrears = (decimal)recArrears.arrears; }
                catch { arrears = 0; };

                using (dbCommercialEntities context = new dbCommercialEntities())
                {

                    try
                    {
                        tbBillingDetail bill_record = (from billdetails in context.tbBillingDetails
                                                       where billdetails.master_id == master_id &&
                                                       billdetails.billproc_id == billproc_id
                                                       select billdetails).Single();

                        bill_record.arrears = balance;
                        bill_record.arrears_month = ++arrears_months;
                        context.SaveChanges();
                    }
                    catch
                    {
                        errorToggle = true;
                        errorList.Add(string.Format("{0} - Arrears", acctno));                        
                    }
                }
            }            
        }

        private void processMeterDamage()
        {
            int master_id = 0;
            string acctno = "";
            var query = from mAcct in dbContext.tbMasterAccts
                        join en in dbContext.tbMasters on mAcct.master_id equals en.master_id
                        where en.zone_id == zone_id && mAcct.isMtrDmg == true
                              && mAcct.MtrDmg_Balance > 0 && (!en.status.Equals("X") || en.status == null || en.status.Equals("E"))
                        select new
                        {
                            master_id = mAcct.master_id,
                            acctno = en.acctno,
                            MDmg_balance = mAcct.MtrDmg_Balance,
                            MDmg_MonthlyPay = mAcct.MtrDmg_Monthly,
                            MDmg_Arrears = mAcct.MtrDmg_Arrears
                        };
            int MDmg_count = query.Count();
            if (MDmg_count == 0) return;
            foreach (var MDmg in query)
            {
                master_id = MDmg.master_id;
                acctno = MDmg.acctno;
                using (dbCommercialEntities context = new dbCommercialEntities())
                {
                    try
                    {
                        tbBillingDetail MDmg_record = (from billdetails in context.tbBillingDetails
                                                       where billdetails.master_id == master_id &&
                                                       billdetails.billproc_id == billproc_id
                                                       select billdetails).Single();
                        if (MDmg.MDmg_balance > MDmg.MDmg_MonthlyPay)
                        {
                            MDmg_record.mtr_dmg = MDmg.MDmg_MonthlyPay + (MDmg.MDmg_Arrears.HasValue?MDmg.MDmg_Arrears:0);
                        }
                        else
                        {
                            MDmg_record.mtr_dmg = MDmg.MDmg_balance + (MDmg.MDmg_Arrears.HasValue ? MDmg.MDmg_Arrears : 0);
                        }
                        context.SaveChanges();
                    }
                    catch 
                    {
                        errorToggle = true;
                        errorList.Add(string.Format("{0} - DmgMtr", acctno));                       
                    }
                }
            }

        }

        private void processIF2()
        {
            int master_id = 0;
            string acctno = "";
            var query = from mAcct in dbContext.tbMasterAccts
                        join en in dbContext.tbMasters on mAcct.master_id equals en.master_id
                        where (en.zone_id == zone_id) && (mAcct.isIF == true)
                              && (mAcct.IFBalance > 0)  && (!en.status.Equals("X") || en.status==null || en.status.Equals("E"))
                        select new
                        {
                            master_id = mAcct.master_id,
                            acctno = en.acctno,
                            IFBalance = mAcct.IFBalance,
                            IFMonthly = mAcct.IFMonthlyPay,
                            IFArrears = mAcct.IFArrears
                        };
            int IF_count = query.Count();

            if (IF_count == 0) return;

            foreach (var if2 in query)
            {
                master_id = if2.master_id;
                acctno = if2.acctno;
                using (dbCommercialEntities context = new dbCommercialEntities())
                {

                    try
                    {
                        tbBillingDetail IF_record = (from billdetails in context.tbBillingDetails
                                                     where billdetails.master_id == master_id &&
                                                     billdetails.billproc_id == billproc_id
                                                     select billdetails).Single();

                        if (if2.IFBalance >= if2.IFMonthly)
                        {

                            IF_record.inst_fee = if2.IFMonthly + (if2.IFArrears.HasValue?if2.IFArrears:0);
                        }
                        else
                        {
                            IF_record.inst_fee = if2.IFBalance + (if2.IFArrears.HasValue ? if2.IFArrears : 0);
                        }
                        context.SaveChanges();
                    }
                    catch
                    {
                        errorToggle = true;
                        errorList.Add(string.Format("{0} - IF2",acctno));
                    }
                }         
            }           
        }

        private void processSenior()
        {
            int master_id = 0;
            decimal senior_percent = 0;
            int senior_volume_cap = 0;

            var query = from mAcct in dbContext.tbMasterAccts
                        join en in dbContext.tbMasters on mAcct.master_id equals en.master_id
                        where en.zone_id == zone_id && mAcct.isSenior == true
                               && mAcct.senior_expiry > DateTime.Now
                        select mAcct.master_id;
            int senior_count = query.Count();               //Check if have seniors

            if (senior_count == 0) return;   // Exit if no seniors found.   

            var senior_data = (from sen in dbContext.tbSettings
                               select new { percent = sen.senior_percentage, cap = sen.senior_volume_cap }).Single();
            senior_percent = (decimal)senior_data.percent;
            senior_volume_cap = (int)senior_data.cap;

            foreach (var mast in query)
            {
                master_id = mast;
                using (dbCommercialEntities context = new dbCommercialEntities())
                {
                    try
                    {
                        tbBillingDetail seniors = (from billdetails in context.tbBillingDetails
                                                   where billdetails.master_id == master_id &&
                                                   billdetails.billproc_id == billproc_id
                                                   select billdetails).Single();
                    
                    decimal current = (decimal)seniors.current + (decimal)seniors.mtr_mtn;
                    int curr_vol = (int)seniors.volume;

                    if (curr_vol <= senior_volume_cap)
                    {
                        seniors.senior = (current * (senior_percent / 100) * -1);                         
                        context.SaveChanges();                       
                    }
                    }
                    catch { continue; }
                }
            }
        }



        private void cmbZone_TextChanged(object sender, EventArgs e)
        {
            btnProcess.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            processSenior();              // Process Senior
            processIF2();                 // Process Installation Fee
            processMeterDamage();         // Process Meter Damage
            processArrears();             // Process Arrears
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressPanel1.Hide();
            btnEdit.Show();
            button3.Show();
            btnDelete.Show();
            btnView.Show();
            btnFinalize.Show();
            btnSR.Show();
       /**
            if (errorToggle)
            {
                string errorFile = string.Format("D:\\ErrorList-{0}-{1}.txt", strBillPeriod, strBillZone);
                using (StreamWriter tr = new StreamWriter(errorFile, true))
                {
                    foreach (var error in errorList)
                    {
                        tr.WriteLine(error.ToString());
                    }
                }
            }
        */
            setGridDataSource();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            formAddBillEntry frmAddBill = new formAddBillEntry();
            frmAddBill.billproc_id = billproc_id;
            frmAddBill.userID = userID;
            frmAddBill.zoneID = zone_id;
            var query = (from en in dbContext.tbZones
                         where en.zone_name == cmbZone.Text
                         select new { mtr_reader = en.mtr_reader }).Single();
            frmAddBill.meter_reader = (int)query.mtr_reader;
            frmAddBill.ShowDialog();
            setGridDataSource();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             using (var form = new formPassword("delete"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    bool val = form.access_allow;
                    if (val)
                    {
                        using (var frm = new formBillingDelete())
                        {
                            string remarks = "";
                            var rest = frm.ShowDialog();
                            if (rest == DialogResult.OK)
                            {
                                remarks = frm.remarks;
                                tbBillingDetail test =  (tbBillingDetail)tbBillingDetailBindingSource.Current;
                                bool deleted = new GlobalFunctions().deleteBillEntry(test.billingdetails_id);
                                if (deleted)
                                {
                                    using (dbCommercialEntities bcontext = new dbCommercialEntities())
                                    {
                                        tbBillingDelete billdelete = new tbBillingDelete();
                                        billdelete.billproc_id = test.billproc_id;
                                        billdelete.date_deleted = DateTime.Now;
                                        billdelete.deleted_by = userID;
                                        billdelete.master_id = test.master_id;
                                        billdelete.rdg_pres = test.rdg_pres;
                                        billdelete.rdg_prev = test.rdg_prev;
                                        billdelete.remarks = remarks;
                                        billdelete.volume = test.volume;
                                        bcontext.tbBillingDeletes.AddObject(billdelete);
                                        bcontext.SaveChanges();
                                    }
                                    MessageBox.Show("Bill Entry has been deleted successfully.");
                                    setGridDataSource();
                                }
                            }
                            else if (rest == DialogResult.Abort)
                            {
                                MessageBox.Show("Aborted");
                            }                                                      
                         }
                     }
                }
                else
                {
                    MessageBox.Show("Incorrect password. Access Denied.");
                }
            }
            //tbBillingDetail test =  (tbBillingDetail)tbBillingDetailBindingSource.Current;           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                //var query = (from en in context.tbmasters
                //             where en.zone_id == 62
                //             select en);

                //foreach (var drow in query)
                //{
                //    setdata(drow.master_id);
                //}
                var query = (from en in context.tbMasters
                             where en.status.Length <= 0
                             select en);

                foreach (var drow in query)
                {
                    drow.status = null;
                }
                context.SaveChanges();
                MessageBox.Show("Set data done");
            }
        }

        private void setData(int master_id)
        {
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                tbMasterAcct query = (from en in context.tbMasterAccts
                                      where en.master_id == master_id
                                      select en).Single();
                query.IFCurrentPayMonth = 0;
                query.IFPayableMonths = 12;
                query.IFAmount = 2500;
                query.IFBalance = 1800;
                query.IFDownpayment = 700;
                query.IFMonthlyPay = 150;
                query.isIF = true;
                context.SaveChanges();
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            formViewBillYellow frmYellow = new formViewBillYellow();
            frmYellow.ShowDialog();
        }

        private void cmbBilling_Validating(object sender, CancelEventArgs e)
        {
            if ((cmbBilling.Text.Length > 0) && (cmbZone.Text.Length > 0))
            {
                btnLoad.Show();
            }
            else
            {
                btnLoad.Hide();
            }
        }

        private void cmbBilling_Validated(object sender, EventArgs e)
        {
            if ((cmbBilling.Text.Length > 0) && (cmbZone.Text.Length > 0))
            {
                btnLoad.Show();
            }
            else
            {
                btnLoad.Hide();
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            using (dbCommercialEntities context = new dbCommercialEntities())
            {

                decimal mtrMtn = new GlobalFunctions().getMeterMtn();

                
                foreach (tbBillingDetail billrec in tbBillingDetailBindingSource)
                {
                    decimal curr = 0;
                    int sr_id = 0;
                    // compute penalty
                    curr = (decimal)billrec.current;
                   DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
                   billrec.penalty = globFunc.computePenalty(curr);
                    // penalty

                    // check status if R,N then set to null

                    string status = "";
                    try
                    {
                        var query = (from en in context.tbMasters
                                     select en).First(b => b.master_id == billrec.master_id);
                        status = query.status.Trim();
                    }
                    catch { }
                    if (status.Equals("R") || status.Equals("N"))
                    {
                        status = null;
                    }
                    else if (status.Length <= 0) { status = null; }
                    // status R,N

                    // update tbMaster
                    updateMaster((int)billrec.master_id, status, (DateTime)billrec.date_pres);
                    // tbMaster                 

                    // update tbMasterAcct
                    updateMasterAccts(billrec);
                    // tbMasterAcct

                    //Save to ledger
                    saveToLedger(billrec, mtrMtn);
                    //ledger



                    // create SR
                    string rem = billrec.remarks.Trim();
                    if (!rem.Equals("OK") && rem.Length > 0)
                    {
                        sr_id = makeServiceRequest(rem, billrec, string.Format("Billfile_{0}-{1}", strBillPeriod, strBillZone));
                        billrec.sr_id = sr_id;
                    }
                    // SR
                } // foreach

                tbBillProcessing billfile = context.tbBillProcessings.First(i => i.bill_process_id == billproc_id);
                billfile.date_checked = DateTime.Now;
                billfile.checked_by = (byte)userID;
                tbBillingDetailBindingSource.EndEdit();
                dbContext.SaveChanges();
                context.SaveChanges();
            } //using
        }  // backgroundworker2

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressPanel2.Hide();
            MessageBox.Show("Billfile has been finalized.");
            Close();
            
        }     

        private void centerToForm(Control control)
        {
            control.Left = (this.Width - control.Width) / 2;
            control.Top = (this.Height - control.Height) / 2;
        }

        private void btnSR_Click(object sender, EventArgs e)
        {
            if (tbBillingDetailBindingSource.Count > 0)
            {
                tbBillingDetail dataRow = (tbBillingDetail)tbBillingDetailBindingSource.Current;
                if (dataRow != null)
                {
                    int masterID = Int32.TryParse(dataRow.master_id.ToString(), out masterID) ? masterID : 0;
                    billdetails_id = dataRow.billingdetails_id;
                    if (masterID > 0)
                    {
                        //labelSRAccntNo.Text = dataRow.tbMaster.acctno;
                        //labelSRName.Text = dataRow.tbMaster.name;
                        centerToForm(groupBox2);
                        groupBox2.Show();
                        cmbSRCodes.SelectedIndex = 23;
                    }
                }
            }
        }

        private void fillSRCodes()
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = (from en in dbcontext.tbServiceRequestCodes
                             select en.code_desc);
                if (query != null)
                {
                    cmbSRCodes.Items.AddRange(query.ToArray());
                }
            }

        }

        private void btnSRCancel_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
        }

        private void btnSROk_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities srcontext = new dbCommercialEntities())
            {
                tbBillingDetail srquery = (from en in srcontext.tbBillingDetails
                                           where en.billingdetails_id == billdetails_id
                                           select en).SingleOrDefault();
                if (srquery != null)
                {
                    srquery.remarks = cmbSRCodes.Text;                    
                }
                srcontext.SaveChanges();
            }
            groupBox2.Hide();
            setGridDataSource();
        }



    }  // end class
} //end namespace
