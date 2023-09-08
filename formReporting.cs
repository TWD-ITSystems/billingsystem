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
    public partial class formReporting : Form
    {
        public formReporting()
        {
            InitializeComponent();
        }

        private void formReporting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMaster.tbMaster' table. You can move, or remove it, as needed.
            this.tbMasterTableAdapter.Fill(this.dsMaster.tbMaster);

            this.reportViewer1.RefreshReport();
        }

        private void tbMasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbMasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsMaster);

        }
    }
}
