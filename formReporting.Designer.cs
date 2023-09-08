namespace BillingSystem
{
    partial class formReporting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsMaster = new BillingSystem.dsMaster();
            this.tbMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMasterTableAdapter = new BillingSystem.dsMasterTableAdapters.tbMasterTableAdapter();
            this.tableAdapterManager = new BillingSystem.dsMasterTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbMasterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BillingSystem.reportBillPrint.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(765, 431);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsMaster
            // 
            this.dsMaster.DataSetName = "dsMaster";
            this.dsMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMasterBindingSource
            // 
            this.tbMasterBindingSource.DataMember = "tbMaster";
            this.tbMasterBindingSource.DataSource = this.dsMaster;
            // 
            // tbMasterTableAdapter
            // 
            this.tbMasterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbMasterTableAdapter = this.tbMasterTableAdapter;
            this.tableAdapterManager.UpdateOrder = BillingSystem.dsMasterTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // formReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 502);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formReporting";
            this.Text = "formReporting";
            this.Load += new System.EventHandler(this.formReporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsMaster dsMaster;
        private System.Windows.Forms.BindingSource tbMasterBindingSource;
        private dsMasterTableAdapters.tbMasterTableAdapter tbMasterTableAdapter;
        private dsMasterTableAdapters.TableAdapterManager tableAdapterManager;
    }
}