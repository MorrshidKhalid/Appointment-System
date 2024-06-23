using System;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ClinicPresentationLayerDesktop.lib;

namespace ClinicPresentationLayerDesktop.ui.dashboard.department
{
    public partial class FormDepartment : Form
    {
        private ClsDepartment department;
        private Mode mode = Mode.Add;

        // Default Constructor.
        public FormDepartment() => InitializeComponent();

        
        private bool CheckValidation()
        {
            // TextBox Input Validation.
            bool isValid = Validation.IsTextBoxEmpty(tbDepName, e: ErrorProvider) ||
                           Validation.IsTextBoxEmpty(tbSpecialization, e: ErrorProvider);

            return isValid;
        }


        private int CurrentRowID() => (int)dgvDepList.CurrentRow.Cells[0].Value;
        private void RefreshDepList() => dgvDepList.DataSource = ClsDepartment.GetAllDepartments();
        private void FormDepartment_Load(object sender, EventArgs e) => RefreshDepList();
        private void CntxEdit_Click(object sender, EventArgs e)
        {
            department = ClsDepartment.Find(CurrentRowID());

            if (department != null)
            {
                lbTitle.Text = "Update Department";
                tbDepName.Text = department.DepName.ToString();
                tbSpecialization.Text = department.Specialization.ToString();
                BtnSave.Text = "Update";
                mode = Mode.Update;
            }
        }
        private void SaveDepartment()
        {
            if (mode == Mode.Add)
            {
                department = new ClsDepartment
                {
                    DepName = tbDepName.Text.ToString(),
                    Specialization = tbSpecialization.Text.ToString()
                };
                return;
            }

            department.DepName = tbDepName.Text.ToString();
            department.Specialization = tbSpecialization.Text.ToString();
        }
        private void Clear()
        {
            lbTitle.Text = "Add Department";
            tbDepName.Clear();
            tbSpecialization.Clear();
            mode = Mode.Add;
            BtnSave.Text = "Save";
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
                return;

            SaveDepartment();
            if (department.Save())
            {
                MessageBox.Show("Successfully Done");
                Clear();
                RefreshDepList();
            }
            else MessageBox.Show("Error");
        }
        private void DeleteDep()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // User clicked Yes
                department = ClsDepartment.Find(CurrentRowID());

                if (department.Delete())
                {
                    MessageBox.Show("Department Deleted");
                    RefreshDepList();
                }
                else MessageBox.Show("Error Deleting Department");
            }
        }
        private void CntxDelete_Click(object sender, EventArgs e) => DeleteDep();
    }
}
