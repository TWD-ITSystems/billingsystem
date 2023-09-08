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
    public partial class formDamageMeters : Form
    {
        public int userID;
        public formDamageMeters()
        {
            InitializeComponent();
        }

        private void formDamageMeters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDMTR.tbDMTRAccnts' table. You can move, or remove it, as needed.
            this.tbDMTRAccntsTableAdapter.Fill(this.dsDMTR.tbDMTRAccnts);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
                using (formDMTRNew frmDM = new formDMTRNew())
                {
                    frmDM.userID = this.userID;
                    frmDM.ShowDialog();
                }
                this.tbDMTRAccntsTableAdapter.Fill(this.dsDMTR.tbDMTRAccnts);
                gridView1.RefreshData();
        }
    }
}
