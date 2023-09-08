using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;

namespace BillingSystem
{
    public partial class formGenerateAging : Form
    {
        GlobalFunctions globfunc = new GlobalFunctions();
        Dictionary<int, decimal> Negative_Fbal = new Dictionary<int, decimal>{
            {1164,100},{4068,0.90M}
            ,{14348,0.35M}
            //{516,100} disabled on 11/08/2018 to correct aging
        };


        int billing_ID = 0;
        Boolean work1 = false;
        Boolean work2 = false;
        int totalNUMBER = 0;
        Stopwatch stopwatch;

        public formGenerateAging()
        {
            InitializeComponent();
        }

        private void Generate1(int billingID)
        {
            string acctno = "";
            string oldtxt = this.Text;
            string status = "";
            decimal negFBAL = 0;
            DateTime cutDate = dateTimePicker1.Value.AddDays(-1);
 
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                //string agingstr = TextPrompt.ShowDialog("Enter Account:", "Aging");
                // var qMaster = dbcontext.tbMasters.Where(x => x.acctno.Equals(agingstr));
                // var qMaster = dbcontext.tbMasters.Where(x => x.acctno.Equals("025719"));
                //var qMaster = dbcontext.tbMasters.Where(x => x.master_id > 25615 && x.category!=0 && x.zone_id!=0);
                //var qMaster = dbcontext.tbMasters.Where(x => x.master_id == 14624);

                // var qPaid = dbcontext.tbLedgers.Where(x=>x.remarks.Contains("Paid 7/31/2014") && x.code.Equals("PAID"));

               var qMaster = dbcontext.tbMasters.Where(x => x.category != 0 && x.zone_id != 0 && x.category != 0 && x.master_id<=20000);
               // var qMaster = dbcontext.tbMasters.Where(x => x.master_id == 2306);
                var global_ledger = dbcontext.tbLedgers;
                int rec_count = 0;
                foreach (tbMaster mast in qMaster)
                {

                    rec_count++;

                    acctno = mast.acctno;
                    if (mast.status != null)
                    {
                        status = mast.status.TrimEnd();
                    }
                   
                    decimal rbalance = globfunc.getBalance(mast.master_id);


                    if (rbalance <= 0)
                    {
                        tbMasterAging mAging = new tbMasterAging();
                        mAging.master_id = mast.master_id;
                        mAging.status = mast.status;
                        mAging.zone_id = mast.zone_id;
                        mAging.date_generated = DateTime.Today;
                        mAging.balance = rbalance;
                        mAging.day0 = rbalance;
                        mAging.day1to60 = 0;
                        mAging.day61to180 = 0;
                        mAging.day181to365 = 0;
                        mAging.over365 = 0;
                        mAging.ctgy = mast.category;
                        mAging.billing_id = billing_ID;
                        dbcontext.AddTotbMasterAgings(mAging);
                        IDisposable disp = mAging as IDisposable;
                        if (disp != null) { disp.Dispose(); }
                    }
                    else
                    {

                        //Prepare the hidden negative FBAL
                        if (!Negative_Fbal.TryGetValue(mast.master_id, out negFBAL))
                        {
                            negFBAL = 0;
                        }

                        //var qLedger = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id && x.trans_date <= new DateTime(2014,8,5));
                        DateTime cutoff = dateTimePicker1.Value;
                        //int qLastZeroTransaction = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id && x.balance<=0 &&!x.code.Substring(0, 4).Equals("canc"))
                        //                            .OrderByDescending(p=>p.ledger_id).Select(r=>r.ledger_id).First();

                        int qLastZeroTransaction = global_ledger.Where(x => x.master_id == mast.master_id && x.amount > 0 && x.balance <= 0 && !x.code.Substring(0, 4).Equals("canc"))
                                                    .OrderByDescending(p => p.ledger_id).Select(r => r.ledger_id).FirstOrDefault();
                        decimal adv_payment = Convert.ToDecimal(global_ledger.Where(x => x.ledger_id == qLastZeroTransaction).Select(x => x.balance).FirstOrDefault());
                        //var qLedger = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id && x.trans_date < cutoff);
                        var qLedger = global_ledger.Where(x => x.master_id == mast.master_id && x.trans_date < cutoff && x.ledger_id > qLastZeroTransaction);
                        int ledger_count = qLedger.Count();
                        if ((qLedger == null) || (ledger_count == 0))
                        {
                            decimal balance = rbalance;
                            tbMasterAging mAging = new tbMasterAging();
                            mAging.master_id = mast.master_id;
                            mAging.status = mast.status.TrimEnd();
                            mAging.zone_id = mast.zone_id;
                            mAging.date_generated = DateTime.Today;

                            if (balance < 0)
                            {
                                if (mAging.status.Equals("X"))
                                {
                                    mAging.day0 = balance;
                                    mAging.balance = balance;
                                }
                                else
                                {
                                    mAging.day0 = 0;
                                    mAging.balance = 0;
                                }
                            }
                            else
                            {
                                mAging.day0 = 0;
                                mAging.balance = 0;
                            }
                            mAging.day1to60 = 0;
                            mAging.day61to180 = 0;
                            mAging.day181to365 = 0;
                            mAging.over365 = 0;
                            mAging.ctgy = mast.category;
                            mAging.billing_id = billing_ID;
                            dbcontext.AddTotbMasterAgings(mAging);
                            continue;
                        }
                        //var qLedger = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id);

                        IEnumerable<tbLedger> ieLedger = qLedger.AsEnumerable();
                        // IEnumerable<tbLedger> neLedger = qLedger.AsEnumerable();
                        List<tbLedger> ieBills = new List<tbLedger>();
                        List<tbLedger> iePays = new List<tbLedger>();
                        int billID = 0;
                        decimal amount = 0;
                        decimal negBalance = 0;


                        foreach (tbLedger lData in qLedger)
                        {
                            string tset = lData.code;
                            if (lData.code == null) tset = "";
                            if ((tset.Equals("BILL")) || (tset.Equals("PNLT")) || (tset.Equals("SNR")) || (lData.code.Equals("FBAL"))
                                || (tset.Equals("DMWS")) || (tset.Equals("DMAR")) || (tset.Equals("DMPN")) || (tset.Equals("CANC")) || (tset.Equals("DMIF")))
                            {
                                /**
                                if (lData.trans_date >= new DateTime(2014, 8, 1))
                                {
                                    continue;
                                }*/
                                if ((tset.Equals("PNLT")) && (lData.amount == 0))
                                {
                                    continue;
                                }
                                try
                                {
                                    billID = (int)lData.billing_id;
                                }
                                catch
                                {
                                    int belleng = billing_ID;
                                    billID = belleng;
                                }
                                amount = lData.amount.HasValue ? (decimal)lData.amount : 0;

                                if (negBalance < 0)
                                {
                                    amount += negBalance;
                                    negBalance = 0;
                                }
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = lData.code;
                                ieBills.Add(nLedger);
                                continue;
                            }

                            if ((tset.ToUpper().Equals("PAID")) || (tset.Equals("CMWS")) || (tset.Equals("CMAR")) || (tset.Equals("CMPN")) || (tset.Equals("Pd_DV"))                              )
                            {
                                amount = (decimal)lData.amount;
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = lData.code;
                                iePays.Add(nLedger);
                            }

                            if (tset.Equals("CMIFref"))
                            {
                                amount = decimal.TryParse(lData.other.ToString(),out amount)?amount:0;
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = lData.code;
                                iePays.Add(nLedger);

                            }

                            if (negFBAL != 0)
                            {
                                amount = negFBAL;
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = "FBAL";
                                iePays.Add(nLedger);
                                negFBAL = 0;
                            }
                        } //foreach (tbLedger lData in qLedger)

                        IDisposable disp = qLedger as IDisposable;
                        if (disp != null) { disp.Dispose(); }

                        var reverse_iebills = ieBills.OrderByDescending(x => x.ledger_id);
                        int icnt = 1;
                        decimal days0 = 0;                        
                        decimal days1to60 = 0;
                        decimal days61to180 = 0;
                        decimal days181to365 = 0;
                        decimal days365over = 0;
                        decimal total_bill_amount = Convert.ToDecimal(ieBills.Sum(x => x.amount));
                        decimal ibalance = total_bill_amount;

                        int cnter = 0;
                        foreach (tbLedger ldata in reverse_iebills)
                        {
                            
                           
                            string code = ldata.code;
                            decimal data_amount = Convert.ToDecimal(ldata.amount);
                            if (code == null)  code = "";
                            ++cnter;
                            if ((cnter == reverse_iebills.Count()) && (code.Equals("BILL") || code.Substring(0,2).Equals("DM")) && adv_payment<0)// this is the last entry subtract advance pay
                            {
                                data_amount += adv_payment;
                            }
                            if ((icnt >= 1) && (icnt <= 2))
                            {
                                if (status.Equals("X"))
                                {
                                    cutDate = dateTimePicker1.Value.AddDays(-1);
                                    DateTime disco = getLastDisco(ldata.master_id);
                                    if (disco.Date <= cutDate)
                                    {
                                        TimeSpan ts = cutDate - disco.Date;
                                        if (ts.Days >= 366)
                                        {
                                            /**   if (data_amount < 0)
                                               {
                                                   days0 += data_amount;
                                               }
                                               else
                                               {*/
                                            days365over += data_amount;
                                            //  }
                                            continue;
                                        }
                                        else if ((ts.Days >= 181) && (ts.Days <= 365))
                                        {
                                            if ((data_amount < 0) && (!code.Equals("SNR")))
                                            {
                                                days0 += data_amount;
                                            }
                                            else
                                            {
                                                days181to365 += data_amount;
                                            }
                                            continue;
                                        }
                                        else if ((ts.Days >= 61) && (ts.Days <= 180))
                                        {
                                            if ((data_amount < 0) && (!code.Equals("SNR")))
                                            {
                                                days0 += data_amount;
                                            }
                                            else
                                            {
                                                days61to180 += data_amount;
                                            }
                                            continue;
                                        }
                                        else if ((ts.Days >= 0) && (ts.Days <= 60))
                                        {
                                            if ((data_amount < 0) && (!code.Equals("SNR")))
                                            {
                                                days0 += data_amount;
                                            }
                                            else
                                            {

                                            }
                                            {
                                                days1to60 += data_amount;
                                            }
                                            continue;
                                        }
                                    }

                                }
                                else
                                {

                                    days1to60 += data_amount;

                                    if (code.Equals("BILL"))
                                    {
                                        icnt++;
                                    }
                                }
                                continue;
 
                            } //if ((icnt >= 1) && (icnt <= 2))
                            if ((icnt >= 3) && (icnt <= 6))
                            {

                                days61to180 += data_amount;

                                if (code.Equals("BILL"))
                                {
                                    icnt++;
                                }
                                continue;
                            }
                            if ((icnt >= 7) && (icnt <= 12))
                            {

                                days181to365 += data_amount;

                                if (code.Equals("BILL"))
                                {
                                    icnt++;
                                }
                                continue;
                            }
                            if (icnt > 12)
                            {
                                days365over += data_amount;
                                continue;
                            }


                        }// foreach (tbLedger ldata in reverse_iebills)

                        int pay_count = iePays.Count();
                        decimal total_amt = total_bill_amount;
                        if (pay_count > 0)
                        {
                            
                            decimal total_payment = (decimal)iePays.Sum(x => x.amount);
                            decimal total_pay = 0;
                            foreach (tbLedger pays in iePays)
                            {

                                decimal pamount = (decimal)pays.amount;
                                decimal sobra = 0;
                                total_amt -= pamount;
                                total_pay += pamount;

                                if (days365over > 0)
                                {
                                    if (pamount > days365over)
                                    {
                                        sobra = pamount - days365over;
                                        days365over = 0;
                                    }
                                    else
                                    {

                                        days365over -= pamount;
                                    }

                                    if (sobra > 0)
                                    {
                                        if (sobra < days181to365)
                                        {
                                            days181to365 -= sobra;
                                        }
                                        else
                                        {
                                            sobra = sobra - days181to365;
                                            days181to365 = 0;
                                        }
                                        continue;
                                    }

                                    if (sobra > 0)
                                    {
                                        if (sobra < days1to60)
                                        {
                                            days1to60 -= sobra;
                                        }
                                    }

                                    continue;
                                }
                                if (days181to365 > 0)
                                {
                                    if (pamount < days181to365)
                                    {
                                        days181to365 -= pamount;
                                    }
                                    else
                                    {
                                        sobra = pamount - days181to365;
                                        days181to365 = 0;
                                    }
                                    if (sobra > 0)
                                    {
                                        if (sobra < days61to180)
                                        {
                                            days61to180 -= sobra;
                                            sobra = 0;
                                        }
                                        else
                                        {
                                            sobra = sobra - days61to180;
                                            days61to180 = 0;
                                        }
                                    }
                                    if (sobra > 0)
                                    {
                                        if (sobra < days1to60)
                                        {
                                            days1to60 -= sobra;
                                        }
                                    }
                                    continue;
                                }

                                if (days61to180 > 0)
                                {
                                    if (pamount < days61to180)
                                    {
                                        days61to180 -= pamount;
                                        pamount = 0;
                                    }
                                    else
                                    {
                                        sobra = pamount - days61to180;
                                        days61to180 = 0;
                                    }
                                    if (sobra > 0)
                                    {
                                        if (sobra < days1to60)
                                        {
                                            days1to60 -= sobra;
                                        }
                                    }
                                    continue;
                                }

                                if (days1to60 != 0)
                                {
                                    if (pamount < days1to60)
                                    {
                                        days1to60 -= pamount;
                                        pamount = 0;
                                    }

                                    if (days1to60 < 0)
                                    {
                                        days0 += days1to60;
                                        days1to60 = 0;
                                    }
                                    continue;
                                }


                                if (total_amt < 0)
                                {
                                    days1to60 = 0;
                                    days0 = total_amt;
                                }

                            }
                        }//if (pay_count > 0)

                        tbMasterAging mastAging = new tbMasterAging();
                        mastAging.master_id = mast.master_id;
                        mastAging.status = mast.status.Trim();
                        mastAging.zone_id = mast.zone_id;
                        mastAging.date_generated = DateTime.Today;
                        if (adv_payment < 0)
                        {
                            mastAging.balance = total_amt+adv_payment;
                        }
                        else
                        {
                            mastAging.balance = total_amt;
                        }

                        if (mastAging.balance <= 0)
                        {
                            mastAging.day1to60 = 0;
                            mastAging.day61to180 = 0;
                            mastAging.day181to365 = 0;
                            mastAging.over365 = 0;
                            if (negBalance < 0)
                            {
                                mastAging.day0 = negBalance;
                                mastAging.balance = negBalance;
                            }
                            else
                            {

                                 mastAging.day0 = total_amt;

                            }
                        }
                        else
                        {
                            mastAging.day1to60 = days1to60;
                            mastAging.day61to180 = days61to180;
                            mastAging.day181to365 = days181to365;
                            mastAging.over365 = days365over;
                            mastAging.day0 = days0;
                        }
                        mastAging.ctgy = mast.category;
                        mastAging.billing_id = billing_ID;
                        dbcontext.AddTotbMasterAgings(mastAging);
                    }
//                    int percentage = (rec_count + 1) * 100 / totalNUMBER;
//                    backgroundWorker1.ReportProgress(percentage);
                } //foreach (tbMaster mast in qMaster)
                dbcontext.SaveChanges();
            } //dbcontext
        } // Generate 1

