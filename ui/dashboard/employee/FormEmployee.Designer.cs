namespace ClinicPresentationLayerDesktop.ui.employee
{
    partial class FormEmployee
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
            this.BtnPhone = new System.Windows.Forms.Button();
            this.CntxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuPhone = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.dgvPhoneList = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemel = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbMidName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.BtnNewDep = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).BeginInit();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPhone
            // 
            this.BtnPhone.Location = new System.Drawing.Point(13, 288);
            this.BtnPhone.Name = "BtnPhone";
            this.BtnPhone.Size = new System.Drawing.Size(184, 29);
            this.BtnPhone.TabIndex = 59;
            this.BtnPhone.Text = "Add Phone Number";
            this.BtnPhone.UseVisualStyleBackColor = true;
            this.BtnPhone.Click += new System.EventHandler(this.BtnPhone_Click);
            // 
            // CntxDelete
            // 
            this.CntxDelete.Name = "CntxDelete";
            this.CntxDelete.Size = new System.Drawing.Size(107, 22);
            this.CntxDelete.Text = "Delete";
            // 
            // contextMenuPhone
            // 
            this.contextMenuPhone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxDelete});
            this.contextMenuPhone.Name = "contextMenuPhone";
            this.contextMenuPhone.Size = new System.Drawing.Size(108, 26);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 58;
            this.label8.Text = "Contact";
            // 
            // dgvPhoneList
            // 
            this.dgvPhoneList.AllowUserToAddRows = false;
            this.dgvPhoneList.AllowUserToDeleteRows = false;
            this.dgvPhoneList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhoneList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPhoneList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneList.ContextMenuStrip = this.contextMenuPhone;
            this.dgvPhoneList.Location = new System.Drawing.Point(532, 189);
            this.dgvPhoneList.Name = "dgvPhoneList";
            this.dgvPhoneList.ReadOnly = true;
            this.dgvPhoneList.Size = new System.Drawing.Size(200, 184);
            this.dgvPhoneList.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 19);
            this.label7.TabIndex = 56;
            this.label7.Text = "Select Department amd Specialization";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(98, 258);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(200, 20);
            this.tbAddress.TabIndex = 53;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(665, 418);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(123, 39);
            this.BtnSave.TabIndex = 51;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemel);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(456, 85);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(252, 90);
            this.gbGender.TabIndex = 50;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemel
            // 
            this.rbFemel.AutoSize = true;
            this.rbFemel.Location = new System.Drawing.Point(131, 38);
            this.rbFemel.Name = "rbFemel";
            this.rbFemel.Size = new System.Drawing.Size(53, 17);
            this.rbFemel.TabIndex = 1;
            this.rbFemel.TabStop = true;
            this.rbFemel.Text = "Femel";
            this.rbFemel.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(15, 38);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(98, 229);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 20);
            this.tbEmail.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Birth Day";
            // 
            // dtBirthDay
            // 
            this.dtBirthDay.Location = new System.Drawing.Point(537, 46);
            this.dtBirthDay.Name = "dtBirthDay";
            this.dtBirthDay.Size = new System.Drawing.Size(200, 20);
            this.dtBirthDay.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 54;
            this.label6.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Mid Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "First Name";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(289, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(186, 31);
            this.lbTitle.TabIndex = 42;
            this.lbTitle.Text = "New Employee";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(98, 199);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(131, 20);
            this.tbLastName.TabIndex = 41;
            // 
            // tbMidName
            // 
            this.tbMidName.Location = new System.Drawing.Point(98, 166);
            this.tbMidName.Name = "tbMidName";
            this.tbMidName.Size = new System.Drawing.Size(131, 20);
            this.tbMidName.TabIndex = 40;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(98, 133);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(131, 20);
            this.tbFirstName.TabIndex = 39;
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(16, 68);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(223, 21);
            this.cbDepartment.TabIndex = 60;
            // 
            // BtnNewDep
            // 
            this.BtnNewDep.Location = new System.Drawing.Point(260, 66);
            this.BtnNewDep.Name = "BtnNewDep";
            this.BtnNewDep.Size = new System.Drawing.Size(97, 25);
            this.BtnNewDep.TabIndex = 63;
            this.BtnNewDep.Text = "New";
            this.BtnNewDep.UseVisualStyleBackColor = true;
            this.BtnNewDep.Click += new System.EventHandler(this.BtnNewDep_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.BtnNewDep);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.BtnPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvPhoneList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtBirthDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbMidName);
            this.Controls.Add(this.tbFirstName);
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.contextMenuPhone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).EndInit();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPhone;
        private System.Windows.Forms.ToolStripMenuItem CntxDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvPhoneList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemel;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtBirthDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbMidName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Button BtnNewDep;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}