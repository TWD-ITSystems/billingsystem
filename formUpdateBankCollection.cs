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
    public partial class formUpdateBankCollection : Form
    {
        public int userID;
        GlobalFunctions gfunc = new GlobalFunctions();

        public formUpdateBankCollection()
        {
            InitializeComponent();
        }

        private void formUpdateBankCollection_Shown(object sender, EventArgs e)
        {
            int tmp = getUnpostedPayments();
            label1.Text = string.Format("There are {0} payments need to be updated.",tmp);
            if (tmp > 0) button1.Enabled = true;
        }

        private int getUnpostedPayments()
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbBankCollections.Where(x => x.updated == null);
                return  query.Count();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldtxt = this.Text;
            int cnt = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var dRows = dbcontext.tbBankCollections.Where(x => x.updated == null);
                //var dRows = dbcontext.tbBankCollections.Where(x => x.master_id==27927);
                int dcount = dRows.Count();
                foreach (tbBankCollection drow in dRows)
                {
                    tbLedger ledgerData;
                    int masterID = Convert.ToInt32(drow.master_id);
                    decimal collected = Convert.ToDecimal(drow.totalamt);
                    decimal current = decimal.TryParse(drow.current.ToString(), out current) ? current : 0;
                    decimal if2 = Convert.ToDecimal(drow.others);
                    decimal dmtr = Convert.ToDecimal(drow.dmg_mtr);
                    decimal arrears = Convert.ToDecimal(drow.arrears);
                    decimal senior = Convert.ToDecimal(drow.senior);
                    decimal penalty = Convert.ToDecimal(drow.penalty);
                    decimal AmtToDeduct = (collected  - (if2+dmtr));
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
                            ledgerData.zoneuid = gfunc.getZoneUIDbyMaster(masterID);
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
                    ledgerData.zoneuid = gfunc.getZoneUIDbyMaster(masterID);
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
                        ledgerData.zoneuid = gfunc.getZoneUIDbyMaster(masterID);
                        dbcontext.AddTotbLedgers(ledgerData);
                    }

                    if (dmtr > 0)
                    {
                        ledgerData = new tbLedger();
                        ledgerData.code = "DMpd";
                        ledgerData.@ref = drow.refnum.ToString();
                        ledgerData.trans_date = DateTime.Today;
                        ledgerData.remarks = "Paid " + trans_date.ToShortDateString();
                        ledgerData.symbol = "";
                        ledgerData.encoder = drow.collect_agent.ToString();
                        ledgerData.master_id = masterID;
                        ledgerData.other = dmtr;
                        ledgerData.zoneuid = gfunc.getZoneUIDbyMaster(masterID);
                        dbcontext.AddTotbLedgers(ledgerData);

                        mastAcct.MtrDmg_Balance -= dmtr;   
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
                            if (mastAcct.bill_arrears_months > 0)
                            {
                                mastAcct.bill_arrears_months--;
                            }
                            //  }
                        }
                    }
                    cnt++;
                    decimal balance = Convert.ToDecimal(mastAcct.bill_balance);
                    if (mastAcct.bill_current >= current)
                    {
                        mastAcct.bill_current = mastAcct.bill_current - current;
                    }
                    else
                    {
                        mastAcct.bill_current = 0;
                    }
                    mastAcct.bill_balance = balance - AmtToDeduct;
                    drow.updated = "Y";
                    this.Text = string.Format("[Total: {0}] {1}", cnt, drow.master_id.ToString());

                } // foreach end
                dbcontext.SaveChanges();
                MessageBox.Show("Bank Payments are successfully updated.","Success");
                this.Text = oldtxt;
                button1.Enabled = false;
                int tmp = getUnpostedPayments();
                label1.Text = string.Format("There are {0} payments need to be updated.", tmp);
                if (tmp > 0) button1.Enabled = true;
            } //using end
        }
    }
}