        private void Generate2(int billingID)  // Generate 2
        {
            string acctno = "";
            string oldtxt = this.Text;
            string status = "";
            decimal negFBAL = 0;
            DateTime cutDate = dateTimePicker1.Value.AddDays(-1);
            

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                //string agingstr = TextPrompt.ShowDialog("Enter Account:", "Aging");
                // var qMaster = dbcontext.tbMasters.Where(x => x.acctno.Equals(agingstr));
                // var qMaster = dbcontext.tbMasters.Where(x => x.acctno.Equals("025719"));
                //var qMaster = dbcontext.tbMasters.Where(x => x.master_id > 25615 && x.category!=0 && x.zone_id!=0);
                //var qMaster = dbcontext.tbMasters.Where(x => x.master_id == 14624);

                // var qPaid = dbcontext.tbLedgers.Where(x=>x.remarks.Contains("Paid 7/31/2014") && x.code.Equals("PAID"));

              var qMaster = dbcontext.tbMasters.Where(x => x.category != 0 && x.zone_id != 0 && x.category != 0 && x.master_id>=20001);
              //var qMaster = dbcontext.tbMasters.Where(x => x.master_id == 17077);
                var global_ledger = dbcontext.tbLedgers;
                int rec_count = 0;
                foreach (tbMaster mast in qMaster)
                {

                    rec_count++;

                    acctno = mast.acctno;
                    if (mast.status != null)
                    {
                        status = mast.status.TrimEnd();
                    }

                    decimal rbalance = globfunc.getBalance(mast.master_id);


                    if (rbalance <= 0)
                    {
                        tbMasterAging mAging = new tbMasterAging();
                        mAging.master_id = mast.master_id;
                        mAging.status = mast.status;
                        mAging.zone_id = mast.zone_id;
                        mAging.date_generated = DateTime.Today;
                        mAging.balance = rbalance;
                        mAging.day0 = rbalance;
                        mAging.day1to60 = 0;
                        mAging.day61to180 = 0;
                        mAging.day181to365 = 0;
                        mAging.over365 = 0;
                        mAging.ctgy = mast.category;
                        mAging.billing_id = billing_ID;
                        dbcontext.AddTotbMasterAgings(mAging);
                        IDisposable disp = mAging as IDisposable;
                        if (disp != null) { disp.Dispose(); }
                    }
                    else
                    {

                        //Prepare the hidden negative FBAL
                        if (!Negative_Fbal.TryGetValue(mast.master_id, out negFBAL))
                        {
                            negFBAL = 0;
                        }

                        //var qLedger = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id && x.trans_date <= new DateTime(2014,8,5));
                        DateTime cutoff = dateTimePicker1.Value;
                        //int qLastZeroTransaction = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id && x.balance<=0 &&!x.code.Substring(0, 4).Equals("canc"))
                        //                            .OrderByDescending(p=>p.ledger_id).Select(r=>r.ledger_id).First();

                        int qLastZeroTransaction = global_ledger.Where(x => x.master_id == mast.master_id && x.amount > 0 && x.balance <= 0 && !x.code.Substring(0, 4).Equals("canc"))
                                                    .OrderByDescending(p => p.ledger_id).Select(r => r.ledger_id).FirstOrDefault();
                        decimal adv_payment = Convert.ToDecimal(global_ledger.Where(x => x.ledger_id == qLastZeroTransaction).Select(x => x.balance).FirstOrDefault());
                        //var qLedger = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id && x.trans_date < cutoff);
                        var qLedger = global_ledger.Where(x => x.master_id == mast.master_id && x.trans_date < cutoff && x.ledger_id > qLastZeroTransaction);
                        int ledger_count = qLedger.Count();
                        if ((qLedger == null) || (ledger_count == 0))
                        {
                            decimal balance = rbalance;
                            tbMasterAging mAging = new tbMasterAging();
                            mAging.master_id = mast.master_id;
                            mAging.status = mast.status.TrimEnd();
                            mAging.zone_id = mast.zone_id;
                            mAging.date_generated = DateTime.Today;

                            if (balance < 0)
                            {
                                if (mAging.status.Equals("X"))
                                {
                                    mAging.day0 = balance;
                                    mAging.balance = balance;
                                }
                                else
                                {
                                    mAging.day0 = 0;
                                    mAging.balance = 0;
                                }
                            }
                            else
                            {
                                mAging.day0 = 0;
                                mAging.balance = 0;
                            }
                            mAging.day1to60 = 0;
                            mAging.day61to180 = 0;
                            mAging.day181to365 = 0;
                            mAging.over365 = 0;
                            mAging.ctgy = mast.category;
                            mAging.billing_id = billing_ID;
                            dbcontext.AddTotbMasterAgings(mAging);
                            continue;
                        }
                        //var qLedger = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id);

                        IEnumerable<tbLedger> ieLedger = qLedger.AsEnumerable();
                        // IEnumerable<tbLedger> neLedger = qLedger.AsEnumerable();
                        List<tbLedger> ieBills = new List<tbLedger>();
                        List<tbLedger> iePays = new List<tbLedger>();
                        int billID = 0;
                        decimal amount = 0;
                        decimal negBalance = 0;


                        foreach (tbLedger lData in qLedger)
                        {
                            string tset = lData.code;
                            if (lData.code == null) tset = "";
                            if ((tset.Equals("BILL")) || (tset.Equals("PNLT")) || (tset.Equals("SNR")) || (lData.code.Equals("FBAL"))
                                || (tset.Equals("DMWS")) || (tset.Equals("DMAR")) || (tset.Equals("DMPN")) || (tset.Equals("CANC")) || (tset.Equals("DMIF")))
                            {
                                /**
                                if (lData.trans_date >= new DateTime(2014, 8, 1))
                                {
                                    continue;
                                }*/
                                if ((tset.Equals("PNLT")) && (lData.amount == 0))
                                {
                                    continue;
                                }
                                try
                                {
                                    billID = (int)lData.billing_id;
                                }
                                catch
                                {
                                    int belleng = billing_ID;
                                    billID = belleng;
                                }
                                amount = lData.amount.HasValue ? (decimal)lData.amount : 0;
                                if (negBalance < 0)
                                {
                                    amount += negBalance;
                                    negBalance = 0;
                                }
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = lData.code;
                                ieBills.Add(nLedger);
                                continue;
                            }

                            if ((tset.ToUpper().Equals("PAID")) || (tset.Equals("CMWS")) || (tset.Equals("CMAR")) || (tset.Equals("CMPN")) || (tset.Equals("Pd_DV")))
                            {
                                amount = (decimal)lData.amount;
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = lData.code;
                                iePays.Add(nLedger);
                            }

                            if (tset.Equals("CMIFref"))
                            {
                                amount = decimal.TryParse(lData.other.ToString(), out amount) ? amount : 0;
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = lData.code;
                                iePays.Add(nLedger);

                            }

                            if (negFBAL != 0)
                            {
                                amount = negFBAL;
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = "FBAL";
                                iePays.Add(nLedger);
                                negFBAL = 0;
                            }
                        } //foreach (tbLedger lData in qLedger)

                        IDisposable disp = qLedger as IDisposable;
                        if (disp != null) { disp.Dispose(); }

                        var reverse_iebills = ieBills.OrderByDescending(x => x.ledger_id);
                        int icnt = 1;
                        decimal days0 = 0;
                        decimal days1to60 = 0;
                        decimal days61to180 = 0;
                        decimal days181to365 = 0;
                        decimal days365over = 0;
                        decimal total_bill_amount = Convert.ToDecimal(ieBills.Sum(x => x.amount));
                        decimal ibalance = total_bill_amount;

                        int cnter = 0;
                        foreach (tbLedger ldata in reverse_iebills)
                        {


                            string code = ldata.code;
                            decimal data_amount = Convert.ToDecimal(ldata.amount);
                            if (code == null) code = "";
                            ++cnter;
                            if ((cnter == reverse_iebills.Count()) && code.Equals("BILL") && adv_payment < 0)// this is the last entry subtract advance pay
                            {
                                data_amount += adv_payment;
                            }
                            if ((icnt >= 1) && (icnt <= 2))
                            {
                                if (status.Equals("X"))
                                {
                                    cutDate = dateTimePicker1.Value.AddDays(-1);
                                    DateTime disco = getLastDisco(ldata.master_id);
                                    if (disco.Date <= cutDate)
                                    {
                                        TimeSpan ts = cutDate - disco.Date;
                                        if (ts.Days >= 366)
                                        {
                                            /**   if (data_amount < 0)
                                               {
                                                   days0 += data_amount;
                                               }
                                               else
                                               {*/
                                            days365over += data_amount;
                                            //  }
                                            continue;
                                        }
                                        else if ((ts.Days >= 181) && (ts.Days <= 365))
                                        {
                                            if ((data_amount < 0) && (!code.Equals("SNR")))
                                            {
                                                days0 += data_amount;
                                            }
                                            else
                                            {
                                                days181to365 += data_amount;
                                            }
                                            continue;
                                        }
                                        else if ((ts.Days >= 61) && (ts.Days <= 180))
                                        {
                                            if ((data_amount < 0) && (!code.Equals("SNR")))
                                            {
                                                days0 += data_amount;
                                            }
                                            else
                                            {
                                                days61to180 += data_amount;
                                            }
                                            continue;
                                        }
                                        else if ((ts.Days >= 0) && (ts.Days <= 60))
                                        {
                                            if ((data_amount < 0) && (!code.Equals("SNR")))
                                            {
                                                days0 += data_amount;
                                            }
                                            else
                                            {

                                            }
                                            {
                                                days1to60 += data_amount;
                                            }
                                            continue;
                                        }
                                    }

                                }
                                else
                                {

                                    days1to60 += data_amount;

                                    if (code.Equals("BILL"))
                                    {
                                        icnt++;
                                    }
                                }
                                continue;

                            } //if ((icnt >= 1) && (icnt <= 2))
                            if ((icnt >= 3) && (icnt <= 6))
                            {

                                days61to180 += data_amount;

                                if (code.Equals("BILL"))
                                {
                                    icnt++;
                                }
                                continue;
                            }
                            if ((icnt >= 7) && (icnt <= 12))
                            {

                                days181to365 += data_amount;

                                if (code.Equals("BILL"))
                                {
                                    icnt++;
                                }
                                continue;
                            }
                            if (icnt > 12)
                            {
                                days365over += data_amount;
                                continue;
                            }


                        }// foreach (tbLedger ldata in reverse_iebills)

                        int pay_count = iePays.Count();
                        decimal total_amt = total_bill_amount;
                        if (pay_count > 0)
                        {

                            decimal total_payment = (decimal)iePays.Sum(x => x.amount);
                            decimal total_pay = 0;
                            foreach (tbLedger pays in iePays)
                            {

                                decimal pamount = (decimal)pays.amount;
                                decimal sobra = 0;
                                total_amt -= pamount;
                                total_pay += pamount;

                                if (days365over > 0)
                                {
                                    if (pamount > days365over)
                                    {
                                        sobra = pamount - days365over;
                                        days365over = 0;
                                    }
                                    else
                                    {

                                        days365over -= pamount;
                                    }

                                    if (sobra > 0)
                                    {
                                        if (sobra < days181to365)
                                        {
                                            days181to365 -= sobra;
                                        }
                                        else
                                        {
                                            sobra = sobra - days181to365;
                                            days181to365 = 0;
                                        }
                                        continue;
                                    }

                                    if (sobra > 0)
                                    {
                                        if (sobra < days1to60)
                                        {
                                            days1to60 -= sobra;
                                        }
                                    }

                                    continue;
                                }
                                if (days181to365 > 0)
                                {
                                    if (pamount < days181to365)
                                    {
                                        days181to365 -= pamount;
                                    }
                                    else
                                    {
                                        sobra = pamount - days181to365;
                                        days181to365 = 0;
                                    }
                                    if (sobra > 0)
                                    {
                                        if (sobra < days61to180)
                                        {
                                            days61to180 -= sobra;
                                            sobra = 0;
                                        }
                                        else
                                        {
                                            sobra = sobra - days61to180;
                                            days61to180 = 0;
                                        }
                                    }
                                    if (sobra > 0)
                                    {
                                        if (sobra < days1to60)
                                        {
                                            days1to60 -= sobra;
                                        }
                                    }
                                    continue;
                                }

                                if (days61to180 > 0)
                                {
                                    if (pamount < days61to180)
                                    {
                                        days61to180 -= pamount;
                                        pamount = 0;
                                    }
                                    else
                                    {
                                        sobra = pamount - days61to180;
                                        days61to180 = 0;
                                    }
                                    if (sobra > 0)
                                    {
                                        if (sobra < days1to60)
                                        {
                                            days1to60 -= sobra;
                                        }
                                    }
                                    continue;
                                }

                                if (days1to60 != 0)
                                {
                                    if (pamount < days1to60)
                                    {
                                        days1to60 -= pamount;
                                        pamount = 0;
                                    }

                                    if (days1to60 < 0)
                                    {
                                        days0 += days1to60;
                                        days1to60 = 0;
                                    }
                                    continue;
                                }


                                if (total_amt < 0)
                                {
                                    days1to60 = 0;
                                    days0 = total_amt;
                                }

                            }
                        }//if (pay_count > 0)

                        tbMasterAging mastAging = new tbMasterAging();
                        mastAging.master_id = mast.master_id;
                        mastAging.status = mast.status.Trim();
                        mastAging.zone_id = mast.zone_id;
                        mastAging.date_generated = DateTime.Today;
                        if (adv_payment < 0)
                        {
                            mastAging.balance = total_amt + adv_payment;
                        }
                        else
                        {
                            mastAging.balance = total_amt;
                        }

                        if (mastAging.balance <= 0)
                        {
                            mastAging.day1to60 = 0;
                            mastAging.day61to180 = 0;
                            mastAging.day181to365 = 0;
                            mastAging.over365 = 0;
                            if (negBalance < 0)
                            {
                                mastAging.day0 = negBalance;
                                mastAging.balance = negBalance;
                            }
                            else
                            {
                                mastAging.day0 = total_amt;
                            }
                        }
                        else
                        {
                            mastAging.day1to60 = days1to60;
                            mastAging.day61to180 = days61to180;
                            mastAging.day181to365 = days181to365;
                            mastAging.over365 = days365over;
                            mastAging.day0 = days0;
                        }
                        mastAging.ctgy = mast.category;
                        mastAging.billing_id = billing_ID;
                        dbcontext.AddTotbMasterAgings(mastAging);
                    }
                    int percentage = (rec_count + 1) * 100 / totalNUMBER;
                    backgroundWorker2.ReportProgress(percentage);
                } //foreach (tbMaster mast in qMaster)
                dbcontext.SaveChanges();
            } //dbcontext
        } // Generate 2

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string oldtxt = this.Text;
            billing_ID = (int)comboBox1.SelectedValue;

            if (checkNullEntries())
            {

                MessageBox.Show("Null code detected. Please check in sql. Generation cancelled.");
                return;
            }
            int accCount = globfunc.getTotalNumberAccounts();
            
        
            totalNUMBER = accCount;
            progressBar1.Minimum = 0;
            progressBar2.Minimum = 0;
            progressBar1.Maximum = 20000;
            progressBar2.Maximum = accCount - 20000;
            progressBar1.Step = 1;
            progressBar2.Step = 1;
            stopwatch = new Stopwatch();
            stopwatch.Start();
            clearPreviousData();
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.RunWorkerAsync();
            btnGenerate.Enabled = false;
          
          //  Generate1(billing_ID);
        }


        private bool checkNullEntries()
        {
            bool result = false;
            string accounts = "";
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbLedgers.Where(x => x.code == string.Empty || x.code.Equals("") || x.code == null ).Select(x => x);
                if (query.Count() > 0)
                {
                    foreach (tbLedger mastID in query)
                    {
                        accounts = accounts + "," + globfunc.getAcctNo(mastID.master_id);
                    }
                    MessageBox.Show("Generation cancelled please check the ff. accounts \n" + accounts);
                   result = true;
                }           
                
            }
            return result;
        }


        private void clearPreviousData()
        {
            //delete previous data tbMasterAging Entry
            string conStr = ConfigurationManager.ConnectionStrings["BillingSystem.Properties.Settings.dbCommercialConnectionString"].ConnectionString;
            string billMonth = comboBox1.Text;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(string.Format("Delete from tbMasterAging where billing_id={0}", billing_ID),con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occured:{0}", ex.Message));
            }

            //delete previous data in summary
            try
            {
                using (SqlConnection con1 = new SqlConnection(conStr))
                {
                    con1.Open();
                    using (SqlCommand command1 = new SqlCommand(string.Format("Delete from tbAgingSummary where billmonth='{0}'", billMonth),con1))
                    {
                        command1.ExecuteNonQuery();
                    }
                    con1.Close();
                }
            }
            catch (SystemException enx)
            {
                MessageBox.Show(string.Format("An error occured:{0}", enx.Message));
            }

        }

        private DateTime getLastDisco(int masterID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMasters.FirstOrDefault(x => x.master_id == masterID).last_disco_date;
                return Convert.ToDateTime(query);
            }

        }



        private void formGenerateAging_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int billingID = (int)comboBox1.SelectedValue;
            saveAgingSummary(billingID);
            MessageBox.Show("Summary Done.");
        }

        private void saveAgingSummary(int billingID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                int[] ctgy = { 12, 22, 32 };
                GlobalFunctions gfunc = new GlobalFunctions();

                var active = dbcontext.tbMasterAgings.Where(x => !x.status.Equals("X") && x.billing_id == billingID && x.ctgy!=0 && x.zone_id!=0);
                var inactive = dbcontext.tbMasterAgings.Where(x => x.status.Equals("X") && x.billing_id == billingID && x.ctgy != 0 && x.zone_id!=0);
                string billText = comboBox1.Text;
                int tst = inactive.Count();
                for (int i = 0; i < ctgy.Count(); i++)
                {
                    int index = ctgy[i];
                    tbAgingSummary aging = new tbAgingSummary();
                    tbAgingSummary in_aging = new tbAgingSummary();
                    aging.status = "active";
                    in_aging.status = "inactive";
                    aging.billmonth = billText;
                    in_aging.billmonth = billText;

                    int total_con = active.Where(x => x.ctgy == index).Count();
                    int intotal_con = inactive.Where(x => x.ctgy == index).Count();
                    aging.ctgry = index;
                    aging.total_con = total_con;
                    in_aging.ctgry = index;
                    in_aging.total_con = intotal_con;

                    decimal balance = (decimal)active.Where(x => x.ctgy == index ).Sum(x => x.balance);
                    decimal inbalance = (decimal)inactive.Where(x => x.ctgy == index ).Sum(x => x.balance);
                    aging.balance = balance + 0;
                    in_aging.balance = inbalance + 0;

                    var neg_bal = active.Where(x => x.ctgy == index && x.balance < 0).Sum(x => x.balance);
                    decimal negative_balance = neg_bal.HasValue ? (decimal)neg_bal : 0;
                    var ineg = inactive.Where(x => x.ctgy == index && x.balance < 0).Sum(x => x.balance);
                    decimal innegative_balance = ineg.HasValue ? (decimal)ineg : 0;
                    aging.days0 = negative_balance;
                    in_aging.days0 = innegative_balance;

                    var s_1to60 = active.Where(x => x.ctgy == index ).Sum(x => x.day1to60);
                    decimal sum_1to60 = s_1to60.HasValue ? (decimal)s_1to60 : 0;
                    var i_1to60 = inactive.Where(x => x.ctgy == index ).Sum(x => x.day1to60);
                    decimal insum_1to60 = i_1to60.HasValue ? (decimal)i_1to60 : 0;
                    aging.days1to60 = sum_1to60 + 0;
                    in_aging.days1to60 = insum_1to60 + 0;

                    var s_61to180 = active.Where(x => x.ctgy == index ).Sum(x => x.day61to180);
                    decimal sum_61to180 = s_61to180.HasValue?(decimal)s_61to180:0;
                    var i_61to180 = inactive.Where(x => x.ctgy == index ).Sum(x => x.day61to180);
                    decimal insum_61to180 = i_61to180.HasValue ? (decimal)i_61to180 : 0;
                    aging.days61to180 = sum_61to180;
                    in_aging.days61to180 = insum_61to180;

                    var s_181to365 = active.Where(x => x.ctgy == index ).Sum(x => x.day181to365);
                    decimal sum_181to365 = s_181to365.HasValue ? (decimal)s_181to365 : 0;
                    var i_181to365 = inactive.Where(x => x.ctgy == index ).Sum(x => x.day181to365);
                    decimal insum_181to365 = i_181to365.HasValue ? (decimal)i_181to365 : 0;
                    aging.days181to365 = sum_181to365 + 0;
                    in_aging.days181to365 = insum_181to365 + 0;

                    var s_over365 = active.Where(x => x.ctgy == index ).Sum(x => x.over365);
                    decimal sum_over365 = s_over365.HasValue ? (decimal)s_over365 : 0;
                    var i_over365 = inactive.Where(x => x.ctgy == index ).Sum(x => x.over365);
                    decimal insum_over365 = i_over365.HasValue ? (decimal)i_over365 : 0;
                    aging.over365 = sum_over365 + 0;
                    in_aging.over365 = insum_over365 + 0;

                    /**
                    int con_with_bal = active.Where(x => x.balance > 0).Count();
                    int con_with_nega = active.Where(x => x.balance < 0).Count();
                    int con_with_zero = active.Where(x => x.balance == 0).Count();
                     
                    int incon_with_bal = inactive.Where(x => x.balance > 0).Count();
                    int incon_with_nega = inactive.Where(x => x.balance < 0).Count();
                    int incon_with_zero = inactive.Where(x => x.balance == 0).Count();
                     */
                    dbcontext.AddTotbAgingSummaries(aging);
                    dbcontext.AddTotbAgingSummaries(in_aging);
                }
                dbcontext.SaveChanges();
            }
        }//  private void saveAgingSummary(int billingID)

        private void button2_Click(object sender, EventArgs e)
        {
            int billingID = 20;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var inactive = dbcontext.tbMasterAgings.Where(x => x.billing_id == billingID && x.ctgy != 0 && x.zone_id != 0);
                decimal total = 0,balance=0;
                foreach (tbMasterAging mAge in inactive)
                {
                    total = Convert.ToDecimal(mAge.day0 + mAge.day1to60 + mAge.day61to180 + mAge.day181to365 + mAge.over365);
                    balance = (decimal)mAge.balance;
                    if (balance != total)
                    {
                        globfunc.saveLogFile(@"D:\checkbalance.txt", string.Format("ID:{0} --- {1}", mAge.aging_id, mAge.master_id));
                    }
                }
                MessageBox.Show("Done");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            formAgingChecking frmcheck = new formAgingChecking();
            frmcheck.billingID = globfunc.getBillingID(comboBox1.Text);
            frmcheck.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string acctno = "";
            string oldtxt = this.Text;
            string status = "";
            decimal negFBAL = 0;
            DateTime cutDate = dateTimePicker1.Value.AddDays(-1);

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                //string agingstr = TextPrompt.ShowDialog("Enter Account:", "Aging");
                // var qMaster = dbcontext.tbMasters.Where(x => x.acctno.Equals(agingstr));
                // var qMaster = dbcontext.tbMasters.Where(x => x.acctno.Equals("025719"));
                //var qMaster = dbcontext.tbMasters.Where(x => x.master_id > 25615 && x.category!=0 && x.zone_id!=0);
                //var qMaster = dbcontext.tbMasters.Where(x => x.master_id == 14624);

                // var qPaid = dbcontext.tbLedgers.Where(x=>x.remarks.Contains("Paid 7/31/2014") && x.code.Equals("PAID"));

                var qMaster = dbcontext.tbMasters.Where(x => x.category != 0 && x.zone_id != 0 && x.category != 0 && x.master_id <= 20000);
                //var qMaster = dbcontext.tbMasters.Where(x => x.master_id ==34388);
                var global_ledger = dbcontext.tbLedgers;
                int rec_count = 0;
                foreach (tbMaster mast in qMaster)
                {

                    rec_count++;

                    acctno = mast.acctno;
                    if (mast.status != null)
                    {
                        status = mast.status.TrimEnd();
                    }

                    decimal rbalance = globfunc.getBalance(mast.master_id);


                    if (rbalance <= 0)
                    {
                        tbMasterAging mAging = new tbMasterAging();
                        mAging.master_id = mast.master_id;
                        mAging.status = mast.status;
                        mAging.zone_id = mast.zone_id;
                        mAging.date_generated = DateTime.Today;
                        mAging.balance = rbalance;
                        mAging.day0 = rbalance;
                        mAging.day1to60 = 0;
                        mAging.day61to180 = 0;
                        mAging.day181to365 = 0;
                        mAging.over365 = 0;
                        mAging.ctgy = mast.category;
                        mAging.billing_id = billing_ID;
                        dbcontext.AddTotbMasterAgings(mAging);
                        IDisposable disp = mAging as IDisposable;
                        if (disp != null) { disp.Dispose(); }
                    }
                    else
                    {

                        //Prepare the hidden negative FBAL
                        if (!Negative_Fbal.TryGetValue(mast.master_id, out negFBAL))
                        {
                            negFBAL = 0;
                        }

                        //var qLedger = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id && x.trans_date <= new DateTime(2014,8,5));
                        DateTime cutoff = dateTimePicker1.Value;
                        //int qLastZeroTransaction = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id && x.balance<=0 &&!x.code.Substring(0, 4).Equals("canc"))
                        //                            .OrderByDescending(p=>p.ledger_id).Select(r=>r.ledger_id).First();

                        int qLastZeroTransaction = global_ledger.Where(x => x.master_id == mast.master_id && x.amount > 0 && x.balance <= 0 && !x.code.Substring(0, 4).Equals("canc"))
                                                    .OrderByDescending(p => p.ledger_id).Select(r => r.ledger_id).FirstOrDefault();
                        decimal adv_payment = Convert.ToDecimal(global_ledger.Where(x => x.ledger_id == qLastZeroTransaction).Select(x => x.balance).FirstOrDefault());
                        //var qLedger = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id && x.trans_date < cutoff);
                        var qLedger = global_ledger.Where(x => x.master_id == mast.master_id && x.trans_date < cutoff && x.ledger_id > qLastZeroTransaction);
                        int ledger_count = qLedger.Count();
                        if ((qLedger == null) || (ledger_count == 0))
                        {
                            decimal balance = rbalance;
                            tbMasterAging mAging = new tbMasterAging();
                            mAging.master_id = mast.master_id;
                            mAging.status = mast.status.TrimEnd();
                            mAging.zone_id = mast.zone_id;
                            mAging.date_generated = DateTime.Today;

                            if (balance < 0)
                            {
                                if (mAging.status.Equals("X"))
                                {
                                    mAging.day0 = balance;
                                    mAging.balance = balance;
                                }
                                else
                                {
                                    mAging.day0 = 0;
                                    mAging.balance = 0;
                                }
                            }
                            else
                            {
                                mAging.day0 = 0;
                                mAging.balance = 0;
                            }
                            mAging.day1to60 = 0;
                            mAging.day61to180 = 0;
                            mAging.day181to365 = 0;
                            mAging.over365 = 0;
                            mAging.ctgy = mast.category;
                            mAging.billing_id = billing_ID;
                            dbcontext.AddTotbMasterAgings(mAging);
                            continue;
                        }
                        //var qLedger = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id);

                        IEnumerable<tbLedger> ieLedger = qLedger.AsEnumerable();
                        // IEnumerable<tbLedger> neLedger = qLedger.AsEnumerable();
                        List<tbLedger> ieBills = new List<tbLedger>();
                        List<tbLedger> iePays = new List<tbLedger>();
                        int billID = 0;
                        decimal amount = 0;
                        decimal negBalance = 0;


                        foreach (tbLedger lData in qLedger)
                        {
                            string tset = lData.code;
                            if (lData.code == null) tset = "";
                            if ((tset.Equals("BILL")) || (tset.Equals("PNLT")) || (tset.Equals("SNR")) || (lData.code.Equals("FBAL"))
                                || (tset.Equals("DMWS")) || (tset.Equals("DMAR")) || (tset.Equals("DMPN")) || (tset.Equals("CANC")) || (tset.Equals("DMIF")))
                            {
                                /**
                                if (lData.trans_date >= new DateTime(2014, 8, 1))
                                {
                                    continue;
                                }*/
                                if ((tset.Equals("PNLT")) && (lData.amount == 0))
                                {
                                    continue;
                                }
                                try
                                {
                                    billID = (int)lData.billing_id;
                                }
                                catch
                                {
                                    int belleng = billing_ID;
                                    billID = belleng;
                                }
                                amount = lData.amount.HasValue ? (decimal)lData.amount : 0;

                                if (negBalance < 0)
                                {
                                    amount += negBalance;
                                    negBalance = 0;
                                }
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = lData.code;
                                ieBills.Add(nLedger);
                                continue;
                            }

                            if ((tset.ToUpper().Equals("PAID")) || (tset.Equals("CMWS")) || (tset.Equals("CMAR")) || (tset.Equals("CMPN")) || (tset.Equals("Pd_DV")))
                            {
                                amount = (decimal)lData.amount;
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = lData.code;
                                iePays.Add(nLedger);
                            }

                            if (tset.Equals("CMIFref"))
                            {
                                amount = decimal.TryParse(lData.other.ToString(), out amount) ? amount : 0;
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = lData.code;
                                iePays.Add(nLedger);

                            }

                            if (negFBAL != 0)
                            {
                                amount = negFBAL;
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = "FBAL";
                                iePays.Add(nLedger);
                                negFBAL = 0;
                            }
                        } //foreach (tbLedger lData in qLedger)

                        IDisposable disp = qLedger as IDisposable;
                        if (disp != null) { disp.Dispose(); }

                        var reverse_iebills = ieBills.OrderByDescending(x => x.ledger_id);
                        int icnt = 1;
                        decimal days0 = 0;
                        decimal days1to60 = 0;
                        decimal days61to180 = 0;
                        decimal days181to365 = 0;
                        decimal days365over = 0;
                        decimal total_bill_amount = Convert.ToDecimal(ieBills.Sum(x => x.amount));
                        decimal ibalance = total_bill_amount;

                        int cnter = 0;
                        foreach (tbLedger ldata in reverse_iebills)
                        {


                            string code = ldata.code;
                            decimal data_amount = Convert.ToDecimal(ldata.amount);
                            if (code == null) code = "";
                            ++cnter;
                            if ((cnter == reverse_iebills.Count()) && (code.Equals("BILL") || code.Substring(0, 2).Equals("DM")) && adv_payment < 0)// this is the last entry subtract advance pay
                            {
                                data_amount += adv_payment;
                            }
                            if ((icnt >= 1) && (icnt <= 2))
                            {
                                if (status.Equals("X"))
                                {
                                    cutDate = dateTimePicker1.Value.AddDays(-1);
                                    DateTime disco = getLastDisco(ldata.master_id);
                                    if (disco.Date <= cutDate)
                                    {
                                        TimeSpan ts = cutDate - disco.Date;
                                        if (ts.Days >= 366)
                                        {
                                            /**   if (data_amount < 0)
                                               {
                                                   days0 += data_amount;
                                               }
                                               else
                                               {*/
                                            days365over += data_amount;
                                            //  }
                                            continue;
                                        }
                                        else if ((ts.Days >= 181) && (ts.Days <= 365))
                                        {
                                            if ((data_amount < 0) && (!code.Equals("SNR")))
                                            {
                                                days0 += data_amount;
                                            }
                                            else
                                            {
                                                days181to365 += data_amount;
                                            }
                                            continue;
                                        }
                                        else if ((ts.Days >= 61) && (ts.Days <= 180))
                                        {
                                            if ((data_amount < 0) && (!code.Equals("SNR")))
                                            {
                                                days0 += data_amount;
                                            }
                                            else
                                            {
                                                days61to180 += data_amount;
                                            }
                                            continue;
                                        }
                                        else if ((ts.Days >= 0) && (ts.Days <= 60))
                                        {
                                            if ((data_amount < 0) && (!code.Equals("SNR")))
                                            {
                                                days0 += data_amount;
                                            }
                                            else
                                            {

                                            }
                                            {
                                                days1to60 += data_amount;
                                            }
                                            continue;
                                        }
                                    }

                                }
                                else
                                {

                                    days1to60 += data_amount;

                                    if (code.Equals("BILL"))
                                    {
                                        icnt++;
                                    }
                                }
                                continue;

                            } //if ((icnt >= 1) && (icnt <= 2))
                            if ((icnt >= 3) && (icnt <= 6))
                            {

                                days61to180 += data_amount;

                                if (code.Equals("BILL"))
                                {
                                    icnt++;
                                }
                                continue;
                            }
                            if ((icnt >= 7) && (icnt <= 12))
                            {

                                days181to365 += data_amount;

                                if (code.Equals("BILL"))
                                {
                                    icnt++;
                                }
                                continue;
                            }
                            if (icnt > 12)
                            {
                                days365over += data_amount;
                                continue;
                            }


                        }// foreach (tbLedger ldata in reverse_iebills)

                        int pay_count = iePays.Count();
                        decimal total_amt = total_bill_amount;
                        if (pay_count > 0)
                        {

                            decimal total_payment = (decimal)iePays.Sum(x => x.amount);
                            decimal total_pay = 0;
                            foreach (tbLedger pays in iePays)
                            {

                                decimal pamount = (decimal)pays.amount;
                                decimal sobra = 0;
                                total_amt -= pamount;
                                total_pay += pamount;

                                if (days365over > 0)
                                {
                                    if (pamount > days365over)
                                    {
                                        sobra = pamount - days365over;
                                        days365over = 0;
                                    }
                                    else
                                    {

                                        days365over -= pamount;
                                    }

                                    if (sobra > 0)
                                    {
                                        if (sobra < days181to365)
                                        {
                                            days181to365 -= sobra;
                                        }
                                        else
                                        {
                                            sobra = sobra - days181to365;
                                            days181to365 = 0;
                                        }
                                        continue;
                                    }

                                    if (sobra > 0)
                                    {
                                        if (sobra < days1to60)
                                        {
                                            days1to60 -= sobra;
                                        }
                                    }

                                    continue;
                                }
                                if (days181to365 > 0)
                                {
                                    if (pamount < days181to365)
                                    {
                                        days181to365 -= pamount;
                                    }
                                    else
                                    {
                                        sobra = pamount - days181to365;
                                        days181to365 = 0;
                                    }
                                    if (sobra > 0)
                                    {
                                        if (sobra < days61to180)
                                        {
                                            days61to180 -= sobra;
                                            sobra = 0;
                                        }
                                        else
                                        {
                                            sobra = sobra - days61to180;
                                            days61to180 = 0;
                                        }
                                    }
                                    if (sobra > 0)
                                    {
                                        if (sobra < days1to60)
                                        {
                                            days1to60 -= sobra;
                                        }
                                    }
                                    continue;
                                }

                                if (days61to180 > 0)
                                {
                                    if (pamount < days61to180)
                                    {
                                        days61to180 -= pamount;
                                        pamount = 0;
                                    }
                                    else
                                    {
                                        sobra = pamount - days61to180;
                                        days61to180 = 0;
                                    }
                                    if (sobra > 0)
                                    {
                                        if (sobra < days1to60)
                                        {
                                            days1to60 -= sobra;
                                        }
                                    }
                                    continue;
                                }

                                if (days1to60 != 0)
                                {
                                    if (pamount < days1to60)
                                    {
                                        days1to60 -= pamount;
                                        pamount = 0;
                                    }

                                    if (days1to60 < 0)
                                    {
                                        days0 += days1to60;
                                        days1to60 = 0;
                                    }
                                    continue;
                                }


                                if (total_amt < 0)
                                {
                                    days1to60 = 0;
                                    days0 = total_amt;
                                }

                            }
                        }//if (pay_count > 0)

                        tbMasterAging mastAging = new tbMasterAging();
                        mastAging.master_id = mast.master_id;
                        mastAging.status = mast.status.Trim();
                        mastAging.zone_id = mast.zone_id;
                        mastAging.date_generated = DateTime.Today;
                        if (adv_payment < 0)
                        {
                            mastAging.balance = total_amt + adv_payment;
                        }
                        else
                        {
                            mastAging.balance = total_amt;
                        }

                        if (mastAging.balance <= 0)
                        {
                            mastAging.day1to60 = 0;
                            mastAging.day61to180 = 0;
                            mastAging.day181to365 = 0;
                            mastAging.over365 = 0;
                            if (negBalance < 0)
                            {
                                mastAging.day0 = negBalance;
                                mastAging.balance = negBalance;
                            }
                            else
                            {
                                mastAging.day0 = total_amt;
                            }
                        }
                        else
                        {
                            mastAging.day1to60 = days1to60;
                            mastAging.day61to180 = days61to180;
                            mastAging.day181to365 = days181to365;
                            mastAging.over365 = days365over;
                            mastAging.day0 = days0;
                        }
                        mastAging.ctgy = mast.category;
                        mastAging.billing_id = billing_ID;
                        dbcontext.AddTotbMasterAgings(mastAging);
                    }
                    int percentage = (rec_count + 1) * 100 / 20000;
                    backgroundWorker1.ReportProgress(percentage,rec_count);
                } //foreach (tbMaster mast in qMaster)
                dbcontext.SaveChanges();
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
            //ProgressBar1.Value = Convert.ToInt32(e.UserState.ToString());
            progressBar1.PerformStep();
            label3.Text = string.Format("Thread 1 Total Processed {0} of 20000 ({1}%)",e.UserState.ToString(),e.ProgressPercentage);
            label5.Text = string.Format("Time Elapsed : {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            string acctno = "";
            string oldtxt = this.Text;
            string status = "";
            decimal negFBAL = 0;
            DateTime cutDate = dateTimePicker1.Value.AddDays(-1);


            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                //string agingstr = TextPrompt.ShowDialog("Enter Account:", "Aging");
                // var qMaster = dbcontext.tbMasters.Where(x => x.acctno.Equals(agingstr));
                // var qMaster = dbcontext.tbMasters.Where(x => x.acctno.Equals("025719"));
                //var qMaster = dbcontext.tbMasters.Where(x => x.master_id > 25615 && x.category!=0 && x.zone_id!=0);
                //var qMaster = dbcontext.tbMasters.Where(x => x.master_id == 14624);

                // var qPaid = dbcontext.tbLedgers.Where(x=>x.remarks.Contains("Paid 7/31/2014") && x.code.Equals("PAID"));

                var qMaster = dbcontext.tbMasters.Where(x => x.category != 0 && x.zone_id != 0 && x.category != 0 && x.master_id >= 20001);
                //var qMaster = dbcontext.tbMasters.Where(x => x.master_id == 17077);
                var global_ledger = dbcontext.tbLedgers;
                int rec_count = 0;
                foreach (tbMaster mast in qMaster)
                {

                    rec_count++;

                    acctno = mast.acctno;
                    if (mast.status != null)
                    {
                        status = mast.status.TrimEnd();
                    }

                    decimal rbalance = globfunc.getBalance(mast.master_id);


                  //  string logFile = "";
                  //  logFile = string.Format(@"F:\repair\AgingThread2.txt");
                  //  globfunc.saveLogFile(logFile,acctno);

                    if (rbalance <= 0)
                    {
                        tbMasterAging mAging = new tbMasterAging();
                        mAging.master_id = mast.master_id;
                        mAging.status = mast.status;
                        mAging.zone_id = mast.zone_id;
                        mAging.date_generated = DateTime.Today;
                        mAging.balance = rbalance;
                        mAging.day0 = rbalance;
                        mAging.day1to60 = 0;
                        mAging.day61to180 = 0;
                        mAging.day181to365 = 0;
                        mAging.over365 = 0;
                        mAging.ctgy = mast.category;
                        mAging.billing_id = billing_ID;
                        dbcontext.AddTotbMasterAgings(mAging);
                        IDisposable disp = mAging as IDisposable;
                        if (disp != null) { disp.Dispose(); }
                    }
                    else
                    {

                        //Prepare the hidden negative FBAL
                        if (!Negative_Fbal.TryGetValue(mast.master_id, out negFBAL))
                        {
                            negFBAL = 0;
                        }

                        //var qLedger = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id && x.trans_date <= new DateTime(2014,8,5));
                        DateTime cutoff = dateTimePicker1.Value;
                        //int qLastZeroTransaction = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id && x.balance<=0 &&!x.code.Substring(0, 4).Equals("canc"))
                        //                            .OrderByDescending(p=>p.ledger_id).Select(r=>r.ledger_id).First();

                        int qLastZeroTransaction = global_ledger.Where(x => x.master_id == mast.master_id && x.amount > 0 && x.balance <= 0 && !x.code.Substring(0, 4).Equals("canc"))
                                                    .OrderByDescending(p => p.ledger_id).Select(r => r.ledger_id).FirstOrDefault();
                        decimal adv_payment = Convert.ToDecimal(global_ledger.Where(x => x.ledger_id == qLastZeroTransaction).Select(x => x.balance).FirstOrDefault());
                        //var qLedger = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id && x.trans_date < cutoff);
                        var qLedger = global_ledger.Where(x => x.master_id == mast.master_id && x.trans_date < cutoff && x.ledger_id > qLastZeroTransaction);
                        int ledger_count = qLedger.Count();
                        if ((qLedger == null) || (ledger_count == 0))
                        {
                            decimal balance = rbalance;
                            tbMasterAging mAging = new tbMasterAging();
                            mAging.master_id = mast.master_id;
                            mAging.status = mast.status.TrimEnd();
                            mAging.zone_id = mast.zone_id;
                            mAging.date_generated = DateTime.Today;

                            if (balance < 0)
                            {
                                if (mAging.status.Equals("X"))
                                {
                                    mAging.day0 = balance;
                                    mAging.balance = balance;
                                }
                                else
                                {
                                    mAging.day0 = 0;
                                    mAging.balance = 0;
                                }
                            }
                            else
                            {
                                mAging.day0 = 0;
                                mAging.balance = 0;
                            }
                            mAging.day1to60 = 0;
                            mAging.day61to180 = 0;
                            mAging.day181to365 = 0;
                            mAging.over365 = 0;
                            mAging.ctgy = mast.category;
                            mAging.billing_id = billing_ID;
                            dbcontext.AddTotbMasterAgings(mAging);
                            continue;
                        }
                        //var qLedger = dbcontext.tbLedgers.Where(x => x.master_id == mast.master_id);

                        IEnumerable<tbLedger> ieLedger = qLedger.AsEnumerable();
                        // IEnumerable<tbLedger> neLedger = qLedger.AsEnumerable();
                        List<tbLedger> ieBills = new List<tbLedger>();
                        List<tbLedger> iePays = new List<tbLedger>();
                        int billID = 0;
                        decimal amount = 0;
                        decimal negBalance = 0;


                        foreach (tbLedger lData in qLedger)
                        {
                            string tset = lData.code;
                            if (lData.code == null) tset = "";
                            if ((tset.Equals("BILL")) || (tset.Equals("PNLT")) || (tset.Equals("SNR")) || (lData.code.Equals("FBAL"))
                                || (tset.Equals("DMWS")) || (tset.Equals("DMAR")) || (tset.Equals("DMPN")) || (tset.Equals("CANC")) || (tset.Equals("DMIF")))
                            {
                                /**
                                if (lData.trans_date >= new DateTime(2014, 8, 1))
                                {
                                    continue;
                                }*/
                                if ((tset.Equals("PNLT")) && (lData.amount == 0))
                                {
                                    continue;
                                }
                                try
                                {
                                    billID = (int)lData.billing_id;
                                }
                                catch
                                {
                                    int belleng = billing_ID;
                                    billID = belleng;
                                }
                                amount = lData.amount.HasValue ? (decimal)lData.amount : 0;

                                if (negBalance < 0)
                                {
                                    amount += negBalance;
                                    negBalance = 0;
                                }
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = lData.code;
                                ieBills.Add(nLedger);
                                continue;
                            }

                            if ((tset.ToUpper().Equals("PAID")) || (tset.Equals("CMWS")) || (tset.Equals("CMAR")) || (tset.Equals("CMPN")) || (tset.Equals("Pd_DV")))
                            {
                                try
                                {
                                    amount = (decimal)lData.amount;
                                }
                                catch (NullReferenceException)
                                {
                                    amount = 0;
                                }

                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = lData.code;
                                iePays.Add(nLedger);
                            }

                            if (tset.Equals("CMIFref"))
                            {
                                amount = decimal.TryParse(lData.other.ToString(), out amount) ? amount : 0;
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = lData.code;
                                iePays.Add(nLedger);

                            }

                            if (negFBAL != 0)
                            {
                                amount = negFBAL;
                                tbLedger nLedger = new tbLedger();
                                nLedger.master_id = mast.master_id;
                                nLedger.amount = amount;
                                nLedger.ledger_id = lData.ledger_id;
                                nLedger.code = "FBAL";
                                iePays.Add(nLedger);
                                negFBAL = 0;
                            }
                        } //foreach (tbLedger lData in qLedger)

                        IDisposable disp = qLedger as IDisposable;
                        if (disp != null) { disp.Dispose(); }

                        var reverse_iebills = ieBills.OrderByDescending(x => x.ledger_id);
                        int icnt = 1;
                        decimal days0 = 0;
                        decimal days1to60 = 0;
                        decimal days61to180 = 0;
                        decimal days181to365 = 0;
                        decimal days365over = 0;
                        decimal total_bill_amount = Convert.ToDecimal(ieBills.Sum(x => x.amount));
                        decimal ibalance = total_bill_amount;

                        int cnter = 0;
                        foreach (tbLedger ldata in reverse_iebills)
                        {


                            string code = ldata.code;
                            decimal data_amount = Convert.ToDecimal(ldata.amount);
                            if (code == null) code = "";
                            ++cnter;
                            if ((cnter == reverse_iebills.Count()) && (code.Equals("BILL") || code.Substring(0, 2).Equals("DM")) && adv_payment < 0)// this is the last entry subtract advance pay
                            {
                                data_amount += adv_payment;
                            }
                            if ((icnt >= 1) && (icnt <= 2))
                            {
                                if (status.Equals("X"))
                                {
                                    cutDate = dateTimePicker1.Value.AddDays(-1);
                                    DateTime disco = getLastDisco(ldata.master_id);
                                    if (disco.Date <= cutDate)
                                    {
                                        TimeSpan ts = cutDate - disco.Date;
                                        if (ts.Days >= 366)
                                        {
                                            /**   if (data_amount < 0)
                                               {
                                                   days0 += data_amount;
                                               }
                                               else
                                               {*/
                                            days365over += data_amount;
                                            //  }
                                            continue;
                                        }
                                        else if ((ts.Days >= 181) && (ts.Days <= 365))
                                        {
                                            if ((data_amount < 0) && (!code.Equals("SNR")))
                                            {
                                                days0 += data_amount;
                                            }
                                            else
                                            {
                                                days181to365 += data_amount;
                                            }
                                            continue;
                                        }
                                        else if ((ts.Days >= 61) && (ts.Days <= 180))
                                        {
                                            if ((data_amount < 0) && (!code.Equals("SNR")))
                                            {
                                                days0 += data_amount;
                                            }
                                            else
                                            {
                                                days61to180 += data_amount;
                                            }
                                            continue;
                                        }
                                        else if ((ts.Days >= 0) && (ts.Days <= 60))
                                        {
                                            if ((data_amount < 0) && (!code.Equals("SNR")))
                                            {
                                                days0 += data_amount;
                                            }
                                            else
                                            {

                                            }
                                            {
                                                days1to60 += data_amount;
                                            }
                                            continue;
                                        }
                                    }

                                }
                                else
                                {

                                    days1to60 += data_amount;

                                    if (code.Equals("BILL"))
                                    {
                                        icnt++;
                                    }
                                }
                                continue;

                            } //if ((icnt >= 1) && (icnt <= 2))
                            if ((icnt >= 3) && (icnt <= 6))
                            {

                                days61to180 += data_amount;

                                if (code.Equals("BILL"))
                                {
                                    icnt++;
                                }
                                continue;
                            }
                            if ((icnt >= 7) && (icnt <= 12))
                            {

                                days181to365 += data_amount;

                                if (code.Equals("BILL"))
                                {
                                    icnt++;
                                }
                                continue;
                            }
                            if (icnt > 12)
                            {
                                days365over += data_amount;
                                continue;
                            }


                        }// foreach (tbLedger ldata in reverse_iebills)

                        int pay_count = iePays.Count();
                        decimal total_amt = total_bill_amount;
                        if (pay_count > 0)
                        {

                            decimal total_payment = (decimal)iePays.Sum(x => x.amount);
                            decimal total_pay = 0;
                            foreach (tbLedger pays in iePays)
                            {

                                decimal pamount = (decimal)pays.amount;
                                decimal sobra = 0;
                                total_amt -= pamount;
                                total_pay += pamount;

                                if (days365over > 0)
                                {
                                    if (pamount > days365over)
                                    {
                                        sobra = pamount - days365over;
                                        days365over = 0;
                                    }
                                    else
                                    {

                                        days365over -= pamount;
                                    }

                                    if (sobra > 0)
                                    {
                                        if (sobra < days181to365)
                                        {
                                            days181to365 -= sobra;
                                        }
                                        else
                                        {
                                            sobra = sobra - days181to365;
                                            days181to365 = 0;
                                        }
                                        continue;
                                    }

                                    if (sobra > 0)
                                    {
                                        if (sobra < days1to60)
                                        {
                                            days1to60 -= sobra;
                                        }
                                    }

                                    continue;
                                }
                                if (days181to365 > 0)
                                {
                                    if (pamount < days181to365)
                                    {
                                        days181to365 -= pamount;
                                    }
                                    else
                                    {
                                        sobra = pamount - days181to365;
                                        days181to365 = 0;
                                    }
                                    if (sobra > 0)
                                    {
                                        if (sobra < days61to180)
                                        {
                                            days61to180 -= sobra;
                                            sobra = 0;
                                        }
                                        else
                                        {
                                            sobra = sobra - days61to180;
                                            days61to180 = 0;
                                        }
                                    }
                                    if (sobra > 0)
                                    {
                                        if (sobra < days1to60)
                                        {
                                            days1to60 -= sobra;
                                        }
                                    }
                                    continue;
                                }

                                if (days61to180 > 0)
                                {
                                    if (pamount < days61to180)
                                    {
                                        days61to180 -= pamount;
                                        pamount = 0;
                                    }
                                    else
                                    {
                                        sobra = pamount - days61to180;
                                        days61to180 = 0;
                                    }
                                    if (sobra > 0)
                                    {
                                        if (sobra < days1to60)
                                        {
                                            days1to60 -= sobra;
                                        }
                                    }
                                    continue;
                                }

                                if (days1to60 != 0)
                                {
                                    if (pamount < days1to60)
                                    {
                                        days1to60 -= pamount;
                                        pamount = 0;
                                    }

                                    if (days1to60 < 0)
                                    {
                                        days0 += days1to60;
                                        days1to60 = 0;
                                    }
                                    continue;
                                }


                                if (total_amt < 0)
                                {
                                    days1to60 = 0;
                                    days0 = total_amt;
                                }

                            }
                        }//if (pay_count > 0)

                        tbMasterAging mastAging = new tbMasterAging();
                        mastAging.master_id = mast.master_id;
                        mastAging.status = mast.status.Trim();
                        mastAging.zone_id = mast.zone_id;
                        mastAging.date_generated = DateTime.Today;
                        if (adv_payment < 0)
                        {
                            mastAging.balance = total_amt + adv_payment;
                        }
                        else
                        {
                            mastAging.balance = total_amt;
                        }

                        if (mastAging.balance <= 0)
                        {
                            mastAging.day1to60 = 0;
                            mastAging.day61to180 = 0;
                            mastAging.day181to365 = 0;
                            mastAging.over365 = 0;
                            if (negBalance < 0)
                            {
                                mastAging.day0 = negBalance;
                                mastAging.balance = negBalance;
                            }
                            else
                            {
                                mastAging.day0 = total_amt;
                            }
                        }
                        else
                        {
                            mastAging.day1to60 = days1to60;
                            mastAging.day61to180 = days61to180;
                            mastAging.day181to365 = days181to365;
                            mastAging.over365 = days365over;
                            mastAging.day0 = days0;
                        }
                        mastAging.ctgy = mast.category;
                        mastAging.billing_id = billing_ID;
                        dbcontext.AddTotbMasterAgings(mastAging);
                    }
                    int percentage = (rec_count + 1) * 100 / (totalNUMBER-20000);
                    backgroundWorker2.ReportProgress(percentage,rec_count);
                } //foreach (tbMaster mast in qMaster)
                dbcontext.SaveChanges();
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar2.Value = e.ProgressPercentage;
            progressBar2.PerformStep();
            label4.Text = string.Format("Thread 2 Total Processed {0} of {1} ({2}%)", e.UserState.ToString(), totalNUMBER - 20000, e.ProgressPercentage);
            //this.Text = string.Format("Thread 2 Total Processed {0} of {1} ({2}%)", e.UserState.ToString(), totalNUMBER - 20000, e.ProgressPercentage);
            
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label4.Text = "Thread 2 is finished";
            work2 = true;
            if (work2 && work1)
            {
                MessageBox.Show("Aging Generation is done");
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label3.Text = "Thread 1 is finished";
            work1 = true;
            if (work2 && work1)
            {
                MessageBox.Show("Aging Generation is done");
            }
        }


    } // class
}
