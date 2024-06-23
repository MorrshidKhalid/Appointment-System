namespace ClinicPresentationLayerDesktop.ui.payment
{
    partial class FormPaymentMethodList
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
            this.dgvMethodList = new System.Windows.Forms.DataGridView();
            this.cntxMethod = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CntxEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnNewMethod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMethodList)).BeginInit();
            this.cntxMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMethodList
            // 
            this.dgvMethodList.AllowUserToAddRows = false;
            this.dgvMethodList.AllowUserToDeleteRows = false;
            this.dgvMethodList.AllowUserToOrderColumns = true;
            this.dgvMethodList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMethodList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMethodList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMethodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMethodList.ContextMenuStrip = this.cntxMethod;
            this.dgvMethodList.Location = new System.Drawing.Point(12, 50);
            this.dgvMethodList.Name = "dgvMethodList";
            this.dgvMethodList.ReadOnly = true;
            this.dgvMethodList.Size = new System.Drawing.Size(322, 169);
            this.dgvMethodList.TabIndex = 0;
            // 
            // cntxMethod
            // 
            this.cntxMethod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxEdit,
            this.CntxDelete});
            this.cntxMethod.Name = "cntxMethod";
            this.cntxMethod.Size = new System.Drawing.Size(108, 48);
            // 
            // CntxEdit
            // 
            this.CntxEdit.Name = "CntxEdit";
            this.CntxEdit.Size = new System.Drawing.Size(107, 22);
            this.CntxEdit.Text = "Edit";
            // 
            // CntxDelete
            // 
            this.CntxDelete.Name = "CntxDelete";
            this.CntxDelete.Size = new System.Drawing.Size(107, 22);
            this.CntxDelete.Text = "Delete";
            // 
            // BtnNewMethod
            // 
            this.BtnNewMethod.Location = new System.Drawing.Point(230, 12);
            this.BtnNewMethod.Name = "BtnNewMethod";
            this.BtnNewMethod.Size = new System.Drawing.Size(104, 32);
            this.BtnNewMethod.TabIndex = 2;
            this.BtnNewMethod.Text = "New Method";
            this.BtnNewMethod.UseVisualStyleBackColor = true;
            this.BtnNewMethod.Click += new System.EventHandler(this.BtnNewMethod_Click);
            // 
            // FormPaymentMethodList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 238);
            this.Controls.Add(this.BtnNewMethod);
            this.Controls.Add(this.dgvMethodList);
            this.Name = "FormPaymentMethodList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPaymentMethodList";
            this.Load += new System.EventHandler(this.FormPaymentMethodList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMethodList)).EndInit();
            this.cntxMethod.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMethodList;
        private System.Windows.Forms.ContextMenuStrip cntxMethod;
        private System.Windows.Forms.Button BtnNewMethod;
        private System.Windows.Forms.ToolStripMenuItem CntxEdit;
        private System.Windows.Forms.ToolStripMenuItem CntxDelete;
    }
}