using System;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ClinicPresentationLayerDesktop.ui.users;

namespace ClinicPresentationLayerDesktop.ui.dashboard.users
{
    public partial class FormUserList : Form
    {
        public FormUserList() => InitializeComponent();

        private int CurrentRowID() => (int)dgvUserList.CurrentRow.Cells[0].Value;
        private void RefreshUserList() => dgvUserList.DataSource = ClsUser.AllUsers();
        private void FormUserList_Load(object sender, EventArgs e) => RefreshUserList();
        private void CntxDelete_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // User clicked Yes
                
                ClsUser userToDelete = ClsUser.Find(CurrentRowID());
                if (userToDelete.DeleteUser())
                {
                    MessageBox.Show("User Deleted");
                    RefreshUserList();
                }
                else MessageBox.Show("Error Deleting User");
            }
        }
        private void CntxEdit_Click(object sender, EventArgs e)
        {
            new FormAddUpdateUser(CurrentRowID()).ShowDialog();
            RefreshUserList();
        }
    }
}
