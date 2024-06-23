namespace ClinicPresentationLayerDesktop.ui.dashboard.department
{
    partial class FormDepartment
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
            this.dgvDepList = new System.Windows.Forms.DataGridView();
            this.ContextMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CntxEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDepName = new System.Windows.Forms.TextBox();
            this.tbSpecialization = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepList)).BeginInit();
            this.ContextMenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepList
            // 
            this.dgvDepList.AllowUserToAddRows = false;
            this.dgvDepList.AllowUserToDeleteRows = false;
            this.dgvDepList.AllowUserToOrderColumns = true;
            this.dgvDepList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDepList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepList.ContextMenuStrip = this.ContextMenuOptions;
            this.dgvDepList.Location = new System.Drawing.Point(407, 27);
            this.dgvDepList.Name = "dgvDepList";
            this.dgvDepList.ReadOnly = true;
            this.dgvDepList.Size = new System.Drawing.Size(381, 411);
            this.dgvDepList.TabIndex = 0;
            // 
            // ContextMenuOptions
            // 
            this.ContextMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxEdit,
            this.CntxDelete});
            this.ContextMenuOptions.Name = "ContextMenuOptions";
            this.ContextMenuOptions.Size = new System.Drawing.Size(108, 48);
            // 
            // CntxEdit
            // 
            this.CntxEdit.Name = "CntxEdit";
            this.CntxEdit.Size = new System.Drawing.Size(107, 22);
            this.CntxEdit.Text = "Edit";
            this.CntxEdit.Click += new System.EventHandler(this.CntxEdit_Click);
            // 
            // CntxDelete
            // 
            this.CntxDelete.Name = "CntxDelete";
            this.CntxDelete.Size = new System.Drawing.Size(107, 22);
            this.CntxDelete.Text = "Delete";
            this.CntxDelete.Click += new System.EventHandler(this.CntxDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(11, 158);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(114, 32);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Specialization:";
            // 
            // tbDepName
            // 
            this.tbDepName.Location = new System.Drawing.Point(114, 93);
            this.tbDepName.Name = "tbDepName";
            this.tbDepName.Size = new System.Drawing.Size(183, 20);
            this.tbDepName.TabIndex = 4;
            // 
            // tbSpecialization
            // 
            this.tbSpecialization.Location = new System.Drawing.Point(114, 118);
            this.tbSpecialization.Name = "tbSpecialization";
            this.tbSpecialization.Size = new System.Drawing.Size(183, 20);
            this.tbSpecialization.TabIndex = 5;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(7, 27);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(161, 24);
            this.lbTitle.TabIndex = 22;
            this.lbTitle.Text = "Add Department";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tbSpecialization);
            this.Controls.Add(this.tbDepName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dgvDepList);
            this.Name = "FormDepartment";
            this.Text = "FormDepartment";
            this.Load += new System.EventHandler(this.FormDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepList)).EndInit();
            this.ContextMenuOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepList;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDepName;
        private System.Windows.Forms.TextBox tbSpecialization;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ContextMenuStrip ContextMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem CntxEdit;
        private System.Windows.Forms.ToolStripMenuItem CntxDelete;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}