using System;
using System.Windows.Forms;
using ClinicBusinessLayer;

namespace ClinicPresentationLayerDesktop.ui.appointment
{
    public partial class FormAppointementInfo : Form
    {
        private readonly ClsAppointment appointment;

        public FormAppointementInfo(int AppointementID)
        {
            InitializeComponent();
            appointment = ClsAppointment.Find(AppointementID);
        }

        private void FormAppointementInfo_Load(object sender, EventArgs e)
        {
            if (appointment.IsEmpty())
            {
                MessageBox.Show($"This form will Close. There is no Appointment with");
                Close();
                return;
            }

            ClsPatient patient = ClsPatient.Find(appointment.PateintID);
            ClsEmployee doctor = ClsEmployee.Find(appointment.DoctorID);
            ClsPayment payment = ClsPayment.Find(appointment.PaymentID);

            lbDoctorName.Text = doctor.FullName();
            lbPatientName.Text = patient.FullName();
            lbDate.Text = appointment.DateAndTime.ToShortDateString();
            lbStatus.Text = appointment.AppointmentStatus;
            lbAmount.Text = payment.PaymentAmount.ToString();
        }
    }
}
