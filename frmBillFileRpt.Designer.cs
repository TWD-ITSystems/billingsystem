namespace BillingSystem
{
    partial class formBillFileRpt
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
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsMRSDownload = new BillingSystem.dsMRSDownload();
            this.tbMrsDownloadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMrsDownloadTableAdapter = new BillingSystem.dsMRSDownloadTableAdapters.tbMrsDownloadTableAdapter();
            this.tbZoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBillMonth = new System.Windows.Forms.ComboBox();
            this.dsBilling = new BillingSystem.dsBilling();
            this.dsBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBillingTableAdapter = new BillingSystem.dsBillingTableAdapters.tbBillingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsMRSDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMrsDownloadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbZone
            // 
            this.cmbZone.DataSource = this.tbZoneBindingSource;
            this.cmbZone.DisplayMember = "zone_name";
            this.cmbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(90, 62);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(115, 21);
            this.cmbZone.TabIndex = 0;
            this.cmbZone.ValueMember = "zone_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zone/Book :";
            // 
            // dsMRSDownload
            // 
            this.dsMRSDownload.DataSetName = "dsMRSDownload";
            this.dsMRSDownload.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMrsDownloadBindingSource
            // 
            this.tbMrsDownloadBindingSource.DataMember = "tbMrsDownload";
            this.tbMrsDownloadBindingSource.DataSource = this.dsMRSDownload;
            // 
            // tbMrsDownloadTableAdapter
            // 
            this.tbMrsDownloadTableAdapter.ClearBeforeFill = true;
            // 
            // tbZoneBindingSource
            // 
            this.tbZoneBindingSource.DataSource = typeof(BillingSystem.tbZone);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(275, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 30);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bill Month :";
            // 
            // cmbBillMonth
            // 
            this.cmbBillMonth.DataSource = this.tbBillingBindingSource;
            this.cmbBillMonth.DisplayMember = "billing_desc";
            this.cmbBillMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillMonth.FormattingEnabled = true;
            this.cmbBillMonth.Location = new System.Drawing.Point(90, 19);
            this.cmbBillMonth.Name = "cmbBillMonth";
            this.cmbBillMonth.Size = new System.Drawing.Size(115, 21);
            this.cmbBillMonth.TabIndex = 4;
            this.cmbBillMonth.ValueMember = "billing_id";
            // 
            // dsBilling
            // 
            this.dsBilling.DataSetName = "dsBilling";
            this.dsBilling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBillingBindingSource
            // 
            this.dsBillingBindingSource.DataSource = this.dsBilling;
            this.dsBillingBindingSource.Position = 0;
            // 
            // tbBillingBindingSource
            // 
            this.tbBillingBindingSource.DataMember = "tbBilling";
            this.tbBillingBindingSource.DataSource = this.dsBillingBindingSource;
            // 
            // tbBillingTableAdapter
            // 
            this.tbBillingTableAdapter.ClearBeforeFill = true;
            // 
            // formBillFileRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 109);
            this.Controls.Add(this.cmbBillMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbZone);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formBillFileRpt";
            this.Text = "Print Bill File";
            this.Load += new System.EventHandler(this.frmBillFileRpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMRSDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMrsDownloadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbZone;
        private System.Windows.Forms.Label label1;
        private dsMRSDownload dsMRSDownload;
        private System.Windows.Forms.BindingSource tbMrsDownloadBindingSource;
        private dsMRSDownloadTableAdapters.tbMrsDownloadTableAdapter tbMrsDownloadTableAdapter;
        private System.Windows.Forms.BindingSource tbZoneBindingSource;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBillMonth;
        private System.Windows.Forms.BindingSource dsBillingBindingSource;
        private dsBilling dsBilling;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private dsBillingTableAdapters.tbBillingTableAdapter tbBillingTableAdapter;
    }
}