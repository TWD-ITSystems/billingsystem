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
    public partial class formDormantMonitor : Form
    {
        class DormantAccount
        {
            public int masterID { get; set; }
            public string acctno { get; set; }
            public string name { get; set; }
            public string address { get; set; }
            public string zone { get; set; }            
            public int cardno { get; set; }
            public int category { get; set; }
            public DateTime datedisco { get; set; }
            public decimal arrears { get; set; }
            public decimal amountpaid{ get; set; }
            public DateTime datepaid { get; set; }
            public decimal balance { get; set; }
            public int paidcount { get; set; }
            public string currentstatus { get; set; }
            public DateTime dategenerated { get; set; }
            public string baselinedata { get; set; }
        }

        class PaymentsClass
        {
            public int masterID { get; set; }
            public decimal amountpaid { get; set; }
            public DateTime datepaid { get; set; }
            public int paidcount { get; set; }            
        }

        List<DormantAccount> dormantAccnts = new List<DormantAccount>();
        GlobalFunctions gfunc = new GlobalFunctions();
        public formDormantMonitor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            using (dbCommercialEntities dbContext = new dbCommercialEntities())
            {
                var query = dbContext.tbMasters.Where(x => x.status.Equals("x"));
                int rec = query.Count();
                foreach (tbMaster master in query)
                {
                    i++;
                    DormantAccount dmAccnt = new DormantAccount();
                    dmAccnt.masterID = master.master_id;
                    dmAccnt.acctno = master.acctno;
                    dmAccnt.address = master.address;
                    dmAccnt.name = master.name;
                    dmAccnt.zone = gfunc.getZoneName(master.zone_id);
                    dmAccnt.cardno = Convert.ToInt32(master.cardno);
                    dmAccnt.category = Convert.ToInt32(master.category);
                    if (master.last_disco_date != null)
                    {
                        dmAccnt.datedisco = Convert.ToDateTime(master.last_disco_date);
                    }
                    
                    dmAccnt.arrears = gfunc.getBalance(master.master_id);
                    dmAccnt.baselinedata = "12-2020";
                    dormantAccnts.Add(dmAccnt);
                }
            }
            MessageBox.Show(String.Format("Data loaded to memory [records: {0} ]", i));
            i = 0;
            using (dbCommercialEntitiesLIVE liveContext = new dbCommercialEntitiesLIVE())
            {
                foreach (DormantAccount dmAct in dormantAccnts)
                {
                    i++;
                    tbDormantMonitoring liveAcct = new tbDormantMonitoring();
                    liveAcct.masterID = dmAct.masterID;
                    liveAcct.acctno = dmAct.acctno;
                    liveAcct.address = dmAct.address;
                    liveAcct.name = dmAct.name;
                    liveAcct.zone = dmAct.zone;
                    liveAcct.cardno = dmAct.cardno;
                    liveAcct.category = dmAct.category;
                   liveAcct.date_disconnected = dmAct.datedisco;
                    liveAcct.arrears = dmAct.arrears;
                    liveAcct.baseline_data = dmAct.baselinedata;
                    liveContext.AddTotbDormantMonitorings(liveAcct);                    
                }
                liveContext.SaveChanges();
            }
            MessageBox.Show(String.Format("Save to Live Server [records: {0} ]", i));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntitiesLIVE liveContext = new dbCommercialEntitiesLIVE())
            {
                var dmaccounts = liveContext.tbDormantMonitorings.Where(x => x.baseline_data.Equals("12-2020")).Select(x=>x);
                int mastID = 0;
                foreach(tbDormantMonitoring dmAcct in dmaccounts)
                {
                    PaymentsClass pClass = new PaymentsClass();
                    mastID = Convert.ToInt32(dmAcct.masterID);
                    pClass = updatePayments(mastID,dateTimePicker1.Value);
                    if (pClass.amountpaid > 0)
                    {
                        dmAcct.amount_paid = pClass.amountpaid;
                        dmAcct.date_paid = pClass.datepaid;
                        dmAcct.paid_count = pClass.paidcount;
                        dmAcct.date_generated = DateTime.Today;
                        dmAcct.current_status = gfunc.getStatus(mastID);
                        dmAcct.balance = gfunc.getBalance(mastID);                      
                        
                    }
                }
                liveContext.SaveChanges();
                MessageBox.Show("Payment transactions successfully updated");
            }
        }

        private PaymentsClass updatePayments(int masterID, DateTime cutoff)
        {
            DateTime baseDate = new DateTime(2020,12,31);
            PaymentsClass pClass = new PaymentsClass();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var payments_made = dbcontext.tbLedgers.Where(x => x.master_id == masterID && (x.code.Equals("Paid") || x.code.Equals("paid")) && (x.trans_date >= baseDate && x.trans_date <= cutoff)).Select(x => x);
                if (payments_made != null)
                {                  
                    int paycounter = 0;
                    DateTime payDate = new DateTime();
                    decimal total = 0;
                    foreach (tbLedger ledger in payments_made)
                    {
                        payDate = Convert.ToDateTime(ledger.trans_date);
                        total = total + Convert.ToDecimal(ledger.amount);
                        paycounter++;                                               
                    }
                    PaymentsClass returnClass = new PaymentsClass() { amountpaid = total, paidcount = paycounter, datepaid = payDate };
                    pClass = returnClass;
                }
            }
            return pClass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baseData = comboBox1.Text;           
            this.tbDormantMonitoringTableAdapter.FillByBaseData(this.dsDormantMonitor.tbDormantMonitoring, baseData);
            if (gridView1.RowCount>0)btnExport.Visible = true;
        }

        private void formDormantMonitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDormantMonitor.tbDormantMonitoring' table. You can move, or remove it, as needed.
           // this.tbDormantMonitoringTableAdapter.Fill(this.dsDormantMonitor.tbDormantMonitoring);
            comboBox1.SelectedIndex = 0;

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                DialogResult dlgResult = saveFileDialog1.ShowDialog();
                if (dlgResult == DialogResult.OK)
                {
                    string filepath = saveFileDialog1.FileName;
                    gridView1.ExportToXlsx(filepath);
                    MessageBox.Show("Export to xlsx is successfull");
                }
            }
            else
            {
                MessageBox.Show("There is no data to show");
            }
        }
    }
}
