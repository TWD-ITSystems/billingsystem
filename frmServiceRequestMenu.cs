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
    public partial class frmServiceRequestMenu : Form
    {
        public int userID = 0;

        public frmServiceRequestMenu()
        {
            InitializeComponent();
        }

        private void frmServiceRequestMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsServiceRequest.vwServiceRequest' table. You can move, or remove it, as needed.
            this.vwServiceRequestTableAdapter.Fill(this.dsServiceRequest.vwServiceRequest);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vwServiceRequestBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if  (statusSpinEdit.Value != 1)
            {
                txtStatus.Text = "To Do";
            }
            else
            {
                txtStatus.Text = "Done";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var query = gridView1.GetSelectedRows();
            

            this.Text = query.Count().ToString();
            foreach (var col in query)
            {
                
                MessageBox.Show(col.ToString());
            }
        }
    }
}
