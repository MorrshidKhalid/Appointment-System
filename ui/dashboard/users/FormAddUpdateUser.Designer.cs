namespace ClinicPresentationLayerDesktop.ui.users
{
    partial class FormAddUpdateUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.CbAll = new System.Windows.Forms.CheckBox();
            this.gbActive = new System.Windows.Forms.GroupBox();
            this.rbInActive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.BtnSave = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbPermissions = new System.Windows.Forms.GroupBox();
            this.cbPayment = new System.Windows.Forms.CheckBox();
            this.cbManageUsers = new System.Windows.Forms.CheckBox();
            this.cbDep = new System.Windows.Forms.CheckBox();
            this.cbEmpList = new System.Windows.Forms.CheckBox();
            this.cbEditEmployee = new System.Windows.Forms.CheckBox();
            this.cbDeleteEmployee = new System.Windows.Forms.CheckBox();
            this.cbFindEmployee = new System.Windows.Forms.CheckBox();
            this.cbNewEmployee = new System.Windows.Forms.CheckBox();
            this.cbMR = new System.Windows.Forms.CheckBox();
            this.cbPatientAS = new System.Windows.Forms.CheckBox();
            this.cbPatientList = new System.Windows.Forms.CheckBox();
            this.cbEditPatient = new System.Windows.Forms.CheckBox();
            this.cbDeletePatient = new System.Windows.Forms.CheckBox();
            this.cbFindPatient = new System.Windows.Forms.CheckBox();
            this.cbNewPatient = new System.Windows.Forms.CheckBox();
            this.cbAppointment = new System.Windows.Forms.CheckBox();
            this.CbNothing = new System.Windows.Forms.CheckBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbActive.SuspendLayout();
            this.gbPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Am Employee";
            // 
            // cbEmployees
            // 
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Location = new System.Drawing.Point(124, 52);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(164, 21);
            this.cbEmployees.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Password";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(124, 82);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(164, 20);
            this.tbUserName.TabIndex = 11;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(124, 110);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(164, 20);
            this.tbPassword.TabIndex = 12;
            // 
            // CbAll
            // 
            this.CbAll.AutoSize = true;
            this.CbAll.Location = new System.Drawing.Point(315, 55);
            this.CbAll.Name = "CbAll";
            this.CbAll.Size = new System.Drawing.Size(105, 17);
            this.CbAll.TabIndex = 14;
            this.CbAll.Tag = "-1";
            this.CbAll.Text = "Give Full Access";
            this.CbAll.UseVisualStyleBackColor = true;
            this.CbAll.CheckedChanged += new System.EventHandler(this.CbAll_CheckedChanged);
            // 
            // gbActive
            // 
            this.gbActive.Controls.Add(this.rbInActive);
            this.gbActive.Controls.Add(this.rbActive);
            this.gbActive.Location = new System.Drawing.Point(20, 162);
            this.gbActive.Name = "gbActive";
            this.gbActive.Size = new System.Drawing.Size(200, 78);
            this.gbActive.TabIndex = 15;
            this.gbActive.TabStop = false;
            this.gbActive.Text = "User Activation";
            // 
            // rbInActive
            // 
            this.rbInActive.AutoSize = true;
            this.rbInActive.Location = new System.Drawing.Point(7, 46);
            this.rbInActive.Name = "rbInActive";
            this.rbInActive.Size = new System.Drawing.Size(63, 17);
            this.rbInActive.TabIndex = 1;
            this.rbInActive.TabStop = true;
            this.rbInActive.Text = "Inactive";
            this.rbInActive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(7, 23);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(55, 17);
            this.rbActive.TabIndex = 0;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(461, 456);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(134, 45);
            this.BtnSave.TabIndex = 16;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(219, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(126, 31);
            this.lbTitle.TabIndex = 43;
            this.lbTitle.Text = "New User";
            // 
            // gbPermissions
            // 
            this.gbPermissions.Controls.Add(this.cbPayment);
            this.gbPermissions.Controls.Add(this.cbManageUsers);
            this.gbPermissions.Controls.Add(this.cbDep);
            this.gbPermissions.Controls.Add(this.cbEmpList);
            this.gbPermissions.Controls.Add(this.cbEditEmployee);
            this.gbPermissions.Controls.Add(this.cbDeleteEmployee);
            this.gbPermissions.Controls.Add(this.cbFindEmployee);
            this.gbPermissions.Controls.Add(this.cbNewEmployee);
            this.gbPermissions.Controls.Add(this.cbMR);
            this.gbPermissions.Controls.Add(this.cbPatientAS);
            this.gbPermissions.Controls.Add(this.cbPatientList);
            this.gbPermissions.Controls.Add(this.cbEditPatient);
            this.gbPermissions.Controls.Add(this.cbDeletePatient);
            this.gbPermissions.Controls.Add(this.cbFindPatient);
            this.gbPermissions.Controls.Add(this.cbNewPatient);
            this.gbPermissions.Controls.Add(this.cbAppointment);
            this.gbPermissions.Location = new System.Drawing.Point(315, 78);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(244, 329);
            this.gbPermissions.TabIndex = 45;
            this.gbPermissions.TabStop = false;
            this.gbPermissions.Text = "Give User Permissions";
            // 
            // cbPayment
            // 
            this.cbPayment.AutoSize = true;
            this.cbPayment.Location = new System.Drawing.Point(7, 298);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(135, 17);
            this.cbPayment.TabIndex = 15;
            this.cbPayment.Tag = "32768";
            this.cbPayment.Text = "Give Access Payments";
            this.cbPayment.UseVisualStyleBackColor = true;
            // 
            // cbManageUsers
            // 
            this.cbManageUsers.AutoSize = true;
            this.cbManageUsers.Location = new System.Drawing.Point(7, 278);
            this.cbManageUsers.Name = "cbManageUsers";
            this.cbManageUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbManageUsers.Size = new System.Drawing.Size(158, 17);
            this.cbManageUsers.TabIndex = 14;
            this.cbManageUsers.Tag = "16384";
            this.cbManageUsers.Text = "Give Access Manage Users";
            this.cbManageUsers.UseVisualStyleBackColor = true;
            // 
            // cbDep
            // 
            this.cbDep.AutoSize = true;
            this.cbDep.Location = new System.Drawing.Point(7, 258);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(144, 17);
            this.cbDep.TabIndex = 13;
            this.cbDep.Tag = "8192";
            this.cbDep.Text = "Give Access Department";
            this.cbDep.UseVisualStyleBackColor = true;
            // 
            // cbEmpList
            // 
            this.cbEmpList.AutoSize = true;
            this.cbEmpList.Location = new System.Drawing.Point(7, 238);
            this.cbEmpList.Name = "cbEmpList";
            this.cbEmpList.Size = new System.Drawing.Size(154, 17);
            this.cbEmpList.TabIndex = 12;
            this.cbEmpList.Tag = "4096";
            this.cbEmpList.Text = "Give Access Employee List";
            this.cbEmpList.UseVisualStyleBackColor = true;
            // 
            // cbEditEmployee
            // 
            this.cbEditEmployee.AutoSize = true;
            this.cbEditEmployee.Location = new System.Drawing.Point(7, 218);
            this.cbEditEmployee.Name = "cbEditEmployee";
            this.cbEditEmployee.Size = new System.Drawing.Size(156, 17);
            this.cbEditEmployee.TabIndex = 11;
            this.cbEditEmployee.Tag = "2048";
            this.cbEditEmployee.Text = "Give Access Edit Employee";
            this.cbEditEmployee.UseVisualStyleBackColor = true;
            // 
            // cbDeleteEmployee
            // 
            this.cbDeleteEmployee.AutoSize = true;
            this.cbDeleteEmployee.Location = new System.Drawing.Point(7, 200);
            this.cbDeleteEmployee.Name = "cbDeleteEmployee";
            this.cbDeleteEmployee.Size = new System.Drawing.Size(169, 17);
            this.cbDeleteEmployee.TabIndex = 10;
            this.cbDeleteEmployee.Tag = "1024";
            this.cbDeleteEmployee.Text = "Give Access Delete Employee";
            this.cbDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // cbFindEmployee
            // 
            this.cbFindEmployee.AutoSize = true;
            this.cbFindEmployee.Location = new System.Drawing.Point(7, 182);
            this.cbFindEmployee.Name = "cbFindEmployee";
            this.cbFindEmployee.Size = new System.Drawing.Size(158, 17);
            this.cbFindEmployee.TabIndex = 9;
            this.cbFindEmployee.Tag = "512";
            this.cbFindEmployee.Text = "Give Access Find Employee";
            this.cbFindEmployee.UseVisualStyleBackColor = true;
            // 
            // cbNewEmployee
            // 
            this.cbNewEmployee.AutoSize = true;
            this.cbNewEmployee.Location = new System.Drawing.Point(7, 164);
            this.cbNewEmployee.Name = "cbNewEmployee";
            this.cbNewEmployee.Size = new System.Drawing.Size(157, 17);
            this.cbNewEmployee.TabIndex = 8;
            this.cbNewEmployee.Tag = "256";
            this.cbNewEmployee.Text = "Give Access Add Employee";
            this.cbNewEmployee.UseVisualStyleBackColor = true;
            // 
            // cbMR
            // 
            this.cbMR.AutoSize = true;
            this.cbMR.Location = new System.Drawing.Point(7, 146);
            this.cbMR.Name = "cbMR";
            this.cbMR.Size = new System.Drawing.Size(164, 17);
            this.cbMR.TabIndex = 7;
            this.cbMR.Tag = "128";
            this.cbMR.Text = "Give Access Medical Record";
            this.cbMR.UseVisualStyleBackColor = true;
            // 
            // cbPatientAS
            // 
            this.cbPatientAS.AutoSize = true;
            this.cbPatientAS.Location = new System.Drawing.Point(7, 128);
            this.cbPatientAS.Name = "cbPatientAS";
            this.cbPatientAS.Size = new System.Drawing.Size(103, 17);
            this.cbPatientAS.TabIndex = 6;
            this.cbPatientAS.Tag = "64";
            this.cbPatientAS.Text = "Give Access AS";
            this.cbPatientAS.UseVisualStyleBackColor = true;
            // 
            // cbPatientList
            // 
            this.cbPatientList.AutoSize = true;
            this.cbPatientList.Location = new System.Drawing.Point(7, 110);
            this.cbPatientList.Name = "cbPatientList";
            this.cbPatientList.Size = new System.Drawing.Size(141, 17);
            this.cbPatientList.TabIndex = 5;
            this.cbPatientList.Tag = "32";
            this.cbPatientList.Text = "Give Access Patient List";
            this.cbPatientList.UseVisualStyleBackColor = true;
            // 
            // cbEditPatient
            // 
            this.cbEditPatient.AutoSize = true;
            this.cbEditPatient.Location = new System.Drawing.Point(7, 92);
            this.cbEditPatient.Name = "cbEditPatient";
            this.cbEditPatient.Size = new System.Drawing.Size(160, 17);
            this.cbEditPatient.TabIndex = 4;
            this.cbEditPatient.Tag = "16";
            this.cbEditPatient.Text = "Give Access Update Patient";
            this.cbEditPatient.UseVisualStyleBackColor = true;
            // 
            // cbDeletePatient
            // 
            this.cbDeletePatient.AutoSize = true;
            this.cbDeletePatient.Location = new System.Drawing.Point(7, 74);
            this.cbDeletePatient.Name = "cbDeletePatient";
            this.cbDeletePatient.Size = new System.Drawing.Size(156, 17);
            this.cbDeletePatient.TabIndex = 3;
            this.cbDeletePatient.Tag = "8";
            this.cbDeletePatient.Text = "Give Access Delete Patient";
            this.cbDeletePatient.UseVisualStyleBackColor = true;
            // 
            // cbFindPatient
            // 
            this.cbFindPatient.AutoSize = true;
            this.cbFindPatient.Location = new System.Drawing.Point(7, 56);
            this.cbFindPatient.Name = "cbFindPatient";
            this.cbFindPatient.Size = new System.Drawing.Size(145, 17);
            this.cbFindPatient.TabIndex = 2;
            this.cbFindPatient.Tag = "4";
            this.cbFindPatient.Text = "Give Access Find Patient";
            this.cbFindPatient.UseVisualStyleBackColor = true;
            // 
            // cbNewPatient
            // 
            this.cbNewPatient.AutoSize = true;
            this.cbNewPatient.Location = new System.Drawing.Point(7, 38);
            this.cbNewPatient.Name = "cbNewPatient";
            this.cbNewPatient.Size = new System.Drawing.Size(169, 17);
            this.cbNewPatient.TabIndex = 1;
            this.cbNewPatient.Tag = "2";
            this.cbNewPatient.Text = "Give Access Add New Patient";
            this.cbNewPatient.UseVisualStyleBackColor = true;
            // 
            // cbAppointment
            // 
            this.cbAppointment.AutoSize = true;
            this.cbAppointment.Location = new System.Drawing.Point(7, 20);
            this.cbAppointment.Name = "cbAppointment";
            this.cbAppointment.Size = new System.Drawing.Size(152, 17);
            this.cbAppointment.TabIndex = 0;
            this.cbAppointment.Tag = "1";
            this.cbAppointment.Text = "Give Access appointments";
            this.cbAppointment.UseVisualStyleBackColor = true;
            // 
            // CbNothing
            // 
            this.CbNothing.AutoSize = true;
            this.CbNothing.Location = new System.Drawing.Point(441, 55);
            this.CbNothing.Name = "CbNothing";
            this.CbNothing.Size = new System.Drawing.Size(63, 17);
            this.CbNothing.TabIndex = 46;
            this.CbNothing.Tag = "0";
            this.CbNothing.Text = "Nothing";
            this.CbNothing.UseVisualStyleBackColor = true;
            this.CbNothing.CheckedChanged += new System.EventHandler(this.CbNothing_CheckedChanged);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FormAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 513);
            this.Controls.Add(this.CbNothing);
            this.Controls.Add(this.gbPermissions);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.gbActive);
            this.Controls.Add(this.CbAll);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmployees);
            this.Name = "FormAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            this.Load += new System.EventHandler(this.FormAddUpdateUser_Load);
            this.gbActive.ResumeLayout(false);
            this.gbActive.PerformLayout();
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmployees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox CbAll;
        private System.Windows.Forms.GroupBox gbActive;
        private System.Windows.Forms.RadioButton rbInActive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbPermissions;
        private System.Windows.Forms.CheckBox cbEditEmployee;
        private System.Windows.Forms.CheckBox cbDeleteEmployee;
        private System.Windows.Forms.CheckBox cbFindEmployee;
        private System.Windows.Forms.CheckBox cbNewEmployee;
        private System.Windows.Forms.CheckBox cbMR;
        private System.Windows.Forms.CheckBox cbPatientAS;
        private System.Windows.Forms.CheckBox cbPatientList;
        private System.Windows.Forms.CheckBox cbDeletePatient;
        private System.Windows.Forms.CheckBox cbFindPatient;
        private System.Windows.Forms.CheckBox cbNewPatient;
        private System.Windows.Forms.CheckBox cbAppointment;
        private System.Windows.Forms.CheckBox cbEditPatient;
        private System.Windows.Forms.CheckBox cbDep;
        private System.Windows.Forms.CheckBox cbEmpList;
        private System.Windows.Forms.CheckBox cbPayment;
        private System.Windows.Forms.CheckBox cbManageUsers;
        private System.Windows.Forms.CheckBox CbNothing;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}