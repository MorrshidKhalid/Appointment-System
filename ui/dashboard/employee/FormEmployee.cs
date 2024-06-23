using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ClinicPresentationLayerDesktop.lib;
using ClinicPresentationLayerDesktop.ui.dashboard.department;

namespace ClinicPresentationLayerDesktop.ui.employee
{
    public partial class FormEmployee : Form
    {
        private readonly ClsEmployee employee;
        private ClsPhone phone;
        private int textBoxCount = 0; // Keeps track of the number of textboxes.
        private readonly Mode mode = Mode.Add;


        // Default Constructor.
        public FormEmployee(int empID)
        {
            InitializeComponent();
            rbMale.Checked = true; // Default Gender selected.
            LoadDepartmentData();

            if (empID <= 0)
            {
                employee = new ClsEmployee();
                mode = Mode.Add;
            } 
            else
            {
                employee = ClsEmployee.Find(empID);
                mode = Mode.Update;
            }
        }


        private bool CheckValidation()
        {
            // TextBox Validation.
            bool isValid = !Validation.IsTextBoxEmpty(tbFirstName, e: ErrorProvider) &&
                           !Validation.IsTextBoxEmpty(tbLastName, e: ErrorProvider) &&

            // ComboBox Validation.
                           !Validation.HasNotSelected(cbDepartment, e: ErrorProvider);

            return !isValid;
        }

        private void LoadDepartmentData()
        {
            cbDepartment.Items.Clear();
            DataTable dt = ClsDepartment.GetAllDepartments();
            foreach (DataRow row in dt.Rows)
                cbDepartment.Items.Add($"{row["DepartmentName"]} {row["Specialization"]}");
        }
        private int GetSelectedDepartmentID()
        {
            if (cbDepartment.SelectedItem == null)
                return -1;

            string[] selectedItem = cbDepartment.SelectedItem.ToString().Split(' '); // Here Spit Department and Specialization.
            // Find the Department in database by Department and Specialization.
            ClsDepartment department = ClsDepartment.Find(selectedItem[0], selectedItem[1]);

            return (department == null) ? -1 : department.DepartmentID;
        }
        private void SavePhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Trim() != "")
            {
                phone = new ClsPhone
                {
                    PersonID = employee.PersonID,
                    PhoneNumber = phoneNumber
                };
                phone.Save();
            }
        }
        private void GetPhoneFromDynamicTextBox()
        {
            if (textBoxCount > 0)
            {
                // Get text by name.
                for (int i = 0; i < textBoxCount; i++)
                {
                    TextBox textBox = (TextBox)Controls.Find($"phone{i}", true)[0];
                    string text = textBox.Text;
                    if (text.Trim() != "")
                        SavePhoneNumber(text); // Save Pateint Phone(s).
                }
            }
        }
        private void GenerateDynamicTextBox()
        {
            if (textBoxCount <= 5)
            {
                // Create a new TextBox control
                TextBox newTextBox = new TextBox
                {
                    // Set some properties.
                    Location = new Point(25, 325 + (textBoxCount * 25)), // Adjust position based on count
                    Size = new Size(150, 25),
                    Name = $"phone{textBoxCount}" // Unique name for each textbox.
                };

                // Add the TextBox to the form's Controls collection.
                Controls.Add(newTextBox);
            }

            textBoxCount++; // Increment counter for next textbox
        }
        private void RefreshPhoneList() => dgvPhoneList.DataSource = ClsPhone.GetPhones(employee.PersonID);
        private void LoadDate()
        {
            if (mode == Mode.Add)
            {
                lbTitle.Text = "Add Employee";
                return;
            }

            lbTitle.Text = "Update Employee";
            tbFirstName.Text = employee.FirstName.ToString();
            tbMidName.Text = employee.MidName.ToString();
            tbLastName.Text = employee.LastName.ToString();
            tbAddress.Text = employee.Address.ToString();
            tbEmail.Text = employee.Email.ToString();
            _ = (employee.Gender == 'M') ? rbMale.Checked = true : rbFemel.Checked = true;
            dtBirthDay.Value = employee.DateOfBirth.Date;

            RefreshPhoneList();
        }
        private void FormEmployee_Load(object sender, EventArgs e) => LoadDate();
        private void SaveEmployee()
        {
            employee.FirstName = tbFirstName.Text.ToString().Trim();
            employee.MidName = tbMidName.Text.ToString().Trim();
            employee.LastName = tbLastName.Text.ToString().Trim();
            employee.DateOfBirth = dtBirthDay.Value;
            employee.Email = tbEmail.Text.ToString().Trim();
            employee.Gender = (rbFemel.Checked) ? 'F' : 'M';
            employee.DepartmentID = GetSelectedDepartmentID();
            employee.Address = tbAddress.Text.ToString();

            if (employee.Save())
            {
                GetPhoneFromDynamicTextBox();
                MessageBox.Show("Successfully Done");
            }
            else
                MessageBox.Show("Error");
            
            
        }
        private void BtnSave_Click(object sender, EventArgs e) 
        {
            if (CheckValidation())
                return;

            SaveEmployee();
            Close();
        }
        private void BtnPhone_Click(object sender, EventArgs e) => GenerateDynamicTextBox();
        private void BtnNewDep_Click(object sender, EventArgs e)
        {
            new FormDepartment().ShowDialog();
            LoadDepartmentData();
        }
    }
}
