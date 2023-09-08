using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace BillingSystem
{
    public partial class formConsumptionPatternChecker : Form
    {
        public int userID = 0;
        GlobalFunctions gfunc = new GlobalFunctions();

        public formConsumptionPatternChecker()
        {
            InitializeComponent();
        }


        private void formConsumptionPatternChecker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
            // TODO: This line of code loads data into the 'dsZoneLookup.tbZoneLookup' table. You can move, or remove it, as needed.
            this.tbZoneLookupTableAdapter.Fill(this.dsZoneLookup.tbZoneLookup);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int billingID = (int)comboBox2.SelectedValue;
            ArrayList paramArray = new ArrayList();
            paramArray.Add(billingID);
            paramArray.Add(textBox1.Text);    // Cum
            paramArray.Add(comboBox2.Text);   // Billmonth
            paramArray.Add(Convert.ToInt32(comboBox1.Text));   // zoneid
            paramArray.Add(gfunc.getUserFullName(userID)); // Preparedby

            frmReport frmRpt = new frmReport();
            frmRpt.rptMode = 25;
            frmRpt.param = paramArray;
            frmRpt.Show();

        }

    }
}
