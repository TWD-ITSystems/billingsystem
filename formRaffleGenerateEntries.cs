using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class formRaffleGenerateEntries : Form
    {
        public string username;
        GlobalFunctions gfunc = new GlobalFunctions();
        int raffleID = 0;
        int entry_count = 0;

        public formRaffleGenerateEntries()
        {
            InitializeComponent();
        }


        private void formRaffleGenerateEntries_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dbRafflePeriod.tbRafflePeriod' table. You can move, or remove it, as needed.
            this.tbRafflePeriodTableAdapter.Fill(this.dbRafflePeriod.tbRafflePeriod);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Proceed generating raffle entries?", "Raffe Entries", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                raffleID = Convert.ToInt32(raffle_periodComboBox.SelectedValue.ToString());               
                button1.Enabled = false;
                progressPanel1.Show();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<int> query = new List<int>();           
            using (dbCommercialEntities dbContext = new dbCommercialEntities())
            {
                query = dbContext.tbMasterAccts.Where(x => x.bill_balance <= 0).Select(x=>x.master_id).ToList();
            }
            using (dbRaffleEntities dContext = new dbRaffleEntities())
            {
                foreach (int masterID in query)
                {
                    string acctno = gfunc.getAcctNo(masterID);
                    string name = gfunc.getAcctName(acctno);
                    if (name.StartsWith("***") || name.TrimEnd().Equals("."))
                    {                       
                        continue;
                    }else
                    {
                        string status = gfunc.getStatus(masterID);
                        if (!status.Equals("X") || !status.Equals("E"))
                        {
                            tbRaffeEntry tEntry = new tbRaffeEntry();
                            tEntry.acctno = acctno;
                            tEntry.acctname = name.Trim();
                            tEntry.raffle_id = raffleID;
                            tEntry.added_by = username;
                            tEntry.added_date = DateTime.Today;
                            tEntry.master_id = masterID;
                            dContext.AddTotbRaffeEntries(tEntry);
                            entry_count++;
                        }                      
                    }
                }
                dContext.SaveChanges();
            }                    
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Raffle Entries is succesfully generated.");
            progressPanel1.Visible = false;
            button1.Enabled = true;
            using (dbRaffleEntities dContext = new dbRaffleEntities())
            {
                tbRafflePeriod rafflePeriod = dContext.tbRafflePeriods.Single(x => x.raffle_id == raffleID);
                rafflePeriod.qualified_entries = entry_count;
                rafflePeriod.generated_date = DateTime.Today;
                dContext.SaveChanges();
            }
        }
    }
}
 