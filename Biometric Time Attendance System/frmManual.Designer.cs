namespace Biometric_Time_Attendance_System
{
    partial class frmManual
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
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.grpEmpList = new System.Windows.Forms.GroupBox();
            this.grdEmployees = new System.Windows.Forms.DataGridView();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Modify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_MidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_DayOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manual_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manual_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manual_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbManType = new System.Windows.Forms.ComboBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rtbReason = new System.Windows.Forms.RichTextBox();
            this.dtToHr = new System.Windows.Forms.DateTimePicker();
            this.lblMTo = new System.Windows.Forms.Label();
            this.dtFromHr = new System.Windows.Forms.DateTimePicker();
            this.lblMHours = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblMType = new System.Windows.Forms.Label();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.dtPickerManual = new System.Windows.Forms.DateTimePicker();
            this.lblMDate = new System.Windows.Forms.Label();
            this.txtMidName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.grpEmpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearch,
            this.btnNew,
            this.btnSave,
            this.btnCancel,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 50);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = global::Biometric_Time_Attendance_System.Properties.Resources.search_person;
            this.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 55);
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.ToolTipText = "Employee Main List";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = false;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNew.Enabled = false;
            this.btnNew.Image = global::Biometric_Time_Attendance_System.Properties.Resources.New;
            this.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 55);
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.ToolTipText = "Add Manual";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Enabled = false;
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
            this.btnCancel.Enabled = false;
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 47);
            // 
            // grpEmpList
            // 
            this.grpEmpList.BackColor = System.Drawing.Color.Transparent;
            this.grpEmpList.Controls.Add(this.grdEmployees);
            this.grpEmpList.Controls.Add(this.label6);
            this.grpEmpList.Controls.Add(this.txtSearch);
            this.grpEmpList.Location = new System.Drawing.Point(384, 57);
            this.grpEmpList.Name = "grpEmpList";
            this.grpEmpList.Size = new System.Drawing.Size(352, 395);
            this.grpEmpList.TabIndex = 26;
            this.grpEmpList.TabStop = false;
            this.grpEmpList.Text = "Employee List";
            // 
            // grdEmployees
            // 
            this.grdEmployees.AllowUserToAddRows = false;
            this.grdEmployees.AllowUserToDeleteRows = false;
            this.grdEmployees.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empName,
            this.Created_By,
            this.Date_Created,
            this.Modify_By,
            this.Date_Modify,
            this.Deleted,
            this.Emp_ID,
            this.Emp_LastName,
            this.Emp_FirstName,
            this.Emp_MidName,
            this.Company_ID,
            this.Branch_ID,
            this.Department_ID,
            this.Emp_Type,
            this.Emp_DayOff,
            this.Emp_Shift,
            this.Company_Name,
            this.Branch_Name,
            this.Department_Name,
            this.Manual_Date,
            this.Manual_Time,
            this.Manual_Type,
            this.Reason});
            this.grdEmployees.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdEmployees.Location = new System.Drawing.Point(12, 54);
            this.grdEmployees.Name = "grdEmployees";
            this.grdEmployees.ReadOnly = true;
            this.grdEmployees.RowHeadersWidth = 20;
            this.grdEmployees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdEmployees.Size = new System.Drawing.Size(327, 320);
            this.grdEmployees.TabIndex = 18;
            this.grdEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmployees_CellClick);
            // 
            // empName
            // 
            this.empName.DataPropertyName = "EmpName";
            this.empName.HeaderText = "Employee";
            this.empName.Name = "empName";
            this.empName.ReadOnly = true;
            this.empName.Width = 150;
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
            // Emp_ID
            // 
            this.Emp_ID.DataPropertyName = "Emp_ID";
            this.Emp_ID.HeaderText = "Emp_ID";
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.ReadOnly = true;
            this.Emp_ID.Visible = false;
            // 
            // Emp_LastName
            // 
            this.Emp_LastName.DataPropertyName = "Emp_LastName";
            this.Emp_LastName.HeaderText = "Emp_LastName";
            this.Emp_LastName.Name = "Emp_LastName";
            this.Emp_LastName.ReadOnly = true;
            this.Emp_LastName.Visible = false;
            // 
            // Emp_FirstName
            // 
            this.Emp_FirstName.DataPropertyName = "Emp_FirstName";
            this.Emp_FirstName.HeaderText = "Emp_FirstName";
            this.Emp_FirstName.Name = "Emp_FirstName";
            this.Emp_FirstName.ReadOnly = true;
            this.Emp_FirstName.Visible = false;
            // 
            // Emp_MidName
            // 
            this.Emp_MidName.DataPropertyName = "Emp_MidName";
            this.Emp_MidName.HeaderText = "Emp_MidName";
            this.Emp_MidName.Name = "Emp_MidName";
            this.Emp_MidName.ReadOnly = true;
            this.Emp_MidName.Visible = false;
            // 
            // Company_ID
            // 
            this.Company_ID.DataPropertyName = "Company_ID";
            this.Company_ID.HeaderText = "Company_ID";
            this.Company_ID.Name = "Company_ID";
            this.Company_ID.ReadOnly = true;
            this.Company_ID.Visible = false;
            // 
            // Branch_ID
            // 
            this.Branch_ID.DataPropertyName = "Branch_ID";
            this.Branch_ID.HeaderText = "Branch_ID";
            this.Branch_ID.Name = "Branch_ID";
            this.Branch_ID.ReadOnly = true;
            this.Branch_ID.Visible = false;
            // 
            // Department_ID
            // 
            this.Department_ID.DataPropertyName = "Department_ID";
            this.Department_ID.HeaderText = "Department_ID";
            this.Department_ID.Name = "Department_ID";
            this.Department_ID.ReadOnly = true;
            this.Department_ID.Visible = false;
            // 
            // Emp_Type
            // 
            this.Emp_Type.DataPropertyName = "Emp_Type";
            this.Emp_Type.HeaderText = "Emp_Type";
            this.Emp_Type.Name = "Emp_Type";
            this.Emp_Type.ReadOnly = true;
            this.Emp_Type.Visible = false;
            // 
            // Emp_DayOff
            // 
            this.Emp_DayOff.DataPropertyName = "Emp_DayOff";
            this.Emp_DayOff.HeaderText = "Emp_DayOff";
            this.Emp_DayOff.Name = "Emp_DayOff";
            this.Emp_DayOff.ReadOnly = true;
            this.Emp_DayOff.Visible = false;
            // 
            // Emp_Shift
            // 
            this.Emp_Shift.DataPropertyName = "Emp_Shift";
            this.Emp_Shift.HeaderText = "Emp_Shift";
            this.Emp_Shift.Name = "Emp_Shift";
            this.Emp_Shift.ReadOnly = true;
            this.Emp_Shift.Visible = false;
            // 
            // Company_Name
            // 
            this.Company_Name.DataPropertyName = "Company_Name";
            this.Company_Name.HeaderText = "Company_Name";
            this.Company_Name.Name = "Company_Name";
            this.Company_Name.ReadOnly = true;
            this.Company_Name.Visible = false;
            // 
            // Branch_Name
            // 
            this.Branch_Name.DataPropertyName = "Branch_Name";
            this.Branch_Name.HeaderText = "Branch_Name";
            this.Branch_Name.Name = "Branch_Name";
            this.Branch_Name.ReadOnly = true;
            this.Branch_Name.Visible = false;
            // 
            // Department_Name
            // 
            this.Department_Name.DataPropertyName = "Department_Name";
            this.Department_Name.HeaderText = "Department_Name";
            this.Department_Name.Name = "Department_Name";
            this.Department_Name.ReadOnly = true;
            this.Department_Name.Visible = false;
            // 
            // Manual_Date
            // 
            this.Manual_Date.DataPropertyName = "Manual_Date";
            this.Manual_Date.HeaderText = "Manual_Date";
            this.Manual_Date.Name = "Manual_Date";
            this.Manual_Date.ReadOnly = true;
            this.Manual_Date.Width = 80;
            // 
            // Manual_Time
            // 
            this.Manual_Time.DataPropertyName = "Manual_Time";
            this.Manual_Time.HeaderText = "Manual_Time";
            this.Manual_Time.Name = "Manual_Time";
            this.Manual_Time.ReadOnly = true;
            this.Manual_Time.Visible = false;
            // 
            // Manual_Type
            // 
            this.Manual_Type.DataPropertyName = "Manual_Type";
            this.Manual_Type.HeaderText = "Manual_Type";
            this.Manual_Type.Name = "Manual_Type";
            this.Manual_Type.ReadOnly = true;
            this.Manual_Type.Width = 80;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            this.Reason.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(64, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(113, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpDetails.Controls.Add(this.txtCompany);
            this.grpDetails.Controls.Add(this.label13);
            this.grpDetails.Controls.Add(this.cmbManType);
            this.grpDetails.Controls.Add(this.txtDept);
            this.grpDetails.Controls.Add(this.label12);
            this.grpDetails.Controls.Add(this.rtbReason);
            this.grpDetails.Controls.Add(this.dtToHr);
            this.grpDetails.Controls.Add(this.lblMTo);
            this.grpDetails.Controls.Add(this.dtFromHr);
            this.grpDetails.Controls.Add(this.lblMHours);
            this.grpDetails.Controls.Add(this.lblReason);
            this.grpDetails.Controls.Add(this.lblMType);
            this.grpDetails.Controls.Add(this.txtBranch);
            this.grpDetails.Controls.Add(this.dtPickerManual);
            this.grpDetails.Controls.Add(this.lblMDate);
            this.grpDetails.Controls.Add(this.txtMidName);
            this.grpDetails.Controls.Add(this.label8);
            this.grpDetails.Controls.Add(this.txtFirstName);
            this.grpDetails.Controls.Add(this.txtLastName);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.Label3);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.txtEmpNo);
            this.grpDetails.Controls.Add(this.Label1);
            this.grpDetails.Enabled = false;
            this.grpDetails.Location = new System.Drawing.Point(10, 57);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(353, 395);
            this.grpDetails.TabIndex = 27;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Manual Details";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(86, 150);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(237, 20);
            this.txtCompany.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Company:";
            // 
            // cmbManType
            // 
            this.cmbManType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManType.FormattingEnabled = true;
            this.cmbManType.Items.AddRange(new object[] {
            "TimeIn",
            "TimeOut"});
            this.cmbManType.Location = new System.Drawing.Point(85, 316);
            this.cmbManType.Name = "cmbManType";
            this.cmbManType.Size = new System.Drawing.Size(239, 21);
            this.cmbManType.TabIndex = 42;
            this.cmbManType.SelectedIndexChanged += new System.EventHandler(this.cmbManType_SelectedIndexChanged);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(87, 213);
            this.txtDept.Name = "txtDept";
            this.txtDept.ReadOnly = true;
            this.txtDept.Size = new System.Drawing.Size(237, 20);
            this.txtDept.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Department:";
            // 
            // rtbReason
            // 
            this.rtbReason.Location = new System.Drawing.Point(85, 350);
            this.rtbReason.Name = "rtbReason";
            this.rtbReason.Size = new System.Drawing.Size(238, 35);
            this.rtbReason.TabIndex = 39;
            this.rtbReason.Text = "";
            this.rtbReason.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbReason_KeyPress);
            // 
            // dtToHr
            // 
            this.dtToHr.Location = new System.Drawing.Point(244, 283);
            this.dtToHr.Name = "dtToHr";
            this.dtToHr.Size = new System.Drawing.Size(80, 20);
            this.dtToHr.TabIndex = 38;
            // 
            // lblMTo
            // 
            this.lblMTo.AutoSize = true;
            this.lblMTo.Location = new System.Drawing.Point(193, 286);
            this.lblMTo.Name = "lblMTo";
            this.lblMTo.Size = new System.Drawing.Size(20, 13);
            this.lblMTo.TabIndex = 37;
            this.lblMTo.Text = "To";
            // 
            // dtFromHr
            // 
            this.dtFromHr.Location = new System.Drawing.Point(87, 283);
            this.dtFromHr.Name = "dtFromHr";
            this.dtFromHr.Size = new System.Drawing.Size(80, 20);
            this.dtFromHr.TabIndex = 36;
            // 
            // lblMHours
            // 
            this.lblMHours.AutoSize = true;
            this.lblMHours.Location = new System.Drawing.Point(3, 286);
            this.lblMHours.Name = "lblMHours";
            this.lblMHours.Size = new System.Drawing.Size(76, 13);
            this.lblMHours.TabIndex = 35;
            this.lblMHours.Text = "Manual Hours:";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(32, 349);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(47, 13);
            this.lblReason.TabIndex = 32;
            this.lblReason.Text = "Reason:";
            // 
            // lblMType
            // 
            this.lblMType.AutoSize = true;
            this.lblMType.Location = new System.Drawing.Point(8, 319);
            this.lblMType.Name = "lblMType";
            this.lblMType.Size = new System.Drawing.Size(72, 13);
            this.lblMType.TabIndex = 31;
            this.lblMType.Text = "Manual Type:";
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(87, 182);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.ReadOnly = true;
            this.txtBranch.Size = new System.Drawing.Size(237, 20);
            this.txtBranch.TabIndex = 29;
            // 
            // dtPickerManual
            // 
            this.dtPickerManual.Location = new System.Drawing.Point(87, 247);
            this.dtPickerManual.Name = "dtPickerManual";
            this.dtPickerManual.Size = new System.Drawing.Size(237, 20);
            this.dtPickerManual.TabIndex = 28;
            // 
            // lblMDate
            // 
            this.lblMDate.AutoSize = true;
            this.lblMDate.Location = new System.Drawing.Point(8, 250);
            this.lblMDate.Name = "lblMDate";
            this.lblMDate.Size = new System.Drawing.Size(71, 13);
            this.lblMDate.TabIndex = 27;
            this.lblMDate.Text = "Manual Date:";
            // 
            // txtMidName
            // 
            this.txtMidName.Location = new System.Drawing.Point(87, 118);
            this.txtMidName.Name = "txtMidName";
            this.txtMidName.ReadOnly = true;
            this.txtMidName.Size = new System.Drawing.Size(237, 20);
            this.txtMidName.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(87, 86);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(237, 20);
            this.txtFirstName.TabIndex = 21;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(87, 52);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(237, 20);
            this.txtLastName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Branch:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(18, 88);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Last Name:";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(88, 22);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.ReadOnly = true;
            this.txtEmpNo.Size = new System.Drawing.Size(124, 20);
            this.txtEmpNo.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(73, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Employee No:";
            // 
            // frmManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpEmpList);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Time";
            this.Load += new System.EventHandler(this.frmManual_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpEmpList.ResumeLayout(false);
            this.grpEmpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox grpEmpList;
        internal System.Windows.Forms.DataGridView grdEmployees;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.GroupBox grpDetails;
        internal System.Windows.Forms.TextBox txtMidName;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtEmpNo;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DateTimePicker dtPickerManual;
        internal System.Windows.Forms.Label lblMDate;
        private System.Windows.Forms.RichTextBox rtbReason;
        private System.Windows.Forms.DateTimePicker dtToHr;
        internal System.Windows.Forms.Label lblMTo;
        private System.Windows.Forms.DateTimePicker dtFromHr;
        internal System.Windows.Forms.Label lblMHours;
        internal System.Windows.Forms.Label lblReason;
        internal System.Windows.Forms.Label lblMType;
        internal System.Windows.Forms.TextBox txtBranch;
        internal System.Windows.Forms.TextBox txtDept;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbManType;
        private System.Windows.Forms.ToolStripButton btnSearch;
        internal System.Windows.Forms.TextBox txtCompany;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modify_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Modify;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_MidName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_DayOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manual_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manual_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manual_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
    }
}