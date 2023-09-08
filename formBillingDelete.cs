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
    public partial class formBillingDelete : Form
    {
        public string remarks { get; set; }


        public formBillingDelete()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            this.remarks = textBox1.Text;
            Close();
        }

    }
}
