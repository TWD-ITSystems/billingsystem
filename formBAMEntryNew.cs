using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;

namespace BillingSystem
{
    public partial class formBAMEntryNew : Form
    {
        public int userID = 0;
        const string DATAUSER = "commsys";
        const string DATAPASS = "comm123";
        const string DATABASE = "dbCommercial";
        string SERVER ="";

        GlobalFunctions globfunc = new GlobalFunctions();
        const int ERROR_IN_READING=14;
        int master_id = 0;
        int bam_id = 0;
        
        public formBAMEntryNew()
        {
            InitializeComponent();
        }

        private void formBAMEntryNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBAMCases.tbBAMCases' table. You can move, or remove it, as needed.
            this.tbBAMCasesTableAdapter.Fill(this.dsBAMCases.tbBAMCases);
            SERVER = ConfigurationManager.ConnectionStrings["ServerNew"].ConnectionString; 

            txDate.Text = string.Format("{0:d}", DateTime.Today);
            txBAMNo.Text = getBAMNo();
            comboBAMCase.DroppedDown = true;
        }

       private bool checkBillMonth()
       {
            string searchStr = txBillMonth.Text.Trim();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var checkmonth = dbcontext.tbBillings.FirstOrDefault(x => x.billing_desc.Equals(searchStr));
                return checkmonth == null ? false : true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acct_title = "";
            string acct_code = "";
            decimal amt = 0;

            if (txAcctNo.TextLength == 0)
            {
                MessageBox.Show("Please indicate Account Number.");
            }
            else
            {
                using (formAddJournalEntry frmAddJournal = new formAddJournalEntry())
                {
                    if (frmAddJournal.ShowDialog() == DialogResult.OK)
                    {
                        acct_title = frmAddJournal.AcctTitle;
                        acct_code = frmAddJournal.AcctCode;
                        amt = frmAddJournal.AcctAmount;
                        ListViewItem lv1 = new ListViewItem(acct_title);
                        lv1.SubItems.Add(acct_code);
                        if (acct_code.Substring(0, 2).Equals("CM"))
                        {
                            lv1.SubItems.Add(string.Empty);
                        }
                        lv1.SubItems.Add(string.Format("{0:g}", amt));
                        listView1.Items.Add(lv1);
                        getTotal();
                    }
                }
            }
        }
        
