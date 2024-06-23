using System;
using System.Windows.Forms;
using ClinicBusinessLayer;

namespace ClinicPresentationLayerDesktop.ui.payment
{
    public partial class FormPaymentMethodList : Form
    {
        public FormPaymentMethodList() => InitializeComponent();

        private void RefreshList() => dgvMethodList.DataSource = ClsPaymentMethod.GetAllPaymentMethods();
        private void FormPaymentMethodList_Load(object sender, EventArgs e) => RefreshList();
        private string GetMethodNameFromDialof()
        {
            // Open form
            FormInput input = new FormInput();
            input.ShowDialog();

            return input.Input; // User Input
        }
        private void SaveMethod()
        {
            ClsPaymentMethod method = new ClsPaymentMethod
            {
                PaymentMethod = GetMethodNameFromDialof()
            };

            if (method.Save())
            {
                MessageBox.Show("Method Added");
                RefreshList();
            }
            else
                MessageBox.Show("Method Not Added");
        }
        private void BtnNewMethod_Click(object sender, EventArgs e) => SaveMethod();
    }
}
