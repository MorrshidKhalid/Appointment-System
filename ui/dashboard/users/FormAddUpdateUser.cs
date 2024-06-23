using System;
using System.Data;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ClinicPresentationLayerDesktop.lib;

namespace ClinicPresentationLayerDesktop.ui.users
{
    public partial class FormAddUpdateUser : Form
    {
        private readonly ClsUser user;
        private Mode mode = Mode.Nothing;


        // Default Constructor.
        public FormAddUpdateUser(int userID)
        {
            InitializeComponent();
            rbActive.Checked = true; // Set Default User Activation.
            CbNothing.Checked = true; // Set Default User Permission to Nothing.


            if (userID == -1)
            {
                mode = Mode.Add;
                user = new ClsUser();
            }
            else
            {
                cbEmployees.Enabled = false;
                lbTitle.Text = "Update User";
                BtnSave.Text = "Update";
                mode = Mode.Update;
                user = ClsUser.Find(userID);

                // In Case Current User Edit His Profile.
                if (user.UserName == CurrentUser.user.UserName)
                {
                    gbActive.Enabled = false;
                    EnableCheckBoxes(false);
                }
            }
        }

        private bool CheckValidation()
        {
            // TextBox Validation.
            bool isValid = !Validation.IsTextBoxEmpty(tbUserName, e: ErrorProvider) &&
                           !Validation.IsTextBoxEmpty(tbUserName, e: ErrorProvider);

            // ComboBox Validation.
            if (mode == Mode.Add)
                isValid = isValid && !Validation.HasNotSelected(cbEmployees, e: ErrorProvider);

            return !isValid;
        }

        private bool EnableCheckBoxes(bool enable)
        {
            CbAll.Enabled = enable;
            gbPermissions.Enabled = enable;
            CbNothing.Enabled = enable;

            return enable;
        }

        private void RefreshEmployiesComboBox()
        {
            cbEmployees.Items.Clear();
            DataTable dt = ClsEmployee.GetAllEmployees();
            foreach (DataRow row in dt.Rows)
                cbEmployees.Items.Add(row["Name"]);
        }

        private int GetSelectedEmployeeID()
        {
            if (cbEmployees.SelectedItem == null)
                return -1;

            string selectedItem = cbEmployees.SelectedItem.ToString();
            ClsEmployee employee = ClsEmployee.Find(selectedItem); // Search by Name.
            return (employee == null) ? -1 : employee.EmployeeID;
        }

        private int GetUserPermissions()
        {
            int allowedPermissions = 0;

            if (CbAll.Checked)
                return (int)EnPermissions.All;

            if (CbNothing.Checked)
                return (int)EnPermissions.Nothing;

            if (cbAppointment.Checked)
                allowedPermissions += (int)EnPermissions.Appointement;
            
            if (cbNewPatient.Checked)
                allowedPermissions += (int)EnPermissions.AddPatient;
                
            if (cbFindPatient.Checked)
                allowedPermissions += (int)EnPermissions.FindPatient;
                
            if (cbDeletePatient.Checked)
                allowedPermissions += (int)EnPermissions.DeletePatient;
                
            if (cbEditPatient.Checked)
                allowedPermissions += (int)EnPermissions.UpdatePatient;
                
            if (cbPatientList.Checked)
                allowedPermissions += (int)EnPermissions.PatientList;
                
            if (cbPatientAS.Checked)
                allowedPermissions += (int)EnPermissions.PatientAS;
                
            if (cbMR.Checked)
                allowedPermissions += (int)EnPermissions.PatientMR;
                
            if (cbNewEmployee.Checked)
                allowedPermissions += (int)EnPermissions.AddEmployee;
                
            if (cbFindEmployee.Checked)
                allowedPermissions += (int)EnPermissions.FindEmployee;
                
            if (cbDeleteEmployee.Checked)
                allowedPermissions += (int)EnPermissions.DeleteEmployee;
                
            if (cbEditEmployee.Checked)
                allowedPermissions += (int)EnPermissions.UpdateEmployee;
                
            if (cbEmpList.Checked)
                allowedPermissions += (int)EnPermissions.EmployeeList;
                
            if (cbDep.Checked)
                allowedPermissions += (int)EnPermissions.Department;
                
            if (cbManageUsers.Checked)
                allowedPermissions += (int)EnPermissions.ManageUsers;
                
            if (cbDep.Checked)
                allowedPermissions += (int)EnPermissions.Department;
                
            if (cbPayment.Checked)
                allowedPermissions += (int)EnPermissions.Payments;


            return allowedPermissions;
        }

        private void LoadUserData()
        {
            tbUserName.Text = user.UserName.ToString();
            tbPassword.Text = user.Password.ToString();
            rbActive.Checked = user.IsActive;

            if (user.IsUserHasPermission((int)EnPermissions.All))
            {
                CbAll.Checked = true;
                return;
            }

            if (user.Permission == (int)EnPermissions.Nothing)
            {
                CbNothing.Checked = true;
                return;
            }

            if (user.IsUserHasPermission((int)EnPermissions.Appointement))
                cbAppointment.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.AddPatient))
                cbNewPatient.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.FindPatient))
                cbFindPatient.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.DeletePatient))
                cbDeletePatient.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.UpdatePatient))
                cbEditPatient.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.PatientList))
                cbPatientList.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.PatientAS))
                cbPatientAS.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.PatientMR))
                cbMR.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.AddEmployee))
                cbNewEmployee.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.FindEmployee))
                cbFindEmployee.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.DeleteEmployee))
                cbDeleteEmployee.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.UpdateEmployee))
                cbEditEmployee.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.EmployeeList))
                cbEmpList.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.Department))
                cbDep.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.ManageUsers))
                cbManageUsers.Checked = true;

            if (user.IsUserHasPermission((int)EnPermissions.Payments))
                cbPayment.Checked = true;
        }

        private void SaveUser()
        {
            if (mode == Mode.Add)
                user.EmployeeID = GetSelectedEmployeeID();
            


            user.UserName = tbUserName.Text.ToString().Trim();
            user.Password = tbPassword.Text.ToString().Trim();
            user.IsActive = (rbActive.Checked == true);
            user.Permission = GetUserPermissions();

            if (user.Save())
            {
                MessageBox.Show("Done Seccussefully");
                mode = Mode.Update;
                Close();
            }
            else
            {
                MessageBox.Show("Error Saving User Info");
                mode = Mode.Add;
            }

        }

        private void FormAddUpdateUser_Load(object sender, EventArgs e)
        {
            RefreshEmployiesComboBox();
            if (mode == Mode.Update)
                LoadUserData();
        }

        private void CbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (mode == Mode.Add && CbAll.Checked)
                EnableCheckBoxes(false);
            else EnableCheckBoxes(true);

            if (CbAll.Checked && user.UserName == CurrentUser.user.UserName)
                EnableCheckBoxes(false);
            else EnableCheckBoxes(true);

            //_= CbAll.Checked && user.UserName == CurrentUser.user.UserName ? EnableCheckBoxes(false) : EnableCheckBoxes(true);
        }

        private void BtnSave_Click(object sender, EventArgs e) 
        {
            if (CheckValidation())
                return;

            SaveUser();
        } 

        private void CbNothing_CheckedChanged(object sender, EventArgs e)
        {
            if (CbNothing.Checked)
            {
                gbPermissions.Enabled = false;
                CbAll.Enabled = false;
            }
            else
            {
                gbPermissions.Enabled = true;
                CbAll.Enabled = true;
            }
        }
    }
}
