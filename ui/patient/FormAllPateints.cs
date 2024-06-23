using System;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ClinicPresentationLayerDesktop.ui.pateint;

namespace ClinicPresentationLayerDesktop
{
    public partial class FormPateintList : Form
    {
        public FormPateintList() => InitializeComponent();

        private int CurrentRowID() => (int)dgvAllPateints.CurrentRow.Cells[0].Value;
        private void RefreshPateintsList() => dgvAllPateints.DataSource = ClsPatient.GetAllPateints();
        private void AllPateints_Load(object sender, EventArgs e) => RefreshPateintsList();
        private void CntxEdit_Click(object sender, EventArgs e)
        {
            new FormAddUpdatePateint(CurrentRowID()).ShowDialog();
            RefreshPateintsList();
        }
        private void CntxDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to continue?",
                                       "Confirmation",
                                       MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ClsPatient patientToDelete = ClsPatient.Find(CurrentRowID());

                if (patientToDelete.Delete())
                {
                    MessageBox.Show("Deleted Successfully");
                    RefreshPateintsList();
                }
                else
                    MessageBox.Show("Make sure there is no relited Info with this patient!");
            }
        }
    }
}
