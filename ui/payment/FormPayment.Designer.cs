namespace ClinicPresentationLayerDesktop.ui.payment
{
    partial class FormPayment
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
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.CbPatient = new System.Windows.Forms.ComboBox();
            this.BtnPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMethod
            // 
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Location = new System.Drawing.Point(13, 14);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(133, 21);
            this.cbMethod.TabIndex = 0;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(9, 72);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(359, 72);
            this.tbNote.TabIndex = 1;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(9, 182);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(109, 20);
            this.tbAmount.TabIndex = 2;
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(436, 14);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(186, 20);
            this.dpDate.TabIndex = 3;
            // 
            // CbPatient
            // 
            this.CbPatient.FormattingEnabled = true;
            this.CbPatient.Location = new System.Drawing.Point(152, 14);
            this.CbPatient.Name = "CbPatient";
            this.CbPatient.Size = new System.Drawing.Size(220, 21);
            this.CbPatient.TabIndex = 4;
            // 
            // BtnPay
            // 
            this.BtnPay.Location = new System.Drawing.Point(526, 179);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(96, 23);
            this.BtnPay.TabIndex = 5;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Note";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 211);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.CbPatient);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.cbMethod);
            this.MaximumSize = new System.Drawing.Size(660, 250);
            this.MinimumSize = new System.Drawing.Size(660, 250);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.ComboBox CbPatient;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}