        private void txAcctNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txTotalCredit.Clear();
                txTotalDebit.Clear();
                txConcessioner.Clear();
                txZoneNo.Clear();
                txCardNo.Clear();
                txReading.Clear();
                int bamcase = (int)comboBAMCase.SelectedValue;
                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    var queryAcct = dbcontext.tbMasters.Where(x => x.acctno == txAcctNo.Text.Trim()).FirstOrDefault();
                    if (queryAcct != null)
                    {
                        txConcessioner.Text = queryAcct.name.Trim();
                        txZoneNo.Text = globfunc.getZoneName(queryAcct.zone_id);
                        txCardNo.Text = queryAcct.cardno.ToString();
                        master_id = queryAcct.master_id;
                        btnAddJournal.Enabled = true;
                        if (bamcase == ERROR_IN_READING)
                        {
                            txReading.Enabled = true;
                            btnEditReading.Enabled = true;
                            string lastReading = TextPrompt.ShowDialog("Please input last reading", "Error in Reading");
                            int newReading = Int32.TryParse(lastReading, out newReading) ? newReading : 0;
                            if (newReading > 0) txReading.Text = newReading.ToString();

                        }
                        else
                        {
                            txReading.Enabled = false;
                            btnEditReading.Enabled = false;
                        }
                        txExplanation.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Account No. not found. Please try again.");
                        txAcctNo.SelectAll();
                        btnAddJournal.Enabled = false;
                    }
                }

            }
            
        }

        private void comboBAMCase_KeyPress(object sender, KeyPressEventArgs e)
        {
            txAcctNo.Focus();
        }

        private void btnEditReading_Click(object sender, EventArgs e)
        {
            string lastReading = TextPrompt.ShowDialog("Please input last reading", "Error in Reading");
            int newReading = Int32.TryParse(lastReading, out newReading) ? newReading : 0;
            if (newReading > 0) txReading.Text = newReading.ToString();
        }

        private string getBAMNo()
        {
            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month;
            int numDays = DateTime.DaysInMonth(year,month);
            DateTime monthStart = new DateTime(year,month,1);
            DateTime monthEnd = new DateTime(year,month,numDays);
            int countBAM_entries=0;

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                countBAM_entries = dbcontext.tbBAMEntries.Where(x => x.bam_date >= monthStart && x.bam_date <= monthEnd).Count();
            }
            return string.Format("{0:yy}{1:MM}{2:0000}", DateTime.Today, DateTime.Today, countBAM_entries + 1);
        }

        private void getTotal()
        {
            decimal total_credit = 0;
            decimal total_debit = 0;
            foreach (ListViewItem lv in listView1.Items)
            {
                decimal credit = 0;
                decimal debit = decimal.TryParse(lv.SubItems[2].Text, out debit) ? debit : 0;
                if (lv.SubItems.Count == 4)
                {
                    credit = decimal.TryParse(lv.SubItems[3].Text, out credit) ? credit : 0;
                    
                }
                total_debit += debit;
                total_credit += credit;
            }
            txTotalCredit.Text = string.Format("{0:n}",total_credit);
            txTotalDebit.Text = string.Format("{0:n}", total_debit);
            btnSave.Enabled = (total_credit == 0) && (total_debit == 0) ? false : true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            txTotalDebit.Clear();
            txTotalCredit.Clear();
            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text.Equals("Close"))
            {
                Close();
            }
            else
            {
                if ((txTotalCredit.TextLength == 0) && (txTotalDebit.TextLength == 0))
                {
                    MessageBox.Show("Please add journal entry to proceed.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you really want to save this record? \r Please check the BAM Case first before saving.", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                        {
                            tbBAMEntry BAM_entry = new tbBAMEntry();

                            BAM_entry.acctno = txAcctNo.Text;
                            BAM_entry.acctname = txConcessioner.Text.Trim();
                            BAM_entry.bam_date = DateTime.Today;
                            BAM_entry.bamno = txBAMNo.Text;
                            BAM_entry.bamcase_id = (int)comboBAMCase.SelectedValue;
                            BAM_entry.cardno = txCardNo.Text;
                            BAM_entry.zoneno = txZoneNo.Text;
                            BAM_entry.explanation = txExplanation.Text;
                            if (txReading.TextLength > 0)
                            {
                                BAM_entry.last_reading = Convert.ToInt32(txReading.Text);
                            }
                            BAM_entry.billmonth = txBillMonth.Text;
                            BAM_entry.cum_as_billed = txCumBilled.Text;
                            BAM_entry.cum_should_be = txCumShould.Text;
                            BAM_entry.cum_adjustment = txCumCorrected.Text;
                            BAM_entry.master_id = master_id;
                            decimal total_debit = decimal.TryParse(txTotalDebit.Text, out total_debit) ? total_debit : 0;
                            decimal total_credit = decimal.TryParse(txTotalCredit.Text, out total_credit) ? total_credit : 0;
                            BAM_entry.debit = total_debit;
                            BAM_entry.credit = total_credit;
                            BAM_entry.prepared_by_id = userID;
                            dbcontext.AddTotbBAMEntries(BAM_entry);
                            dbcontext.SaveChanges();
                            var id = BAM_entry.bamdetail_id;
                            foreach (ListViewItem lv in listView1.Items)
                            {
                                tbBAMJournalEntry journal = new tbBAMJournalEntry();
                                journal.bam_id = id;
                                journal.account_title = lv.SubItems[0].Text;
                                journal.account_code = lv.SubItems[1].Text;
                                if (lv.SubItems[1].Text.Substring(0, 2).Equals("CM"))
                                {
                                    journal.amt_debit = 0;
                                    journal.amt_credit = Convert.ToDecimal(lv.SubItems[3].Text);
                                }
                                else
                                {
                                    journal.amt_debit = Convert.ToDecimal(lv.SubItems[2].Text);
                                    journal.amt_credit = 0;
                                }
                                dbcontext.AddTotbBAMJournalEntries(journal);
                            }
                            bam_id = id;
                            dbcontext.SaveChanges();

                            ArrayList paramArr = new ArrayList();
                            paramArr.Add(globfunc.getDeptDivHead(6));
                            paramArr.Add(string.Format("{0}-{1} Division", globfunc.getDeptDivHeadDescription(6), globfunc.getDeptName(6)));
                            paramArr.Add(bam_id);

                            rptBAM rptbam = new rptBAM();
                            rptbam.DataSourceConnections.Clear();
                            rptbam.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                            rptbam.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                            rptbam.SetParameterValue("paramApproved", paramArr[0]);
                            rptbam.SetParameterValue("paramDesignation", paramArr[1]);
                            rptbam.SetParameterValue("paramBamid", paramArr[2]);
                            rptbam.PrintToPrinter(1, false, 1, 1);

                            MessageBox.Show("BAM is saved successfully. Currently Printing..");
                            Close();
                        }
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ArrayList paramArr = new ArrayList();

            paramArr.Add(globfunc.getDeptDivHead(6));
            paramArr.Add(string.Format("{0}-{1} Division",globfunc.getDeptDivHeadDescription(6),globfunc.getDeptName(6)));
            paramArr.Add(bam_id);
            using (frmReport frmRpt = new frmReport())
            {
                frmRpt.param = paramArr;
                frmRpt.rptMode = 24;
                frmRpt.ShowDialog();
            }
        }
        
    }
}
