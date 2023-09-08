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
    public partial class formRafflePrint : Form
    {
        public string username = "";
        int raffleID = 0;
        public formRafflePrint()
        {
            InitializeComponent();
        }

        private void tbRafflePeriodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbRafflePeriodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbRafflePeriod);

        }

        private void formRafflePrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbRafflePeriod.tbRafflePeriod' table. You can move, or remove it, as needed.
            this.tbRafflePeriodTableAdapter.Fill(this.dbRafflePeriod.tbRafflePeriod);
            raffleID = Convert.ToInt32(raffle_periodComboBox.SelectedValue.ToString());
            setNumEntries(raffleID);

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            raffleID = Convert.ToInt32(raffle_periodComboBox.SelectedValue.ToString());
            if ((getNumEntries(raffleID) > 0))
            {
                //MessageBox.Show(raffle_periodComboBox.SelectedText);
                
                ArrayList param = new ArrayList();
                param.Add(raffle_periodComboBox.SelectedValue);
                param.Add(raffle_periodComboBox.Text);
                frmReport frm = new frmReport();
                frm.param = param;
                frm.rptMode = 27;
                frm.Show();
                
            } 
          
        }

        private int getNumEntries(int raffleID)
        {
            int rValue = 0;
            using (dbRaffleEntities dbContext = new dbRaffleEntities())
               try{
                  rValue=(int)dbContext.tbRafflePeriods.Single(x => x.raffle_id == raffleID).qualified_entries;
                }catch{
                    rValue= 0;
                }
            return rValue;
        }

        private void setNumEntries(int raffleID)
        {
            int numEntries=getNumEntries(raffleID);
            if (numEntries > 0)
            {
                label1.Text = "No. of Entries: " + numEntries;
            }
            else
            {
                label1.Text = "No. of Entries: Not yet generated.";
            }
        }

        private void raffle_periodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                raffleID = Convert.ToInt32(raffle_periodComboBox.SelectedValue.ToString());
                setNumEntries(raffleID);
            }catch{}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName;
            raffleID = Convert.ToInt32(raffle_periodComboBox.SelectedValue.ToString());
            if ((getNumEntries(raffleID) > 0))
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog1.FileName;
                    using (dbRaffleEntities dbcontext = new dbRaffleEntities())
                    {
                        List<string> query = dbcontext.tbRaffeEntries.Where(x => x.raffle_id == raffleID).Select(x => x.acctno).ToList();
                        if (query.Count() > 0)
                        {
                            System.IO.File.WriteAllLines(fileName, query);
                        }

                    }
                    MessageBox.Show("List has been exported");
                }
            }
            else
            {
                MessageBox.Show("Raffle period not yet generated.");
            }
        }


    }
}
