using System;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ClinicPresentationLayerDesktop.lib;

namespace ClinicPresentationLayerDesktop.ui.login
{
    public partial class FormLogin : Form
    {
        public FormLogin() => InitializeComponent();

        private bool CheckValidation()
        {
            // TextBox Validation.
            bool isValid = !Validation.IsTextBoxEmpty(tbUserName, e: ErrorProvider) &&
                           !Validation.IsTextBoxEmpty(tbPassword, e: ErrorProvider);
                        
            return !isValid;
        }

        private void VerifyUserAndPassword()
        {

            CurrentUser.user = ClsUser.Find(tbUserName.Text.ToString(), tbPassword.Text.ToString());

            if (CurrentUser.user == null)
            {
                MessageBox.Show("Invalid Username/Password");
                return; // Block User access.
            }
            else
            {
                new HomeForm().Show();
                Hide(); // Here hide login form.
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
                return;

            VerifyUserAndPassword();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
