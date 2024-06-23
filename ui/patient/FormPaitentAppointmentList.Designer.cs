namespace ClinicPresentationLayerDesktop.ui.pateint
{
    partial class FormPaitentAppointmentList
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
            this.dgvPaitentAppointmentList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaitentAppointmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaitentAppointmentList
            // 
            this.dgvPaitentAppointmentList.AllowUserToAddRows = false;
            this.dgvPaitentAppointmentList.AllowUserToDeleteRows = false;
            this.dgvPaitentAppointmentList.AllowUserToOrderColumns = true;
            this.dgvPaitentAppointmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaitentAppointmentList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPaitentAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaitentAppointmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaitentAppointmentList.Location = new System.Drawing.Point(0, 0);
            this.dgvPaitentAppointmentList.Name = "dgvPaitentAppointmentList";
            this.dgvPaitentAppointmentList.ReadOnly = true;
            this.dgvPaitentAppointmentList.Size = new System.Drawing.Size(800, 450);
            this.dgvPaitentAppointmentList.TabIndex = 0;
            // 
            // FormPaitentAppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPaitentAppointmentList);
            this.Name = "FormPaitentAppointmentList";
            this.Text = "FormPaitentAppointmentList";
            this.Load += new System.EventHandler(this.FormPaitentAppointmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaitentAppointmentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaitentAppointmentList;
    }
}