using System;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ClinicPresentationLayerDesktop.lib;

namespace ClinicPresentationLayerDesktop.ui.appointment
{
    public partial class FormReschedule : Form
    {

        private readonly ClsAppointment appointment;
        
        // Default Consreuctor.
        public FormReschedule(int AppointmentID)
        {
            InitializeComponent();
            appointment = ClsAppointment.Find(AppointmentID);
        }


        private bool CheckValidation() => 
            Validation.IsDateSmaller(dpAppointDate, msg: "To Reschedule, Date Must Be On The Futuer", e: ErrorProvider)
            || Validation.IsEqual(dpAppointDate, msg: "To Reschedule, Date Must Be On The Futuer", e: ErrorProvider);

        private void LoadData()
        {
            ClsEmployee doctor = ClsEmployee.Find(appointment.DoctorID);
            ClsPatient patient = ClsPatient.Find(appointment.PateintID);
            lbDoctorName.Text = doctor.FullName();
            lbPatientName.Text = patient.FullName();
            lbDate.Text = appointment.DateAndTime.ToString();
        }
        private void FormReschedule_Load(object sender, EventArgs e) => LoadData();
        private void btnCancel_Click(object sender, EventArgs e) => Close();
        private void SetRescheduleDate()
        {
            DateTime newDate = dpAppointDate.Value;
            appointment.DateAndTime = newDate;
            appointment.AppointmentStatus = EnStatus.Rescheduled.ToString(); // Change Status
            if (appointment.Save())
            {
                MessageBox.Show("Recheduled successfully");
                Close();
            }
            else MessageBox.Show("Error");

        }
        private void BtnReschedule_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
                return;

            SetRescheduleDate();
        }
    }
}
