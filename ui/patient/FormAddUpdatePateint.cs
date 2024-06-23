using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ClinicPresentationLayerDesktop.lib;

namespace ClinicPresentationLayerDesktop.ui.pateint
{
    public partial class FormAddUpdatePateint : Form
    {
     
        private Mode mode; // Used to determine (Edit, Add) Form.
        private readonly ClsPatient patient;
        private ClsPhone phone;
        private int textBoxCount = 0; // Keeps track of the number of textboxes.

        public FormAddUpdatePateint(int id)
        {
            InitializeComponent();

            patient = ClsPatient.Find(id);
            mode = patient.IsExists() ? Mode.Update : Mode.Add;
            
        }


        private bool CheckValidation()
        {
            // TextBox Validation.
            bool isValid = !Validation.IsTextBoxEmpty(tbFirstName, e: ErrorProvider) &&
                           !Validation.IsTextBoxEmpty(tbLastName, e: ErrorProvider);

            return !isValid;
        }


        private void GenerateDynamicTextBox()
        {
            if (textBoxCount <= 5)
            {
                // Create a new TextBox control
                TextBox newTextBox = new TextBox
                {
                    // Set some properties.
                    Location = new Point(25, 300 + (textBoxCount * 25)), // Adjust position based on count
                    Size = new Size(150, 25),
                    Name = $"phone{textBoxCount}" // Unique name for each textbox.
                };

                // Add the TextBox to the form's Controls collection.
                Controls.Add(newTextBox);
            }

            textBoxCount++; // Increment counter for next textbox
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
        private void RefreshPhoneList() => dgvPhoneList.DataSource = ClsPhone.GetPhones(patient.ID);
        private void LoadDate()
        {
            if (mode == Mode.Add)
            {
                lbTitle.Text = "New Pateint";
                return;
            }

            lbTitle.Text = "Update Pateint";
            if (patient == null)
            {
                MessageBox.Show("This form will be closed because no Patient found");
                Close();
                return;
            }
            

            // Set old values on controls.
            tbFirstName.Text = patient.FirstName;
            tbMidName.Text = patient.MidName;
            tbLastName.Text = patient.LastName;
            _ = (patient.Gender == 'M') ? rbMale.Checked = true : rbFemel.Checked = true;
            dtBirthDay.Value = patient.DateOfBirth;
            tbEmail.Text = patient.Email;
            tbAddress.Text = patient.Address;

            RefreshPhoneList();
        }
        private void SavePatientInfo()
        {

            patient.FirstName = tbFirstName.Text;
            patient.MidName = tbMidName.Text;
            patient.LastName = tbLastName.Text;
            patient.Email = tbEmail.Text;
            patient.Address = tbAddress.Text;
            patient.DateOfBirth = dtBirthDay.Value;
            patient.Gender = (rbFemel.Checked) ? 'F' : 'M';

            if (patient.Save())
            {
                GetPhoneFromDynamicTextBox(); // Save Phone Number.
                MessageBox.Show("Successfully Done");
                mode = Mode.Update;
            }
            else
                MessageBox.Show("Error Update Patient");

            Close();
        }
        private void SavePhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Trim() != string.Empty)
            {
                phone = new ClsPhone
                {
                    PersonID = patient.ID,
                    PhoneNumber = phoneNumber
                };
                phone.Save();
            }
        }
        private void AddUpdatePateintScreen_Load(object sender, EventArgs e) => LoadDate();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
                return;

            SavePatientInfo();
            Close();
        }
        private void BtnPhone_Click(object sender, EventArgs e) => GenerateDynamicTextBox();
        private void CntxDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirm", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (ClsPhone.Delete((int)dgvPhoneList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted successfully");
                    RefreshPhoneList();
                }
                else
                    MessageBox.Show("Error Deleting");
            }
        }

       
    }
}