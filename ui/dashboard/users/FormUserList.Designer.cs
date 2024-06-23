namespace ClinicPresentationLayerDesktop.ui.dashboard.users
{
    partial class FormUserList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.ContextUserOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CntxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxEdit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.ContextUserOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.AllowUserToOrderColumns = true;
            this.dgvUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.ContextMenuStrip = this.ContextUserOptions;
            this.dgvUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserList.Location = new System.Drawing.Point(0, 0);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.Size = new System.Drawing.Size(800, 450);
            this.dgvUserList.TabIndex = 0;
            // 
            // ContextUserOptions
            // 
            this.ContextUserOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxDelete,
            this.CntxEdit});
            this.ContextUserOptions.Name = "ContextUserOptions";
            this.ContextUserOptions.Size = new System.Drawing.Size(181, 70);
            // 
            // CntxDelete
            // 
            this.CntxDelete.Name = "CntxDelete";
            this.CntxDelete.Size = new System.Drawing.Size(180, 22);
            this.CntxDelete.Text = "Delete";
            this.CntxDelete.Click += new System.EventHandler(this.CntxDelete_Click);
            // 
            // CntxEdit
            // 
            this.CntxEdit.Name = "CntxEdit";
            this.CntxEdit.Size = new System.Drawing.Size(180, 22);
            this.CntxEdit.Text = "Edit";
            this.CntxEdit.Click += new System.EventHandler(this.CntxEdit_Click);
            // 
            // FormUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUserList);
            this.Name = "FormUserList";
            this.Text = "FormUserList";
            this.Load += new System.EventHandler(this.FormUserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ContextUserOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.ContextMenuStrip ContextUserOptions;
        private System.Windows.Forms.ToolStripMenuItem CntxDelete;
        private System.Windows.Forms.ToolStripMenuItem CntxEdit;
    }
}