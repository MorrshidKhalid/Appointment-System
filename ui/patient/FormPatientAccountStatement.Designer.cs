namespace ClinicPresentationLayerDesktop.ui.pateint
{
    partial class FormPatientAccountStatement
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
            this.dgvAccountStatement = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccountStatement
            // 
            this.dgvAccountStatement.AllowUserToAddRows = false;
            this.dgvAccountStatement.AllowUserToDeleteRows = false;
            this.dgvAccountStatement.AllowUserToOrderColumns = true;
            this.dgvAccountStatement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountStatement.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAccountStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountStatement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccountStatement.Location = new System.Drawing.Point(0, 0);
            this.dgvAccountStatement.Name = "dgvAccountStatement";
            this.dgvAccountStatement.ReadOnly = true;
            this.dgvAccountStatement.Size = new System.Drawing.Size(800, 450);
            this.dgvAccountStatement.TabIndex = 0;
            // 
            // FormPatientAccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAccountStatement);
            this.Name = "FormPatientAccountStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Statement";
            this.Load += new System.EventHandler(this.FormPatientAccountStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountStatement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccountStatement;
    }
}