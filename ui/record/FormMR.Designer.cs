namespace ClinicPresentationLayerDesktop.ui.record
{
    partial class FormMR
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
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbDiagnosis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPatientName = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnPrescribe = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(13, 35);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(306, 49);
            this.tbDescription.TabIndex = 1;
            // 
            // tbDiagnosis
            // 
            this.tbDiagnosis.Location = new System.Drawing.Point(13, 126);
            this.tbDiagnosis.Multiline = true;
            this.tbDiagnosis.Name = "tbDiagnosis";
            this.tbDiagnosis.Size = new System.Drawing.Size(306, 71);
            this.tbDiagnosis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diagnosis";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(13, 229);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(306, 20);
            this.tbNote.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Patient:";
            // 
            // lbPatientName
            // 
            this.lbPatientName.AutoSize = true;
            this.lbPatientName.Location = new System.Drawing.Point(431, 35);
            this.lbPatientName.Name = "lbPatientName";
            this.lbPatientName.Size = new System.Drawing.Size(25, 13);
            this.lbPatientName.TabIndex = 7;
            this.lbPatientName.Text = "???";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(431, 61);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(25, 13);
            this.lbGender.TabIndex = 9;
            this.lbGender.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gender:";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(431, 86);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(25, 13);
            this.lbAge.TabIndex = 11;
            this.lbAge.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Age:";
            // 
            // BtnPrescribe
            // 
            this.BtnPrescribe.Location = new System.Drawing.Point(548, 35);
            this.BtnPrescribe.Name = "BtnPrescribe";
            this.BtnPrescribe.Size = new System.Drawing.Size(102, 52);
            this.BtnPrescribe.TabIndex = 12;
            this.BtnPrescribe.Text = "Prescribe";
            this.BtnPrescribe.UseVisualStyleBackColor = true;
            this.BtnPrescribe.Click += new System.EventHandler(this.BtnPrescribe_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(548, 212);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(102, 37);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FormMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnPrescribe);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbPatientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDiagnosis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(700, 300);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.name = "FormMR";
            this.Text = "FormMR";
            this.Load += new System.EventHandler(this.FormMR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbDiagnosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPatientName;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnPrescribe;
        private System.Windows.Forms.Button BtnSave;
    }
}