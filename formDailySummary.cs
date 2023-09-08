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

    public partial class formDailySummary : Form
    {
        public class GroupedRow
        {
            public string bankcode { get; set; }
            public decimal? totalBill { get; set; }
            public decimal? totalOthers { get; set; }
            public DateTime? dateCollect { get; set; }
            public int? numrec { get; set; }
            public decimal? totalArrears { get; set; }
            public decimal? totalSenior { get; set; }
            public decimal? totalMtrMtn { get; set; }
            public decimal? totalAdvPay { get; set; }
            public decimal? totalPenalty { get; set; }

        }

        public int userID = 0;
        GlobalFunctions gfunc = new GlobalFunctions();
        private decimal meter_mtn = 0;
        private int bill_update_count = 0;
        private int penalty_count = 0;
        private int bam_count = 0;
        private int bam_credit_count = 0;
        private int bam_debit_count = 0;

        public formDailySummary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime currDate = new DateTime();

            //currDate = DateTime.Today.Date;
            currDate = dateTimePicker1.Value.Date;
            if (checkDate())
            {
                DialogResult dresult = MessageBox.Show("Transaction Date is already processed. Do you want to load the data?", "Warning", MessageBoxButtons.YesNo);
                if (dresult == DialogResult.Yes)
                {
                    clearTextBox();
                    loadProcessedData();
                }
                else
                {
                    //MASTER BALANCE
                    tMasterBalance.Text = string.Format("{0:n}", getMasterBalance());
                    tIFBalance.Text = string.Format("{0:n}", getIFBalance());
                    tNewAccounts.Text = string.Format("{0}", getNewAccounts(currDate));
                }

            }
            else
            {
                //MASTER BALANCE
                tMasterBalance.Text = string.Format("{0:n}", getMasterBalance());
                tIFBalance.Text = string.Format("{0:n}", getIFBalance());
                tNewAccounts.Text = string.Format("{0}", getNewAccounts(currDate));
            }

            btnSave.Enabled = true;
            ListViewItem lv2 = new ListViewItem("IF");
            List<decimal> collect = new List<decimal>();
            List<decimal> BAM = new List<decimal>();
            List<GroupedRow> bCollections = new List<GroupedRow>();
            decimal totalOthers = 0;
            //listView1.Clear();
            listView2.Items.Clear();
            listView1.Items.Clear();

            labelSummary.Text = string.Format("Transaction Summary as of {0:d}", dateTimePicker1.Value.Date);

            //currDate = currDate.Date;
            
            

            //BILLS,BAM, PENALTY
            tBillAmount.Text = nformat(getUpdatedBills(currDate));
            tNoBillsUpdated.Text = string.Format("{0:#,##0}",bill_update_count);
            tPenaltyAmt.Text = nformat(getPenaltyAmount(currDate));
            tNoPenalized.Text = string.Format("{0:#,##0}", penalty_count);
            BAM = getBAM(currDate);
            tBAMentry.Text = string.Format("{0:#,##0}", bam_count);
            tBAMDebit.Text = nformat(BAM[0]);
            tBAMCredit.Text = nformat(BAM[1]);



            //collections
            collect = getCollections(currDate);
            tOfficeSales.Text = string.Format("{0:n}", collect[0]);
            lv2.SubItems.Add(string.Format("{0:n}", collect[1]));
            listView2.Items.Add(lv2);

            lv2 = new ListViewItem("RFEE");
            lv2.SubItems.Add(string.Format("{0:n}", collect[2]));
            listView2.Items.Add(lv2);

            lv2 = new ListViewItem("TFEE");
            lv2.SubItems.Add(string.Format("{0:n}", collect[3]));
            listView2.Items.Add(lv2);

            lv2 = new ListViewItem("Sundries");
            lv2.SubItems.Add(string.Format("{0:n}", collect[4]));
            listView2.Items.Add(lv2);

            totalOthers = collect.Sum() - collect[0] ;
            tOfficeOthers.Text = string.Format("{0:n}", totalOthers);

            bCollections = getBankCollections(currDate);

            foreach (GroupedRow bPay in bCollections)
            {
                ListViewItem lv1 = new ListViewItem(bPay.bankcode);
                lv1.SubItems.Add(string.Format("{0:d}", bPay.dateCollect));
                lv1.SubItems.Add(string.Format("{0:n}", bPay.totalBill));
                lv1.SubItems.Add(string.Format("{0:n}", bPay.totalOthers));
                lv1.SubItems.Add(string.Format("{0:n}", bPay.totalArrears));
                lv1.SubItems.Add(string.Format("{0:n}", bPay.totalSenior));
                lv1.SubItems.Add(string.Format("{0:n}", bPay.totalPenalty));
                lv1.SubItems.Add(string.Format("{0:n}", bPay.totalMtrMtn));
                lv1.SubItems.Add(string.Format("{0:n}", bPay.totalAdvPay));
                lv1.SubItems.Add(string.Format("{0}", bPay.numrec));
                listView1.Items.Add(lv1);
            }
            decimal totalCurrent = Convert.ToDecimal(bCollections.Sum(x => x.totalBill));
            decimal totalBankOthers = Convert.ToDecimal(bCollections.Sum(x => x.totalOthers));
            decimal totalArrears = Convert.ToDecimal(bCollections.Sum(x => x.totalArrears));
            decimal totalSenior = Convert.ToDecimal(bCollections.Sum(x => x.totalSenior));
            decimal totalPenalty = Convert.ToDecimal(bCollections.Sum(x => x.totalPenalty));
            decimal totalMtrMtn = Convert.ToDecimal(bCollections.Sum(x => x.totalMtrMtn));
            decimal totalAdvPay = Convert.ToDecimal(bCollections.Sum(x => x.totalAdvPay));

            ListViewItem lvt1 = new ListViewItem("TOTAL");
            lvt1.SubItems.Add("------->");
            lvt1.SubItems.Add(string.Format("{0:n}", totalCurrent));
            lvt1.SubItems.Add(string.Format("{0:n}", totalBankOthers));
            lvt1.SubItems.Add(string.Format("{0:n}", totalArrears));
            lvt1.SubItems.Add(string.Format("{0:n}", totalSenior));
            lvt1.SubItems.Add(string.Format("{0:n}", totalPenalty));
            lvt1.SubItems.Add(string.Format("{0:n}", totalMtrMtn));
            lvt1.SubItems.Add(string.Format("{0:n}", totalAdvPay));
            listView1.Items.Add(lvt1);
            
            tBankCollections.Text = string.Format("{0:n}", getTotalBankCollections(currDate));

            btnSave.Enabled = true;
        }


        private void loadProcessedData()
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbDailySummary dSummary = dbcontext.tbDailySummaries.Single(x => x.trans_date == dateTimePicker1.Value.Date);
                this.tMasterBalance.Text = nformat(dSummary.balance_master);
                this.tIFBalance.Text = nformat(dSummary.balance_instfee);
                this.tNewAccounts.Text = dSummary.new_accounts.ToString();                    
            }

            btnSave.Enabled = false;
        }

        private string nformat(decimal? num)
        {
            if (num == null) num = 0;
            return string.Format("{0:n}", num);
        }

        private bool checkDate()
        {
            bool retval = false;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbDailySummaries.Where(x => x.trans_date == dateTimePicker1.Value.Date).SingleOrDefault();
                if (query != null)
                {
                    retval = true;
                }

            }
            return retval;
        }

        private decimal getMasterBalance()
        {
            decimal retval = 0;

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var mastbal = dbcontext.tbMasterAccts.Sum(x => x.bill_balance);
                if (mastbal.HasValue)
                {
                    retval = Convert.ToDecimal(mastbal);
                }
                else
                {
                    retval = 0;
                }
            }
            return retval;
        } // getmasterbalance

        private decimal getIFBalance()
        {
            decimal retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryIF = dbcontext.tbMasterAccts.Sum(x => x.IFBalance);
                if (queryIF.HasValue)
                {
                    retval = Convert.ToDecimal(queryIF);
                }
                else
                {
                    retval = 0;
                }
            }
            return retval;
        } // getIFBalance

        private int getNewAccounts(DateTime selDate)
        {
            int retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryNew = dbcontext.tbMasters.Where(x => x.date_encoded == selDate);
                retval = queryNew.Count();
            }
            return retval;
        } // getNewAccounts

        private List<decimal> getCollections(DateTime selDate)
        {
            List<decimal> collect = new List<decimal>();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var querySales = dbcontext.tbPays.Where(x=>x.date==selDate).Sum(x => x.current + x.ar_curr + x.ar_pri + x.penalty + x.mtrmain);
                if (querySales.HasValue)
                {
                    collect.Add(Convert.ToDecimal(querySales));
                }
                else
                {
                    collect.Add(0);
                }

                var queryInstFee = dbcontext.tbPays.Where(x => x.date == selDate).Sum(x => x.instfee);
                if (queryInstFee.HasValue)
                {
                    collect.Add(Convert.ToDecimal(queryInstFee));
                }
                else
                {
                    collect.Add(0);
                }

                var queryRFee = dbcontext.tbPays.Where(x => x.date == selDate).Sum(x => x.svfee);
                if (queryRFee.HasValue)
                {
                    collect.Add(Convert.ToDecimal(queryRFee));
                }
                else
                {
                    collect.Add(0);
                }

                var queryTFee = dbcontext.tbPays.Where(x => x.date == selDate).Sum(x => x.tffee);
                if (queryTFee.HasValue)
                {
                    collect.Add(Convert.ToDecimal(queryTFee));
                }
                else
                {
                    collect.Add(0);
                }

                var querySun = dbcontext.tbPays.Where(x => x.date == selDate).Sum(x => x.sdramt);
                if (querySun.HasValue)
                {
                    collect.Add(Convert.ToDecimal(querySun));
                }
                else
                {
                    collect.Add(0);
                }

            }
            return collect;
        } // getCollections

        private List<GroupedRow> getBankCollections(DateTime selDate)
        {
            List<GroupedRow> bankCol = new List<GroupedRow>();
            meter_mtn = gfunc.getMeterMtn();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var qBankCodes = dbcontext.tbBankCodes.Select(x=>x.bank_code);
                foreach (string bCode in qBankCodes)
                {
                    //var qBankCollect = dbcontext.tbBankCollections.Where(x => x.collect_agent.Equals(bCode) && x.date_posted == selDate && x.updated.Equals("Y")).GroupBy(x => x.date_collected).Select(x=>x);
                    var qBankCollect = from em in dbcontext.tbBankCollections
                                       where em.collect_agent.Equals(bCode) && em.date_posted==selDate && em.updated.Equals("Y")
                                       group em by em.date_collected into payGroup
                                       select new GroupedRow()
                                       {
                                           
                                           dateCollect = payGroup.Key,
                                           bankcode = payGroup.FirstOrDefault().collect_agent,
                                           totalBill = payGroup.Sum(x => x.current),
                                           totalOthers = payGroup.Sum(x=>x.others),
                                           totalArrears = payGroup.Sum(x=>x.arrears),
                                           totalSenior = payGroup.Sum(x=>x.senior),
                                           totalAdvPay = payGroup.Sum(x=>x.advpay),
                                           totalMtrMtn = payGroup.Sum(x=>x.mtr_mtn),
                                           totalPenalty = payGroup.Sum(x=>x.penalty),
                                           numrec = payGroup.Count()
                                        };


                     int test = qBankCollect.Count();
                     if (test == 0) continue;
                    foreach (GroupedRow gr in qBankCollect)
                    {
                        string bkcode = gr.bankcode;
                        decimal totalBill = Convert.ToDecimal(gr.totalBill);
                        decimal totalOthers = Convert.ToDecimal(gr.totalOthers);
                        DateTime colDate = Convert.ToDateTime(gr.dateCollect);
                        int numrec = Convert.ToInt32(gr.numrec);
                        decimal totalArrears = Convert.ToDecimal(gr.totalArrears);
                        decimal totalSenior = Convert.ToDecimal(gr.totalSenior);
                        decimal totalPenalty = Convert.ToDecimal(gr.totalPenalty);
                        decimal totalMtrMtn = Convert.ToDecimal(gr.totalMtrMtn);
                        decimal totalAdvPay = Convert.ToDecimal(gr.totalAdvPay);


                        GroupedRow grpPay = new GroupedRow();
                        grpPay.bankcode = bkcode;
                        grpPay.totalBill = totalBill;
                        grpPay.totalOthers = totalOthers;
                        grpPay.dateCollect = colDate;
                        grpPay.numrec = numrec;
                        grpPay.totalArrears = totalArrears;
                        grpPay.totalSenior = totalSenior;
                        grpPay.totalAdvPay = totalAdvPay;
                        grpPay.totalMtrMtn = totalMtrMtn;
                        grpPay.totalPenalty = totalPenalty;

                        bankCol.Add(grpPay);
                    }
                    System.Threading.Thread.CurrentThread.Join(10);
                }
            }
            return bankCol;
        } // getBankCollections

        private decimal getTotalBankCollections(DateTime selDate)
        {
            decimal retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryTotal = dbcontext.tbBankCollections.Where(x => x.date_posted==selDate && x.updated.Equals("Y")).Sum(x=>x.totalamt);
                if (queryTotal != null)
                {
                    retval = Convert.ToDecimal(queryTotal);
                }
            }
            return retval;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tBankCollections_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
            dateTimePicker1.Value = DateTime.Today.Date;
            comboBox1.SelectedIndex = 0;
            foreach (GroupBox grp in Controls.OfType<GroupBox>())
            {
                foreach (DevExpress.XtraEditors.TextEdit txt in grp.Controls.OfType<DevExpress.XtraEditors.TextEdit>())
                {
                    txt.Properties.ReadOnly = true;
                }
            }
        }

        private decimal getUpdatedBills(DateTime selDate)
        {
            decimal retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var sumBills = dbcontext.tbLedgers.Where(x => x.trans_date == selDate && x.code.Equals("BILL"));
                if (sumBills != null)
                {
                    retval = Convert.ToDecimal(sumBills.Sum(x=>x.amount));
                    bill_update_count = sumBills.Count();
                }
            }
            return retval;
        }

        private decimal getPenaltyAmount(DateTime selDate)
        {
            decimal retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var qPenalty = dbcontext.tbLedgers.Where(x => x.trans_date == selDate && x.code.Equals("PNLT"));
                if (qPenalty != null)
                {
                    retval = Convert.ToDecimal(qPenalty.Sum(x => x.amount));
                    penalty_count = qPenalty.Count();
                }
            }
            return retval;
        }

        private List<decimal> getBAM(DateTime selDate)
        {
            List<decimal> retval = new List<decimal>();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                List<string> bamCodesDebit = new List<string>();
                List<string> bamCodesCredit = new List<string>();
                bamCodesDebit = dbcontext.tbBAMLookups.Where(x=>x.bam_type.Equals("debit")).Select(x=>x.bam_code).ToList();
                bamCodesCredit = dbcontext.tbBAMLookups.Where(x => x.bam_type.Equals("credit")).Select(x => x.bam_code).ToList();

                var qBAMDebit = dbcontext.tbLedgers.Where(x => bamCodesDebit.Contains(x.code) && x.trans_date==selDate);
                var qBAMCredit = dbcontext.tbLedgers.Where(x => bamCodesCredit.Contains(x.code) && x.trans_date == selDate);
                bam_count = qBAMCredit.Count() + qBAMDebit.Count();
                bam_credit_count = qBAMCredit.Count();
                bam_debit_count = qBAMDebit.Count();
                decimal amtDebit = Convert.ToDecimal(qBAMDebit.Sum(x => x.amount));
                decimal amtCredit = Convert.ToDecimal(qBAMCredit.Sum(x => x.amount));
                retval.Add(amtDebit);
                retval.Add(amtCredit);
            }
            return retval;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkDate())
            {
                DialogResult lresult = MessageBox.Show("Transaction Date is already processed. Do you want to overwrite the data?", "Overwrite", MessageBoxButtons.YesNo);
                if (lresult == DialogResult.No)
                {
                    return;
                }
            }

            tbDailySummary dSummary = new tbDailySummary();
            dSummary.balance_master = gfunc.sformat(tMasterBalance.Text);
            dSummary.balance_instfee = gfunc.sformat(tIFBalance.Text);
            dSummary.new_accounts = this.sformat(tNewAccounts.Text);

            dSummary.collections_office_sales = gfunc.sformat(tOfficeSales.Text);
            dSummary.collections_office_others = gfunc.sformat(tOfficeOthers.Text);
            dSummary.collections_bank = gfunc.sformat(tBankCollections.Text);

            dSummary.bills_amount = gfunc.sformat(tBillAmount.Text);
            dSummary.bills_uploaded = this.sformat(tNoBillsUpdated.Text);
            dSummary.penalty_amt = gfunc.sformat(tPenaltyAmt.Text);
            dSummary.penalty_count = this.sformat(tNoPenalized.Text);

            dSummary.bam_amt_credit = gfunc.sformat(tBAMCredit.Text);
            dSummary.bam_amt_debit = gfunc.sformat(tBAMDebit.Text);
            dSummary.bam_count_credit = bam_credit_count;
            dSummary.bam_count_debit = bam_debit_count;

            dSummary.trans_date = DateTime.Today.Date;
            dSummary.done_by = gfunc.getUserInitials(userID);

            try
            {
                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    dbcontext.AddTotbDailySummaries(dSummary);
                    dbcontext.SaveChanges();
                    MessageBox.Show("Data has been successfully saved.");
                    btnSave.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Error saving data.");
            }

        }



        private int sformat(string val)
        {
            int con_val = 0;
            con_val = Int32.TryParse(val, out con_val) ? con_val : 0;
            return con_val;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void clearTextBox()
        {
            foreach (GroupBox grp in Controls.OfType<GroupBox>())
            {
                foreach (DevExpress.XtraEditors.TextEdit txt in grp.Controls.OfType<DevExpress.XtraEditors.TextEdit>())
                {
                    txt.ResetText();
                }
            }
            listView1.Items.Clear();
            listView2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        

    }
}
