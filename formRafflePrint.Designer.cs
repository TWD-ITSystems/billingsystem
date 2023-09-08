namespace BillingSystem
{
    partial class formRafflePrint
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
            System.Windows.Forms.Label raffle_periodLabel;
            this.dbRafflePeriod = new BillingSystem.dbRafflePeriod();
            this.tbRafflePeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbRafflePeriodTableAdapter = new BillingSystem.dbRafflePeriodTableAdapters.tbRafflePeriodTableAdapter();
            this.tableAdapterManager = new BillingSystem.dbRafflePeriodTableAdapters.TableAdapterManager();
            this.raffle_periodComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            raffle_periodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbRafflePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRafflePeriodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbRafflePeriod
            // 
            this.dbRafflePeriod.DataSetName = "dbRafflePeriod";
            this.dbRafflePeriod.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbRafflePeriodBindingSource
            // 
            this.tbRafflePeriodBindingSource.DataMember = "tbRafflePeriod";
            this.tbRafflePeriodBindingSource.DataSource = this.dbRafflePeriod;
            // 
            // tbRafflePeriodTableAdapter
            // 
            this.tbRafflePeriodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbRafflePeriodTableAdapter = this.tbRafflePeriodTableAdapter;
            this.tableAdapterManager.UpdateOrder = BillingSystem.dbRafflePeriodTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // raffle_periodLabel
            // 
            raffle_periodLabel.AutoSize = true;
            raffle_periodLabel.Location = new System.Drawing.Point(37, 47);
            raffle_periodLabel.Name = "raffle_periodLabel";
            raffle_periodLabel.Size = new System.Drawing.Size(71, 13);
            raffle_periodLabel.TabIndex = 1;
            raffle_periodLabel.Text = "Raffle Period:";
            // 
            // raffle_periodComboBox
            // 
            this.raffle_periodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbRafflePeriodBindingSource, "raffle_period", true));
            this.raffle_periodComboBox.DataSource = this.tbRafflePeriodBindingSource;
            this.raffle_periodComboBox.DisplayMember = "raffle_period";
            this.raffle_periodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raffle_periodComboBox.FormattingEnabled = true;
            this.raffle_periodComboBox.Location = new System.Drawing.Point(108, 43);
            this.raffle_periodComboBox.Name = "raffle_periodComboBox";
            this.raffle_periodComboBox.Size = new System.Drawing.Size(180, 21);
            this.raffle_periodComboBox.TabIndex = 2;
            this.raffle_periodComboBox.ValueMember = "raffle_id";
            this.raffle_periodComboBox.SelectedIndexChanged += new System.EventHandler(this.raffle_periodComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Export to File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Title = "Export Entries";
            // 
            // formRafflePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(raffle_periodLabel);
            this.Controls.Add(this.raffle_periodComboBox);
            this.Name = "formRafflePrint";
            this.Text = "Print Raffle Entries";
            this.Load += new System.EventHandler(this.formRafflePrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbRafflePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRafflePeriodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbRafflePeriod dbRafflePeriod;
        private System.Windows.Forms.BindingSource tbRafflePeriodBindingSource;
        private dbRafflePeriodTableAdapters.tbRafflePeriodTableAdapter tbRafflePeriodTableAdapter;
        private dbRafflePeriodTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox raffle_periodComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}