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
    public partial class formChangeCardNo : Form
    {
        public formChangeCardNo()
        {
            InitializeComponent();
        }

        private void formChangeCardNo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsZone.tbZone' table. You can move, or remove it, as needed.
            this.tbZoneTableAdapter.Fill(this.dsZone.tbZone);

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            int zoneid = (int)comboBox1.SelectedValue;
            int startCard = 0;
            int endCard = 0;
            int gap = 0;
            int newCardstart = 0;
            bool first = true;

            try{
                startCard = Convert.ToInt32(txtFrom.Text);
                endCard = Convert.ToInt32(txtTo.Text);
                gap = Convert.ToInt32(txtGap.Text);
                newCardstart = Convert.ToInt32(txtNew.Text);
            }catch{
                MessageBox.Show("Error converting values. Please check your input.");
                return;
            }

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryAccts = dbcontext.tbMasters.Where(x => x.zone_id == zoneid && (x.cardno >= startCard && x.cardno <= endCard)).OrderBy(x=>x.cardno);
                int newCardNo = newCardstart;
                string oldcaption = this.Text;
                int counter = 0;
                foreach (tbMaster mast in queryAccts)
                {
                    this.Text = string.Format("Processing Account[{0}] - Count[{1}]", mast.acctno,counter++);
                    if (first){
                        mast.cardno = newCardNo;
                        first = false;
                    }else{
                        newCardNo += gap;
                        mast.cardno = newCardNo;
                    }
                }
                dbcontext.SaveChanges();
                MessageBox.Show("Recarding is finished.");
            }
            
        }
    }
}
