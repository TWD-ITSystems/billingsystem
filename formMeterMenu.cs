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
    public partial class formMeterMenu : Form
    {
        public formMeterMenu()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {

                //List<string> meters = dbcontext.tbMeters.Select(x => x.meterno).ToList();

                //List<string> duplicates = meters.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
                var distinct_meters = dbcontext.tbMeters.Select(x => x.meterno).Distinct();

                foreach (string meternum in distinct_meters)
                {
                    string metercode = "";
                    string meterno = "";
                                        if (meternum.Length > 4)
                    {
                        string[] meterstr = meternum.Split('-');
                        metercode = meterstr[0];
                        meterno = meterstr[1];

                        tbMeterList newMeter = new tbMeterList();
                        newMeter.meter_code = metercode;
                        newMeter.meter_no = meterno;

                        dbcontext.AddTotbMeterLists(newMeter);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                List<string> meters = dbcontext.tbMeters.Select(x => x.meterno).ToList();
                var dmeters = dbcontext.tbMeters.Select(x => new { key = x.meterno,masterid=x.master_id}).Distinct();
                
                MessageBox.Show(dmeters.Count().ToString()); 
            }
        }
    }
}
