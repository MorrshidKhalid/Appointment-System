using System;
using ClinicBusinessLayer;
using System.Windows.Forms;
using System.Data;
using ClinicPresentationLayerDesktop.lib;

namespace ClinicPresentationLayerDesktop.ui.payment
{
    public partial class FormPaymentList : Form
    {

        // Default Constructor.
        public FormPaymentList() => InitializeComponent();

        // ComboBox Validation.
        private bool CheckValidation() => Validation.HasNotSelected(cbMethod, e: ErrorProvider);

        private void EnableControls(bool enable)
        {
            dpFrom.Enabled = enable;
            dpTo.Enabled = enable;
            BtnSearch.Enabled = enable;
            cbMethod.Enabled = enable;
        }
        private void RefreshMethodComboBox()
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

            string selectedItem = (string)cbMethod.SelectedItem;
            return ClsPaymentMethod.Find(selectedItem).PM_ID;
        } // PK Of Selected (Method).
        private void RefreshPaymentList(EnStatus status)
        {
            if (status == EnStatus.All)
            {
                dgvPaymentList.DataSource = ClsPayment.GetAllPayments();
                return;
            }

            
            dgvPaymentList.DataSource = ClsPayment.GetByDateAndMethod(dpFrom.Value.Date, dpTo.Value.Date, GetSelectedMethodID());

        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
                return;

            RefreshPaymentList(EnStatus.ByInOperator);
        }
        private void CbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (CbAll.Checked)
            {
                EnableControls(false);
                RefreshPaymentList(EnStatus.All);
            } 
            else
            {
                EnableControls(true);
                RefreshPaymentList(EnStatus.ByInOperator);
            }
                
        }

        private void CbAllMethods_CheckedChanged(object sender, EventArgs e)
        {
            if (CbAllMethods.Checked)
            {
                cbMethod.Enabled = false;
                RefreshPaymentList(EnStatus.ByInOperator);
            }
            else
            {
                cbMethod.Enabled = true;
                RefreshPaymentList(EnStatus.ByInOperator);
            }
        }
        private void FormPaymentList_Load(object sender, EventArgs e) => RefreshMethodComboBox();
    }
}