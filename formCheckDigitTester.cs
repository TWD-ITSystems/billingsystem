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
    public partial class formCheckDigitTester : Form
    {
        public formCheckDigitTester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CDAV chk = new CDAV();

            
            chk.SID1 = textBox1.Text;
            //chk.AmountDue = 1103.15;
            try
            {
                chk.DueDate = Convert.ToDateTime(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Due date is invalid");
                return;
            }

            try
            {
                chk.AmountDue = Convert.ToDouble(textBox2.Text);
            }catch
            {
                MessageBox.Show("Total Amount is invalid.");
                return;
            }

            textBox4.Text = chk.Generate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
