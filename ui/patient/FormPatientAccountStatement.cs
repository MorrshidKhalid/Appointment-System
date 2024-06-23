using System;
using System.Windows.Forms;
using ClinicBusinessLayer;

namespace ClinicPresentationLayerDesktop.ui.pateint
{
    public partial class FormPatientAccountStatement : Form
    {
        private readonly int PatientID;

        // Default Constructor.
        public FormPatientAccountStatement(int PatientID)
        {
            InitializeComponent();
            this.PatientID = PatientID;
        }
        private void FormPatientAccountStatement_Load(object sender, EventArgs e) 
        {
            if (ClsPatient.GetAccountStatement(PatientID).Rows.Count <= 0)
            {
                MessageBox.Show("There is no data to show for this patient, this form will be closed");
                Close();
            }
            
            dgvAccountStatement.DataSource = ClsPatient.GetAccountStatement(PatientID);
        } 
    }
}
