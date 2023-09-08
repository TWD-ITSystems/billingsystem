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
    public partial class formLoadSchedZones : Form
    {
        public int billingID = 0;
        public bool showMode = false;
        dbCommercialEntities context = new dbCommercialEntities();
        

        public formLoadSchedZones()
        {
            InitializeComponent();
        }

        private void formLoadSchedZones_Load(object sender, EventArgs e)
        {
            var query = from con in context.tbBillings
                        where con.billing_id == billingID
                        select con;
            this.tbBillingBindingSource.DataSource = query;

            var querySched = getBillingSched();
            this.tbBillingScheduleBindingSource.DataSource = querySched;
            if (showMode)
            {
                btnLoad.Enabled = true;
            }
            else
            {
                btnCancel.Enabled = true;
            }

        }

        private IQueryable<tbBillingSchedule> getBillingSched()
        {
            var querySched = from sched in context.tbBillingSchedules
                             where sched.billing_id == billingID
                             select sched;
            return querySched;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var qZoneLookup = from zoneLook in context.tbZoneLookups
                              orderby zoneLook.zone_lookup_id
                              select zoneLook;
                              

            foreach(tbZoneLookup zoneData in qZoneLookup)
            {
                tbBillingSchedule billsched = new tbBillingSchedule();

                billsched.billing_id = billingID;
                billsched.zone = zoneData.zone_uid;
                context.AddTotbBillingSchedules(billsched);                         
            }
            context.SaveChanges();     
            tbBillingScheduleBindingSource.DataSource = getBillingSched();
            btnSave.Enabled = true;
            btnLoad.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {           
            tbBilling bill = context.tbBillings.First(i => i.billing_id == billingID);
            bill.loaded_to_zones = true;
            context.SaveChanges();
            btnLoad.Enabled = false;
            btnCancel.Enabled = true;
            //btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to cancel this schedule?", "Schedule", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {                            
                context.ExecuteStoreCommand("Delete from tbBillingSchedule where billing_id ={0}", billingID);            
                tbBilling bill = context.tbBillings.First(i => i.billing_id == billingID);
                bill.loaded_to_zones = false;
                context.SaveChanges();
                MessageBox.Show("Billing Schedule has been deleted successfully.");
                btnLoad.Enabled = true;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                tbBillingScheduleBindingSource.DataSource = getBillingSched();
            }            
        }


    }
}
