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
    public partial class formAgingChecking : Form
    {
        public int billingID = 0;
        public formAgingChecking()
        {
            InitializeComponent();
        }

        private void formAgingChecking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMasterAging.tbMasterAging' table. You can move, or remove it, as needed.
            this.tbMasterAgingTableAdapter.FillByBillingID(this.dsMasterAging.tbMasterAging, billingID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog1.FileName;
                gridControl1.ExportToXls(filepath);
                MessageBox.Show("Saving is successful");
            }
        }
    }
}
