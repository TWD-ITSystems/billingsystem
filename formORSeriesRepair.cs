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
    public partial class formORSeriesRepair : Form
    {
                    int orStart = 0;
            int orEnd = 0;
            int rprValue = 0;
            string encoder="";
            
        public formORSeriesRepair()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                orStart = Convert.ToInt32(textBox1.Text);
                orEnd = Convert.ToInt32(textBox2.Text);
                rprValue = Convert.ToInt32(textBox3.Text);
                encoder = textBox6.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("OR Number Format Error or repair value. Please check.");
            }

            if (radioButton1.Checked)
            {
                textBox4.Text = (orStart + rprValue).ToString();
                textBox5.Text = (orEnd + rprValue).ToString();
                button2.Enabled = true;
            }
            else
            {
                textBox4.Text = (orStart - rprValue).ToString();
                textBox5.Text = (orEnd - rprValue).ToString();
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                encoder = textBox6.Text;
                var orseries = dbcontext.tbPays.Where(x=>x.@ref>= orStart && x.@ref<=orEnd && x.encoder.Equals(encoder)).Select(x=>x);
                int recCount = orseries.Count();
                if (recCount > 0)
                {
                    DialogResult dlg = MessageBox.Show("Do you want to repair the " + recCount.ToString() + " records?", "Repair", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {                     
                        foreach (tbPay tpay in orseries)
                        {
                            int oldOR = (int)tpay.@ref;
                            int newOR = 0;
                            if (radioButton1.Checked)
                            {
                                newOR = oldOR + rprValue;
                            }
                            else
                            {
                                newOR = oldOR - rprValue;
                            }
                            tpay.@ref = newOR;
                            string oldORstr = oldOR.ToString();
                            var qryLedger = dbcontext.tbLedgers.Where(x => x.encoder.Equals(encoder) && x.@ref.Equals(oldORstr)).Select(x=>x);
                            if (qryLedger != null)
                            {
                                foreach (tbLedger tLedger in qryLedger)
                                {
                                    string newStr =  newOR.ToString();
                                    tLedger.@ref = newStr;
                                    tLedger.remarks = "OR Series Repaired " + DateTime.Now.ToShortDateString();
                                }
                            }

                        }

                        dbcontext.SaveChanges();
                        MessageBox.Show("OR Series repair done.");
                    }

                    
                }
            }
        }

        private void formORSeriesRepair_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}