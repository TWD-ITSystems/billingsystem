using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BillingSystem
{
    public partial class frmBAMBatchEntry : Form
    {
        public int userID = 0;
        public string userInitials = "";
        private GlobalFunctions gfunc = new GlobalFunctions();
        decimal totalAmount = 0;
        int bamEntryID = 0;
        decimal debitTotal, creditTotal;
        List<string> addList = new List<string>();

        public frmBAMBatchEntry()
        {
            InitializeComponent();
        }

        private void frmBAMBatchEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBAMLookup.tbBAMLookup' table. You can move, or remove it, as needed.
            this.tbBAMLookupTableAdapter.Fill(this.dsBAMLookup.tbBAMLookup);
            // TODO: This line of code loads data into the 'dsBAMCases.tbBAMCases' table. You can move, or remove it, as needed.
            this.tbBAMCasesTableAdapter.Fill(this.dsBAMCases.tbBAMCases);
            txtBAMNo.Text = getBAMNo();

        }

        private string getBAMNo()
        {
            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month;
            int numDays = DateTime.DaysInMonth(year, month);
            DateTime monthStart = new DateTime(year, month, 1);
            DateTime monthEnd = new DateTime(year, month, numDays);
            int countBAM_entries = 0;

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                countBAM_entries = dbcontext.tbBAMEntries.Where(x => x.bam_date >= monthStart && x.bam_date <= monthEnd).Count();
            }
            return string.Format("{0:yy}{1:MM}{2:0000}", DateTime.Today, DateTime.Today, countBAM_entries + 1);
        }

        private void txAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAddToList.Focus();
            }
        }

        private void txtAcctno_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                txAmount.Focus();
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            string name = gfunc.getAcctName(txtAcctno.Text);
            int masterID = gfunc.getMasterID(txtAcctno.Text);
            if (name.Length <= 0)
            {
                MessageBox.Show("Account not found");
            }
            else
            {
                if (addList.Contains(txtAcctno.Text))
                {
                    MessageBox.Show("Account already added to list.");
                }else
                {
                    GridViewDataRowInfo dataRowInfo = new GridViewDataRowInfo(this.radGridView1.MasterView);
                    dataRowInfo.Cells[0].Value = false;
                    dataRowInfo.Cells[1].Value = txtAcctno.Text;
                    dataRowInfo.Cells[2].Value = name;
                    dataRowInfo.Cells[3].Value = comboCode.Text;
                    decimal amt = Convert.ToDecimal(txAmount.Text);
                    dataRowInfo.Cells[4].Value = string.Format("{0:0.00}", amt);
                    dataRowInfo.Cells[5].Value = masterID;
                    radGridView1.Rows.Insert(0, dataRowInfo);
                    getTotal();
                    addList.Add(txtAcctno.Text);
                }
            }
            txtAcctno.Clear();
            txAmount.Text = "0";
            txtAcctno.Focus();
        }

        private void getTotal()
        {
            decimal totalAll = radGridView1.Rows.Sum(x => decimal.Parse(x.Cells[4].Value.ToString()));
            label7.Text = string.Format("{0:0.00}",totalAll);
            totalAmount = totalAll;
            if (radGridView1.Rows.Count > 0)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowcount = radGridView1.Rows.Count();
            for (int i = rowcount; i > 0; i--)
            {
                if (radGridView1.Rows[i - 1].Cells[0].Value.Equals(true))
                {                    
                    radGridView1.Rows[i - 1].Delete();
                    getTotal();
                }
            }
        }

        private int saveBAMEntry()
        {            
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbBAMEntry bamData = new tbBAMEntry();
                bamData.bam_date = DateTime.Today;
                bamData.explanation = txtExplanation.Text;
                bamData.bamno =getBAMNo();
                bamData.bamcase_id = (int)comboBox1.SelectedValue;
                bamData.acctname = "Batch Entry";
                bamData.prepared_by_id = userID;

                debitTotal = radGridView1.Rows.Where(x => x.Cells[3].Value.ToString().StartsWith("DM")).Sum(x => decimal.Parse(x.Cells[4].Value.ToString()));
                creditTotal = radGridView1.Rows.Where(x => x.Cells[3].Value.ToString().StartsWith("CM")).Sum(x => decimal.Parse(x.Cells[4].Value.ToString()));

                bamData.debit = debitTotal>0?debitTotal:0;
                bamData.credit = creditTotal>0?creditTotal:0;


                dbcontext.AddTotbBAMEntries(bamData);
                dbcontext.SaveChanges();
                var id = bamData.bamdetail_id;
                return id;
            }
        }


        private void saveBAMDetails(int bamEntryID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbBAMJournalEntry bamJournal = new tbBAMJournalEntry();
                bamJournal.bam_id = bamEntryID;
                bamJournal.account_title = txAcctTitle.Text;
                bamJournal.account_code = comboCode.Text;
                bamJournal.amt_credit = creditTotal;
                bamJournal.amt_debit = debitTotal;

                dbcontext.AddTotbBAMJournalEntries(bamJournal);
                dbcontext.SaveChanges();
            }    
        }

        private void saveBAMBatchDetails(int bamEntryID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var bamData = radGridView1.Rows.Select(x => x);

                foreach(GridViewRowInfo rwData in bamData)
                {
                    tbBAMBatchDetail bamSave = new tbBAMBatchDetail();
                    bamSave.acctno = rwData.Cells[1].Value.ToString();
                    bamSave.bam_id = bamEntryID;
                    bamSave.bam_no = txtBAMNo.Text;
                    bamSave.bam_code = rwData.Cells[3].Value.ToString();
                    bamSave.amount = Convert.ToDecimal(rwData.Cells[4].Value.ToString());
                    bamSave.master_id = Convert.ToInt32(rwData.Cells[5].Value.ToString());

                    dbcontext.AddTotbBAMBatchDetails(bamSave);
                }
                dbcontext.SaveChanges();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dsResult = MessageBox.Show("Do you want to save this records?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dsResult == DialogResult.Yes)
            {
                try
                {
                    bamEntryID = saveBAMEntry();
                    saveBAMDetails(bamEntryID);
                    saveBAMBatchDetails(bamEntryID);
                    MessageBox.Show("BAM Entry is successfully saved");
                    Close();
                }catch{
                    MessageBox.Show("Error Saving BAM Entry.");
                }
               
            }
        }


    }
}
