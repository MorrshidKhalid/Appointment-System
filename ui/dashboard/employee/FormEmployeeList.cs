using System;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ClinicPresentationLayerDesktop.ui.employee;

namespace ClinicPresentationLayerDesktop.ui.dashboard.employee
{
    public partial class FormEmployeeList : Form
    {
     
        // Default Constructor.
        public FormEmployeeList() => InitializeComponent();

        private int CurrentRowID() => (int)dgvEmployeeList.CurrentRow.Cells[0].Value;

        private void RefreshEmployeeList() => dgvEmployeeList.DataSource = ClsEmployee.GetAllEmployees();

        private void FormEmployeeList_Load(object sender, EventArgs e) => RefreshEmployeeList();

        private void DeleteEmployee()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // User clicked Yes
                ClsEmployee employee = ClsEmployee.Find(CurrentRowID());

                if (employee.Delete())
                {
                    MessageBox.Show("Deleted Successfully");
                    RefreshEmployeeList();
                }
                else MessageBox.Show("Make sure this employee has no related data in the system");
            }
        }

        private void CntxDelete_Click(object sender, EventArgs e) => DeleteEmployee();

        private void CntxEdit_Click(object sender, EventArgs e)
        {
            int empID = CurrentRowID();
            new FormEmployee(empID).ShowDialog();
            RefreshEmployeeList();
        }
    }
}
