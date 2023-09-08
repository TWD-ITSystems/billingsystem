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
    public partial class formCheckDownload : Form
    {
        public string zonebook;
        public int zoneID = 0;
        GlobalFunctions gfunc = new GlobalFunctions();

        public formCheckDownload()
        {
            InitializeComponent();
        }

        private void formCheckDownload_Load(object sender, EventArgs e)
        {
            label1.Text = string.Format("Zone : {0}", zonebook);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {

                var tbDownloads = dbcontext.tbMrsDownloads.Where(x => x.md_zone.Equals(zonebook)).AsEnumerable().Select(x => x.md_acctno.TrimEnd());
                var tbMasterSearch = dbcontext.tbMasters.Where(x => x.zone_id == zoneID).AsEnumerable().Select(x => x.acctno.TrimEnd());
                var tbMaster = dbcontext.tbMasters.Where(x => x.zone_id == zoneID).Select(x => x);


                IEnumerable<string> notInDownload = tbMasterSearch.Except(tbDownloads);
                var results = tbMaster.Where(r => notInDownload.Contains(r.acctno)).Select(x => new { acctno = x.acctno,name=x.name, status = x.status,discodate=x.last_disco_date });
                

                gridControl1.DataSource = results;
                gridView1.PopulateColumns();
                gridView1.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns[0].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns[0].Caption = "Account No.";
                gridView1.Columns[1].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                gridView1.Columns[1].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns[1].Caption = "Name";
                gridView1.Columns[2].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns[2].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns[2].Caption = "Status";
                gridView1.Columns[3].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns[3].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns[3].Caption = "Disco Date";

                gridControl1.Refresh();

                label1.Text = string.Format("Zone : {0} - Total No.:{1}", zonebook,results.Count());
            }
        }

    }
}
