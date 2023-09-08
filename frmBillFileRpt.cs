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
    public partial class formBillFileRpt : Form
    {
        public string username;
        dbCommercialEntities dbContext = new dbCommercialEntities();

        public formBillFileRpt()
        {
            InitializeComponent();
        }

        private void frmBillFileRpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
            // TODO: This line of code loads data into the 'dsMRSDownload.tbMrsDownload' table. You can move, or remove it, as needed.
            this.tbMrsDownloadTableAdapter.Fill(this.dsMRSDownload.tbMrsDownload);
            tbZoneBindingSource.DataSource = dbContext.tbZones;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReport rptBillfile = new frmReport();
            rptBillfile.rptMode = 1;
            ArrayList rptVal = new ArrayList();
            rptVal.Add(cmbZone.Text);
            rptVal.Add(cmbBillMonth.Text);
            rptVal.Add(cmbBillMonth.SelectedValue);
            rptBillfile.param = rptVal;
            rptBillfile.Show();
        }
    }
}
