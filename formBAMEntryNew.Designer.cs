namespace BillingSystem
{
    partial class formBAMEntryNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txBAMNo = new System.Windows.Forms.TextBox();
            this.txDate = new System.Windows.Forms.TextBox();
            this.txAcctNo = new System.Windows.Forms.TextBox();
            this.txConcessioner = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txZoneNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txCardNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txExplanation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBAMCase = new System.Windows.Forms.ComboBox();
            this.tbBAMCasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBAMCases = new BillingSystem.dsBAMCases();
            this.tbBAMCasesTableAdapter = new BillingSystem.dsBAMCasesTableAdapters.tbBAMCasesTableAdapter();
            this.btnAddJournal = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txBillMonth = new System.Windows.Forms.TextBox();
            this.txCumBilled = new System.Windows.Forms.TextBox();
            this.txCumShould = new System.Windows.Forms.TextBox();
            this.txCumCorrected = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txTotalDebit = new System.Windows.Forms.TextBox();
            this.txTotalCredit = new System.Windows.Forms.TextBox();
            this.txReading = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnEditReading = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbBAMCasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBAMCases)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(714, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAM No. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(738, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(930, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "BILLING ADJUSTMENT MEMO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Acct No. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Concessioner :";
            // 
            // txBAMNo
            // 
            this.txBAMNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txBAMNo.Location = new System.Drawing.Point(787, 47);
            this.txBAMNo.Name = "txBAMNo";
            this.txBAMNo.Size = new System.Drawing.Size(132, 22);
            this.txBAMNo.TabIndex = 5;
            this.txBAMNo.TabStop = false;
            this.txBAMNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txDate
            // 
            this.txDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txDate.Location = new System.Drawing.Point(787, 75);
            this.txDate.Name = "txDate";
            this.txDate.Size = new System.Drawing.Size(132, 22);
            this.txDate.TabIndex = 6;
            this.txDate.TabStop = false;
            this.txDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txAcctNo
            // 
            this.txAcctNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txAcctNo.Location = new System.Drawing.Point(110, 80);
            this.txAcctNo.MaxLength = 6;
            this.txAcctNo.Name = "txAcctNo";
            this.txAcctNo.Size = new System.Drawing.Size(132, 22);
            this.txAcctNo.TabIndex = 7;
            this.txAcctNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txAcctNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txAcctNo_KeyPress);
            // 
            // txConcessioner
            // 
            this.txConcessioner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txConcessioner.Location = new System.Drawing.Point(110, 108);
            this.txConcessioner.Name = "txConcessioner";
            this.txConcessioner.Size = new System.Drawing.Size(420, 22);
            this.txConcessioner.TabIndex = 8;
            this.txConcessioner.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Zone No. :";
            // 
            // txZoneNo
            // 
            this.txZoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txZoneNo.Location = new System.Drawing.Point(638, 108);
            this.txZoneNo.Name = "txZoneNo";
            this.txZoneNo.Size = new System.Drawing.Size(90, 22);
            this.txZoneNo.TabIndex = 10;
            this.txZoneNo.TabStop = false;
            this.txZoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(754, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Card No. :";
            // 
            // txCardNo
            // 
            this.txCardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCardNo.Location = new System.Drawing.Point(827, 108);
            this.txCardNo.Name = "txCardNo";
            this.txCardNo.Size = new System.Drawing.Size(92, 22);
            this.txCardNo.TabIndex = 12;
            this.txCardNo.TabStop = false;
            this.txCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Explanation :";
            // 
            // txExplanation
            // 
            this.txExplanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txExplanation.Location = new System.Drawing.Point(110, 148);
            this.txExplanation.MaxLength = 254;
            this.txExplanation.Multiline = true;
            this.txExplanation.Name = "txExplanation";
            this.txExplanation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txExplanation.Size = new System.Drawing.Size(478, 77);
            this.txExplanation.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "BAM Case :";
            // 
            // comboBAMCase
            // 
            this.comboBAMCase.DataSource = this.tbBAMCasesBindingSource;
            this.comboBAMCase.DisplayMember = "case_desc";
            this.comboBAMCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBAMCase.FormattingEnabled = true;
            this.comboBAMCase.Location = new System.Drawing.Point(110, 47);
            this.comboBAMCase.Name = "comboBAMCase";
            this.comboBAMCase.Size = new System.Drawing.Size(301, 24);
            this.comboBAMCase.TabIndex = 16;
            this.comboBAMCase.ValueMember = "bcase_id";
            this.comboBAMCase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBAMCase_KeyPress);
            // 
            // tbBAMCasesBindingSource
            // 
            this.tbBAMCasesBindingSource.DataMember = "tbBAMCases";
            this.tbBAMCasesBindingSource.DataSource = this.dsBAMCases;
            // 
            // dsBAMCases
            // 
            this.dsBAMCases.DataSetName = "dsBAMCases";
            this.dsBAMCases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBAMCasesTableAdapter
            // 
            this.tbBAMCasesTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddJournal
            // 
            this.btnAddJournal.Enabled = false;
            this.btnAddJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJournal.Location = new System.Drawing.Point(814, 248);
            this.btnAddJournal.Name = "btnAddJournal";
            this.btnAddJournal.Size = new System.Drawing.Size(105, 25);
            this.btnAddJournal.TabIndex = 17;
            this.btnAddJournal.Text = "Add Journal";
            this.btnAddJournal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddJournal.UseVisualStyleBackColor = true;
            this.btnAddJournal.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(7, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(500, 36);
            this.label10.TabIndex = 18;
            this.label10.Text = "Consumption(CuM)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(508, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(417, 36);
            this.label12.TabIndex = 20;
            this.label12.Text = "Journal Entries";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(508, 280);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(417, 125);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Account Title";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 125;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Code";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 77;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Debit";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 89;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Credit";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader12.Width = 120;
            // 
            // txBillMonth
            // 
            this.txBillMonth.AcceptsReturn = true;
            this.txBillMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txBillMonth.Location = new System.Drawing.Point(6, 303);
            this.txBillMonth.MaxLength = 50;
            this.txBillMonth.Multiline = true;
            this.txBillMonth.Name = "txBillMonth";
            this.txBillMonth.Size = new System.Drawing.Size(124, 103);
            this.txBillMonth.TabIndex = 22;
            this.txBillMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txCumBilled
            // 
            this.txCumBilled.AcceptsReturn = true;
            this.txCumBilled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCumBilled.Location = new System.Drawing.Point(132, 303);
            this.txCumBilled.MaxLength = 50;
            this.txCumBilled.Multiline = true;
            this.txCumBilled.Name = "txCumBilled";
            this.txCumBilled.Size = new System.Drawing.Size(124, 103);
            this.txCumBilled.TabIndex = 23;
            this.txCumBilled.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txCumShould
            // 
            this.txCumShould.AcceptsReturn = true;
            this.txCumShould.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCumShould.Location = new System.Drawing.Point(258, 303);
            this.txCumShould.MaxLength = 50;
            this.txCumShould.Multiline = true;
            this.txCumShould.Name = "txCumShould";
            this.txCumShould.Size = new System.Drawing.Size(124, 103);
            this.txCumShould.TabIndex = 24;
            this.txCumShould.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txCumCorrected
            // 
            this.txCumCorrected.AcceptsReturn = true;
            this.txCumCorrected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCumCorrected.Location = new System.Drawing.Point(383, 303);
            this.txCumCorrected.MaxLength = 80;
            this.txCumCorrected.Multiline = true;
            this.txCumCorrected.Name = "txCumCorrected";
            this.txCumCorrected.Size = new System.Drawing.Size(124, 103);
            this.txCumCorrected.TabIndex = 25;
            this.txCumCorrected.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Location = new System.Drawing.Point(6, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "Bill Month";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Location = new System.Drawing.Point(132, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "As Billed";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Location = new System.Drawing.Point(258, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 21);
            this.label14.TabIndex = 28;
            this.label14.Text = "Should be";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label15.Location = new System.Drawing.Point(383, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 21);
            this.label15.TabIndex = 29;
            this.label15.Text = "Inc. (Dec)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(626, 413);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 19);
            this.label16.TabIndex = 30;
            this.label16.Text = "TOTAL :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txTotalDebit
            // 
            this.txTotalDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txTotalDebit.Location = new System.Drawing.Point(707, 412);
            this.txTotalDebit.Name = "txTotalDebit";
            this.txTotalDebit.Size = new System.Drawing.Size(95, 22);
            this.txTotalDebit.TabIndex = 31;
            this.txTotalDebit.TabStop = false;
            this.txTotalDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txTotalCredit
            // 
            this.txTotalCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txTotalCredit.Location = new System.Drawing.Point(808, 412);
            this.txTotalCredit.Name = "txTotalCredit";
            this.txTotalCredit.Size = new System.Drawing.Size(104, 22);
            this.txTotalCredit.TabIndex = 32;
            this.txTotalCredit.TabStop = false;
            this.txTotalCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txReading
            // 
            this.txReading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txReading.Enabled = false;
            this.txReading.Location = new System.Drawing.Point(666, 175);
            this.txReading.Name = "txReading";
            this.txReading.Size = new System.Drawing.Size(90, 22);
            this.txReading.TabIndex = 33;
            this.txReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(699, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 16);
            this.label17.TabIndex = 34;
            this.label17.Text = "New Last Reading :";
            // 
            // btnEditReading
            // 
            this.btnEditReading.Enabled = false;
            this.btnEditReading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditReading.Location = new System.Drawing.Point(766, 172);
            this.btnEditReading.Name = "btnEditReading";
            this.btnEditReading.Size = new System.Drawing.Size(105, 26);
            this.btnEditReading.TabIndex = 35;
            this.btnEditReading.Text = "Edit Reading";
            this.btnEditReading.UseVisualStyleBackColor = true;
            this.btnEditReading.Click += new System.EventHandler(this.btnEditReading_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(513, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 36;
            this.button1.Text = "Clear";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(425, 449);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 28);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(741, 449);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 28);
            this.btnPrint.TabIndex = 38;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // formBAMEntryNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 489);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddJournal);
            this.Controls.Add(this.btnEditReading);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txReading);
            this.Controls.Add(this.txTotalCredit);
            this.Controls.Add(this.txTotalDebit);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txCumCorrected);
            this.Controls.Add(this.txCumShould);
            this.Controls.Add(this.txCumBilled);
            this.Controls.Add(this.txBillMonth);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBAMCase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txExplanation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txCardNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txZoneNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txConcessioner);
            this.Controls.Add(this.txAcctNo);
            this.Controls.Add(this.txDate);
            this.Controls.Add(this.txBAMNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formBAMEntryNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New BAM";
            this.Load += new System.EventHandler(this.formBAMEntryNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBAMCasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBAMCases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txBAMNo;
        private System.Windows.Forms.TextBox txDate;
        private System.Windows.Forms.TextBox txAcctNo;
        private System.Windows.Forms.TextBox txConcessioner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txZoneNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txCardNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txExplanation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBAMCase;
        private dsBAMCases dsBAMCases;
        private System.Windows.Forms.BindingSource tbBAMCasesBindingSource;
        private dsBAMCasesTableAdapters.tbBAMCasesTableAdapter tbBAMCasesTableAdapter;
        private System.Windows.Forms.Button btnAddJournal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TextBox txBillMonth;
        private System.Windows.Forms.TextBox txCumBilled;
        private System.Windows.Forms.TextBox txCumShould;
        private System.Windows.Forms.TextBox txCumCorrected;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txTotalDebit;
        private System.Windows.Forms.TextBox txTotalCredit;
        private System.Windows.Forms.TextBox txReading;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnEditReading;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
    }
}