using ClinicBusinessLayer;
using System;
using System.Windows.Forms;

namespace ClinicPresentationLayerDesktop.ui.appointment
{
    public partial class FormAppointmentBetweenDate : Form
    {
        public FormAppointmentBetweenDate(DateTime fromDate, DateTime  toDate)
        {
            InitializeComponent();

            lbFrom.Text = fromDate.ToShortDateString();
            lbTo.Text = toDate.ToShortDateString();
            dgvAppointementList.DataSource = ClsAppointment.GetAppointmentBetween(fromDate, toDate);
        }

    }
}
