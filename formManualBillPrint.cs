using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using BillingSystem.models;

namespace BillingSystem
{
    public partial class formManualBillPrint : Form
    {
        public string username = "";

        public formManualBillPrint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           // frmReport frm = new frmReport();
           //// frm.param = param;
           // frm.rptMode = 30;
           // frm.Show();

           // RawPrinterHelper.SendFileToPrinter()

            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();

            var maxRes = pd.PrinterSettings.PrinterResolutions.OfType<PrinterResolution>()
                .OrderByDescending(r => r.X)
                .ThenByDescending(r => r.Y)
                .First();

            int maxX = maxRes.X;
            int linecount = 16;
            //printTest();
            //printTemplate();
            //printTemplate(true);
            //printTemplate(true);
            //printTemplate(true);
            //printTemplate(true);
            //printTemplate(true);
            RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, @"C:\manualbill.txt");
            btnProcessed.Hide();
            btnPrinting.Hide();
            txtRefnum.Clear();
        }
       

        void saveToTextFile(dsManualBill.tbManualBillsRow m,bool mode=false)
        {
            string strTemplate = "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@{0,7}@@@{1,18}@@@@{2,12}@@@@{3,7}@@@{4,18}@@@{5,12}@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@{6,-30}@@@@@@@@@@@@@@@@@@@{7,-30}@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@{8,-30}@@@@@@@@@@@@@@@@@@@{9,-30}@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@{10,5}@@@@@{11,5}@@@@@{12,6}@@@@{13,6}@@@{14,5}@@@{15,5}@@@@@{16,5}@@@@@{17,6}@@@@{18,6}@@@{19,5}" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                               "@@@@@@@@@@@@@@@@@@@@@Current    ->  {20,10}@@@@@@@@@@@@@@@@@@@@@@@Current    ->  {21,10}@@@@@@@@@" + "\n" +
                               "@@@@@@@@@@@@@@@@@@@@@Arrears    ->  {22,10}@@@@@@@@@@@@@@@@@@@@@@@Arrears    ->  {23,10}@@@@@@@@@" + "\n" +
                               "@@@@@@@@@@@@@@@@@@@@@Mtr.Maint. ->  {24,10}@@@@@@@@@@@@@@@@@@@@@@@Mtr.Maint. ->  {25,10}@" + "\n" +
                               "@@@@@@@@@@@@@@@@@@@@@Dmg. Mtr.  ->  {26,10}@@@@@@@@@@@@@@@@@@@@@@@Dmg .Mtr.  ->  {27,10}@" + "\n" +
                               "@@@@@@@@@@@@@@@@@@@@@Inst. Fee  ->  {28,10}@@@@@@@@@@@@@@@@@@@@@@@Inst. Fee  ->  {29,10}@" + "\n" +
                               "@@@@@@@@@@@@@@@@@@@@@==========================@@@@@@@@@@@@@@@@@@@@@@=========================" + "\n" +
                               "@@@@@@@@@@@@@@@@@@@@@** Total **       {30,7}@@@@@@@@@@@@@@@@@@@@@@@** Total **       {31,7}" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n \n \n " +
                                 "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@TAGUM WATER DISTRICT OFFICE@@@@@@" + "\n" +
                                 "\n \n \n \n \n \n";

            string newStr = strTemplate.Replace("@"," ");
            
            using (StreamWriter writer = new StreamWriter(@"C:\manualbill.txt", mode))
            {
                string acctDetails =  string.Format("{0}/{1}/{2}",m.acctno,m.zone,m.cardno);
                decimal? total = m.current_amt + m.mtrmaintenance + m.instfee + m.arrears;                
                string prevdate = m.prev_rdg_date.ToShortDateString().Substring(0,5);
                string presdate = m.pres_rdg_date.ToShortDateString().Substring(0,5);
                string addr = m.address.PadRight(30,' ');
                int tmp = addr.Length;
                string nam = m.name.PadRight(30,' ');
                int tmp1 = nam.Length;
                writer.WriteLine(string.Format(newStr, m.billmonth,acctDetails, m.meter_num,m.billmonth,acctDetails,m.meter_num,
                    nam.Substring(0, 29), nam.Substring(0, 29),
                    addr.Substring(0,29),addr.Substring(0,29),
                    prevdate,presdate, m.pres_rdg, m.prev_rdg, m.volume,prevdate,presdate, m.pres_rdg, m.prev_rdg, m.volume,
                    m.current_amt,m.current_amt,
                    m.arrears,m.arrears,
                               m.mtrmaintenance,m.mtrmaintenance,
                               "0.00","0.00",
                               m.instfee,m.instfee,
                               total,total
                    ));
                writer.Dispose();
            }


        }

        private void formManualBillPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsManualBill.tbManualBills' table. You can move, or remove it, as needed.
         //   this.tbManualBillsTableAdapter.Fill(this.dsManualBill.tbManualBills);
            // TODO: This line of code loads data into the 'dsManualBill.tbManualBills' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'dsZone.tbZone' table. You can move, or remove it, as needed.
            this.tbZoneTableAdapter.Fill(this.dsZone.tbZone);
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
            cmbZone.SelectedIndex = 0;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.tbManualBillsTableAdapter.FillByBillmonthZone(this.dsManualBill.tbManualBills, cmbBillmonth.Text, cmbZone.Text);
            }
            else
            {
                this.tbManualBillsTableAdapter.FillByBillwithArrears(this.dsManualBill.tbManualBills, cmbBillmonth.Text, cmbZone.Text);
            }
            int totalbills = this.tbManualBillsBindingSource.Count;
            labelTotal.Text = string.Format("Total Number of Bills : {0}", totalbills);
            if (totalbills > 0) btnRefnum.Show();
          //  var ds = dsManualBill.tbManualBills.AsEnumerable();   
            
            
          
        }

        private void btnRefnum_Click(object sender, EventArgs e)
        {
            if (txtRefnum.Text.Length > 0)
            {
                int i = 0;
                foreach (var tbManual in dsManualBill.tbManualBills)
                {
                    tbManual.refnum = string.Format("{0}", Convert.ToInt32(txtRefnum.Text) + i++);
                }
                btnProcessed.Show();
            }
            else
            {
                MessageBox.Show("Please provide Reference Number.");
            }
            gridView1.RefreshData();
        }

        private void btnProcessed_Click(object sender, EventArgs e)
        {
            //processedManualBills();
            try
            {
                processedManualBills();
                MessageBox.Show("Records processing is successful. You can now proceed to printing.");
                btnPrinting.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing records.");
            }
        }

        void processedManualBills()
        {
            int counter = 0;
            foreach (var tbManual in dsManualBill.tbManualBills)
            {
                if (radioButton1.Checked == true)
                {
                    if (counter == 0)
                    {
                        saveToTextFile(tbManual);
                        counter++;
                    }
                    else
                    {
                        saveToTextFile(tbManual, true);
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    if (counter == 0)
                    {
                        loadtoTemplateArrears(tbManual);
                        counter++;
                    }
                    else
                    {
                        loadtoTemplateArrears(tbManual, true);
                    }
                }
                saveRefNum(tbManual.manual_id, tbManual.refnum);
            }
        }

        void saveRefNum(int manualID, string refnum)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbManualBill manualbill = dbcontext.tbManualBills.Single(x => x.manual_id == manualID);
                manualbill.refnum = refnum;
                manualbill.printed_by = username;
                manualbill.printed_date = DateTime.Today;
                if (manualbill.printed_times.HasValue)
                {
                    manualbill.printed_times += 1;
                }
                else
                {
                    manualbill.printed_times = 1;
                }
                dbcontext.SaveChanges();
            }
        }

        private void chkReprint_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReprint.Checked)
            {
                tabControl1.SelectedTab = tabControl1.TabPages[1];

                btnLoad.Enabled = false;
            }
            else
            {
                tabControl1.SelectedTab = tabControl1.TabPages[0];
                btnLoad.Enabled = true;
                
            }
        }

        private void btnLoadStarting_Click(object sender, EventArgs e)
        {      
            try
            {
                if (radioButton1.Checked)
                {
                    //this.tbManualBillsTableAdapter.FillByBillmonthZone(this.dsManualBill.tbManualBills, cmbBillmonth.Text, cmbZone.Text);
                    this.tbManualBillsTableAdapter.FillByStarting(this.dsManualBill.tbManualBills, cmbBillmonth.Text, cmbZone.Text, Convert.ToInt32(txtStartRefNum.Text));
                }
                else
                {
                    this.tbManualBillsTableAdapter.FillByStartingArrears(this.dsManualBill.tbManualBills, cmbBillmonth.Text, cmbZone.Text, Convert.ToInt32(txtStartRefNum.Text));
                }
                int totalbills = this.tbManualBillsBindingSource.Count;
                labelTotal.Text = string.Format("Total Number of Bills : {0}", totalbills);
                btnProcessed.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show("Error loading Dataset.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void loadtoTemplateArrears(dsManualBill.tbManualBillsRow m, bool mode = false)
        {
            string strTemplate =   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "{0,7}@@@{1,18}@@@@{2,12}@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "@@{3,-30}@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "@@{4,-30}@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "{5,5}@@@@{6,5}@@{7,6}@@@@{8,6}@@@@@@@{9,5}@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@Current    ->  {10,10}@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@Arrears    ->  {11,10}@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@Mtr.Maint. ->  {12,10}@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@Dmg. Mtr.  ->  {13,10}@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@Inst. Fee  ->  {14,10}@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@==========================@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@** Total **       {15,7}@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n" +
                                   "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" + "\n \n \n " +
                                   "@@@@@@@@@@@@TAGUM WATER DISTRICT OFFICE@@@@@@" + "\n" +
                                   "\n \n \n \n \n \n \n ";

            string newStr = strTemplate.Replace("@", " ");

            using (StreamWriter writer = new StreamWriter(@"C:\manualbill.txt", mode))
            {
                string acctDetails = string.Format("{0}/{1}/{2}", m.acctno, m.zone, m.cardno);
                decimal? total = m.current_amt + m.mtrmaintenance + m.instfee + m.arrears;
                string prevdate = m.prev_rdg_date.ToShortDateString().Substring(0, 5);
                string presdate = m.pres_rdg_date.ToShortDateString().Substring(0, 5);
                string addr = m.address.PadRight(30, ' ');
                int tmp = addr.Length;
                string nam = m.name.PadRight(30, ' ');
                int tmp1 = nam.Length;
                writer.WriteLine(string.Format(newStr, m.billmonth, acctDetails, m.meter_num,
                    nam.Substring(0, 29),
                    addr.Substring(0, 29), 
                    prevdate, presdate, m.pres_rdg, m.prev_rdg, m.volume,
                    m.current_amt,
                    m.arrears, 
                               m.mtrmaintenance,
                               "0.00",
                               m.instfee,
                               total
                    ));
                writer.Dispose();
            }          
        }
 
    }
}
