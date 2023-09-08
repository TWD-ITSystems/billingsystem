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
    public partial class formCheckBilling : Form
    {

        List<NoReading> listNoReading = new List<NoReading>();
        GlobalFunctions gfunc = new GlobalFunctions();
        string mode = "";
        int billingID = 0;
        int numrec = 0;

        class NoReading
        {
            public string acctno{get;set;}
            public string name{get;set;}
            public string zone { get; set; }
            public string zonereading { get; set; }
            public string date_inst { get; set; }
            public string disco_date { get; set; }
            public string reco_date { get; set; }
            public string remarks { get; set; }

        }

        public formCheckBilling()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            billingID = int.TryParse(comboBox1.SelectedValue.ToString(), out billingID) ? billingID : 0;
            if (radioButton1.Checked)
            {
                mode = "ACTIVE";
                processActive();
            }
            else
            {
                mode = "INACTIVE";
                processInactive();
            }
        }

        private void processActive()
        {
            listNoReading.Clear();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var active_accounts = dbcontext.tbMasters.Where(x => !x.status.Equals("X") && x.date_installed < dateTimePicker1.Value).Select(x => x.master_id);
                //var active_accounts = dbcontext.tbMasters.Where(x => !x.status.Equals("X")).Select(x => x.master_id);
                //int xy = active_accounts.Count();
                var dec_bill = dbcontext.tbLedgers.Where(x => x.billing_id == billingID && x.code.Equals("BILL")).Select(x => x.master_id);
                //int zy = dec_bill.Count();
                var NoBill = active_accounts.Except(dec_bill);
                int wy = NoBill.Count();
                numrec = wy;
                string caption = this.Text;
                int counter = 0;
                foreach (int mID in NoBill)
                {
                    counter++;
                    tbMaster mMast = dbcontext.tbMasters.FirstOrDefault(x => x.master_id == mID);
                    NoReading newRow = new NoReading();
                    newRow.acctno = mMast.acctno;
                    newRow.name = mMast.name;
                    newRow.zone = gfunc.getZoneName(mMast.zone_id);
                    newRow.zonereading = gfunc.getZoneReadingDateString(billingID,mMast.zone_id);
                    if (mMast.date_installed.HasValue)
                    {
                        newRow.date_inst = mMast.date_installed.Value.ToShortDateString();
                    }
                    if (mMast.last_disco_date.HasValue)
                    {
                        newRow.disco_date = mMast.last_disco_date.Value.ToShortDateString();
                    }
                    if (mMast.last_reco_date.HasValue)
                    {
                        newRow.reco_date = mMast.last_reco_date.Value.ToShortDateString();
                    }
                    listNoReading.Add(newRow);
                    this.Text = string.Format("Processing...[{0}] - {1}", counter, newRow.acctno);
                }

                gridControl1.DataSource = listNoReading;
                gridView1.PopulateColumns();
                this.Text = caption;
            }
        }

        private void processInactive()
        {
            listNoReading.Clear();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var active_accounts = dbcontext.tbMasters.Where(x => x.status.Equals("X") && x.last_disco_date<=dateTimePicker1.Value).Select(x => x.master_id);
                int xy = active_accounts.Count();
                var dec_bill = dbcontext.tbLedgers.Where(x => x.billing_id == billingID && x.code.Equals("BILL")).Select(x => x.master_id);
                int zy = dec_bill.Count();
                var NoBill = active_accounts.Except(dec_bill);
                int wy = NoBill.Count();
                numrec = wy;
                string caption = this.Text;
                int counter = 0;
                foreach (int mID in NoBill)
                {
                    counter++;
                    tbMaster mMast = dbcontext.tbMasters.FirstOrDefault(x => x.master_id == mID);
                    NoReading newRow = new NoReading();
                    newRow.acctno = mMast.acctno;
                    newRow.name = mMast.name;
                    newRow.zone = gfunc.getZoneName(mMast.zone_id);
                    newRow.zonereading = gfunc.getZoneReadingDateString(billingID, mMast.zone_id);
                    if (mMast.date_installed.HasValue)
                    {
                        newRow.date_inst = mMast.date_installed.Value.ToShortDateString();
                    }
                    if (mMast.last_disco_date.HasValue)
                    {
                        newRow.disco_date = mMast.last_disco_date.Value.ToShortDateString();
                    }
                    if (mMast.last_reco_date.HasValue)
                    {
                        newRow.reco_date = mMast.last_reco_date.Value.ToShortDateString();
                    }
                    listNoReading.Add(newRow);
                    this.Text = string.Format("Processing...[{0}] - {1}", counter, newRow.acctno);
                }

                gridControl1.DataSource = listNoReading;
                gridView1.PopulateColumns();
                this.Text = caption;
            }
        }

        private void formCheckBilling_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
            gridControl1.DataSource = listNoReading;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string leftcol = string.Format("      \r\n   \r\n \r\n    \r\n Total Records:{0}",numrec);
            string midcol = string.Format("TAGUM WATER DISTRICT \r\n   \r\n \r\n    \r\n List of Unbilled Accounts ({0})",mode);
            string rightcol = string.Format("      \r\n   \r\n \r\n    \r\n BillMonth:{0}", comboBox1.Text);
            PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.Clear();
            phf.Header.Content.AddRange(new string[] {leftcol,midcol,rightcol});

            phf.Header.LineAlignment = BrickAlignment.Near;            
            printableComponentLink1.CreateDocument();
            printableComponentLink1.ShowPreview();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            mode = "ACTIVE";
            label2.Text = "Inst. Cutoff :";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            mode = "INACTIVE";
            label2.Text = "Disco Cutoff :";
        }
    }
}
