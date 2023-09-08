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
    public partial class formAccountInfoFill : Form
    {
        class AccntInfo
        {
            public string acctno { get; set; }
            public string name { get; set; }
            public string address { get; set; }
            public int zoneUID { get; set; }
            public string meterno { get; set; }
            public int lastreading { get; set; }
            public decimal billamt { get; set; }
        }

        List<AccntInfo> acct_list = new List<AccntInfo>();
        GlobalFunctions gfunc = new GlobalFunctions();
        public int userID;

        public formAccountInfoFill()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    tbMaster mast = dbcontext.tbMasters.FirstOrDefault(x=>x.acctno.Equals(textBox1.Text));
                    if (mast != null)
                    {
                        AccntInfo ainfo = new AccntInfo();
                        ainfo.acctno = textBox1.Text;
                        ainfo.name = mast.name;
                        ainfo.address = mast.address;
                        ainfo.zoneUID = gfunc.getZoneUID(mast.zone_id);
                        ainfo.meterno = gfunc.getMeterNumber(textBox1.Text);
                        ainfo.lastreading = (int)dbcontext.tbMasterAccts.First(x => x.master_id == mast.master_id).rdg_pres;
                        ainfo.billamt = Convert.ToDecimal(dbcontext.tbMasterAccts.First(x=> x.master_id == mast.master_id).bill_balance);

                        if (checkAccount(textBox1.Text))
                        {
                            acct_list.Insert(0, ainfo);
                        }
                        else
                        {
                            MessageBox.Show("Account is already in the list");
                        }
                    }

                    PopulateGrid();
                }
                textBox1.SelectAll();
            }
        }

        private bool checkAccount(string acctno)
        {
            bool retval = true;

            var accnt = acct_list.FirstOrDefault(x => x.acctno.Equals(acctno));
            if (accnt != null) retval = false;
            return retval;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acct_list.Clear();
            gridControl1.DataSource = null;
            textBox1.Clear();
            textBox1.Focus();
        }

        private void PopulateGrid()
        {
            gridControl1.DataSource = acct_list;
            gridView1.PopulateColumns();

            gridView1.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[0].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[0].Caption = "Account No.";
            gridView1.Columns[0].Width = 70;
            gridView1.Columns[1].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[1].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[1].Caption = "Name";
            gridView1.Columns[1].Width = 150;
            gridView1.Columns[2].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[2].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[2].Caption = "Address";
            gridView1.Columns[2].Width = 230;
            gridView1.Columns[3].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[3].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[3].Caption = "Zone";
            gridView1.Columns[3].Width = 50;
            gridView1.Columns[4].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[4].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[4].Caption = "Meter No.";
            gridView1.Columns[4].Width = 100;
            gridView1.Columns[5].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[5].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[5].Caption = "Last Rdg";
            gridView1.Columns[5].Width = 70;
            gridView1.Columns[6].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[6].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[6].Caption = "Bill Balance";
            gridView1.Columns[6].Width = 70;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printableComponentLink1.CreateDocument();
            printableComponentLink1.ShowPreview();
        }

        private void formAccountInfoFill_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
