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
    public partial class formDMTRNew : Form
    {
        public int userID;
        GlobalFunctions gfunc = new GlobalFunctions();
        int masterID = 0;
        public formDMTRNew()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBox1.TextLength == 6) 
                {
                    if (checkIfEncoded())
                    {
                        MessageBox.Show("Account is already in the list.", "Duplicate Account");
                        textBox1.SelectAll();
                        textBox1.Focus();
                    }
                    else
                    {
                        using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                        {
                            var acctno = dbcontext.tbMasters.FirstOrDefault(x => x.acctno.Equals(textBox1.Text));
                            if (acctno != null)
                            {
                                masterID = acctno.master_id;
                                label2.Text = string.Format("Name : {0}", acctno.name);
                                textBox2.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Account No. not found.Please try again.", "Error");
                                textBox1.SelectAll();
                                textBox1.Focus();
                            }
                        }
                    }
                }
            }
        }

        private bool checkIfEncoded()
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                int masterid = gfunc.getMasterID(textBox1.Text);
                var acctno = dbcontext.tbDMTRAccnts.FirstOrDefault(x => x.master_id == masterid);
                if (acctno != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                decimal amt = 0;
                if (decimal.TryParse(textBox2.Text, out amt))
                {
                    textBox3.Text = amt.ToString();
                    textBox3.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid entry.","Error");
                    textBox2.SelectAll();
                    textBox2.Focus();
                }

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                decimal amt = 0;
                if (decimal.TryParse(textBox3.Text, out amt))
                {
                    textBox4.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid entry.", "Error");
                    textBox3.SelectAll();
                    textBox3.Focus();
                }

            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                decimal amt = 0;
                if (decimal.TryParse(textBox4.Text, out amt))
                {
                    btnSave.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid entry.", "Error");
                    textBox4.SelectAll();
                    textBox4.Focus();
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Do you want to save this record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (result == DialogResult.Yes)
             {
                 using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                 {
                     tbMasterAcct mastacct = dbcontext.tbMasterAccts.FirstOrDefault(x => x.master_id == masterID);
                     tbDMTRAccnt dmtr = new tbDMTRAccnt();
                     dmtr.master_id = masterID;
                     dmtr.encoded_by = gfunc.getUserInitials(userID);
                     dmtr.encoded_date = DateTime.Today;
                     dmtr.amount = Convert.ToDecimal(textBox2.Text);
                     dmtr.balance = Convert.ToDecimal(textBox3.Text);
                     dmtr.monthly = Convert.ToDecimal(textBox4.Text);
                     

                     mastacct.isMtrDmg = true;
                     mastacct.MtrDmg_Amount = dmtr.amount;
                     mastacct.MtrDmg_Balance = dmtr.balance;
                     mastacct.MtrDmg_Monthly = dmtr.monthly;

                     dbcontext.AddTotbDMTRAccnts(dmtr);
                     dbcontext.SaveChanges();
                 }
                 MessageBox.Show("Account is successfully updated with Damage Meter charge", "Save");
                 Close();
             }
        }
    }
}
