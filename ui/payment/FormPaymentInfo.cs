using System;
using System.Windows.Forms;
using ClinicBusinessLayer;

namespace ClinicPresentationLayerDesktop.ui.payment
{
    public partial class FormPaymentInfo : Form
    {
        private readonly int PaymentID;

        // Default Constructor.
        public FormPaymentInfo(int PaymentID)
        {
            InitializeComponent();
            this.PaymentID = PaymentID;
        }

        private void SetPaymentInfo()
        {
            ClsPayment payment = ClsPayment.Find(PaymentID);
            ClsPatient patient = ClsPatient.Find(payment.PateintID);

            // Set Date on Controls.
            lbPatietName.Text = patient.FullName();
            lbNote.Text = payment.Note;
            lbDate.Text = payment.PaymentDate.ToString();
            lbAmount.Text = payment.PaymentAmount.ToString();
        }
        private void FormPaymentInfo_Load(object sender, EventArgs e) => SetPaymentInfo();
    }
}
