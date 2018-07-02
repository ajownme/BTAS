namespace Biometric_Time_Attendance_System
{
    partial class frmEmployeeSearch
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
            this.grdEmployees = new System.Windows.Forms.DataGridView();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEmployees
            // 
            this.grdEmployees.AllowUserToAddRows = false;
            this.grdEmployees.AllowUserToDeleteRows = false;
            this.grdEmployees.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empName});
            this.grdEmployees.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdEmployees.Location = new System.Drawing.Point(12, 51);
            this.grdEmployees.Name = "grdEmployees";
            this.grdEmployees.ReadOnly = true;
            this.grdEmployees.RowHeadersWidth = 20;
            this.grdEmployees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdEmployees.Size = new System.Drawing.Size(246, 274);
            this.grdEmployees.TabIndex = 18;
            this.grdEmployees.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdEmployees_RowHeaderMouseDoubleClick);
            // 
            // empName
            // 
            this.empName.DataPropertyName = "EmpName";
            this.empName.HeaderText = "Employee";
            this.empName.Name = "empName";
            this.empName.ReadOnly = true;
            this.empName.Width = 250;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(69, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(88, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmEmployeeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(268, 341);
            this.Controls.Add(this.grdEmployees);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmEmployeeSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Main List";
            this.Load += new System.EventHandler(this.frmEmployeeSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.DataGridView grdEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
    }
}