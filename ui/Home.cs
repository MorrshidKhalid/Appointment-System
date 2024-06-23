using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ClinicPresentationLayerDesktop.lib;
using ClinicPresentationLayerDesktop.ui;
using ClinicPresentationLayerDesktop.ui.appointment;
using ClinicPresentationLayerDesktop.ui.dashboard.department;
using ClinicPresentationLayerDesktop.ui.dashboard.employee;
using ClinicPresentationLayerDesktop.ui.dashboard.users;
using ClinicPresentationLayerDesktop.ui.employee;
using ClinicPresentationLayerDesktop.ui.login;
using ClinicPresentationLayerDesktop.ui.pateint;
using ClinicPresentationLayerDesktop.ui.payment;
using ClinicPresentationLayerDesktop.ui.record;
using ClinicPresentationLayerDesktop.ui.users;

namespace ClinicPresentationLayerDesktop
{
    public partial class HomeForm : Form
    {
        
        List<string> statuses = new List<string>(); // Used in (In Operator) To Retrieve Data from DB
        private ClsAppointment appointment;
        private FormLogin login; // Reference to parent Form.


        // Form Default Constractor.
        public HomeForm()
        {
            InitializeComponent();
            EnableAllowedUserPermissions();

            CbToday.Checked = true;
            CbPending.Checked = true;
            tbPaymentNote.Text = "For An Appointment";
        }


        private string SelectedItem(ComboBox cb) => (string)cb.SelectedItem;
        private bool CheckValidation()
        {
            // TextBox Validation.
            bool isValid = !Validation.IsTextBoxEmpty(tbPaymentAmount, e: ErrorProvider) &&

            // ComboBox Validation.
                           !Validation.HasNotSelected(CbDoctor, e: ErrorProvider)
                        && !Validation.HasNotSelected(CbPatient, e: ErrorProvider)
                        && !Validation.HasNotSelected(cbMethod, e: ErrorProvider)
           // Date Validation
                        && !Validation.IsDateSmaller(dpAppointment, e: ErrorProvider);

            return !isValid;
        }



        /******************** Enable ********************/
        public void DisableAllMenuItems()
        {
            MenuAppointment.Enabled = false;
            MenuPatient.Enabled = false;
            MenuPayments.Enabled = false;
            MenuDashboard.Enabled = false;
        }
        private void EnableCheckBoxes(bool enable)
        {
            CbToday.Enabled = enable;
            CbPending.Enabled = enable;
            CbConfirmed.Enabled = enable;
            CbCompleted.Enabled = enable;
            CbCanceled.Enabled = enable;
            CbRescheduled.Enabled = enable;
            CbNoShow.Enabled = enable;
        }
        private void EnableAllowedUserPermissions()
        {
            if (CurrentUser.user.Permission == (int)EnPermissions.All)
                return;

            if (CurrentUser.user.Permission == (int)EnPermissions.Nothing)
            {
                DisableAllMenuItems();
                return;
            }


            if (!CurrentUser.user.IsUserHasPermission((int)EnPermissions.Appointement))
                MenuAppointment.Visible = false;

            if (!CurrentUser.user.IsUserHasPermission((int)EnPermissions.AddPatient))
                MenuAddPatient.Enabled = false;

            if (!CurrentUser.user.IsUserHasPermission((int)EnPermissions.PatientList))
                MenuPatientList.Enabled = false;

            if (!CurrentUser.user.IsUserHasPermission((int)EnPermissions.PatientAS))
                MenuAccountStatement.Enabled = false;

            if (!CurrentUser.user.IsUserHasPermission((int)EnPermissions.AddEmployee))
                MenuNewEmp.Enabled = false;

            if (!CurrentUser.user.IsUserHasPermission((int)EnPermissions.EmployeeList))
                MenuEmpList.Enabled = false;

            if (!CurrentUser.user.IsUserHasPermission((int)EnPermissions.Department))
                MenuDep.Enabled = false;

            if (!CurrentUser.user.IsUserHasPermission((int)EnPermissions.ManageUsers))
                MenuManageUsers.Visible = false;

            if (!CurrentUser.user.IsUserHasPermission((int)EnPermissions.Payments))
                MenuPayments.Visible = false;
        }



