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
    public partial class formGetDateForm : Form
    {
        public DateTime date_value { get; set; }        

        public formGetDateForm()
        {
            InitializeComponent();
        }

        public formGetDateForm(string txt)
            : this()
        {            
            label1.Text = txt;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0:d}",dateEdit1.EditValue.ToString()));
        }

        private void dateEdit1_Validating(object sender, CancelEventArgs e)
        {
            DateTime dt = new DateTime();

            try
            {
                if (DateTime.TryParse(dateEdit1.EditValue.ToString(), out dt))
                {
                    date_value = dt;
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                MessageBox.Show("Please select a valid date.");
                e.Cancel = true;
                dateEdit1.Focus();
            }
            
        }


    }
}
