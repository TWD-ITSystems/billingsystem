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
    public partial class formZoneLookup : Form
    {
        GlobalFunctions gfunc = new GlobalFunctions();
        List<MasterZone> listMaster = new List<MasterZone>();

        class MasterZone
        {
            public string acctno { get; set; }
            public string name { get; set; }
            public string zone { get; set; }
        }

        public formZoneLookup()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    string acctno = textBox1.Text.Trim();
                    tbMaster master = dbcontext.tbMasters.FirstOrDefault(x=>x.acctno.Equals(acctno));
                    if (master != null)
                    {
                        MasterZone newMaster = new MasterZone();
                        newMaster.acctno = acctno;
                        newMaster.name = master.name;
                        newMaster.zone = gfunc.getZoneName(acctno);
                        //listMaster.Add(newMaster);
                        if (checkAccount(acctno))
                        {
                            listMaster.Insert(0, newMaster);
                        }
                        else
                        {
                            MessageBox.Show("Account is already in the list");
                        }
                    }

                    gridControl1.DataSource = listMaster;
                    gridView1.PopulateColumns();
                    label2.Text = string.Format("Total Num. : {0}", listMaster.Count);                                        
                }
                textBox1.SelectAll();
            }
        }

        private bool checkAccount(string acctno)
        {
            bool retval = true;

            var accnt = listMaster.FirstOrDefault(x=>x.acctno.Equals(acctno));
            if (accnt != null) retval = false;
            return retval;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listMaster.Clear();
            gridControl1.DataSource = null;
            textBox1.Clear();
            textBox1.Focus();
            label2.Text = "Total Num. :";
        }

 
    }
}
