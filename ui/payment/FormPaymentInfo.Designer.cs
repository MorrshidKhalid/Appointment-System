namespace ClinicPresentationLayerDesktop.ui.payment
{
    partial class FormPaymentInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPatietName = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(423, 13);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(25, 13);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Paid:";
            // 
            // lbPatietName
            // 
            this.lbPatietName.AutoSize = true;
            this.lbPatietName.Location = new System.Drawing.Point(73, 13);
            this.lbPatietName.Name = "lbPatietName";
            this.lbPatietName.Size = new System.Drawing.Size(25, 13);
            this.lbPatietName.TabIndex = 4;
            this.lbPatietName.Text = "???";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(27, 61);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(25, 13);
            this.lbNote.TabIndex = 5;
            this.lbNote.Text = "???";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(47, 123);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(25, 13);
            this.lbAmount.TabIndex = 6;
            this.lbAmount.Text = "???";
            // 
            // FormPaymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 166);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.lbPatietName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(600, 205);
            this.MinimumSize = new System.Drawing.Size(600, 205);
            this.Name = "FormPaymentInfo";
            this.Text = "FormPaymentInfo";
            this.Load += new System.EventHandler(this.FormPaymentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPatietName;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label lbAmount;
    }
}