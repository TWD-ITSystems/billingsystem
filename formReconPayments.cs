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
    public partial class formReconPayments : Form
    {
        public formReconPayments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radCalendar1.SelectedDate == new DateTime(1900, 1, 1))
            {
                MessageBox.Show("Please select date again.");
            }
            else
            {
                ArrayList param = new ArrayList();
                param.Add(radCalendar1.SelectedDate);
                frmReport frm = new frmReport();
                frm.param = param;
                frm.rptMode = 20;
                frm.Show();
            }

        }

        private void formReconPayments_Load(object sender, EventArgs e)
        {
            radCalendar1.SelectedDate = DateTime.Today;
            radCalendar1.FocusedDate = DateTime.Today;
        }
    }
}
