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
    public partial class formProcessAccounts : Form
    {
        public int userID = 0;
        GlobalFunctions gfunc = new GlobalFunctions();
        int d_proc = 0;
        int d_marked = 0;
        int d_recon = 0;

        public formProcessAccounts()
        {
            InitializeComponent();
        }

        private void formProcessAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
            // TODO: This line of code loads data into the 'dsPrepareAcct.tbPrepareAcctHistory' table. You can move, or remove it, as needed.
            this.tbPrepareAcctHistoryTableAdapter.Fill(this.dsPrepareAcct.tbPrepareAcctHistory);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = comboBox1.Text.Split('-');
            int int_mon = Convert.ToInt32(str[0]);
            int str_year = Convert.ToInt32(str[1]);
            
            
            string oldtext = this.Text;

            int currIdx = comboBox1.SelectedIndex;
            DataRowView dr = (DataRowView)comboBox1.Items[currIdx + 1];
            string[] prevIdx = dr.Row[1].ToString().Split('-');
            int prev_year = Convert.ToInt32(prevIdx[1]);
            Boolean isCurrYear = str_year == prev_year;

            
            if (CheckIfProcessed())
            {
                MessageBox.Show("Billmonth is already processed. Please check.", "Processing Error");
                return;
            }

            
            /**if (prev_year <= str_year)
            {
                if (int_mon < DateTime.Today.Month) 
                {
                    MessageBox.Show("Billmonth must be later than the current month.", "Processing Error");
                    return;
                }
            }*/

           
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMasterAccts;
                int count = 0;             
                foreach (tbMasterAcct mast in query)
                {
                    this.Text = string.Format("Master ID : {0} - [Count:{1}]", mast.master_id,count++);
                    if (mast.bill_balance > 0)
                    {
                        mast.bill_arrears = mast.bill_balance;
                        mast.bill_arrears_months++;
                        if (isCurrYear)
                        {
                            mast.arrears_curr_yr = mast.bill_balance - mast.arrears_prev_yrs;
                        }
                        else
                        {
                           //mast.arrears_prev_yrs += mast.arrears_curr_yr; edited Jan 2,2017
                            mast.arrears_prev_yrs = mast.bill_arrears;
                            mast.arrears_curr_yr = 0;
                        }
                    }
                    else
                    {
                        mast.bill_arrears = 0;
                        mast.bill_arrears_months = 0;
                        mast.arrears_curr_yr = 0;
                        mast.arrears_prev_yrs = 0;
                    }
                    mast.penalty = 0;
                    mast.senior_amt = 0;
                    mast.bill_current = 0;
                //check IF if paid
                    if (mast.isIF == true)
                    {
                        if (mast.IFBalance <= 0) mast.isIF = false;
                    }

                // check DMTR if zeroed
                    if (mast.isMtrDmg == true)
                    {
                        if (mast.MtrDmg_Balance <= 0) mast.isMtrDmg = false;

                    }

                // check IF arrears if negative
                    if (mast.IFArrears < 0) mast.IFArrears = 0;

                //check senior if expired
                    if (mast.isSenior == true)
                    {
                        if (mast.senior_expiry <= DateTime.Today.Date)
                        {
                            mast.isSenior = false;
                        }
                    }

                 //get average volume
                    try
                    {
                    var queryVol = dbcontext.tbLedgers.Where(x => x.code.Equals("BILL") && x.master_id==mast.master_id).OrderByDescending(x=>x.ledger_id).Take(3);
                    decimal ave = Convert.ToDecimal(queryVol.Average(x=>x.volume));
                    int ave_vol = Convert.ToInt32(ave);
                    mast.ave_vol = ave_vol;
                    }catch{
                        mast.ave_vol = 0;
                    }
                }



                this.Text = "Saving Changes. This will take a while...";
                tbPrepareAcctHistory preHist = new tbPrepareAcctHistory();
                preHist.prepare_billing_of = comboBox1.Text;
                preHist.date_process = DateTime.Today.Date;
                preHist.done_by = gfunc.getUserInitials(userID);
                preHist.numrecords = count;
                preHist.disco_processed = d_proc;
                preHist.disco_marked = d_marked;
                preHist.disco_reconnected = d_recon;
                dbcontext.AddTotbPrepareAcctHistories(preHist);
                dbcontext.SaveChanges();
                MessageBox.Show("Done Processing..");
                this.Text = oldtext;
                
                this.tbPrepareAcctHistoryTableAdapter.Fill(this.dsPrepareAcct.tbPrepareAcctHistory);
            }
        }

        private bool CheckIfProcessed()
        {
            bool retval = false;
            string billmonth = comboBox1.Text;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbPrepareAcctHistories.Where(x => x.prepare_billing_of.Equals(billmonth)).SingleOrDefault();
                if (query == null)
                {
                    retval = false;
                }
                else
                {
                    retval = true;
                }
            }
            return retval;
        }

        private void ProcessDisconnectedAccounts()
        {

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryDisco = dbcontext.tbDiscoEntries.Where(x => x.processed == 0);
                if ((queryDisco != null) || (queryDisco.Count() > 0))
                {
                    foreach (tbDiscoEntry rDisco in queryDisco)
                    {
                        int masterID = Convert.ToInt32(rDisco.master_id);
                        DateTime recoDate = gfunc.getRecoDate(masterID);
                        DateTime discoDate = Convert.ToDateTime(rDisco.disco_date);

                        if ((!(recoDate >= discoDate)) || (recoDate == new DateTime(1900, 1, 1)))
                        {
                            d_marked++;
                        }
                        else if (recoDate >= discoDate)
                        {
                            d_recon++;
                            rDisco.processed = 1;
                            rDisco.processed_by = gfunc.getUserInitials(userID);
                            rDisco.processed_date = DateTime.Today;
                        }
                        d_proc++;
                      }
                    dbcontext.SaveChanges();
                }
            }
        }

       



    }
}
