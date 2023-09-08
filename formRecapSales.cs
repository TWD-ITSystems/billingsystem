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
    public partial class formRecapSales : Form
    {
        dbCommercialEntities dbcontext = new dbCommercialEntities();
        GlobalFunctions gfunc = new GlobalFunctions();
        int zone = 0;
        
        public formRecapSales()
        {
            InitializeComponent();
        }

        private void formRecapSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsZone.tbZone' table. You can move, or remove it, as needed.
            this.tbZoneTableAdapter.Fill(this.dsZone.tbZone);
            // TODO: This line of code loads data into the 'dsRecapSales.tbRecapSales' table. You can move, or remove it, as needed.
            this.tbRecapSalesTableAdapter.Fill(this.dsRecapSales.tbRecapSales);
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string billmonth = cmbBillMonth.Text;
            string zonebook = cmbZone.Text;
            zone = (int)cmbZone.SelectedValue;

            dbcontext.ExecuteStoreCommand("DELETE FROM tbRecapSales WHERE zonebook={0} and billmonth={1}", zonebook,billmonth);
            processResidentialBill();
            processGovernmentBill();
            processCommercialBill();
            MessageBox.Show("Generation is done");
            this.tbRecapSalesTableAdapter.Fill(this.dsRecapSales.tbRecapSales);
        }

        private void processResidentialPenalty(int zoneID)
        {
            int billing_id = Convert.ToInt32(cmbBillMonth.SelectedValue);
 
                string oldtxt = this.Text;
                string zoneBook = gfunc.getZoneName(zoneID);
                var qPenalty = from em in dbcontext.tbLedgers
                            join en in dbcontext.tbMasters on em.master_id equals en.master_id
                            where em.billing_id == billing_id && em.code.Equals("PNLT") && en.zone_id == zoneID && en.category == 12
                            select em;
                                  
                this.Text = string.Format("Processing Penalty Recap Zone : {0}", zoneBook);

                int cnt = qPenalty.Count() + 0; ;
                decimal amt = Convert.ToDecimal(qPenalty.Sum(x => x.amount))+0;

                using (dbCommercialEntities scontext = new dbCommercialEntities())
                {
                        tbRecapSale recap = new tbRecapSale();
                        recap.billmonth = cmbBillMonth.Text;
                        recap.zonebook = zoneBook;
                        recap.category = "Residential";
                        recap.num_con = cnt;
                        recap.total_amt = amt;
                        recap.code = "PNLT";
                        scontext.AddTotbRecapSales(recap);
                        scontext.SaveChanges();
                }

            this.Text = oldtxt;
        }

        private void processResidentialBill()
        {
            int billing_id = Convert.ToInt32(cmbBillMonth.SelectedValue);
            string[] res_vol = { "0-10", "11-20", "21-30", "31-40", "41-50", "51-up" };
           //2023 string[] res_vol = { "0-5", "6-10", "11-20", "21-30", "31-40", "41-50", "51-up" };
            var qZones = dbcontext.tbZones.Where(x => x.zone_uid != null);
            string oldtxt = this.Text;
/**
            foreach (var zone in qZones)
            {
   */      

                var qBill = from em in dbcontext.tbLedgers
                            join en in dbcontext.tbMasters on em.master_id equals en.master_id
                            where em.billing_id == billing_id && em.code.Equals("BILL") && en.zone_id == zone && en.category == 12
                            select em;
            

            
                
                int billcount = qBill.Count();

                this.Text = string.Format("Processing Recap Zone [Residential]: {0}", gfunc.getZoneName(zone));
                // get No. of connections
                List<int> cnt = new List<int>();

          //2023      cnt.Add(qBill.Count(x => x.volume <= 5));
                cnt.Add(qBill.Count(x => x.volume >= 0 && x.volume <= 10));
                cnt.Add(qBill.Count(x => x.volume >= 11 && x.volume <= 20));
                cnt.Add(qBill.Count(x => x.volume >= 21 && x.volume <= 30));
                cnt.Add(qBill.Count(x => x.volume >= 31 && x.volume <= 40));
                cnt.Add(qBill.Count(x => x.volume >= 41 && x.volume <= 50));
                cnt.Add(qBill.Count(x => x.volume >= 51));
                //get Total Volume
                List<int> vols = new List<int>();
          //2023      vols.Add(Convert.ToInt32(qBill.Where(x => x.volume <= 5).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 0 && x.volume <= 10).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 11 && x.volume <= 20).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 21 && x.volume <= 30).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 31 && x.volume <= 40).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 41 && x.volume <= 50).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 51).Sum(x => x.volume)));
                //get Total Amount
                List<decimal> sums = new List<decimal>();
         //2023       sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume <= 5).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 0 && x.volume <= 10).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 11 && x.volume <= 20).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 21 && x.volume <= 30).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 31 && x.volume <= 40).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 41 && x.volume <= 50).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 51).Sum(x => x.amount)));

                using (dbCommercialEntities scontext = new dbCommercialEntities())
                {
                    for (int i = 0; i < cnt.Count(); i++)
                    {
                        tbRecapSale recap = new tbRecapSale();
                        recap.billmonth = cmbBillMonth.Text;
                        recap.zonebook = gfunc.getZoneName(zone);   // zone.zone_name;
                        recap.category = "Residential";
                        recap.vol_ctgr = res_vol[i];
                        recap.num_con = cnt[i];
                        recap.total_vol = vols[i];
                        recap.total_amt = sums[i];
                        recap.code = "BILL";
                        scontext.AddTotbRecapSales(recap);
                        scontext.SaveChanges();
                    }
                }            
                this.Text = oldtxt;
                processResidentialPenalty(zone);
// } foreach
        } // processResidentailBill


        private void processGovernmentBill()
        {
            int billing_id = Convert.ToInt32(cmbBillMonth.SelectedValue);
            string[] res_vol = { "0-10", "11-20", "21-30", "31-40", "41-50", "51-up" };
            //2023  string[] res_vol = { "0-5", "6-10", "11-20", "21-30", "31-40", "41-50", "51-up" };
            var qZones = dbcontext.tbZones.Where(x => x.zone_uid != null);
            string oldtxt = this.Text;
/**
            foreach (var zone in qZones)
            {
 */ 
                var qBill = from em in dbcontext.tbLedgers
                            join en in dbcontext.tbMasters on em.master_id equals en.master_id
                            where em.billing_id == billing_id && em.code.Equals("BILL") && en.zone_id == zone && en.category == 22
                            select em;
                int billcount = qBill.Count();

                this.Text = string.Format("Processing Recap Zone [Government] : {0}", gfunc.getZoneName(zone));
                // get No. of connections
                List<int> cnt = new List<int>();
       //2023         cnt.Add(qBill.Count(x => x.volume <= 5));
                cnt.Add(qBill.Count(x => x.volume >= 0 && x.volume <= 10));
                cnt.Add(qBill.Count(x => x.volume >= 11 && x.volume <= 20));
                cnt.Add(qBill.Count(x => x.volume >= 21 && x.volume <= 30));
                cnt.Add(qBill.Count(x => x.volume >= 31 && x.volume <= 40));
                cnt.Add(qBill.Count(x => x.volume >= 41 && x.volume <= 50));
                cnt.Add(qBill.Count(x => x.volume >= 51));
                //get Total Volume
                List<int> vols = new List<int>();
        //2023        vols.Add(Convert.ToInt32(qBill.Where(x => x.volume <= 5).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 0 && x.volume <= 10).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 11 && x.volume <= 20).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 21 && x.volume <= 30).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 31 && x.volume <= 40).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 41 && x.volume <= 50).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 51).Sum(x => x.volume)));
                //get Total Amount
                List<decimal> sums = new List<decimal>();
          //2023      sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume <= 5).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 0 && x.volume <= 10).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 11 && x.volume <= 20).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 21 && x.volume <= 30).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 31 && x.volume <= 40).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 41 && x.volume <= 50).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 51).Sum(x => x.amount)));

                using (dbCommercialEntities scontext = new dbCommercialEntities())
                {
                    for (int i = 0; i < cnt.Count(); i++)
                    {
                        tbRecapSale recap = new tbRecapSale();
                        recap.billmonth = cmbBillMonth.Text;
                        recap.zonebook = gfunc.getZoneName(zone);
                        recap.category = "Government";
                        recap.vol_ctgr = res_vol[i];
                        recap.num_con = cnt[i];
                        recap.total_vol = vols[i];
                        recap.total_amt = sums[i];
                        recap.code = "BILL";
                        scontext.AddTotbRecapSales(recap);
                        scontext.SaveChanges();
                    }
                }
                this.Text = oldtxt;
                processGovernmentPenalty(zone);
 // }  foreach
        } // processGovernmentBill

        private void processGovernmentPenalty(int zoneID)
        {
            int billing_id = Convert.ToInt32(cmbBillMonth.SelectedValue);

            string oldtxt = this.Text;
            string zoneBook = gfunc.getZoneName(zoneID);
            /**  OLD CODE
            var qPenalty = from em in dbcontext.tbLedgers
                           join en in dbcontext.tbMasters on em.master_id equals en.master_id
                           where em.billing_id == billing_id && em.code.Equals("PNLT") && en.zone_id == zoneID && en.category == 22
                           select em;
            */


            // New code start here
            DateTime firstdate = new DateTime();
            DateTime lastdate = gfunc.getLastDateOfMonth(out firstdate, cmbBillMonth.Text);

            var qPenalty = from em in dbcontext.tbLedgers
                           join en in dbcontext.tbMasters on em.master_id equals en.master_id
                           where (em.trans_date >= firstdate && em.trans_date <= lastdate) && em.code.Equals("PNLT") && en.zone_id == zoneID && en.category == 22
                           select em;

            // New code end here

            this.Text = string.Format("Processing Penalty Recap Zone : {0}", zoneBook);

            int cnt = qPenalty.Count() + 0; ;
            decimal amt = Convert.ToDecimal(qPenalty.Sum(x => x.amount)) + 0;

            using (dbCommercialEntities scontext = new dbCommercialEntities())
            {
                tbRecapSale recap = new tbRecapSale();
                recap.billmonth = cmbBillMonth.Text;
                recap.zonebook = zoneBook;
                recap.category = "Government";
                recap.num_con = cnt;
                recap.total_amt = amt;
                recap.code = "PNLT";
                scontext.AddTotbRecapSales(recap);
                scontext.SaveChanges();
            }

            this.Text = oldtxt;
        }

        private void processCommercialBill()
        {
            int billing_id = Convert.ToInt32(cmbBillMonth.SelectedValue);
            string[] res_vol = {"1-10", "11-20", "21-30", "31-40", "41-50", "51-up" };
            var qZones = dbcontext.tbZones.Where(x => x.zone_uid != null);
            string oldtxt = this.Text;
/**
            foreach (var zone in qZones)
            {
            */
                var qBill = from em in dbcontext.tbLedgers
                            join en in dbcontext.tbMasters on em.master_id equals en.master_id
                            where em.billing_id == billing_id && em.code.Equals("BILL") && en.zone_id == zone&& en.category == 32
                            select em;
                int billcount = qBill.Count();

                this.Text = string.Format("Processing Recap Zone [Commercial] : {0}", gfunc.getZoneName(zone));
                // get No. of connections
                List<int> cnt = new List<int>();
                cnt.Add(qBill.Count(x => x.volume >= 0 && x.volume <= 10));
                cnt.Add(qBill.Count(x => x.volume >= 11 && x.volume <= 20));
                cnt.Add(qBill.Count(x => x.volume >= 21 && x.volume <= 30));
                cnt.Add(qBill.Count(x => x.volume >= 31 && x.volume <= 40));
                cnt.Add(qBill.Count(x => x.volume >= 41 && x.volume <= 50));
                cnt.Add(qBill.Count(x => x.volume >= 51));
                //get Total Volume
                List<int> vols = new List<int>();
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 0 && x.volume <= 10).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 11 && x.volume <= 20).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 21 && x.volume <= 30).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 31 && x.volume <= 40).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 41 && x.volume <= 50).Sum(x => x.volume)));
                vols.Add(Convert.ToInt32(qBill.Where(x => x.volume >= 51).Sum(x => x.volume)));
                //get Total Amount
                List<decimal> sums = new List<decimal>();
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 0 && x.volume <= 10).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 11 && x.volume <= 20).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 21 && x.volume <= 30).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 31 && x.volume <= 40).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 41 && x.volume <= 50).Sum(x => x.amount)));
                sums.Add(Convert.ToDecimal(qBill.Where(x => x.volume >= 51).Sum(x => x.amount)));

                using (dbCommercialEntities scontext = new dbCommercialEntities())
                {
                    for (int i = 0; i < cnt.Count(); i++)
                    {
                        tbRecapSale recap = new tbRecapSale();
                        recap.billmonth = cmbBillMonth.Text;
                        recap.zonebook = gfunc.getZoneName(zone);
                        recap.category = "Commercial";
                        recap.vol_ctgr = res_vol[i];
                        recap.num_con = cnt[i];
                        recap.total_vol = vols[i];
                        recap.total_amt = sums[i];
                        recap.code = "BILL";
                        scontext.AddTotbRecapSales(recap);
                        scontext.SaveChanges();
                    }
                }
                this.Text = oldtxt;
                processCommercialPenalty(zone);
