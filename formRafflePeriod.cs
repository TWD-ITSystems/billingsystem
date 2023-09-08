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
    public partial class formRafflePeriod : Form
    {
        public string username = "";

        public formRafflePeriod()
        {
            InitializeComponent();
        }

        private void formRafflePeriod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbRafflePeriod.tbRafflePeriod' table. You can move, or remove it, as needed.
            this.tbRafflePeriodTableAdapter.Fill(this.dbRafflePeriod.tbRafflePeriod);
             

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAll();            
        }

        private void ClearAll()
        {
            txCoverage.Clear();
            txDescription.Clear();
            txRemarks.Clear();
            dtCutOff.Value = DateTime.Today;
            dtDrawDate.Value = DateTime.Today;

        }

        private void btnAddToTable_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do you want to save this record?", "Add New Raffle Period", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                using (dbRaffleEntities dbContext = new dbRaffleEntities())
                {
                    tbRafflePeriod raffledata = new tbRafflePeriod() {
                        raffle_description = txDescription.Text,
                        raffle_period = txCoverage.Text,
                        remarks=txRemarks.Text,
                        cutoff_date=dtCutOff.Value,
                        added_by=username,
                        added_date=DateTime.Today,
                        draw_date=dtDrawDate.Value                        
                    };
                    dbContext.AddTotbRafflePeriods(raffledata);
                    dbContext.SaveChanges();
                    MessageBox.Show("Raffle Period is saved successfully.");
                    this.tbRafflePeriodTableAdapter.Fill(this.dbRafflePeriod.tbRafflePeriod);
                    gridControl1.RefreshDataSource();
                }

            }
        }
    }
}
