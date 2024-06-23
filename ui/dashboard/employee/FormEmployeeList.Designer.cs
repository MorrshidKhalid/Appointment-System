namespace ClinicPresentationLayerDesktop.ui.dashboard.employee
{
    partial class FormEmployeeList
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
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.ContextMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CntxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxEdit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.ContextMenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
            this.dgvEmployeeList.AllowUserToDeleteRows = false;
            this.dgvEmployeeList.AllowUserToOrderColumns = true;
            this.dgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.ContextMenuStrip = this.ContextMenuOptions;
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeList.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.ReadOnly = true;
            this.dgvEmployeeList.Size = new System.Drawing.Size(800, 450);
            this.dgvEmployeeList.TabIndex = 0;
            // 
            // ContextMenuOptions
            // 
            this.ContextMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxDelete,
            this.CntxEdit});
            this.ContextMenuOptions.Name = "ContextMenuOptions";
            this.ContextMenuOptions.Size = new System.Drawing.Size(181, 70);
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
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEmployeeList);
            this.Name = "FormEmployeeList";
            this.Text = "FormEmployeeList";
            this.Load += new System.EventHandler(this.FormEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.ContextMenuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.ContextMenuStrip ContextMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem CntxDelete;
        private System.Windows.Forms.ToolStripMenuItem CntxEdit;
    }
}