//}  foreach
        } // processCommercialBill

        private void processCommercialPenalty(int zoneID)
        {
            int billing_id = Convert.ToInt32(cmbBillMonth.SelectedValue);

            string oldtxt = this.Text;
            string zoneBook = gfunc.getZoneName(zoneID);
            var qPenalty = from em in dbcontext.tbLedgers
                           join en in dbcontext.tbMasters on em.master_id equals en.master_id
                           where em.billing_id == billing_id && em.code.Equals("PNLT") && en.zone_id == zoneID && en.category == 32
                           select em;

            this.Text = string.Format("Processing Penalty Recap Zone : {0}", zoneBook);

            int cnt = qPenalty.Count() + 0; ;
            decimal amt = Convert.ToDecimal(qPenalty.Sum(x => x.amount)) + 0;

            using (dbCommercialEntities scontext = new dbCommercialEntities())
            {
                tbRecapSale recap = new tbRecapSale();
                recap.billmonth = cmbBillMonth.Text;
                recap.zonebook = zoneBook;
                recap.category = "Commercial";
                recap.num_con = cnt;
                recap.total_amt = amt;
                recap.code = "PNLT";
                scontext.AddTotbRecapSales(recap);
                scontext.SaveChanges();
            }

            this.Text = oldtxt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dcontext = new dbCommercialEntities())
            {
                var qZones = dcontext.tbZones.Where(x => x.zone_uid != null);
                string billmonth = cmbBillMonth.Text;
                string oldtxt = this.Text;
                foreach (var zone in qZones)
                {
                    var query = dcontext.tbRecapSales.Where(x => x.billmonth.Equals(billmonth) && x.zonebook.Equals(zone.zone_name));
                    int cUM = (int)query.Where(x => x.code.Equals("BILL")).Sum(x => x.total_vol);
                    decimal sales = (decimal)query.Where(x => x.code.Equals("BILL")).Sum(x => x.total_amt);
                    int billed = (int)query.Where(x => x.code.Equals("BILL")).Sum(x => x.num_con);
                    decimal penalty = (decimal)query.Where(x => x.code.Equals("PNLT")).Sum(x => x.total_amt);
                    decimal AR = sales + penalty;

                    this.Text = string.Format("Processing Zone :{0}", zone.zone_name);
                    tbBillingSummary bill = new tbBillingSummary();
                    bill.zone = zone.zone_name;
                    bill.cum = cUM;
                    bill.billed = billed;
                    bill.ar = AR;
                    bill.sales = sales;
                    bill.billmonth = cmbBillMonth.Text;
                    bill.penalty = penalty;
                    
                    dcontext.AddTotbBillingSummaries(bill);
                }
                dcontext.SaveChanges();
                MessageBox.Show("Processing Done");
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string billmonth = cmbBillMonth.Text;
            zone = 0;
            dbcontext.ExecuteStoreCommand("DELETE FROM tbRecapSales WHERE billmonth={0}", billmonth);

            for (int i = 1; i < 115; i++)
            {
                zone = i;
                processResidentialBill();
                processGovernmentBill();
                processCommercialBill();              
                
            }
            MessageBox.Show("Generation is done :");
            this.tbRecapSalesTableAdapter.Fill(this.dsRecapSales.tbRecapSales);
        }
    }
}
