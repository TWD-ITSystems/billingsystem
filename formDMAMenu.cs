using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;

namespace BillingSystem
{
    public partial class formDMAMenu : Form
    {
        public int userID = 0;
        GlobalFunctions gfunc = new GlobalFunctions(); 

        public formDMAMenu()
        {
            InitializeComponent();
        }

        private void formDMAMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDMAEntry.tbDMAEntry' table. You can move, or remove it, as needed.
            this.tbDMAEntryTableAdapter.Fill(this.dsDMAEntry.tbDMAEntry);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (formDMAAdd frmAdd = new formDMAAdd())
            {
                frmAdd.userID = this.userID;
                frmAdd.ShowDialog();
            }
            this.tbDMAEntryTableAdapter.Fill(this.dsDMAEntry.tbDMAEntry);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult dlgresult = MessageBox.Show(string.Format("Do you want to remove Account No.:{0} from DMA List",gridView1.GetFocusedRowCellValue("acctno").ToString()),
                "Remove from DMA",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dlgresult == DialogResult.Yes)
            {
                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    int dmaID_entry = Convert.ToInt32(gridView1.GetFocusedRowCellValue("dmaentry_id").ToString());
                    tbDMAEntry entry = dbcontext.tbDMAEntries.FirstOrDefault(x=>x.dmaentry_id==dmaID_entry);
                    if (entry != null)
                    {
                        entry.dma_id=0;
                        entry.date_removed=DateTime.Today;
                        entry.removed_by = gfunc.getUserInitials(userID);
                        dbcontext.SaveChanges();
                    }
                }
                 this.tbDMAEntryTableAdapter.Fill(this.dsDMAEntry.tbDMAEntry);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string filtertext = "";
            string dma_name = "";
            if (gridView1.ActiveFilterString.Length > 0)
            {
                filtertext = gridView1.ActiveFilterString;
                if (filtertext.Substring(0, 11).Equals("[subd_name]"))
                {
                    dma_name = filtertext.Substring(15, (filtertext.Length - 1) - 15);
                }
            }


            string leftcol = "";
            string midcol = string.Format("TAGUM WATER DISTRICT \r\n  List of DMA \r\n as of {0:d} \r\n {1}", DateTime.Today,dma_name);
            string rightcol = "";
            PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.Clear();
            phf.Header.Content.AddRange(new string[] { leftcol, midcol, rightcol });

            phf.Header.LineAlignment = BrickAlignment.Near;
            printableComponentLink1.CreateDocument();
            printableComponentLink1.ShowPreview();
        }
    }
}
