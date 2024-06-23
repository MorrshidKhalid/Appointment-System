namespace ClinicPresentationLayerDesktop.ui.pateint
{
    partial class FormDialogWithText
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGetID = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(79, 73);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(156, 20);
            this.tbID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter ID";
            // 
            // BtnGetID
            // 
            this.BtnGetID.Location = new System.Drawing.Point(120, 99);
            this.BtnGetID.Name = "BtnGetID";
            this.BtnGetID.Size = new System.Drawing.Size(75, 23);
            this.BtnGetID.TabIndex = 2;
            this.BtnGetID.Text = "Get";
            this.BtnGetID.UseVisualStyleBackColor = true;
            this.BtnGetID.Click += new System.EventHandler(this.BtnGetID_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FormDialogWithText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.BtnGetID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.MaximumSize = new System.Drawing.Size(350, 250);
            this.Name = "FormDialogWithText";
            this.Text = "Enter ID Dialoog";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGetID;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}