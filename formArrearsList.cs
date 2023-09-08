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
    public partial class formArrearsList : Form
    {
        public formArrearsList()
        {
            InitializeComponent();
        }

        private void formArrearsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsZone.tbZone' table. You can move, or remove it, as needed.
            this.tbZoneTableAdapter.Fill(this.dsZone.tbZone);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
