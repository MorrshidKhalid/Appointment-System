namespace ClinicPresentationLayerDesktop.ui.appointment
{
    partial class FormReschedule
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BtnReschedule = new System.Windows.Forms.Button();
            this.dpAppointDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDoctorName = new System.Windows.Forms.Label();
            this.lbPatientName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Reschedule Appointment";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(518, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 32);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnReschedule
            // 
            this.BtnReschedule.Location = new System.Drawing.Point(666, 208);
            this.BtnReschedule.Name = "BtnReschedule";
            this.BtnReschedule.Size = new System.Drawing.Size(121, 32);
            this.BtnReschedule.TabIndex = 19;
            this.BtnReschedule.Text = "Reschedule";
            this.BtnReschedule.UseVisualStyleBackColor = true;
            this.BtnReschedule.Click += new System.EventHandler(this.BtnReschedule_Click);
            // 
            // dpAppointDate
            // 
            this.dpAppointDate.Location = new System.Drawing.Point(549, 62);
            this.dpAppointDate.Name = "dpAppointDate";
            this.dpAppointDate.Size = new System.Drawing.Size(203, 20);
            this.dpAppointDate.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "The Patient:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "The Doctor: ";
            // 
            // lbDoctorName
            // 
            this.lbDoctorName.AutoSize = true;
            this.lbDoctorName.Location = new System.Drawing.Point(87, 69);
            this.lbDoctorName.Name = "lbDoctorName";
            this.lbDoctorName.Size = new System.Drawing.Size(25, 13);
            this.lbDoctorName.TabIndex = 22;
            this.lbDoctorName.Text = "???";
            // 
            // lbPatientName
            // 
            this.lbPatientName.AutoSize = true;
            this.lbPatientName.Location = new System.Drawing.Point(87, 109);
            this.lbPatientName.Name = "lbPatientName";
            this.lbPatientName.Size = new System.Drawing.Size(25, 13);
            this.lbPatientName.TabIndex = 23;
            this.lbPatientName.Text = "???";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(548, 109);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(25, 13);
            this.lbDate.TabIndex = 24;
            this.lbDate.Text = "???";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FormReschedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbPatientName);
            this.Controls.Add(this.lbDoctorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnReschedule);
            this.Controls.Add(this.dpAppointDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReschedule";
            this.Text = "Reschedule";
            this.Load += new System.EventHandler(this.FormReschedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BtnReschedule;
        private System.Windows.Forms.DateTimePicker dpAppointDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDoctorName;
        private System.Windows.Forms.Label lbPatientName;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}