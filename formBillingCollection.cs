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
    
    public partial class formBillingCollection : Form
    {
        public int userID = 0;
        class BAMClass
        {
            public decimal? amount { get; set; }
            public int? volume { get; set; }
            public int? scCount { get; set; }

        }

        GlobalFunctions gfunc = new GlobalFunctions();
        decimal mtrmtn = 0;
        DateTime limitDate = new DateTime();

        public formBillingCollection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      

            if (radCalendar1.SelectedDate == new DateTime(1900, 1, 1))
            {
                MessageBox.Show("Please select transaction date again.");
                return;
            }

            if (radCalendar1.SelectedDate > DateTime.Today)
            {
                MessageBox.Show("Sorry you cannot generate this report.");
                return;
            }
            else if (radCalendar1.SelectedDate == DateTime.Today)
            {
                if (!(DateTime.Now.Hour >= 15))
                {
                    MessageBox.Show("Sorry you can only generate this report after 3:00PM");
                    return;
                }
            }



            

            DateTime selDate = radCalendar1.SelectedDate;
            limitDate = selDate.AddDays(1);
            DialogResult dlgResult;

            if (!checkDateIfProcessed(selDate))
            {
                dlgResult = MessageBox.Show(string.Format("No report has been generated for {0}. Do you want to generate it anyway?", selDate.ToShortDateString()), "Generate Report", MessageBoxButtons.YesNo);
                if (dlgResult == DialogResult.Yes)
                {
                    processData(selDate);
                
                }
            }
            showReport(selDate);
        }

        private void showReport(DateTime transdate)
        {
            string divmngr = "";
            string deptmngr = "";
            string username = gfunc.getUserFullName(userID);
            string job_desc = gfunc.getUserJobDesc(userID);

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                string qDiv = dbcontext.tbDeptDivisionHeads.FirstOrDefault(x => x.head_id == 6).DeptDivHead;
                divmngr = qDiv;
                string qDept = dbcontext.tbDeptDivisionHeads.FirstOrDefault(x => x.head_id == 3).DeptDivHead;
                deptmngr = qDept;
            }
            ArrayList paramList = new ArrayList();

            paramList.Add(username.ToUpper());
            paramList.Add(job_desc);
            paramList.Add(divmngr.ToUpper());
            paramList.Add(deptmngr.ToUpper());
            paramList.Add(transdate);

            frmReport frm = new frmReport();
            frm.param = paramList;
            frm.rptMode = 19;
            frm.Show();

        }

        private void formBillingCollection_Load(object sender, EventArgs e)
        {
            if (userID == 2) button2.Show();
            mtrmtn = gfunc.getMeterMtn();
            radCalendar1.SelectedDate = DateTime.Today;
        }

        private Boolean checkDateIfProcessed(DateTime date_selected)
        {
            Boolean retval = false;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryDate = dbcontext.tbBillingCollections.FirstOrDefault(x => x.date_trans == date_selected);
                if (queryDate == null)
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

        private void processData(DateTime date_selected)
        {

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                List<int> ZoneList = dbcontext.tbZoneLookups.Select(x => x.zone_uid).ToList();
                foreach (int zoneuid in ZoneList)
                {
                    decimal billsAmount = 0;
                    decimal billsMtn = 0;
                    int billsCount = 0;
                    int billsVolume = 0;

                    decimal penaltyAmount = 0;
                    int penaltyCount = 0;

                    decimal colAmount = 0;
                    decimal colPenalty = 0;
                    decimal colMtrMtn = 0;
                    int colCount = 0;

                    // Process BILLINGS POSTED
                    billsAmount = getSumDataAmount("BILL", date_selected, zoneuid);
                    billsCount = getCountData("BILL", date_selected, zoneuid);
                    billsVolume = getSumDataVolume("BILL", date_selected, zoneuid);
                    if (billsCount > 0)
                    {
                        billsMtn = billsCount * mtrmtn;
                    }
                    else
                    {
                        billsMtn = 0;
                    }

                    tbBillingCollection billColl = new tbBillingCollection();
                    billColl.date_trans = date_selected;
                    billColl.zone = zoneuid;
                    billColl.date_generated = DateTime.Today;
                    billColl.generated_by = gfunc.getUserInitials(userID);

                    tbPay procPay = new tbPay();
                    procPay = getCollectionData(date_selected, zoneuid);

                    if (procPay.name.Equals("OK"))
                    {
                        colAmount = Convert.ToDecimal(procPay.current) + Convert.ToDecimal(procPay.ar_curr) + Convert.ToDecimal(procPay.penalty) + Convert.ToDecimal(procPay.mtrmain);
                        colPenalty = Convert.ToDecimal(procPay.penalty);
                        colMtrMtn = Convert.ToDecimal(procPay.mtrmain);
                        colCount = Convert.ToInt32(procPay.@ref);
                    }
                    
                    //BILLS
                    billColl.bill_amount = billsAmount;
                    billColl.bill_scno = billsCount;
                    billColl.bill_cum = billsVolume;
                    billColl.bill_mtrmtn = billsMtn;

                    //COLLECTIONS
                    billColl.col_amount = colAmount;
                    billColl.col_penalty = colPenalty;
                    billColl.col_mtrmtn = colMtrMtn;
                    billColl.col_scno = colCount;

                    //BAM
                    BAMClass bamProc = new BAMClass();
                    bamProc = getBAMData(date_selected, zoneuid);
                    if (bamProc.scCount > 0)
                    {
                        billColl.bam_amount = bamProc.amount;
                        billColl.bam_cum = bamProc.volume;
                        billColl.bam_scno = bamProc.scCount;
                    }

                    //PENALTY
                    penaltyAmount = getSumDataAmount("PNLT", date_selected, zoneuid);
                    penaltyCount = getCountData("PNLT", date_selected, zoneuid);
                    billColl.bill_penalty = penaltyAmount;
                    if (billsCount <= 0)
                    {
                        billColl.bill_scno = penaltyCount;
                    }

                    dbcontext.AddTotbBillingCollections(billColl);
                }
                dbcontext.SaveChanges();
            }
        }

        private BAMClass getBAMData(DateTime selDate, int zoneUID)
        {
            List<string> bamCodes = new List<string>();
            BAMClass bamData = new BAMClass();
            bamData.scCount = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                bamCodes = dbcontext.tbBAMLookups.Select(x => x.bam_code).ToList();

                var qLedger = dbcontext.tbLedgers.Where(x => bamCodes.Contains(x.code) && ( x.trans_date>=selDate && x.trans_date<limitDate) && x.zoneuid == zoneUID);
                if (qLedger.Count() > 0)
                {
                    bamData.amount = Convert.ToDecimal(qLedger.Sum(x => x.amount));
                    bamData.volume = Convert.ToInt32(qLedger.Sum(x => x.volume));
                    bamData.scCount = Convert.ToInt32(qLedger.Count());
                }
                else
                {
                    bamData.amount = 0;
                    bamData.volume = 0;
                    bamData.scCount = 0;
                }

            }
            return bamData;
        }

        private decimal getSumDataAmount(string code, DateTime selDate, int zoneUID)
        {
            decimal retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryLedger = dbcontext.tbLedgers.Where(x => x.code.Equals(code.Trim()) && (x.trans_date >= selDate && x.trans_date < limitDate) && x.zoneuid == zoneUID).Sum(x => x.amount);
                retval = decimal.TryParse(queryLedger.ToString(), out retval) ? retval : 0;
            }
            return retval;
        }

        private int getSumDataVolume(string code, DateTime selDate, int zoneUID)
        {
            int retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryLedger = dbcontext.tbLedgers.Where(x => x.code.Equals(code.Trim()) && (x.trans_date >= selDate && x.trans_date < limitDate) && x.zoneuid == zoneUID).Sum(x => x.volume);
                retval = Int32.TryParse(queryLedger.ToString(), out retval) ? retval : 0;
            }
            return retval;
        }

        private int getCountData(string code, DateTime selDate, int zoneUID)
        {
            int retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryLedger = dbcontext.tbLedgers.Where(x => x.code.Equals(code.Trim()) && (x.trans_date >= selDate && x.trans_date < limitDate) && x.zoneuid == zoneUID).Count();
                retval = Int32.TryParse(queryLedger.ToString(), out retval) ? retval : 0;
            }
            return retval;
        }

        private tbPay getCollectionData(DateTime date_selected,int zoneuid)
        {
            tbPay tpay = new tbPay();
            string zoneStr = string.Format("{0:00}", zoneuid);


            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryPay = dbcontext.tbPays.Where(x => (x.date >= date_selected && x.date<limitDate) && x.zone_id.Equals(zoneStr) && (x.current >0 || x.ar_curr>0 || x.penalty>0 || x.mtrmain>0));
                if (queryPay.Count() > 0)
                {
                    tpay.name = "OK";
                    tpay.zone_id = zoneStr;
                    tpay.current = queryPay.Sum(x => x.current);
                    tpay.ar_curr = queryPay.Sum(x => x.ar_curr);
                    tpay.penalty = queryPay.Sum(x => x.penalty);
                    tpay.mtrmain = queryPay.Sum(x => x.mtrmain);
                    tpay.@ref = queryPay.Count();
                }
                else
                {
                    tpay.name = "NO";
                }
            }
            return tpay;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                DateTime nDate = new DateTime(2015, 01, 05);
                var qLedger = dbcontext.tbLedgers.Where(x=>x.trans_date>=nDate);
                int i = 0;
                foreach (tbLedger tLedger in qLedger)
                {
                    tLedger.zoneuid = gfunc.getZoneUIDbyMaster(tLedger.master_id);
                    this.Text = string.Format("Processing masterID: {0} / Total Records: {1:n}", tLedger.master_id,i++);
                }
                this.Text = "Done";
                dbcontext.SaveChanges();
            }
            MessageBox.Show("ZoneUID fill done.");
        }

        

    }
}
