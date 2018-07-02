namespace Biometric_Time_Attendance_System
{
    partial class frmUserAccount
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.grpAcctDetails = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.grpPermission = new System.Windows.Forms.GroupBox();
            this.trvPermission = new System.Windows.Forms.TreeView();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpRegistry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FPrintRegistry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Holiday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegReports = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortBReports = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealBReports = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBReports = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Modify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAccess_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.grpAcctDetails.SuspendLayout();
            this.grpPermission.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnSave,
            this.btnCancel,
            this.btnDelete,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 50);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = false;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNew.Image = global::Biometric_Time_Attendance_System.Properties.Resources.New;
            this.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 55);
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.ToolTipText = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.Image = global::Biometric_Time_Attendance_System.Properties.Resources.Edit;
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 55);
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.ToolTipText = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Image = global::Biometric_Time_Attendance_System.Properties.Resources.Save;
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 55);
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.ToolTipText = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Image = global::Biometric_Time_Attendance_System.Properties.Resources.cancel;
            this.btnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 55);
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.ToolTipText = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::Biometric_Time_Attendance_System.Properties.Resources.Delete;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 55);
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.ToolTipText = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 47);
            // 
            // grpAcctDetails
            // 
            this.grpAcctDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpAcctDetails.Controls.Add(this.txtUserName);
            this.grpAcctDetails.Controls.Add(this.label5);
            this.grpAcctDetails.Controls.Add(this.txtNewPass);
            this.grpAcctDetails.Controls.Add(this.label4);
            this.grpAcctDetails.Controls.Add(this.txtOldPass);
            this.grpAcctDetails.Controls.Add(this.Label1);
            this.grpAcctDetails.Location = new System.Drawing.Point(47, 64);
            this.grpAcctDetails.Name = "grpAcctDetails";
            this.grpAcctDetails.Size = new System.Drawing.Size(302, 136);
            this.grpAcctDetails.TabIndex = 34;
            this.grpAcctDetails.TabStop = false;
            this.grpAcctDetails.Text = "Account Details";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(97, 27);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(178, 20);
            this.txtUserName.TabIndex = 29;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "UserName:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(97, 87);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(177, 20);
            this.txtNewPass.TabIndex = 20;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "New Password:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(97, 58);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(178, 20);
            this.txtOldPass.TabIndex = 6;
            this.txtOldPass.TextChanged += new System.EventHandler(this.txtOldPass_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 60);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Old Password:";
            // 
            // grpPermission
            // 
            this.grpPermission.BackColor = System.Drawing.Color.Transparent;
            this.grpPermission.Controls.Add(this.trvPermission);
            this.grpPermission.Location = new System.Drawing.Point(383, 64);
            this.grpPermission.Name = "grpPermission";
            this.grpPermission.Size = new System.Drawing.Size(306, 377);
            this.grpPermission.TabIndex = 36;
            this.grpPermission.TabStop = false;
            this.grpPermission.Text = "Permission Access";
            // 
            // trvPermission
            // 
            this.trvPermission.CheckBoxes = true;
            this.trvPermission.Location = new System.Drawing.Point(23, 29);
            this.trvPermission.Name = "trvPermission";
            this.trvPermission.Size = new System.Drawing.Size(256, 331);
            this.trvPermission.TabIndex = 0;
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.dgvAccount);
            this.grpSearch.Controls.Add(this.label6);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Location = new System.Drawing.Point(47, 219);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(302, 222);
            this.grpSearch.TabIndex = 37;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Account List";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Password,
            this.EmpRegistry,
            this.FPrintRegistry,
            this.Branch,
            this.Company,
            this.Department,
            this.Holiday,
            this.Location,
            this.TimeLimit,
            this.UserAccess,
            this.RegReports,
            this.ShortBReports,
            this.MealBReports,
            this.OBReports,
            this.Created_By,
            this.Date_Created,
            this.Modify_By,
            this.Date_Modify,
            this.Deleted,
            this.UserAccess_ID});
            this.dgvAccount.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAccount.Location = new System.Drawing.Point(22, 42);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 20;
            this.dgvAccount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAccount.Size = new System.Drawing.Size(253, 165);
            this.dgvAccount.TabIndex = 18;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 250;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // EmpRegistry
            // 
            this.EmpRegistry.DataPropertyName = "EmpRegistry";
            this.EmpRegistry.HeaderText = "EmpRegistry";
            this.EmpRegistry.Name = "EmpRegistry";
            this.EmpRegistry.ReadOnly = true;
            this.EmpRegistry.Visible = false;
            // 
            // FPrintRegistry
            // 
            this.FPrintRegistry.DataPropertyName = "FPrintRegistry";
            this.FPrintRegistry.HeaderText = "FPrintRegistry";
            this.FPrintRegistry.Name = "FPrintRegistry";
            this.FPrintRegistry.ReadOnly = true;
            this.FPrintRegistry.Visible = false;
            // 
            // Branch
            // 
            this.Branch.DataPropertyName = "Branch";
            this.Branch.HeaderText = "Branch";
            this.Branch.Name = "Branch";
            this.Branch.ReadOnly = true;
            this.Branch.Visible = false;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Visible = false;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Visible = false;
            // 
            // Holiday
            // 
            this.Holiday.DataPropertyName = "Holiday";
            this.Holiday.HeaderText = "Holiday";
            this.Holiday.Name = "Holiday";
            this.Holiday.ReadOnly = true;
            this.Holiday.Visible = false;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Visible = false;
            // 
            // TimeLimit
            // 
            this.TimeLimit.DataPropertyName = "TimeLimit";
            this.TimeLimit.HeaderText = "TimeLimit";
            this.TimeLimit.Name = "TimeLimit";
            this.TimeLimit.ReadOnly = true;
            this.TimeLimit.Visible = false;
            // 
            // UserAccess
            // 
            this.UserAccess.DataPropertyName = "UserAccess";
            this.UserAccess.HeaderText = "UserAccess";
            this.UserAccess.Name = "UserAccess";
            this.UserAccess.ReadOnly = true;
            this.UserAccess.Visible = false;
            // 
            // RegReports
            // 
            this.RegReports.DataPropertyName = "RegReports";
            this.RegReports.HeaderText = "RegReports";
            this.RegReports.Name = "RegReports";
            this.RegReports.ReadOnly = true;
            this.RegReports.Visible = false;
            // 
            // ShortBReports
            // 
            this.ShortBReports.DataPropertyName = "ShortBReports";
            this.ShortBReports.HeaderText = "ShortBReports";
            this.ShortBReports.Name = "ShortBReports";
            this.ShortBReports.ReadOnly = true;
            this.ShortBReports.Visible = false;
            // 
            // MealBReports
            // 
            this.MealBReports.DataPropertyName = "MealBReports";
            this.MealBReports.HeaderText = "MealBReports";
            this.MealBReports.Name = "MealBReports";
            this.MealBReports.ReadOnly = true;
            this.MealBReports.Visible = false;
            // 
            // OBReports
            // 
            this.OBReports.DataPropertyName = "OBReports";
            this.OBReports.HeaderText = "OBReports";
            this.OBReports.Name = "OBReports";
            this.OBReports.ReadOnly = true;
            this.OBReports.Visible = false;
            // 
            // Created_By
            // 
            this.Created_By.DataPropertyName = "Created_By";
            this.Created_By.HeaderText = "Created_By";
            this.Created_By.Name = "Created_By";
            this.Created_By.ReadOnly = true;
            this.Created_By.Visible = false;
            // 
            // Date_Created
            // 
            this.Date_Created.DataPropertyName = "Date_Created";
            this.Date_Created.HeaderText = "Date_Created";
            this.Date_Created.Name = "Date_Created";
            this.Date_Created.ReadOnly = true;
            this.Date_Created.Visible = false;
            // 
            // Modify_By
            // 
            this.Modify_By.DataPropertyName = "Modify_By";
            this.Modify_By.HeaderText = "Modify_By";
            this.Modify_By.Name = "Modify_By";
            this.Modify_By.ReadOnly = true;
            this.Modify_By.Visible = false;
            // 
            // Date_Modify
            // 
            this.Date_Modify.DataPropertyName = "Date_Modify";
            this.Date_Modify.HeaderText = "Date_Modify";
            this.Date_Modify.Name = "Date_Modify";
            this.Date_Modify.ReadOnly = true;
            this.Date_Modify.Visible = false;
            // 
            // Deleted
            // 
            this.Deleted.DataPropertyName = "Deleted";
            this.Deleted.HeaderText = "Deleted";
            this.Deleted.Name = "Deleted";
            this.Deleted.ReadOnly = true;
            this.Deleted.Visible = false;
            // 
            // UserAccess_ID
            // 
            this.UserAccess_ID.DataPropertyName = "UserAccess_ID";
            this.UserAccess_ID.HeaderText = "UserAccess_ID";
            this.UserAccess_ID.Name = "UserAccess_ID";
            this.UserAccess_ID.ReadOnly = true;
            this.UserAccess_ID.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(76, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(113, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpPermission);
            this.Controls.Add(this.grpAcctDetails);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmUserAccount";
            this.Text = "User Account";
            this.Load += new System.EventHandler(this.frmUserAccount_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpAcctDetails.ResumeLayout(false);
            this.grpAcctDetails.PerformLayout();
            this.grpPermission.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        internal System.Windows.Forms.GroupBox grpAcctDetails;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtNewPass;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtOldPass;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox grpPermission;
        private System.Windows.Forms.TreeView trvPermission;
        private System.Windows.Forms.GroupBox grpSearch;
        internal System.Windows.Forms.DataGridView dgvAccount;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpRegistry;
        private System.Windows.Forms.DataGridViewTextBoxColumn FPrintRegistry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Holiday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortBReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealBReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modify_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Modify;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAccess_ID;
    }
}