using System;
using System.Windows.Forms;

namespace ClinicPresentationLayerDesktop.ui
{
    public partial class FormInput : Form
    {
        public string Input { get; set; }

        public FormInput() => InitializeComponent();

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Input = tbInput.Text.ToString();
            Close();
        }
    }
}
