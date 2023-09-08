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
    public partial class formBillingSchedule : Form
    {
        dbCommercialEntities dbContext;
        bool schedMode = false;

        public formBillingSchedule()
        {
            InitializeComponent();
        }

        private void formBillingSchedule_Load(object sender, EventArgs e)
        {
                    
            dbContext = new dbCommercialEntities();
            tbBillingBindingSource.DataSource = dbContext.tbBillings;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tbBillingBindingSource.EndEdit();
            dbContext.SaveChanges();
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;           
            if (btnNew.Text.Equals("New"))
            {
                btnNew.Text = "Save";
                tbBillingBindingSource.AddNew();
            }else if (btnNew.Text.Equals("Save")){
                DialogResult result = MessageBox.Show("Do you want to save this record ?", "Add Billing Schedule", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    tbBillingBindingSource.EndEdit();
                    dbContext.SaveChanges();
                }
                btnNew.Text = "New";
                groupBox1.Enabled = false;
            }
        }

        private void tbBillingBindingSource_PositionChanged(object sender, EventArgs e)
        {
            setLoadText();
        }

        private void setLoadText()
        {
            if (loaded_to_zonesCheckEdit.Checked)
            {
                btnLoad.Text = "See Schedules";
                schedMode = false;
            }
            else
            {
                btnLoad.Text = "Load Schedules";
                schedMode = true;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {            
            formLoadSchedZones frmLoadSchedZones = new formLoadSchedZones();
            frmLoadSchedZones.billingID = Convert.ToInt32(billing_idTextBox.Text);
            frmLoadSchedZones.showMode = schedMode;
            frmLoadSchedZones.ShowDialog();
            dbContext = new dbCommercialEntities();
            tbBillingBindingSource.DataSource = dbContext.tbBillings;
            setLoadText();
        }

    }
}
