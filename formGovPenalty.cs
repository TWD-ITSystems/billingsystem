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
    public partial class formGovPenalty : Form
    {
        public int userID = 0;

        GlobalFunctions global_func = new GlobalFunctions();

        public formGovPenalty()
        {
            InitializeComponent();
        }

        private void formGovPenalty_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dsZone.tbZone' table. You can move, or remove it, as needed.
            this.tbZoneTableAdapter.Fill(this.dsZone.tbZone);
        }

        private void formGovPenalty_Shown(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMaster.tbMaster' table. You can move, or remove it, as needed.
            this.tbMasterTableAdapter.Fill(this.dsMaster.tbMaster);
            toolStripStatusLabel1.Text = string.Format("No. of Records:{0}", tbMasterBindingSource.Count);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int zoneID = (int)comboZone.SelectedValue;
            this.tbMasterTableAdapter.FillByZone(this.dsMaster.tbMaster, zoneID);
            toolStripStatusLabel1.Text = string.Format("No. of Records:{0}", tbMasterBindingSource.Count);
            gridControl2.DataSource = null;
            label2.Text = "Ledger";
            label1.Text = string.Format("Zone : {0}", comboZone.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tbMasterTableAdapter.Fill(this.dsMaster.tbMaster);
            toolStripStatusLabel1.Text = string.Format("No. of Records:{0}", tbMasterBindingSource.Count);
            label1.Text = "Zone : ALL";
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int masterID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("master_id").ToString());
            string acctno = gridView1.GetFocusedRowCellValue("acctno").ToString();
            string name= gridView1.GetFocusedRowCellValue("name").ToString();
            //this.tbLedgerTableAdapter.Fill(this.dsLedger.tbLedger);
            this.tbLedgerTableAdapter.FillByMasterID(this.dsLedger.tbLedger, masterID);
            gridControl2.DataSource = dsLedger.tbLedger;
            if (tbLedgerBindingSource.Count == 0) MessageBox.Show(string.Format("No record/s found for {0}",name.TrimEnd()));
            label2.Text = string.Format("Ledger [Acct#-{0}] {1}", acctno, name);
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            int masterID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("master_id").ToString());
            int filteryear = Int32.TryParse(textBox1.Text,out filteryear)?filteryear:0;
            this.tbLedgerTableAdapter.FillByYear(this.dsLedger.tbLedger, masterID, filteryear);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnYear.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int masterID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("master_id").ToString());
            this.tbLedgerTableAdapter.FillByMasterID(this.dsLedger.tbLedger, masterID);
            textBox1.Clear();
        }

        private void penalizedThisBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = gridView2.GetFocusedRowCellValue("code").ToString().ToUpper();
            int masterID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("master_id").ToString());
            if (code.Equals("BILL"))
            {
                DialogResult dlgResult = MessageBox.Show("Do you want to penalize this bill?", "Penalty", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    string str_amt = gridView2.GetFocusedRowCellValue("amount").ToString();
                    decimal amount = Convert.ToDecimal(str_amt);
                    string str_oldbal = gridView2.GetFocusedRowCellValue("balance").ToString();
                    decimal oldbalance = Convert.ToDecimal(str_oldbal);
                    decimal mtrmtn = global_func.getMeterMtn();
                    decimal penalty_percent = global_func.getPenaltyPercent();
                    decimal penalty = 0;
                    decimal newbalance = 0;
                    string str_billingID = gridView2.GetFocusedRowCellValue("billing_id").ToString();
                    int billingID = Convert.ToInt32(str_billingID);
                    string encoder = global_func.getUserInitials(userID);
                    int zoneUID = global_func.getZoneUIDbyMaster(masterID);

                    if(!global_func.checkIfPenalized(billingID,masterID))  // check if Bill is penalized
                    {
                        if (amount > mtrmtn)
                        {
                            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                            {
                                tbMasterAcct mastacct = dbcontext.tbMasterAccts.SingleOrDefault(x => x.master_id == masterID);
                                decimal master_balance = Convert.ToDecimal(mastacct.bill_balance);

                                
                                penalty = global_func.roundOff((amount - mtrmtn) * (penalty_percent / 100));
                                string saveprompt = TextPrompt.ShowDialog("Do you want to impose penalty with this amount?", "Penalty Amount Edit", penalty.ToString("N"),"Set value to 0 to cancel");

                                decimal new_penalty = decimal.TryParse(saveprompt, out new_penalty) ? new_penalty : penalty;

                                if (penalty != new_penalty)
                                {
                                    if (new_penalty == 0) return;
                                    DialogResult dlg = MessageBox.Show("You have modify the penalty. Are you sure with this amount?", "Modified Penalty", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (dlg == DialogResult.Yes)
                                    {
                                        penalty = new_penalty;
                                    }
                                }
                                
                                newbalance = Convert.ToDecimal(mastacct.bill_balance)+penalty;

                                tbLedger ledger = new tbLedger();
                                ledger.master_id = masterID;
                                ledger.code = "PNLT";
                                ledger.zoneuid = zoneUID;
                                ledger.billing_id = billingID;
                                ledger.encoder = encoder;
                                ledger.amount = penalty;
                                ledger.balance = newbalance;
                                ledger.symbol = "+";
                                ledger.trans_date = DateTime.Today;
                                ledger.remarks = string.Format("Penalty for {0} billing", global_func.getBillMonth(billingID));

                            
                                if (billingID == global_func.getCurrentBillingID())
                                {
                                    mastacct.penalty = penalty;

                                }
                                else
                                {
                                    mastacct.bill_arrears+=penalty;
                                }
                                mastacct.bill_balance = newbalance;
                                dbcontext.AddTotbLedgers(ledger);
                                dbcontext.SaveChanges();
                                MessageBox.Show("Penalty is successfull.");
                                this.tbLedgerTableAdapter.FillByMasterID(this.dsLedger.tbLedger, masterID);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cannot impose penalty.Amount is lesser than meter maintenance.");
                        }
                    }else{
                        MessageBox.Show("This bill is already penalized.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a bill to penalize.");
            }
        }
    }
}
