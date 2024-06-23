namespace ClinicPresentationLayerDesktop
{
    partial class HomeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HomeMenu = new System.Windows.Forms.MenuStrip();
            this.MenuAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFindAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPatientList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPatientAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAccountStatement = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMalePayment = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMethodList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAllPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGetPateintPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManageUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUserList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDep = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManageEmployies = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEmpList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMe = new System.Windows.Forms.ToolStripMenuItem();
            this.developedByKhalidAliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLogoutMain = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAppointementList = new System.Windows.Forms.DataGridView();
            this.ctxAppointmentOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CntxReschedule = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxWhosDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxGetPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxPending = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxConfirmed = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxCompleted = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxCanceled = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxNoShow = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxOpenMedicationRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxPatientPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.CntxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbPatient = new System.Windows.Forms.ComboBox();
            this.CbDoctor = new System.Windows.Forms.ComboBox();
            this.dpAppointment = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPaymentNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPaymentAmount = new System.Windows.Forms.TextBox();
            this.BtnNewReservation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.CbRescheduled = new System.Windows.Forms.CheckBox();
            this.CbNoShow = new System.Windows.Forms.CheckBox();
            this.CbPending = new System.Windows.Forms.CheckBox();
            this.CbConfirmed = new System.Windows.Forms.CheckBox();
            this.CbCompleted = new System.Windows.Forms.CheckBox();
            this.CbCanceled = new System.Windows.Forms.CheckBox();
            this.CbToday = new System.Windows.Forms.CheckBox();
            this.CbAll = new System.Windows.Forms.CheckBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.HomeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointementList)).BeginInit();
            this.ctxAppointmentOption.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeMenu
            // 
            this.HomeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAppointment,
            this.MenuPatient,
            this.MenuPayments,
            this.MenuDashboard,
            this.MenuAbout,
            this.MenuLogoutMain});
            this.HomeMenu.Location = new System.Drawing.Point(0, 0);
            this.HomeMenu.Name = "HomeMenu";
            this.HomeMenu.Size = new System.Drawing.Size(820, 24);
            this.HomeMenu.TabIndex = 1;
            this.HomeMenu.Text = "menuStrip1";
            // 
            // MenuAppointment
            // 
            this.MenuAppointment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFindAppointment});
            this.MenuAppointment.Name = "MenuAppointment";
            this.MenuAppointment.Size = new System.Drawing.Size(95, 20);
            this.MenuAppointment.Tag = "";
            this.MenuAppointment.Text = "Appointments";
            // 
            // MenuFindAppointment
            // 
            this.MenuFindAppointment.Name = "MenuFindAppointment";
            this.MenuFindAppointment.Size = new System.Drawing.Size(97, 22);
            this.MenuFindAppointment.Text = "Find";
            this.MenuFindAppointment.Click += new System.EventHandler(this.MenuFind_Click);
            // 
            // MenuPatient
            // 
            this.MenuPatient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAddPatient,
            this.MenuPatientList,
            this.toolStripMenuItem1,
            this.displayToolStripMenuItem,
            this.MenuAccountStatement});
            this.MenuPatient.Name = "MenuPatient";
            this.MenuPatient.Size = new System.Drawing.Size(61, 20);
            this.MenuPatient.Text = "Patients";
            // 
            // MenuAddPatient
            // 
            this.MenuAddPatient.Name = "MenuAddPatient";
            this.MenuAddPatient.Size = new System.Drawing.Size(180, 22);
            this.MenuAddPatient.Tag = "2";
            this.MenuAddPatient.Text = "Add New";
            this.MenuAddPatient.Click += new System.EventHandler(this.MenuAddPatient_Click);
            // 
            // MenuPatientList
            // 
            this.MenuPatientList.Name = "MenuPatientList";
            this.MenuPatientList.Size = new System.Drawing.Size(180, 22);
            this.MenuPatientList.Tag = "32";
            this.MenuPatientList.Text = "Display All Pateints";
            this.MenuPatientList.Click += new System.EventHandler(this.MenuPatientList_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPatientAppointment});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayToolStripMenuItem.Text = "Go To";
            // 
            // MenuPatientAppointment
            // 
            this.MenuPatientAppointment.Name = "MenuPatientAppointment";
            this.MenuPatientAppointment.Size = new System.Drawing.Size(198, 22);
            this.MenuPatientAppointment.Text = "Pateint Appointment(s)";
            this.MenuPatientAppointment.Click += new System.EventHandler(this.MenuPatientAppointment_Click);
            // 
            // MenuAccountStatement
            // 
            this.MenuAccountStatement.Name = "MenuAccountStatement";
            this.MenuAccountStatement.Size = new System.Drawing.Size(180, 22);
            this.MenuAccountStatement.Tag = "64";
            this.MenuAccountStatement.Text = "Account Statement";
            this.MenuAccountStatement.Click += new System.EventHandler(this.MenuAccountStatement_Click);
            // 
            // MenuPayments
            // 
            this.MenuPayments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMalePayment,
            this.goToToolStripMenuItem});
            this.MenuPayments.Name = "MenuPayments";
            this.MenuPayments.Size = new System.Drawing.Size(71, 20);
            this.MenuPayments.Tag = "32768";
            this.MenuPayments.Text = "Payments";
            // 
            // MenuMalePayment
            // 
            this.MenuMalePayment.Name = "MenuMalePayment";
            this.MenuMalePayment.Size = new System.Drawing.Size(153, 22);
            this.MenuMalePayment.Text = "Make Payment";
            this.MenuMalePayment.Click += new System.EventHandler(this.MenuMakePayment_Click);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMethodList,
            this.MenuAllPayments,
            this.MenuGetPateintPayment});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.goToToolStripMenuItem.Text = "Go To";
            // 
            // MenuMethodList
            // 
            this.MenuMethodList.Name = "MenuMethodList";
            this.MenuMethodList.Size = new System.Drawing.Size(189, 22);
            this.MenuMethodList.Text = "Payment Methods list";
            this.MenuMethodList.Click += new System.EventHandler(this.MenuMethodList_Click);
            // 
            // MenuAllPayments
            // 
            this.MenuAllPayments.Name = "MenuAllPayments";
            this.MenuAllPayments.Size = new System.Drawing.Size(189, 22);
            this.MenuAllPayments.Text = "All Payments";
            this.MenuAllPayments.Click += new System.EventHandler(this.MenuAllPayments_Click);
            // 
            // MenuGetPateintPayment
            // 
            this.MenuGetPateintPayment.Name = "MenuGetPateintPayment";
            this.MenuGetPateintPayment.Size = new System.Drawing.Size(189, 22);
            this.MenuGetPateintPayment.Text = "Pateint Payment";
            this.MenuGetPateintPayment.Click += new System.EventHandler(this.MenuGetPateintPayment_Click);
            // 
            // MenuDashboard
            // 
            this.MenuDashboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProfile,
            this.MenuManageUsers,
            this.MenuDep,
            this.MenuManageEmployies});
            this.MenuDashboard.Name = "MenuDashboard";
            this.MenuDashboard.Size = new System.Drawing.Size(76, 20);
            this.MenuDashboard.Text = "Dashboard";
            // 
            // MenuProfile
            // 
            this.MenuProfile.Name = "MenuProfile";
            this.MenuProfile.Size = new System.Drawing.Size(177, 22);
            this.MenuProfile.Text = "User Profile";
            this.MenuProfile.Click += new System.EventHandler(this.MenuProfile_Click);
            // 
            // MenuManageUsers
            // 
            this.MenuManageUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAddUser,
            this.MenuUserList});
            this.MenuManageUsers.Name = "MenuManageUsers";
            this.MenuManageUsers.Size = new System.Drawing.Size(177, 22);
            this.MenuManageUsers.Tag = "8192";
            this.MenuManageUsers.Text = "Manage Users";
            // 
            // MenuAddUser
            // 
            this.MenuAddUser.Name = "MenuAddUser";
            this.MenuAddUser.Size = new System.Drawing.Size(149, 22);
            this.MenuAddUser.Text = "Add New User";
            this.MenuAddUser.Click += new System.EventHandler(this.MenuAddUser_Click);
            // 
            // MenuUserList
            // 
            this.MenuUserList.Name = "MenuUserList";
            this.MenuUserList.Size = new System.Drawing.Size(149, 22);
            this.MenuUserList.Text = "Users List";
            this.MenuUserList.Click += new System.EventHandler(this.MenuUserList_Click);
            // 
            // MenuDep
            // 
            this.MenuDep.Name = "MenuDep";
            this.MenuDep.Size = new System.Drawing.Size(177, 22);
            this.MenuDep.Text = "Departments";
            this.MenuDep.Click += new System.EventHandler(this.MenuDep_Click);
            // 
            // MenuManageEmployies
            // 
            this.MenuManageEmployies.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewEmp,
            this.MenuEmpList});
            this.MenuManageEmployies.Name = "MenuManageEmployies";
            this.MenuManageEmployies.Size = new System.Drawing.Size(177, 22);
            this.MenuManageEmployies.Text = "Manage Employees";
            // 
            // MenuNewEmp
            // 
            this.MenuNewEmp.Name = "MenuNewEmp";
            this.MenuNewEmp.Size = new System.Drawing.Size(153, 22);
            this.MenuNewEmp.Tag = "256";
            this.MenuNewEmp.Text = "New Employee";
            this.MenuNewEmp.Click += new System.EventHandler(this.MenuNewEmp_Click);
            // 
            // MenuEmpList
            // 
            this.MenuEmpList.Name = "MenuEmpList";
            this.MenuEmpList.Size = new System.Drawing.Size(153, 22);
            this.MenuEmpList.Text = "Employies List";
            this.MenuEmpList.Click += new System.EventHandler(this.MenuEmpList_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMe});
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(52, 20);
            this.MenuAbout.Text = "About";
            // 
            // MenuMe
            // 
            this.MenuMe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developedByKhalidAliToolStripMenuItem,
            this.contactDeveloperToolStripMenuItem});
            this.MenuMe.Name = "MenuMe";
            this.MenuMe.Size = new System.Drawing.Size(154, 22);
            this.MenuMe.Text = "Developed Info";
            this.MenuMe.Click += new System.EventHandler(this.MenuMe_Click);
            // 
            // developedByKhalidAliToolStripMenuItem
            // 
            this.developedByKhalidAliToolStripMenuItem.Name = "developedByKhalidAliToolStripMenuItem";
            this.developedByKhalidAliToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.developedByKhalidAliToolStripMenuItem.Text = "Developed By Khalid Ali";
            // 
            // contactDeveloperToolStripMenuItem
            // 
            this.contactDeveloperToolStripMenuItem.Name = "contactDeveloperToolStripMenuItem";
            this.contactDeveloperToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.contactDeveloperToolStripMenuItem.Text = "Contact Developer";
            // 
            // MenuLogoutMain
            // 
            this.MenuLogoutMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLogout,
            this.MenuShutdown});
            this.MenuLogoutMain.Name = "MenuLogoutMain";
            this.MenuLogoutMain.Size = new System.Drawing.Size(57, 20);
            this.MenuLogoutMain.Text = "Logout";
            // 
            // MenuLogout
            // 
            this.MenuLogout.Name = "MenuLogout";
            this.MenuLogout.Size = new System.Drawing.Size(138, 22);
            this.MenuLogout.Text = "Logout User";
            this.MenuLogout.Click += new System.EventHandler(this.MenuLogout_Click);
            // 
            // MenuShutdown
            // 
            this.MenuShutdown.Name = "MenuShutdown";
            this.MenuShutdown.Size = new System.Drawing.Size(138, 22);
            this.MenuShutdown.Text = "Shutdown";
            this.MenuShutdown.Click += new System.EventHandler(this.MenuShutdown_Click);
            // 
            // dgvAppointementList
            // 
            this.dgvAppointementList.AllowUserToAddRows = false;
            this.dgvAppointementList.AllowUserToDeleteRows = false;
            this.dgvAppointementList.AllowUserToOrderColumns = true;
            this.dgvAppointementList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointementList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAppointementList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointementList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAppointementList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointementList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointementList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointementList.ContextMenuStrip = this.ctxAppointmentOption;
            this.dgvAppointementList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointementList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointementList.Location = new System.Drawing.Point(14, 177);
            this.dgvAppointementList.Name = "dgvAppointementList";
            this.dgvAppointementList.ReadOnly = true;
            this.dgvAppointementList.Size = new System.Drawing.Size(794, 473);
            this.dgvAppointementList.TabIndex = 3;
            // 
            // ctxAppointmentOption
            // 
            this.ctxAppointmentOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxReschedule,
            this.CntxWhosDoctor,
            this.CntxGetPhone,
            this.CntxStatus,
            this.CntxOpenMedicationRecord,
            this.CntxPatientPayments,
            this.toolStripMenuItem4,
            this.CntxDelete});
            this.ctxAppointmentOption.Name = "ctxAppointmentOption";
            this.ctxAppointmentOption.Size = new System.Drawing.Size(225, 164);
            // 
            // CntxReschedule
            // 
            this.CntxReschedule.Name = "CntxReschedule";
            this.CntxReschedule.Size = new System.Drawing.Size(224, 22);
            this.CntxReschedule.Text = "Reschedule";
            this.CntxReschedule.Click += new System.EventHandler(this.CntxReschedule_Click);
            // 
            // CntxWhosDoctor
            // 
            this.CntxWhosDoctor.Name = "CntxWhosDoctor";
            this.CntxWhosDoctor.Size = new System.Drawing.Size(224, 22);
            this.CntxWhosDoctor.Text = "Who is the doctor";
            this.CntxWhosDoctor.Click += new System.EventHandler(this.CntxWhosDoctor_Click);
            // 
            // CntxGetPhone
            // 
            this.CntxGetPhone.Name = "CntxGetPhone";
            this.CntxGetPhone.Size = new System.Drawing.Size(224, 22);
            this.CntxGetPhone.Text = "Get Phone";
            this.CntxGetPhone.Click += new System.EventHandler(this.CntxGetPhone_Click);
            // 
            // CntxStatus
            // 
            this.CntxStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxPending,
            this.CntxConfirmed,
            this.CntxCompleted,
            this.CntxCanceled,
            this.CntxNoShow});
            this.CntxStatus.Name = "CntxStatus";
            this.CntxStatus.Size = new System.Drawing.Size(224, 22);
            this.CntxStatus.Text = "Change Appointment Status";
            // 
            // CntxPending
            // 
            this.CntxPending.Name = "CntxPending";
            this.CntxPending.Size = new System.Drawing.Size(133, 22);
            this.CntxPending.Text = "Pending";
            this.CntxPending.Click += new System.EventHandler(this.CntxPending_Click);
            // 
            // CntxConfirmed
            // 
            this.CntxConfirmed.Name = "CntxConfirmed";
            this.CntxConfirmed.Size = new System.Drawing.Size(133, 22);
            this.CntxConfirmed.Text = "Confirmed";
            this.CntxConfirmed.Click += new System.EventHandler(this.CntxConfirmed_Click);
            // 
            // CntxCompleted
            // 
            this.CntxCompleted.Name = "CntxCompleted";
            this.CntxCompleted.Size = new System.Drawing.Size(133, 22);
            this.CntxCompleted.Text = "Completed";
            this.CntxCompleted.Click += new System.EventHandler(this.CntxCompleted_Click);
            // 
            // CntxCanceled
            // 
            this.CntxCanceled.Name = "CntxCanceled";
            this.CntxCanceled.Size = new System.Drawing.Size(133, 22);
            this.CntxCanceled.Text = "Canceled";
            this.CntxCanceled.Click += new System.EventHandler(this.CntxCanceled_Click);
            // 
            // CntxNoShow
            // 
            this.CntxNoShow.Name = "CntxNoShow";
            this.CntxNoShow.Size = new System.Drawing.Size(133, 22);
            this.CntxNoShow.Text = "No Show";
            this.CntxNoShow.Click += new System.EventHandler(this.CntxNoShow_Click);
            // 
            // CntxOpenMedicationRecord
            // 
            this.CntxOpenMedicationRecord.Name = "CntxOpenMedicationRecord";
            this.CntxOpenMedicationRecord.Size = new System.Drawing.Size(224, 22);
            this.CntxOpenMedicationRecord.Text = "Open Medication Record";
            this.CntxOpenMedicationRecord.Click += new System.EventHandler(this.CntxOpenMedicationRecord_Click);
            // 
            // CntxPatientPayments
            // 
            this.CntxPatientPayments.Name = "CntxPatientPayments";
            this.CntxPatientPayments.Size = new System.Drawing.Size(224, 22);
            this.CntxPatientPayments.Text = "Get Patient Payments ";
            this.CntxPatientPayments.Click += new System.EventHandler(this.CntxPatientPayments_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(221, 6);
            // 
            // CntxDelete
            // 
            this.CntxDelete.Name = "CntxDelete";
            this.CntxDelete.Size = new System.Drawing.Size(224, 22);
            this.CntxDelete.Text = "Delete";
            this.CntxDelete.Click += new System.EventHandler(this.CntxDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doctor";
            // 
            // CbPatient
            // 
            this.CbPatient.FormattingEnabled = true;
            this.CbPatient.Location = new System.Drawing.Point(54, 67);
            this.CbPatient.Name = "CbPatient";
            this.CbPatient.Size = new System.Drawing.Size(164, 21);
            this.CbPatient.TabIndex = 5;
            // 
            // CbDoctor
            // 
            this.CbDoctor.FormattingEnabled = true;
            this.CbDoctor.Location = new System.Drawing.Point(54, 38);
            this.CbDoctor.Name = "CbDoctor";
            this.CbDoctor.Size = new System.Drawing.Size(219, 21);
            this.CbDoctor.TabIndex = 4;
            // 
            // dpAppointment
            // 
            this.dpAppointment.Location = new System.Drawing.Point(652, 36);
            this.dpAppointment.Name = "dpAppointment";
            this.dpAppointment.Size = new System.Drawing.Size(154, 20);
            this.dpAppointment.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Note";
            // 
            // tbPaymentNote
            // 
            this.tbPaymentNote.Location = new System.Drawing.Point(432, 68);
            this.tbPaymentNote.Name = "tbPaymentNote";
            this.tbPaymentNote.Size = new System.Drawing.Size(197, 20);
            this.tbPaymentNote.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Amount";
            // 
            // tbPaymentAmount
            // 
            this.tbPaymentAmount.Location = new System.Drawing.Point(279, 68);
            this.tbPaymentAmount.Name = "tbPaymentAmount";
            this.tbPaymentAmount.ShortcutsEnabled = false;
            this.tbPaymentAmount.Size = new System.Drawing.Size(108, 20);
            this.tbPaymentAmount.TabIndex = 18;
            // 
            // BtnNewReservation
            // 
            this.BtnNewReservation.Location = new System.Drawing.Point(652, 66);
            this.BtnNewReservation.Name = "BtnNewReservation";
            this.BtnNewReservation.Size = new System.Drawing.Size(154, 24);
            this.BtnNewReservation.TabIndex = 22;
            this.BtnNewReservation.Tag = "1";
            this.BtnNewReservation.Text = "Make an appointment";
            this.BtnNewReservation.UseVisualStyleBackColor = true;
            this.BtnNewReservation.Click += new System.EventHandler(this.BtnNewReservation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Method";
            // 
            // cbMethod
            // 
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Location = new System.Drawing.Point(330, 38);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(164, 21);
            this.cbMethod.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dpTo);
            this.groupBox1.Controls.Add(this.dpFrom);
            this.groupBox1.Controls.Add(this.CbRescheduled);
            this.groupBox1.Controls.Add(this.CbNoShow);
            this.groupBox1.Controls.Add(this.CbPending);
            this.groupBox1.Controls.Add(this.CbConfirmed);
            this.groupBox1.Controls.Add(this.CbCompleted);
            this.groupBox1.Controls.Add(this.CbCanceled);
            this.groupBox1.Controls.Add(this.CbToday);
            this.groupBox1.Controls.Add(this.CbAll);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 77);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(717, 35);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(62, 24);
            this.BtnSearch.TabIndex = 36;
            this.BtnSearch.Tag = "1";
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "From";
            // 
            // dpTo
            // 
            this.dpTo.Location = new System.Drawing.Point(557, 37);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(154, 20);
            this.dpTo.TabIndex = 36;
            // 
            // dpFrom
            // 
            this.dpFrom.Location = new System.Drawing.Point(397, 37);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(154, 20);
            this.dpFrom.TabIndex = 36;
            // 
            // CbRescheduled
            // 
            this.CbRescheduled.AutoSize = true;
            this.CbRescheduled.Location = new System.Drawing.Point(250, 19);
            this.CbRescheduled.Name = "CbRescheduled";
            this.CbRescheduled.Size = new System.Drawing.Size(89, 17);
            this.CbRescheduled.TabIndex = 42;
            this.CbRescheduled.Tag = "64";
            this.CbRescheduled.Text = "Rescheduled";
            this.CbRescheduled.UseVisualStyleBackColor = true;
            this.CbRescheduled.CheckedChanged += new System.EventHandler(this.CbRescheduled_CheckedChanged);
            // 
            // CbNoShow
            // 
            this.CbNoShow.AutoSize = true;
            this.CbNoShow.Location = new System.Drawing.Point(250, 42);
            this.CbNoShow.Name = "CbNoShow";
            this.CbNoShow.Size = new System.Drawing.Size(70, 17);
            this.CbNoShow.TabIndex = 41;
            this.CbNoShow.Tag = "128";
            this.CbNoShow.Text = "No Show";
            this.CbNoShow.UseVisualStyleBackColor = true;
            this.CbNoShow.CheckedChanged += new System.EventHandler(this.CbNoShow_CheckedChanged);
            // 
            // CbPending
            // 
            this.CbPending.AutoSize = true;
            this.CbPending.Location = new System.Drawing.Point(73, 19);
            this.CbPending.Name = "CbPending";
            this.CbPending.Size = new System.Drawing.Size(65, 17);
            this.CbPending.TabIndex = 40;
            this.CbPending.Tag = "4";
            this.CbPending.Text = "Pending";
            this.CbPending.UseVisualStyleBackColor = true;
            this.CbPending.CheckedChanged += new System.EventHandler(this.CbPending_CheckedChanged);
            // 
            // CbConfirmed
            // 
            this.CbConfirmed.AutoSize = true;
            this.CbConfirmed.Location = new System.Drawing.Point(88, 42);
            this.CbConfirmed.Name = "CbConfirmed";
            this.CbConfirmed.Size = new System.Drawing.Size(73, 17);
            this.CbConfirmed.TabIndex = 39;
            this.CbConfirmed.Tag = "8";
            this.CbConfirmed.Text = "Confirmed";
            this.CbConfirmed.UseVisualStyleBackColor = true;
            this.CbConfirmed.CheckedChanged += new System.EventHandler(this.CbConfirmed_CheckedChanged);
            // 
            // CbCompleted
            // 
            this.CbCompleted.AutoSize = true;
            this.CbCompleted.Location = new System.Drawing.Point(156, 19);
            this.CbCompleted.Name = "CbCompleted";
            this.CbCompleted.Size = new System.Drawing.Size(76, 17);
            this.CbCompleted.TabIndex = 38;
            this.CbCompleted.Tag = "16";
            this.CbCompleted.Text = "Completed";
            this.CbCompleted.UseVisualStyleBackColor = true;
            this.CbCompleted.CheckedChanged += new System.EventHandler(this.CbCompleted_CheckedChanged);
            // 
            // CbCanceled
            // 
            this.CbCanceled.AutoSize = true;
            this.CbCanceled.Location = new System.Drawing.Point(170, 42);
            this.CbCanceled.Name = "CbCanceled";
            this.CbCanceled.Size = new System.Drawing.Size(71, 17);
            this.CbCanceled.TabIndex = 37;
            this.CbCanceled.Tag = "32";
            this.CbCanceled.Text = "Canceled";
            this.CbCanceled.UseVisualStyleBackColor = true;
            this.CbCanceled.CheckedChanged += new System.EventHandler(this.CbCanceled_CheckedChanged);
            // 
            // CbToday
            // 
            this.CbToday.AutoSize = true;
            this.CbToday.Location = new System.Drawing.Point(18, 42);
            this.CbToday.Name = "CbToday";
            this.CbToday.Size = new System.Drawing.Size(61, 17);
            this.CbToday.TabIndex = 36;
            this.CbToday.Tag = "2";
            this.CbToday.Text = "To Day";
            this.CbToday.UseVisualStyleBackColor = true;
            this.CbToday.CheckedChanged += new System.EventHandler(this.CbToday_CheckedChanged);
            // 
            // CbAll
            // 
            this.CbAll.AutoSize = true;
            this.CbAll.Location = new System.Drawing.Point(18, 19);
            this.CbAll.Name = "CbAll";
            this.CbAll.Size = new System.Drawing.Size(37, 17);
            this.CbAll.TabIndex = 35;
            this.CbAll.Tag = "1";
            this.CbAll.Text = "All";
            this.CbAll.UseVisualStyleBackColor = true;
            this.CbAll.CheckedChanged += new System.EventHandler(this.CbAll_CheckedChanged);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(820, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.BtnNewReservation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPaymentNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPaymentAmount);
            this.Controls.Add(this.dpAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbPatient);
            this.Controls.Add(this.CbDoctor);
            this.Controls.Add(this.dgvAppointementList);
            this.Controls.Add(this.HomeMenu);
            this.MainMenuStrip = this.HomeMenu;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.HomeMenu.ResumeLayout(false);
            this.HomeMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointementList)).EndInit();
            this.ctxAppointmentOption.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip HomeMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuAppointment;
        private System.Windows.Forms.ToolStripMenuItem MenuPayments;
        private System.Windows.Forms.ToolStripMenuItem MenuPatient;
        private System.Windows.Forms.ToolStripMenuItem MenuFindAppointment;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuMe;
        private System.Windows.Forms.ToolStripMenuItem MenuAddPatient;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuPatientAppointment;
        private System.Windows.Forms.ToolStripMenuItem MenuMalePayment;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAllPayments;
        private System.Windows.Forms.ToolStripMenuItem MenuGetPateintPayment;
        private System.Windows.Forms.ToolStripMenuItem MenuPatientList;
        private System.Windows.Forms.ToolStripMenuItem MenuAccountStatement;
        private System.Windows.Forms.DataGridView dgvAppointementList;
        private System.Windows.Forms.ContextMenuStrip ctxAppointmentOption;
        private System.Windows.Forms.ToolStripMenuItem CntxReschedule;
        private System.Windows.Forms.ToolStripMenuItem CntxWhosDoctor;
        private System.Windows.Forms.ToolStripMenuItem CntxPatientPayments;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem CntxDelete;
        private System.Windows.Forms.ToolStripMenuItem CntxStatus;
        private System.Windows.Forms.ToolStripMenuItem CntxPending;
        private System.Windows.Forms.ToolStripMenuItem CntxConfirmed;
        private System.Windows.Forms.ToolStripMenuItem CntxCompleted;
        private System.Windows.Forms.ToolStripMenuItem CntxCanceled;
        private System.Windows.Forms.ToolStripMenuItem CntxNoShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbPatient;
        private System.Windows.Forms.ComboBox CbDoctor;
        private System.Windows.Forms.DateTimePicker dpAppointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPaymentNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPaymentAmount;
        private System.Windows.Forms.Button BtnNewReservation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.ToolStripMenuItem CntxGetPhone;
        private System.Windows.Forms.ToolStripMenuItem CntxOpenMedicationRecord;
        private System.Windows.Forms.ToolStripMenuItem MenuMethodList;
        private System.Windows.Forms.ToolStripMenuItem MenuDashboard;
        private System.Windows.Forms.ToolStripMenuItem MenuManageUsers;
        private System.Windows.Forms.ToolStripMenuItem MenuAddUser;
        private System.Windows.Forms.ToolStripMenuItem MenuUserList;
        private System.Windows.Forms.ToolStripMenuItem MenuManageEmployies;
        private System.Windows.Forms.ToolStripMenuItem MenuNewEmp;
        private System.Windows.Forms.ToolStripMenuItem MenuEmpList;
        private System.Windows.Forms.ToolStripMenuItem MenuDep;
        private System.Windows.Forms.ToolStripMenuItem developedByKhalidAliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactDeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuLogoutMain;
        private System.Windows.Forms.ToolStripMenuItem MenuLogout;
        private System.Windows.Forms.ToolStripMenuItem MenuShutdown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CbRescheduled;
        private System.Windows.Forms.CheckBox CbNoShow;
        private System.Windows.Forms.CheckBox CbPending;
        private System.Windows.Forms.CheckBox CbConfirmed;
        private System.Windows.Forms.CheckBox CbCompleted;
        private System.Windows.Forms.CheckBox CbCanceled;
        private System.Windows.Forms.CheckBox CbToday;
        private System.Windows.Forms.CheckBox CbAll;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dpTo;
        private System.Windows.Forms.DateTimePicker dpFrom;
        private System.Windows.Forms.ToolStripMenuItem MenuProfile;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}

