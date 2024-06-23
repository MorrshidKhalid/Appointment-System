using System;
using System.Data;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ClinicPresentationLayerDesktop.lib;

namespace ClinicPresentationLayerDesktop.ui.payment
{
    public partial class FormPayment : Form
    {
        public FormPayment() => InitializeComponent();

        private bool CheckValidation()
        {
            // TextBox Validation.
            bool isValid = !Validation.IsTextBoxEmpty(tbAmount, e: ErrorProvider) &&

            // ComboBox Validation.
                           !Validation.HasNotSelected(CbPatient, e: ErrorProvider)
                        && !Validation.HasNotSelected(cbMethod, e: ErrorProvider)
            // Date Validation
                        && !Validation.IsDateSmaller(dpDate, e: ErrorProvider);

            return !isValid;
        }

        private string SelectedItem(ComboBox cb) => (string)cb.SelectedItem;
        private void RefreshPateintComboBox()
        {
            CbPatient.Items.Clear();
            DataTable dt = ClsPatient.GetAllPateints();
            foreach (DataRow row in dt.Rows)
                CbPatient.Items.Add(row["Name"]);
        }
        private void RefreshhMethod()
        {
            cbMethod.Items.Clear();
            DataTable dt = ClsPaymentMethod.GetAllPaymentMethods();
            foreach (DataRow row in dt.Rows)
                cbMethod.Items.Add(row["Method"]);
        }
        private int GetSelectedMethodID()
        {
            if (cbMethod.SelectedItem == null)
                return -1;

            return ClsPaymentMethod.Find(SelectedItem(cbMethod)).PM_ID;
        }
        private int GetSelectedPatientID()
        {
            if (CbPatient.SelectedItem == null)
                return -1;

            return ClsPatient.Find(SelectedItem(CbPatient)).PatientID;
        }
        private void FormPayment_Load(object sender, EventArgs e)
        {
            RefreshPateintComboBox();
            RefreshhMethod();
        }
        private void MakePayment()
        {
            ClsPayment pay = new ClsPayment()
            {
                PateintID = GetSelectedPatientID(),
                MethodID = GetSelectedMethodID(),
                Note = tbNote.Text.ToString(),
                PaymentDate = dpDate.Value,
                PaymentAmount = decimal.Parse(tbAmount.Text.ToString())
            };

            if (pay.Save())
            {
                MessageBox.Show("A New Payment saved successfully");
                Close();
            }
            else
                MessageBox.Show("Error Saving a New Payment");
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
                return;

            MakePayment();
        }
    }
}
