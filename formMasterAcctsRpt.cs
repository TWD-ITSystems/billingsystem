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
    public partial class formMasterAcctsRpt : Form
    {
        public formMasterAcctsRpt()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            tbZone tst = (tbZone)comboBox1.SelectedValue;

            frmReport rptBillfile = new frmReport();
            rptBillfile.rptMode = 4;
            ArrayList rptVal = new ArrayList();
            rptVal.Add(tst.zone_id);
            rptBillfile.param = rptVal;
            rptBillfile.Show();
        }

        private void formMasterAcctsRpt_Load(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = (from em in dbcontext.tbZones
                             select em);
                this.tbZoneBindingSource.DataSource = query;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