        /******************** Refresh ********************/
        private void RefreshDoctorComboBox()
        {
            CbDoctor.Items.Clear();
            DataTable dt = ClsEmployee.GelAllDoctors();
            foreach (DataRow row in dt.Rows)
                CbDoctor.Items.Add(row["Name"]);
        }
        private void RefreshPateintComboBox()
        {
            CbPatient.Items.Clear();
            DataTable dt = ClsPatient.GetAllPateints();
            foreach (DataRow row in dt.Rows)
                CbPatient.Items.Add(row["Name"]);
        }
        private void RefreshMethodComboBox()
        {
            cbMethod.Items.Clear();
            DataTable dt = ClsPaymentMethod.GetAllPaymentMethods();
            foreach (DataRow row in dt.Rows)
                cbMethod.Items.Add(row["Method"]);
        }
        private void RefreshAppointementList(EnStatus enStatus, bool markToRemove = false, string status = "")
        {
            if (enStatus == EnStatus.All)
            {
                dgvAppointementList.DataSource = ClsAppointment.GetAllAppointment();
                return;
            }

            if (markToRemove)
                statuses.Remove(status);
            else statuses.Add(status);

            dgvAppointementList.DataSource = ClsAppointment.GetAppointmentByStutasAndDate(statuses, DateTime.Now.Date);
        }
        private void Clear()
        {
            tbPaymentAmount.Clear();
            CbPatient.SelectedIndex = -1;
            CbDoctor.SelectedIndex = -1;
            cbMethod.SelectedIndex = -1;
            dpAppointment.Value = DateTime.Now.Date;
        }



        /******************** Dialog Global ********************/
        private int OpenDialogGetPassedID()
        {
            FormDialogWithText dialogWithText = new FormDialogWithText();
            dialogWithText.ShowDialog();

            return dialogWithText.PassedID;
        }



        /******************** Open Form ********************/
        private void MenuAddPatient_Click(object sender, EventArgs e)
        {
            new FormAddUpdatePateint((int)Mode.Nothing).ShowDialog();
            RefreshPateintComboBox();
        }
        private void MenuPatientList_Click(object sender, EventArgs e) => new FormPateintList().Show();
        private void CntxPatientPayments_Click(object sender, EventArgs e)
        {
            appointment = ClsAppointment.Find(CurrentRowID());
            new FormPatientAccountStatement(appointment.PateintID).Show();
        }
        private void MenuAccountStatement_Click(object sender, EventArgs e) => new FormPatientAccountStatement(OpenDialogGetPassedID()).Show();
        private void MenuPatientAppointment_Click(object sender, EventArgs e) => new FormPaitentAppointmentList(OpenDialogGetPassedID()).Show();
        private void MenuFind_Click(object sender, EventArgs e) => new FormAppointementInfo(OpenDialogGetPassedID()).Show();
        private void MenuAllPayments_Click(object sender, EventArgs e) => new FormPaymentList().Show();
        private void MenuGetPateintPayment_Click(object sender, EventArgs e) => new FormPatientAccountStatement(OpenDialogGetPassedID()).Show();
        private void MenuMakePayment_Click(object sender, EventArgs e) => new FormPayment().Show();
        private void MenuMethodList_Click(object sender, EventArgs e)
        {
            new FormPaymentMethodList().ShowDialog();
            RefreshMethodComboBox();
        }
        private void CntxOpenMedicationRecord_Click(object sender, EventArgs e)
        {
            int recordID = ClsAppointment.Find(CurrentRowID()).RecordID;
            string name = (string)dgvAppointementList.CurrentRow.Cells[1].Value;
            char gender = Convert.ToChar(dgvAppointementList.CurrentRow.Cells[2].Value);
            int age = (int)dgvAppointementList.CurrentRow.Cells[3].Value;

            new FormMR(recordID, name, age, gender).Show();
        }
        private void MenuUserList_Click(object sender, EventArgs e) => new FormUserList().Show();
        private void MenuProfile_Click(object sender, EventArgs e) => new FormAddUpdateUser(CurrentUser.user.UserID).ShowDialog();
        private void MenuDep_Click(object sender, EventArgs e) => new FormDepartment().Show();
        private void MenuEmpList_Click(object sender, EventArgs e) => new FormEmployeeList().Show();
        private void MenuAddUser_Click(object sender, EventArgs e) => new FormAddUpdateUser((int)Mode.Nothing).ShowDialog();
        private void MenuNewEmp_Click(object sender, EventArgs e) 
        {
            new FormEmployee((int)Mode.Nothing).ShowDialog();
            RefreshDoctorComboBox();
        }
        private void BtnSearch_Click(object sender, EventArgs e) => new FormAppointmentBetweenDate(dpFrom.Value.Date, dpTo.Value.Date).Show();



