namespace BillingSystem
{
    partial class formManualBillAddEntry
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAcctno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Account No. :";
            // 
            // txtAcctno
            // 
            this.txtAcctno.Location = new System.Drawing.Point(139, 23);
            this.txtAcctno.MaxLength = 6;
            this.txtAcctno.Name = "txtAcctno";
            this.txtAcctno.Size = new System.Drawing.Size(134, 21);
            this.txtAcctno.TabIndex = 5;
            this.txtAcctno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAcctno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcctno_KeyPress);
            // 
            // formManualBillAddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 70);
            this.Controls.Add(this.txtAcctno);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "formManualBillAddEntry";
            this.Text = "Add Manual Entry";
            this.Load += new System.EventHandler(this.formManualBillAddEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAcctno;
    }
}