using ClinicPresentationLayerDesktop.lib;
using System;
using System.Windows.Forms;

namespace ClinicPresentationLayerDesktop.ui.pateint
{
    public partial class FormDialogWithText : Form
    {
        public int PassedID { get; set; }
        public FormDialogWithText() => InitializeComponent();

        // TextBox Input Validation.
        private bool CheckValidation() => Validation.IsTextBoxEmpty(tbID, e: ErrorProvider);

        private void BtnGetID_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
                return;

            PassedID = int.Parse(tbID.Text.ToString());
            Close();
        }
    }
}
