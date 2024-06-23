using System;
using System.Windows.Forms;
using ClinicBusinessLayer;

namespace ClinicPresentationLayerDesktop.ui.pateint
{
    public partial class FormPaitentAppointmentList : Form
    {
        private readonly int PatientID;
        public FormPaitentAppointmentList(int PatientID)
        {
            InitializeComponent();
            this.PatientID = PatientID;
        }

        private void RefreshAppointmentList()
        {
            ClsPatient patient = ClsPatient.Find(PatientID);
            if (PatientID == -1 || patient == null || patient.GetPatientAppointments().Rows.Count <= 0)
            {
                MessageBox.Show("There is no Appointment from this patient");
                Close();
                return;
            }

            dgvPaitentAppointmentList.DataSource = patient.GetPatientAppointments();
        }
        private void FormPaitentAppointmentList_Load(object sender, EventArgs e) => RefreshAppointmentList();

    }
}