namespace BillingSystem
{
    partial class formPrintAging
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
            this.cmbBillMonth = new System.Windows.Forms.ComboBox();
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBilling = new BillingSystem.dsBilling();
            this.tbBillingTableAdapter = new BillingSystem.dsBillingTableAdapters.tbBillingTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrepared = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVerify = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoted = new System.Windows.Forms.TextBox();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnZone = new System.Windows.Forms.Button();
            this.btnRecap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBillMonth
            // 
            this.cmbBillMonth.DataSource = this.tbBillingBindingSource;
            this.cmbBillMonth.DisplayMember = "billing_desc";
            this.cmbBillMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillMonth.FormattingEnabled = true;
            this.cmbBillMonth.Location = new System.Drawing.Point(77, 20);
            this.cmbBillMonth.Name = "cmbBillMonth";
            this.cmbBillMonth.Size = new System.Drawing.Size(150, 21);
            this.cmbBillMonth.TabIndex = 0;
            this.cmbBillMonth.ValueMember = "billing_id";
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
            // tbBillingTableAdapter
            // 
            this.tbBillingTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill Month :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "active",
            "inactive"});
            this.comboBox1.Location = new System.Drawing.Point(77, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prepared by:";
            // 
            // txtPrepared
            // 
            this.txtPrepared.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrepared.Location = new System.Drawing.Point(342, 20);
            this.txtPrepared.Name = "txtPrepared";
            this.txtPrepared.Size = new System.Drawing.Size(229, 20);
            this.txtPrepared.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Designation :";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(342, 46);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(229, 20);
            this.txtDesignation.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Verified by:";
            // 
            // txtVerify
            // 
            this.txtVerify.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVerify.Location = new System.Drawing.Point(342, 72);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Size = new System.Drawing.Size(229, 20);
            this.txtVerify.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Noted by:";
            // 
            // txtNoted
            // 
            this.txtNoted.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoted.Location = new System.Drawing.Point(342, 96);
            this.txtNoted.Name = "txtNoted";
            this.txtNoted.Size = new System.Drawing.Size(229, 20);
            this.txtNoted.TabIndex = 11;
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(104, 141);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(164, 38);
            this.btnCategory.TabIndex = 12;
            this.btnCategory.Text = "By Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnZone
            // 
            this.btnZone.Location = new System.Drawing.Point(366, 141);
            this.btnZone.Name = "btnZone";
            this.btnZone.Size = new System.Drawing.Size(164, 38);
            this.btnZone.TabIndex = 13;
            this.btnZone.Text = "By Zone";
            this.btnZone.UseVisualStyleBackColor = true;
            this.btnZone.Click += new System.EventHandler(this.btnZone_Click);
            // 
            // btnRecap
            // 
            this.btnRecap.Location = new System.Drawing.Point(237, 213);
            this.btnRecap.Name = "btnRecap";
            this.btnRecap.Size = new System.Drawing.Size(164, 38);
            this.btnRecap.TabIndex = 14;
            this.btnRecap.Text = "Receivable Recap";
            this.btnRecap.UseVisualStyleBackColor = true;
            this.btnRecap.Click += new System.EventHandler(this.btnRecap_Click);
            // 
            // formPrintAging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 272);
            this.Controls.Add(this.btnRecap);
            this.Controls.Add(this.btnZone);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.txtNoted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVerify);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrepared);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBillMonth);
            this.Name = "formPrintAging";
            this.Text = "Aging of Accounts Print Menu";
            this.Load += new System.EventHandler(this.formPrintAging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBillMonth;
        private dsBilling dsBilling;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private dsBillingTableAdapters.tbBillingTableAdapter tbBillingTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrepared;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVerify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoted;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnZone;
        private System.Windows.Forms.Button btnRecap;
    }
}