        /******************** Get IDs ********************/
        private int GetSelectedMethodID()
        {
            if (cbMethod.SelectedItem == null)
                return -1;

            return ClsPaymentMethod.Find(SelectedItem(cbMethod)).PM_ID;
        } // PK Of Selected (Method).
        private int GetSelectedPatientID()
        {
            if (CbPatient.SelectedItem == null)
                return -1;

            return ClsPatient.Find(SelectedItem(CbPatient)).PatientID;
        } // PK Of Selected (PATIENT).
        private int GetSelectedDoctorID()
        {
            if (CbDoctor.SelectedItem == null)
                return -1;

            return ClsEmployee.Find(SelectedItem(CbDoctor)).EmployeeID;
        } // PK Of Selected (DOCTOR).
        private int CurrentRowID() => (int)dgvAppointementList.CurrentRow.Cells[0].Value; // PK Of (Appointment).



        /******************** Create Events ********************/
        private int MakePayment()
        {
            ClsPayment payment = new ClsPayment()
            {
                PateintID = GetSelectedPatientID(),
                MethodID = GetSelectedMethodID(),
                PaymentAmount = decimal.Parse(tbPaymentAmount.Text),
                PaymentDate = dpAppointment.Value, // = DateTime.Now
                Note = tbPaymentNote.Text,
            };


            if (payment.Save())
                return payment.insertedID;

            else return -1;
        }
        private int PrepareRecord()
        {
            ClsMedicalRecord record = new ClsMedicalRecord();
            if (record.Save())
                return record.insertedID;

            else return -1;
        }
        private void NewAppointment()
        {
            ClsAppointment appointment = new ClsAppointment
            {
                DoctorID = GetSelectedDoctorID(),
                PateintID = GetSelectedPatientID(),
                PaymentID = MakePayment(),
                RecordID = PrepareRecord(),
                DateAndTime = dpAppointment.Value
            };

            if (appointment.Save())
            {
                MessageBox.Show("Added successfully");
                RefreshAppointementList(EnStatus.ByInOperator);
            }
            else
                MessageBox.Show("Error adding an appointment :(");
        }
        private void BtnNewReservation_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
                return;

            NewAppointment();
            Clear(); // Reset Controls Value.
        }



