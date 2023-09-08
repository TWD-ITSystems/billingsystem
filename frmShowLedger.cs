using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;

namespace BillingSystem
{
    public partial class frmShowLedger : Form
    {
        public int masterID = 0;

        string name = "";
        string acctno = "";
        decimal balance = 0;
        string meterno = "";
        GlobalFunctions globfunc = new GlobalFunctions();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                //return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public frmShowLedger()
        {
            InitializeComponent();
        }



        public frmShowLedger(int master_id):this()
        {
            masterID = master_id;
        }

        private void frmShowLedger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMaster.tbMaster' table. You can move, or remove it, as needed.
            this.tbMasterTableAdapter.FillByMasterID(this.dsMaster.tbMaster, masterID);
            // TODO: This line of code loads data into the 'dsLedger.tbLedger' table. You can move, or remove it, as needed.            
            this.tbLedgerTableAdapter.FillByMasterID(this.dsLedger.tbLedger, masterID);
            labelBalance.Text = string.Format("{0:n}",getBalance().bill_balance);
            balance = Convert.ToDecimal(getBalance().bill_balance);
            name = globfunc.getMasterName(masterID);
            acctno = globfunc.getAcctNo(masterID);
            meterno = globfunc.getMeterNumber(acctno); 
        }

        private tbMasterAcct getBalance()
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMasterAcct query = (from em in dbcontext.tbMasterAccts
                                      where em.master_id == masterID
                                      select em).SingleOrDefault();

                return query;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //gridControl1.ShowPrintPreview();

            string leftcol = string.Format("      \r\n   \r\nName: {0} \r\nAcctNo: {1}    \r\nMeter No.: {2}", name, acctno, meterno);
            string midcol = "TAGUM WATER DISTRICT";
            string rightcol = string.Format("  \r\n   \r\nBalance : {0:n}", balance);
            PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.Clear();
            phf.Header.Content.AddRange(new string[] { leftcol, midcol, rightcol });

            phf.Header.LineAlignment = BrickAlignment.Near;
            printableComponentLink1.CreateDocument();
            printableComponentLink1.ShowPreview();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                textBox1.Focus();
            }else
            {
                this.tbLedgerTableAdapter.FillByMasterID(this.dsLedger.tbLedger, masterID);
                textBox1.Enabled = false;
                textBox1.Clear();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int yearfilter = Int32.TryParse(textBox1.Text,out yearfilter)?yearfilter:0;
                this.tbLedgerTableAdapter.FillByYear(this.dsLedger.tbLedger, masterID, yearfilter);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            string code = gridView1.GetFocusedRowCellValue("code").ToString();
            string refnum = gridView1.GetFocusedRowCellValue("ref").ToString();
            if (code.Equals("PAID"))
            {
                MessageBox.Show(string.Format("Time Paid : {0}",getORTime(refnum)));
            }
        }

        private string getORTime(string refnum)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                int refn = Convert.ToInt32(refnum);
                var paytime = dbcontext.tbPays.FirstOrDefault(x => x.@ref==refn).time_pay;
                if (paytime.HasValue)
                {
                    return paytime.Value.ToShortTimeString();
                }
            }
            return string.Empty;
        }
    }
}
