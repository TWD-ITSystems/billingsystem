namespace BillingSystem
{
    partial class formImportGcash
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn40 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn41 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn42 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn43 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn44 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn45 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn46 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn47 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn48 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn49 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn50 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn51 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn52 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelUnrecognized = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelAmt = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBilling = new BillingSystem.dsBilling();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbBillingTableAdapter = new BillingSystem.dsBillingTableAdapters.tbBillingTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GroupBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 111);
            this.panel1.TabIndex = 1;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.button4);
            this.GroupBox1.Controls.Add(this.labelError);
            this.GroupBox1.Controls.Add(this.labelUnrecognized);
            this.GroupBox1.Controls.Add(this.labelCount);
            this.GroupBox1.Controls.Add(this.labelAmt);
            this.GroupBox1.Location = new System.Drawing.Point(416, 11);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(509, 92);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "[ Data Information ]";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(334, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "Repair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(242, 21);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(85, 13);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "Error in Amount :";
            // 
            // labelUnrecognized
            // 
            this.labelUnrecognized.AutoSize = true;
            this.labelUnrecognized.Location = new System.Drawing.Point(24, 67);
            this.labelUnrecognized.Name = "labelUnrecognized";
            this.labelUnrecognized.Size = new System.Drawing.Size(127, 13);
            this.labelUnrecognized.TabIndex = 2;
            this.labelUnrecognized.Text = "Unrecognized Accounts :";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(24, 21);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(112, 13);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "Total No. of Records :";
            // 
            // labelAmt
            // 
            this.labelAmt.AutoSize = true;
            this.labelAmt.Location = new System.Drawing.Point(24, 44);
            this.labelAmt.Name = "labelAmt";
            this.labelAmt.Size = new System.Drawing.Size(76, 13);
            this.labelAmt.TabIndex = 0;
            this.labelAmt.Text = "Total Amount :";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(199, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Save Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(34, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete Selection";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Billmonth:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tbBillingBindingSource;
            this.comboBox1.DisplayMember = "billing_desc";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "billing_id";
            // 
            // tbBillingBindingSource
            // 
            this.tbBillingBindingSource.DataMember = "tbBilling";
            this.tbBillingBindingSource.DataSource = this.dsBilling;
            this.tbBillingBindingSource.Sort = "billing_id DESC";
            // 
            // dsBilling
            // 
            this.dsBilling.DataSetName = "dsBilling";
            this.dsBilling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(199, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import Gcash Payments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 111);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 390);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(935, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "       Result       ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(3, 3);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewCheckBoxColumn4.FormatString = "";
            gridViewCheckBoxColumn4.HeaderText = "Select";
            gridViewCheckBoxColumn4.Name = "column11";
            gridViewTextBoxColumn40.FormatString = "";
            gridViewTextBoxColumn40.HeaderText = "Trans. Date";
            gridViewTextBoxColumn40.Name = "column1";
            gridViewTextBoxColumn40.ReadOnly = true;
            gridViewTextBoxColumn40.Width = 80;
            gridViewTextBoxColumn41.FormatString = "";
            gridViewTextBoxColumn41.HeaderText = "Ref No.";
            gridViewTextBoxColumn41.Name = "column2";
            gridViewTextBoxColumn41.ReadOnly = true;
            gridViewTextBoxColumn41.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn41.Width = 90;
            gridViewTextBoxColumn42.FormatString = "";
            gridViewTextBoxColumn42.HeaderText = "Acct No.";
            gridViewTextBoxColumn42.Name = "column3";
            gridViewTextBoxColumn42.ReadOnly = true;
            gridViewTextBoxColumn42.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn42.Width = 70;
            gridViewTextBoxColumn43.FormatString = "";
            gridViewTextBoxColumn43.HeaderText = "Name";
            gridViewTextBoxColumn43.Name = "column4";
            gridViewTextBoxColumn43.ReadOnly = true;
            gridViewTextBoxColumn43.Width = 180;
            gridViewTextBoxColumn44.FormatString = "";
            gridViewTextBoxColumn44.HeaderText = "Collected Amt.";
            gridViewTextBoxColumn44.Name = "column5";
            gridViewTextBoxColumn44.ReadOnly = true;
            gridViewTextBoxColumn44.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn44.Width = 80;
            gridViewTextBoxColumn45.FormatString = "";
            gridViewTextBoxColumn45.HeaderText = "Current";
            gridViewTextBoxColumn45.Name = "column6";
            gridViewTextBoxColumn45.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn45.Width = 80;
            gridViewTextBoxColumn46.FormatString = "";
            gridViewTextBoxColumn46.HeaderText = "Arrears";
            gridViewTextBoxColumn46.Name = "column7";
            gridViewTextBoxColumn46.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn46.Width = 80;
            gridViewTextBoxColumn47.FormatString = "";
            gridViewTextBoxColumn47.HeaderText = "Penalty";
            gridViewTextBoxColumn47.Name = "column14";
            gridViewTextBoxColumn48.FormatString = "";
            gridViewTextBoxColumn48.HeaderText = "Inst. Fee";
            gridViewTextBoxColumn48.Name = "column8";
            gridViewTextBoxColumn48.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn48.Width = 80;
            gridViewTextBoxColumn49.FormatString = "";
            gridViewTextBoxColumn49.HeaderText = "Mtr Mtn";
            gridViewTextBoxColumn49.Name = "column10";
            gridViewTextBoxColumn49.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn49.Width = 80;
            gridViewTextBoxColumn50.FormatString = "";
            gridViewTextBoxColumn50.HeaderText = "Adv. Pay";
            gridViewTextBoxColumn50.Name = "column13";
            gridViewTextBoxColumn51.FormatString = "";
            gridViewTextBoxColumn51.HeaderText = "Zone";
            gridViewTextBoxColumn51.Name = "column9";
            gridViewTextBoxColumn51.ReadOnly = true;
            gridViewTextBoxColumn51.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn52.HeaderText = "column12";
            gridViewTextBoxColumn52.IsVisible = false;
            gridViewTextBoxColumn52.Name = "column12";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn4,
            gridViewTextBoxColumn40,
            gridViewTextBoxColumn41,
            gridViewTextBoxColumn42,
            gridViewTextBoxColumn43,
            gridViewTextBoxColumn44,
            gridViewTextBoxColumn45,
            gridViewTextBoxColumn46,
            gridViewTextBoxColumn47,
            gridViewTextBoxColumn48,
            gridViewTextBoxColumn49,
            gridViewTextBoxColumn50,
            gridViewTextBoxColumn51,
            gridViewTextBoxColumn52});
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(929, 358);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.CustomFiltering += new Telerik.WinControls.UI.GridViewCustomFilteringEventHandler(this.radGridView1_CustomFiltering);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbBillingTableAdapter
            // 
            this.tbBillingTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnFilterClear);
            this.tabPage2.Controls.Add(this.txtFilter);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(935, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  Filter Dates  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filter by Date :";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(108, 26);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(134, 20);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.Location = new System.Drawing.Point(248, 25);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(75, 23);
            this.btnFilterClear.TabIndex = 2;
            this.btnFilterClear.Text = "Clear";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "\'ex. 08/15/2023\'";
            // 
            // formImportGcash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 501);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "formImportGcash";
            this.Text = "Import Gcash Payments";
            this.Load += new System.EventHandler(this.formImportGcash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelUnrecognized;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelAmt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private dsBilling dsBilling;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private dsBillingTableAdapters.tbBillingTableAdapter tbBillingTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFilterClear;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
    }
}