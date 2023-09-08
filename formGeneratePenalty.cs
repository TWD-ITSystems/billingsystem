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
    public partial class formGeneratePenalty : Form
    {
        public int userID;
        dbCommercialEntities gcontext = new dbCommercialEntities();
        GlobalFunctions global_funct = new GlobalFunctions();
        int billingID = 0;
        int zoneID = 0;
        int zoneUID = 0;
        DateTime dueDate = new DateTime();
        DateTime dueDateArrears = new DateTime();
        string userInitials = "";

        
        public formGeneratePenalty()
        {
            InitializeComponent();
        }

        private void formGeneratePenalty_Load(object sender, EventArgs e)
        {
            if (userID == 2) btnRepair.Visible = true;
            // TODO: This line of code loads data into the 'dsPenaltyHistory.tbPenaltyHistory' table. You can move, or remove it, as needed.
            this.tbPenaltyHistoryTableAdapter.Fill(this.dsPenaltyHistory.tbPenaltyHistory);
            // TODO: This line of code loads data into the 'dsZoneLookup.tbZoneLookup' table. You can move, or remove it, as needed.
            this.tbZoneLookupTableAdapter.Fill(this.dsZoneLookup.tbZoneLookup);
            dsBillingBindingSource.DataSource = gcontext.tbBillings.OrderByDescending(x=>x.billing_id);
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            //this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
            // TODO: This line of code loads data into the 'dsZone.tbZone' table. You can move, or remove it, as needed.
            this.tbZoneTableAdapter.Fill(this.dsZone.tbZone);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
         //   zoneID = (int)cmbZone.SelectedValue;
         //   zoneUID = global_funct.getZoneUID((int)cmbZone.SelectedValue);
            zoneUID = (int)cmbZone.SelectedValue;
            billingID = (int)cmbBillMonth.SelectedValue;

            tbBillingSchedule billSched = gcontext.tbBillingSchedules.First(x => x.billing_id == billingID && x.zone == zoneUID);
            dueDate = Convert.ToDateTime(billSched.date_due_office);
            dueDateArrears = Convert.ToDateTime(billSched.date_due_disco_arrears);

            txtDueDate.Text = dueDate.ToShortDateString();
            userInitials = global_funct.getUserInitials(userID);
            btnGenerate.Enabled = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                int zoneUID = (int)cmbZone.SelectedValue;
                int billingID = (int)cmbBillMonth.SelectedValue;

                
                if (!BankPaymentsUpdated())
                {
                    MessageBox.Show("Please update the Bank Payments first.","Error");
                    return;
                }

                if (checkIfPenalty())
                {
                    MessageBox.Show("Billmonth and zone is already penalized.", "Error");
                    return;
                }
                decimal penalty = Convert.ToDecimal(dbcontext.tbSettings.Select(x => x.penalty_percentage).Single());
                penalty = penalty / 100;
                var qZones = dbcontext.tbZones.Where(x => x.zone_uid == zoneUID);
                string oldtxt = this.Text;
                int cnt = 0;
                int masterID = 0;
                decimal mtrmtn = global_funct.getMeterMtn();
                decimal totalamt = 0;
                int ctgy = 0;
                foreach (var zone in qZones)
                {
                    var qMaster = dbcontext.tbMasters.Where(x => x.zone_id == zone.zone_id && (!x.status.Equals("X ") || !x.status.Equals("E")));
                    int xts = qMaster.Count();
                    if (qMaster != null)
                    {
                        
                        foreach (tbMaster mast in qMaster)
                        {
                            if (mast.status.Equals("X ") || mast.status.Equals("E ") || mast.status.Equals("X") || mast.status.Equals("E")) continue;                            
                            masterID = mast.master_id;
                            ctgy = Int32.TryParse(mast.category.ToString(), out ctgy) ? ctgy : 0;                            
                            if ((checkBox1.Checked == false) && (ctgy == 22))
                            {
                                continue;
                            }
                            else if ((checkBox1.Checked == true) && (ctgy != 22))
                            {
                                continue;
                            }
                            if (checkIFNotBilled(masterID)) continue;
                            decimal penalty_amt = 0;

                            if (ctgy == 22)
                            {
                                decimal billbalance = 0;
                                decimal current = 0;
                                billbalance = global_funct.getBalance(masterID);
                                var qLedger = dbcontext.tbLedgers.FirstOrDefault(x => x.master_id == masterID && x.billing_id == billingID && x.code.Equals("BILL"));
                                if (qLedger != null)
                                {
                                    current = Convert.ToDecimal(qLedger.amount);
                                }
                                else
                                {
                                    current = 0;
                                }

                                if (billbalance > 0)
                                {
                                    if (billbalance < current)
                                    {
                                        penalty_amt = current * penalty;
                                    }
                                    else if (billbalance == current)
                                    {
                                        penalty_amt = current * penalty;
                                    }
                                }
                                else
                                {
                                    if (current != 0)
                                    {
                                        penalty_amt = (current - mtrmtn) * penalty;
                                    }
                                }
                                tbMasterAcct mastAcct = dbcontext.tbMasterAccts.First(x => x.master_id == masterID);
                                penalty_amt = global_funct.roundOff(penalty_amt);
                                mastAcct.penalty = penalty_amt;
                                mastAcct.bill_balance += penalty_amt;
                                tbLedger ledger = new tbLedger();
                                ledger.code = "PNLT";
                                //ledger.trans_date = rData.date_pres;
                                ledger.trans_date = DateTime.Today;
                                ledger.symbol = "+";
                                ledger.billing_id = billingID;
                                ledger.encoder = userInitials;
                                ledger.master_id = masterID;
                                ledger.amount = penalty_amt;
                                ledger.balance = mastAcct.bill_balance;
                                ledger.zoneuid = global_funct.getZoneUIDbyMaster(masterID);

                                totalamt += penalty_amt;
                                dbcontext.AddTotbLedgers(ledger);
                                cnt++;

                            }
                            else
                            {
                                tbMasterAcct mastAcct = dbcontext.tbMasterAccts.First(x => x.master_id == masterID);
                                if (mastAcct.bill_balance > 0)
                                {
                                    if (mastAcct.bill_balance < mastAcct.bill_current)
                                    {
                                        penalty_amt = Convert.ToDecimal(mastAcct.bill_balance) * penalty;
                                    }
                                    else                                    
                                   {
                                        // Edited Aug. 9  2018, to penalize only accounts with current only
                                        //if (mastAcct.bill_current != 0)
                                        //{
                                        //    penalty_amt = Convert.ToDecimal(mastAcct.bill_current) * penalty;
                                        //}
                                        //else
                                        //{
                                        //    penalty_amt = Convert.ToDecimal(mastAcct.bill_balance) * penalty;
                                        //}
                                       if (mastAcct.bill_current > 0)
                                       {
                                           penalty_amt = Convert.ToDecimal(mastAcct.bill_current) * penalty;
                                       }
                                    }
                                    penalty_amt = global_funct.roundOff(penalty_amt);
                                    mastAcct.penalty = penalty_amt;
                                    mastAcct.bill_balance += penalty_amt;
                                    tbLedger ledger = new tbLedger();
                                    ledger.code = "PNLT";
                                    //ledger.trans_date = rData.date_pres;
                                    ledger.trans_date = DateTime.Today;
                                    ledger.symbol = "+";
                                    ledger.billing_id = billingID;
                                    ledger.encoder = userInitials;
                                    ledger.master_id = masterID;
                                    ledger.amount = penalty_amt;
                                    ledger.balance = mastAcct.bill_balance;
                                    ledger.zoneuid = global_funct.getZoneUIDbyMaster(masterID);

                                    totalamt += penalty_amt;
                                    dbcontext.AddTotbLedgers(ledger);
                                    cnt++;
                                }
                                else
                                {
                                    mastAcct.penalty = 0;
                                }
                            }
                            
                            this.Text = string.Format("Processing Penalty ... [Count: {0}] ...{1}", cnt, mast.name);
                        }   //foreach qmaster
                    }   //if qmaster
                } //foreach (var drows in qWithArrears)
                this.Text = "Saving Penalties";
                tbPenaltyHistory pHist = new tbPenaltyHistory();
                pHist.billmonth = cmbBillMonth.Text;
                pHist.zone = cmbZone.Text;
                pHist.record_count = cnt;
                pHist.total_amount = totalamt;
                pHist.date_generated = DateTime.Today.Date;
                pHist.due_date = Convert.ToDateTime(txtDueDate.Text);
                pHist.done_by = global_funct.getUserInitials(userID);
                pHist.government_only = checkBox1.Checked ? "Yes" : "No";
                dbcontext.AddTotbPenaltyHistories(pHist);
                dbcontext.SaveChanges();
                this.Text = oldtxt;
                MessageBox.Show(string.Format("Penalty processing is finished.[Penalized :{0}]",cnt));
                this.tbPenaltyHistoryTableAdapter.Fill(this.dsPenaltyHistory.tbPenaltyHistory);
                btnGenerate.Enabled = false;
            }
        }

        private bool BankPaymentsUpdated()
        {
            bool retval = false;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryBank = dbcontext.tbBankCollections.Where(x => x.updated == null);
                int tmp = queryBank.Count();
                if (tmp==0)
                {
                    retval = true;
                }
            }
            return retval;
        }

        private bool checkIfPenalty()
        {
            bool retval = false;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                string bmonth = cmbBillMonth.Text;
                string zone = cmbZone.Text;
                var query = dbcontext.tbPenaltyHistories.Where(x => x.billmonth.Equals(bmonth) && x.zone.Equals(zone));
                int tmp = query.Count();
                if (tmp > 0)
                {
                    retval = true;
                }
            }
            return retval;
        }
        private bool validForPenalty(int masterID)
        {
            bool retval = false;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMaster mast = dbcontext.tbMasters.FirstOrDefault(x => x.master_id==masterID);
                if (mast != null)
                {
                    if (mast.status.ToString().Length > 0)
                    {
                        string stat = mast.status.ToUpper();
                        if (stat.Equals("X") || stat.Equals("E"))
                        {
                            retval = false;
                        }
                        else
                        {
                            retval = true;
                        }
                    }
                }
            }
            return retval;
        }

        private bool checkIFNotBilled(int masterid)
        {
            bool retval = false;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryBill = dbcontext.tbLedgers.Where(x => x.master_id == masterid && x.billing_id == billingID && x.code.Equals("BILL"));
                int tmp = queryBill.Count();
                if (tmp == 0) retval = true;

            }
            return retval;
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            DateTime qDate = new DateTime(2015,3,17);
            int zoneID = 1;  // zone 1
            int billingID = 32; // March penalty

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {

                var queryLedger = dbcontext.tbLedgers.Where(x =>x.code.Equals("PNLT") && x.trans_date == qDate && x.zoneuid == zoneID && x.billing_id == billingID);
                int test = queryLedger.Count();
                int counter = 0;
                foreach (tbLedger ledger in queryLedger)
                {
                    int masterID = ledger.master_id;
                    decimal penalty_amt = Convert.ToDecimal(ledger.amount);
                    decimal bill_balance = global_funct.getBalance(masterID);
                    decimal ledger_balance = Convert.ToDecimal(ledger.balance);
                    if (bill_balance == ledger_balance)
                    {
                        ledger.balance -= penalty_amt;
                        this.Text = string.Format("processing [{0}] count-{1}", masterID, counter++);

                        tbMasterAcct qMastAcct = dbcontext.tbMasterAccts.First(x => x.master_id == masterID);
                        qMastAcct.bill_balance = ledger.balance;
                    }
                }
                this.Text = string.Format("Total records:{0}", counter);
                dbcontext.SaveChanges();
                MessageBox.Show("Done");
            }
        }
    }
}