        /******************** Inquiries and Filters ********************/
        private void CntxGetPhone_Click(object sender, EventArgs e)
        {
            appointment = ClsAppointment.Find(CurrentRowID());
            ClsPatient patient = ClsPatient.Find(appointment.PateintID);
            DataTable dt = ClsPhone.GetPhones(patient.ID);
            string phones = string.Empty;
            foreach (DataRow dr in dt.Rows)
                phones += dr["Number"].ToString() + "\n";

            MessageBox.Show(phones);
        }
        private void CntxWhosDoctor_Click(object sender, EventArgs e)
        {
            appointment = ClsAppointment.Find(CurrentRowID());
            ClsEmployee doctor = ClsEmployee.Find(appointment.DoctorID);

            MessageBox.Show($"Patient's Doctor: {doctor.FullName()}");
        }
        private void CbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (CbAll.Checked)
            {
                EnableCheckBoxes(false);
                RefreshAppointementList(EnStatus.All);
            }
            else
            {
                EnableCheckBoxes(true);
                RefreshAppointementList(EnStatus.ByInOperator);
            }
        }
        private void CbToday_CheckedChanged(object sender, EventArgs e)
        {
            if (CbToday.Checked)
                RefreshAppointementList(EnStatus.ByInOperator);
            else CbToday.Checked = true;
        }
        private void CbPending_CheckedChanged(object sender, EventArgs e)
        {
            if (CbPending.Checked)
                RefreshAppointementList(EnStatus.ByInOperator, status: EnStatus.Pending.ToString());
            else
                RefreshAppointementList(EnStatus.ByInOperator, true, EnStatus.Pending.ToString());
        }
        private void CbConfirmed_CheckedChanged(object sender, EventArgs e)
        {
            if (CbConfirmed.Checked)
                RefreshAppointementList(EnStatus.ByInOperator, status: EnStatus.Confirmed.ToString());
            else
                RefreshAppointementList(EnStatus.ByInOperator, true, EnStatus.Confirmed.ToString());
        }
        private void CbCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (CbCompleted.Checked)
                RefreshAppointementList(EnStatus.ByInOperator, status: EnStatus.Completed.ToString());
            else
                RefreshAppointementList(EnStatus.ByInOperator, true, EnStatus.Completed.ToString());
        }
        private void CbCanceled_CheckedChanged(object sender, EventArgs e)
        {
            if (CbCanceled.Checked)
                RefreshAppointementList(EnStatus.ByInOperator, status: EnStatus.Canceled.ToString());
            else
                RefreshAppointementList(EnStatus.ByInOperator, true, EnStatus.Canceled.ToString());
        }
        private void CbRescheduled_CheckedChanged(object sender, EventArgs e)
        {
            if (CbRescheduled.Checked)
                RefreshAppointementList(EnStatus.ByInOperator, status: EnStatus.Rescheduled.ToString());
            else
                RefreshAppointementList(EnStatus.ByInOperator, true, EnStatus.Rescheduled.ToString());
        }
        private void CbNoShow_CheckedChanged(object sender, EventArgs e)
        {
            if (CbNoShow.Checked)
                RefreshAppointementList(EnStatus.ByInOperator, status: EnStatus.NoShow.ToString());
            else
                RefreshAppointementList(EnStatus.ByInOperator, true, EnStatus.NoShow.ToString());
        }




        /******************** Change an Appointment Status ********************/
        private void ChangeAppointmentStatus(EnStatus status)
        {

            appointment = ClsAppointment.Find(CurrentRowID());
            appointment.AppointmentStatus = status.ToString();
            if (appointment.Save())
                MessageBox.Show($"Changed Successfully To: {status}");

            RefreshAppointementList(EnStatus.ByInOperator);
        }
        private void CntxReschedule_Click(object sender, EventArgs e)
        {
            new FormReschedule(CurrentRowID()).ShowDialog();
            RefreshAppointementList(EnStatus.Rescheduled);
        }
        private void CntxPending_Click(object sender, EventArgs e) => ChangeAppointmentStatus(EnStatus.Pending);
        private void CntxConfirmed_Click(object sender, EventArgs e) => ChangeAppointmentStatus(EnStatus.Confirmed);
        private void CntxCompleted_Click(object sender, EventArgs e) => ChangeAppointmentStatus(EnStatus.Completed);
        private void CntxCanceled_Click(object sender, EventArgs e) => ChangeAppointmentStatus(EnStatus.Canceled);
        private void CntxNoShow_Click(object sender, EventArgs e) => ChangeAppointmentStatus(EnStatus.NoShow);



        /******************** Home ********************/
        private void HomeForm_Load(object sender, EventArgs e)
        {
            RefreshDoctorComboBox();
            RefreshPateintComboBox();
            RefreshMethodComboBox();
        }


        /******************** Delete ********************/
        private void CntxDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox
                .Show("Are you sure you want to continue?",
                      "Confirmation",
                      MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (ClsAppointment.Delete(CurrentRowID()))
                {
                    MessageBox.Show("Successfully Deleted!");
                    RefreshAppointementList(EnStatus.ByInOperator);
                }
                else MessageBox.Show("Error");
            }
        }


        /******************** System ********************/
        private void MenuLogout_Click(object sender, EventArgs e)
        {
            Close();
            login = new FormLogin();
            login.Show();
            CurrentUser.user = null;
        }
        private void MenuShutdown_Click(object sender, EventArgs e)
        {
            Close();
            login = new FormLogin();
            login.Close();
            CurrentUser.user = null;
            Application.Exit();
        }
        private void MenuMe_Click(object sender, EventArgs e)
        {
             
        }
    }
}