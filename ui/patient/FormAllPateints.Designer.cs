namespace ClinicPresentationLayerDesktop
{
    partial class FormPateintList
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
            this.dgvAllPateints = new System.Windows.Forms.DataGridView();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CntxEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPateints)).BeginInit();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllPateints
            // 
            this.dgvAllPateints.AllowUserToAddRows = false;
            this.dgvAllPateints.AllowUserToDeleteRows = false;
            this.dgvAllPateints.AllowUserToOrderColumns = true;
            this.dgvAllPateints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllPateints.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAllPateints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPateints.ContextMenuStrip = this.ctxMenu;
            this.dgvAllPateints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllPateints.Location = new System.Drawing.Point(0, 0);
            this.dgvAllPateints.Name = "dgvAllPateints";
            this.dgvAllPateints.ReadOnly = true;
            this.dgvAllPateints.Size = new System.Drawing.Size(843, 457);
            this.dgvAllPateints.TabIndex = 0;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxEdit,
            this.CntxDelete});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // CntxEdit
            // 
            this.CntxEdit.Name = "CntxEdit";
            this.CntxEdit.Size = new System.Drawing.Size(180, 22);
            this.CntxEdit.Text = "Edit";
            this.CntxEdit.Click += new System.EventHandler(this.CntxEdit_Click);
            // 
            // CntxDelete
            // 
            this.CntxDelete.Name = "CntxDelete";
            this.CntxDelete.Size = new System.Drawing.Size(180, 22);
            this.CntxDelete.Text = "Delete";
            this.CntxDelete.Click += new System.EventHandler(this.CntxDelete_Click);
            // 
            // PateintsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 457);
            this.Controls.Add(this.dgvAllPateints);
            this.Name = "PateintsForm";
            this.Text = "All Pateints";
            this.Load += new System.EventHandler(this.AllPateints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPateints)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllPateints;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem CntxEdit;
        private System.Windows.Forms.ToolStripMenuItem CntxDelete;
    }
}