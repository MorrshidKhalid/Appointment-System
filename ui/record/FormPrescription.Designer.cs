﻿namespace ClinicPresentationLayerDesktop.ui.record
{
    partial class FormPrescription
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
            this.BtnMedicationLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPatientName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMedicationLine
            // 
            this.BtnMedicationLine.Location = new System.Drawing.Point(12, 73);
            this.BtnMedicationLine.Name = "BtnMedicationLine";
            this.BtnMedicationLine.Size = new System.Drawing.Size(184, 31);
            this.BtnMedicationLine.TabIndex = 0;
            this.BtnMedicationLine.Text = "New Medication";
            this.BtnMedicationLine.UseVisualStyleBackColor = true;
            this.BtnMedicationLine.Click += new System.EventHandler(this.BtnMedicationLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Medocation Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Freq*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dosage*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "End Date";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(765, 73);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(121, 31);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save Prescription";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Patient Name*";
            // 
            // lbPatientName
            // 
            this.lbPatientName.AutoSize = true;
            this.lbPatientName.Location = new System.Drawing.Point(12, 31);
            this.lbPatientName.Name = "lbPatientName";
            this.lbPatientName.Size = new System.Drawing.Size(25, 13);
            this.lbPatientName.TabIndex = 16;
            this.lbPatientName.Text = "???";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(155, 31);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(25, 13);
            this.lbAge.TabIndex = 18;
            this.lbAge.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Age*";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(260, 31);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(25, 13);
            this.lbGender.TabIndex = 20;
            this.lbGender.Text = "???";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Gender*";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(692, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(166, 24);
            this.lbTitle.TabIndex = 21;
            this.lbTitle.Text = "Add Medications";
            // 
            // FormPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 404);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbPatientName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMedicationLine);
            this.Name = "FormPrescription";
            this.Text = "FormPrescription";
            this.Load += new System.EventHandler(this.FormPrescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMedicationLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPatientName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTitle;
    }
}