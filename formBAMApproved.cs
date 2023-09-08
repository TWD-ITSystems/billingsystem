using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BillingSystem
{
    public partial class formBAMApproved : Form
    {
        public int bamdetail_id = 0;
        public int userID = 0;

        const int ERROR_IN_READING = 14;

        GlobalFunctions globfunc = new GlobalFunctions();
        int formMode = 0;
        Boolean isBatchEntry = false;

        public formBAMApproved()
        {
            InitializeComponent();
        }

        public formBAMApproved(int mode,string caption)
        {
            InitializeComponent();
            this.Text = caption;
            formMode = mode;
        }

        private Boolean checkBatchEntry(int bamdetail_id)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var batchCount = dbcontext.tbBAMBatchDetails.Where(x => x.bam_id == bamdetail_id);
                return batchCount.Count() > 0 ? true : false;
            }
        }


        private void formBAMApproved_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBAMEntries.vwBAMEntries' table. You can move, or remove it, as needed.
            this.vwBAMEntriesTableAdapter.FillByDetailID(this.dsBAMEntries.vwBAMEntries,bamdetail_id);
            this.tbBAMJournalEntryTableAdapter.FillByBAMID(this.dsBAMJournal.tbBAMJournalEntry, bamdetail_id);
            if (formMode == 1)
            {
                button1.Text = "Close";
            }
            isBatchEntry = checkBatchEntry(bamdetail_id);
            btnList.Visible = isBatchEntry;
            
        }

        private string getBAMTitle(int bamdetail_id)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                return dbcontext.tbBAMJournalEntries.Single(x => x.bam_id == bamdetail_id).account_title.ToUpper();
            }
        }

        private int getBAMCaseID(int bamdetail_id)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                return (int)dbcontext.tbBAMEntries.Single(x => x.bamdetail_id == bamdetail_id).bamcase_id;
            }
        }

        private void processBatchEntry(int bamdetail_id)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryBatch = dbcontext.tbBAMBatchDetails.Where(x => x.bam_id == bamdetail_id).Select(x=>x);
                foreach (tbBAMBatchDetail qDetails in queryBatch)
                {
                    string bamcode = qDetails.bam_code;
                    string bamno = qDetails.bam_no;
                    decimal amount = (decimal)qDetails.amount;
                    int masterID = (int)qDetails.master_id;
                    int code_id = globfunc.getBAMCodeID(bamcode);
                    int zone_uid = globfunc.getZoneUIDbyMaster(masterID);
                    string encoder = globfunc.getUserInitials(userID);
                    string ledger_code = "";
                    string title = getBAMTitle(bamdetail_id);

                    tbMasterAcct mast_acct = dbcontext.tbMasterAccts.Single(x => x.master_id == masterID);
                    decimal current = decimal.TryParse(mast_acct.bill_current.ToString(), out current) ? current : 0;
                    decimal arrears = decimal.TryParse(mast_acct.bill_arrears.ToString(), out arrears) ? arrears : 0;
                    decimal penalty = decimal.TryParse(mast_acct.penalty.ToString(), out penalty) ? penalty : 0;
                    decimal balance = decimal.TryParse(mast_acct.bill_balance.ToString(), out balance) ? balance : 0;
                    decimal if_balance = decimal.TryParse(mast_acct.IFBalance.ToString(), out if_balance) ? if_balance : 0;
                    decimal dm_balance = decimal.TryParse(mast_acct.MtrDmg_Balance.ToString(), out dm_balance) ? dm_balance : 0;

                    tbLedger ledger = new tbLedger();
                    ledger.master_id = masterID;
                    ledger.zoneuid = zone_uid;
                    ledger.trans_date = DateTime.Today;
                    ledger.@ref = bamno;
                    ledger.encoder = encoder;

                  

                    switch (code_id)
                    {
                        case 1: // CMWS
                        case 3: // CMAR

                            if (title.Equals("ARREARS"))
                            {
                                arrears -= amount;
                            }
                            else if (title.Equals("CURRENT"))
                            {
                                current -= amount;
                            }
                            balance -= amount;
                            ledger_code = code_id == 1 ? "CMWS" : "CMAR";

                            if (getBAMCaseID(bamdetail_id) == ERROR_IN_READING)
                            {
                                MessageBox.Show("Error in Reading case is not supported in batch entry");
                                Close();
                            }
                            ledger.symbol = "-";
                            ledger.code = ledger_code;
                            ledger.amount = amount;
                            ledger.balance = balance;
                            break;
                        case 2:  // CMPN
                            arrears -= amount;
                            balance -= amount;

                            ledger_code = "CMPN";
                            ledger.code = ledger_code;
                            ledger.symbol = "+";
                            ledger.amount = amount;
                            ledger.balance = balance;
                            break;
                        case 4:  // DMWS
                        case 5:  // DMAR
                            if (title.Equals("ARREARS"))
                            {
                                arrears += amount;
                            }
                            else if (title.Equals("CURRENT"))
                            {
                                current += amount;
                            }
                            balance += amount;
                            ledger_code = code_id == 4 ? "DMWS" : "DMAR";
                            ledger.symbol = "+";
                            ledger.code = ledger_code;
                            ledger.amount = amount;
                            ledger.balance = balance;
                            break;
                        case 6: //DMPN
                            arrears += amount;
                            balance += amount;
                            ledger_code = "DMPN";
                            ledger.code = ledger_code;
                            ledger.symbol = "+";
                            ledger.amount = amount;
                            ledger.balance = balance;
                            break;
                        case 7: // DMIF
                            arrears += amount;
                            balance += amount;
                            ledger_code = "DMIF";
                            ledger.code = ledger_code;
                            ledger.symbol = "+";
                            ledger.amount = amount;
                            ledger.balance = balance;
                            break;
                        case 8: // CMIFpd
                            if_balance -= amount;
                            ledger_code = "IFpd";
                            ledger.symbol = "-";
                            ledger.code = ledger_code;
                            ledger.other = amount;
                            mast_acct.IFBalance = if_balance;
                            break;
                        case 9: //DMIFpd
                            if_balance += amount;
                            ledger_code = "IF";
                            ledger.symbol = "+";
                            ledger.code = ledger_code;
                            ledger.other = amount;
                            mast_acct.IFBalance = if_balance;
                            break;
                        case 10: //CMRFEE
                            ledger_code = "CMRFee";
                            ledger.symbol = "-";
                            ledger.code = ledger_code;
                            ledger.other = amount;
                            break;
                        case 11: //DMRFee
                            ledger_code = "DMRFee";
                            ledger.symbol = "+";
                            ledger.code = ledger_code;
                            ledger.other = amount;
                            break;
                        case 12: //CMIF
                            ledger_code = "CMIF";
                            ledger.symbol = "-";
                            ledger.code = ledger_code;
                            ledger.other = amount;
                            break;
                        case 13: //DMTR    Damage Meter
                            dm_balance += amount;
                            ledger_code = "DMTR";
                            ledger.symbol = "+";
                            ledger.code = ledger_code;
                            ledger.other = amount;
                            mast_acct.MtrDmg_Balance = dm_balance;
                            break;
                        case 14:  //
                            dm_balance -= amount;
                            ledger_code = "DMpd";
                            ledger.symbol = "-";
                            ledger.code = ledger_code;
                            ledger.other = amount;
                            mast_acct.MtrDmg_Balance = dm_balance;
                            break;

                        case 15: // IF Refund to water sales
                            if (mast_acct.IFBalance > 0)
                            {
                                if_balance -= amount;
                            }
                            else if (mast_acct.IFBalance < 0)
                            {
                                if_balance += amount;
                            }
                            else if (mast_acct.IFBalance == 0)
                            {
                                MessageBox.Show("Unable to refund. Insufficient IF Balance");
                                break;
                            }
                            ledger_code = "CMIFref";
                            ledger.symbol = "-";
                            ledger.code = ledger_code;
                            ledger.other = amount;
                            mast_acct.IFBalance = if_balance;
                            decimal salin_sa_arrears = 0;
                            decimal salin_sa_current = 0;
                            decimal mtrmtn = globfunc.getMeterMtn();

                            if (mast_acct.bill_balance <= 0)
                            {
                                mast_acct.bill_balance -= amount;
                            }
                            else
                            {
                                if (mast_acct.bill_arrears > 0)
                                {
                                    if (mast_acct.bill_arrears > amount)
                                    {
                                        mast_acct.bill_arrears -= amount;
                                        mast_acct.arrears_curr_yr -= amount;
                                    }
                                    else
                                    {
                                        salin_sa_arrears = amount - Convert.ToDecimal(mast_acct.bill_arrears);
                                        mast_acct.bill_arrears = 0;
                                        mast_acct.arrears_curr_yr = 0;
                                    }
                                }

                                if (mast_acct.bill_current > 0)
                                {
                                    if ((mast_acct.bill_current + mtrmtn) > amount)
                                    {
                                        mast_acct.bill_current -= amount;
                                    }
                                    else
                                    {
                                        salin_sa_current = amount - (Convert.ToDecimal(mast_acct.bill_current) + mtrmtn);
                                        mast_acct.bill_current = 0;
                                    }
                                }
                                mast_acct.bill_balance -= amount;
                                ledger.balance = mast_acct.bill_balance;
                            }
                            break;
                        case 16: // CMTFEE
                            ledger_code = "CMTFee";
                            ledger.symbol = "-";
                            ledger.code = ledger_code;
                            ledger.other = amount;
                            break;
                        case 17: // DMTFEE
                            ledger_code = "DMTFee";
                            ledger.symbol = "+";
                            ledger.code = ledger_code;
                            ledger.other = amount;
                            break;
                    }
                    ledger.remarks = string.Format("BAM #{0}", bamno);
                    if (code_id <= 7)
                    {
                        mast_acct.arrears_curr_yr = arrears;
                        mast_acct.bill_arrears = arrears;
                        mast_acct.bill_current = current;
                        mast_acct.bill_balance = balance;
                    }

                    dbcontext.AddTotbLedgers(ledger);




                }


                tbBAMEntry bam = dbcontext.tbBAMEntries.FirstOrDefault(x => x.bamdetail_id == bamdetail_id);
                bam.approved_by_id = userID;
                bam.approved_date = DateTime.Today;
                bam.processed = true;
                dbcontext.SaveChanges();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formMode == 1)
            {
                Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you really want to approve this BAM?", "Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (isBatchEntry)
                    {
                        string test = "meow";
                        processBatchEntry(bamdetail_id);
                    }
                    else
                    {

                        using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                        {
                            decimal current = 0;
                            decimal arrears = 0;
                            decimal penalty = 0;
                            decimal balance = 0;
                            decimal if_balance = 0;
                            decimal dm_balance = 0;
                            int last_reading = 0;
                            int masterID = Convert.ToInt32(txMasterID.Text);



                            tbMasterAcct mast_acct = dbcontext.tbMasterAccts.Single(x => x.master_id == masterID);
                            current = decimal.TryParse(mast_acct.bill_current.ToString(), out current) ? current : 0;
                            arrears = decimal.TryParse(mast_acct.bill_arrears.ToString(), out arrears) ? arrears : 0;
                            penalty = decimal.TryParse(mast_acct.penalty.ToString(), out penalty) ? penalty : 0;
                            balance = decimal.TryParse(mast_acct.bill_balance.ToString(), out balance) ? balance : 0;
                            if_balance = decimal.TryParse(mast_acct.IFBalance.ToString(), out if_balance) ? if_balance : 0;
                            dm_balance = decimal.TryParse(mast_acct.MtrDmg_Balance.ToString(), out dm_balance) ? dm_balance : 0;

                            string bam_no = bamnoTextEdit.Text;
                            int bamcase_id = Convert.ToInt32(bamcase_idSpinEdit.Text);
                            last_reading = Int32.TryParse(last_readingSpinEdit.Text, out last_reading) ? last_reading : 0;
                            int zone_uid = globfunc.getZoneUID(zonenoTextEdit.Text);
                            string encoder = globfunc.getUserInitials(userID);
                            string remarks = string.Format("Encoded on {0:d}", bam_dateDateEdit.Text);


                            foreach (DataGridViewRow dr in dataGridView1.Rows)
                            {
                                // dr.Cells[1].Value.ToString()
                                string code = dr.Cells[1].Value.ToString();
                                string title = dr.Cells[0].Value.ToString().ToUpper();
                                int code_id = globfunc.getBAMCodeID(code);
                                decimal amount = 0;
                                string ledger_code = "";


                                tbLedger ledger = new tbLedger();
                                ledger.master_id = masterID;
                                ledger.zoneuid = zone_uid;
                                ledger.trans_date = DateTime.Today;
                                ledger.@ref = bam_no;
                                ledger.encoder = encoder;
                                ledger.remarks = remarks;

                                if (code.Substring(0, 2).Equals("CM"))
                                {
                                    amount = decimal.TryParse(dr.Cells[3].Value.ToString(), out amount) ? amount : 0;
                                }
                                else
                                {
                                    amount = decimal.TryParse(dr.Cells[2].Value.ToString(), out amount) ? amount : 0;
                                }

                                switch (code_id)
                                {
                                    case 1: // CMWS
                                    case 3: // CMAR
                                        if (title.Equals("ARREARS"))
                                        {
                                            arrears -= amount;
                                        }
                                        else if (title.Equals("CURRENT"))
                                        {
                                            current -= amount;
                                        }
                                        balance -= amount;
                                        ledger_code = code_id == 1 ? "CMWS" : "CMAR";

                                        if (bamcase_id == ERROR_IN_READING)
                                        {
                                            ledger.presrdg = last_reading;
                                        }
                                        ledger.symbol = "-";
                                        ledger.code = ledger_code;
                                        ledger.amount = amount;
                                        ledger.balance = balance;
                                        break;
                                    case 2:  // CMPN
                                        arrears -= amount;
                                        balance -= amount;

                                        ledger_code = "CMPN";
                                        ledger.code = ledger_code;
                                        ledger.symbol = "+";
                                        ledger.amount = amount;
                                        ledger.balance = balance;
                                        break;
                                    case 4:  // DMWS
                                    case 5:  // DMAR
                                        if (title.Equals("ARREARS"))
                                        {
                                            arrears += amount;
                                        }
                                        else if (title.Equals("CURRENT"))
                                        {
                                            current += amount;
                                        }
                                        balance += amount;
                                        ledger_code = code_id == 4 ? "DMWS" : "DMAR";
                                        ledger.symbol = "+";
                                        ledger.code = ledger_code;
                                        ledger.amount = amount;
                                        ledger.balance = balance;
                                        break;
                                    case 6: //DMPN
                                        arrears += amount;
                                        balance += amount;
                                        ledger_code = "DMPN";
                                        ledger.code = ledger_code;
                                        ledger.symbol = "+";
                                        ledger.amount = amount;
                                        ledger.balance = balance;
                                        break;
                                    case 7: // DMIF
                                        arrears += amount;
                                        balance += amount;
                                        ledger_code = "DMIF";
                                        ledger.code = ledger_code;
                                        ledger.symbol = "+";
                                        ledger.amount = amount;
                                        ledger.balance = balance;
                                        break;
                                    case 8: // CMIFpd
                                        if_balance -= amount;
                                        ledger_code = "IFpd";
                                        ledger.symbol = "-";
                                        ledger.code = ledger_code;
                                        ledger.other = amount;
                                        mast_acct.IFBalance = if_balance;
                                        break;
                                    case 9: //DMIFpd
                                        if_balance += amount;
                                        ledger_code = "IF";
                                        ledger.symbol = "+";
                                        ledger.code = ledger_code;
                                        ledger.other = amount;
                                        mast_acct.IFBalance = if_balance;
                                        break;
                                    case 10: //CMRFEE
                                        ledger_code = "CMRFee";
                                        ledger.symbol = "-";
                                        ledger.code = ledger_code;
                                        ledger.other = amount;
                                        break;
                                    case 11: //DMRFee
                                        ledger_code = "DMRFee";
                                        ledger.symbol = "+";
                                        ledger.code = ledger_code;
                                        ledger.other = amount;
                                        break;
                                    case 12: //CMIF
                                        ledger_code = "CMIF";
                                        ledger.symbol = "-";
                                        ledger.code = ledger_code;
                                        ledger.other = amount;
                                        break;
                                    case 13: //DMTR    Damage Meter
                                        dm_balance += amount;
                                        ledger_code = "DMTR";
                                        ledger.symbol = "+";
                                        ledger.code = ledger_code;
                                        ledger.other = amount;
                                        mast_acct.MtrDmg_Balance = dm_balance;
                                        break;
                                    case 14:  //
                                        dm_balance -= amount;
                                        ledger_code = "DMpd";
                                        ledger.symbol = "-";
                                        ledger.code = ledger_code;
                                        ledger.other = amount;
                                        mast_acct.MtrDmg_Balance = dm_balance;
                                        break;

                                    case 15: // IF Refund to water sales
                                        if (mast_acct.IFBalance > 0)
                                        {
                                            if_balance -= amount;
                                        }
                                        else if (mast_acct.IFBalance < 0)
                                        {
                                            if_balance += amount;
                                        }
                                        else if (mast_acct.IFBalance == 0)
                                        {
                                            MessageBox.Show("Unable to refund. Insufficient IF Balance");
                                            break;
                                        }
                                        ledger_code = "CMIFref";
                                        ledger.symbol = "-";
                                        ledger.code = ledger_code;
                                        ledger.other = amount;
                                        mast_acct.IFBalance = if_balance;
                                        decimal salin_sa_arrears = 0;
                                        decimal salin_sa_current = 0;
                                        decimal mtrmtn = globfunc.getMeterMtn();

                                        if (mast_acct.bill_balance <= 0)
                                        {
                                            mast_acct.bill_balance -= amount;
                                        }
                                        else
                                        {
                                            if (mast_acct.bill_arrears > 0)
                                            {
                                                if (mast_acct.bill_arrears > amount)
                                                {
                                                    mast_acct.bill_arrears -= amount;
                                                    mast_acct.arrears_curr_yr -= amount;
                                                }
                                                else
                                                {
                                                    salin_sa_arrears = amount - Convert.ToDecimal(mast_acct.bill_arrears);
                                                    mast_acct.bill_arrears = 0;
                                                    mast_acct.arrears_curr_yr = 0;
                                                }
                                            }

                                            if (mast_acct.bill_current > 0)
                                            {
                                                if ((mast_acct.bill_current + mtrmtn) > amount)
                                                {
                                                    mast_acct.bill_current -= amount;
                                                }
                                                else
                                                {
                                                    salin_sa_current = amount - (Convert.ToDecimal(mast_acct.bill_current) + mtrmtn);
                                                    mast_acct.bill_current = 0;
                                                }
                                            }
                                            mast_acct.bill_balance -= amount;
                                            ledger.balance = mast_acct.bill_balance;
                                        }
                                        break;
                                    case 16: // CMTFEE
                                        ledger_code = "CMTFee";
                                        ledger.symbol = "-";
                                        ledger.code = ledger_code;
                                        ledger.other = amount;
                                        break;
                                    case 17: // DMTFEE
                                        ledger_code = "DMTFee";
                                        ledger.symbol = "+";
                                        ledger.code = ledger_code;
                                        ledger.other = amount;
                                        break;
                                }
                                ledger.remarks = string.Format("BAM #{0}", bam_no);
                                if (code_id <= 7)
                                {
                                    mast_acct.arrears_curr_yr = arrears;
                                    mast_acct.bill_arrears = arrears;
                                    mast_acct.bill_current = current;
                                    mast_acct.bill_balance = balance;
                                }

                                dbcontext.AddTotbLedgers(ledger);
                            }

                            tbBAMEntry bam = dbcontext.tbBAMEntries.FirstOrDefault(x => x.bamdetail_id == bamdetail_id);
                            bam.approved_by_id = userID;
                            bam.approved_date = DateTime.Today;
                            bam.processed = true;
                            dbcontext.SaveChanges();
                        }
                    }
                    MessageBox.Show("BAM is successfully approved");
                    Close();
                }
            }
        }

        private string getBAMPreparedBy(int bamdetail_id)
        {
            using(dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                int userID = (int)dbcontext.tbBAMEntries.Single(x => x.bamdetail_id == bamdetail_id).prepared_by_id;
                return globfunc.getUserFullName(userID);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ArrayList param = new ArrayList();


           
           param.Add(getBAMPreparedBy(bamdetail_id));
           param.Add(bamdetail_id);
            

            frmReport frmRpt = new frmReport();
            frmRpt.rptMode = 29;
            frmRpt.param = param;
            frmRpt.Show();
        }

    }
}
