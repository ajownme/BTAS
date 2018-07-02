namespace Biometric_Time_Attendance_System
{
    partial class frmEmployeeReg
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.rdbInactive = new System.Windows.Forms.RadioButton();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbEmployment = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.dtPicker2ndTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo2 = new System.Windows.Forms.Label();
            this.dtPicker2ndFrom = new System.Windows.Forms.DateTimePicker();
            this.lblWorkHours2 = new System.Windows.Forms.Label();
            this.dtPicker3rdTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo3 = new System.Windows.Forms.Label();
            this.dtPicker3rdFrom = new System.Windows.Forms.DateTimePicker();
            this.lblWorkHours3 = new System.Windows.Forms.Label();
            this.rdbShiftingTime = new System.Windows.Forms.RadioButton();
            this.rdbRegularTime = new System.Windows.Forms.RadioButton();
            this.cmbDayOff = new System.Windows.Forms.ComboBox();
            this.dtPicker1stTo = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtPicker1stFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.txtMidName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
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
            this.FirstTimeFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstTimeTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondTimeFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondTimeTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdTimeFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdTimeTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.grpEmpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
            this.SuspendLayout();
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
            this.txtSearch.Size = new System.Drawing.Size(139, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
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
            this.toolStrip1.TabIndex = 32;
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
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbCompany.Location = new System.Drawing.Point(84, 27);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(240, 21);
            this.cmbCompany.TabIndex = 28;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Company:";
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpDetails.Controls.Add(this.grpStatus);
            this.grpDetails.Controls.Add(this.cmbBranch);
            this.grpDetails.Controls.Add(this.cmbEmployment);
            this.grpDetails.Controls.Add(this.label17);
            this.grpDetails.Controls.Add(this.lblShift);
            this.grpDetails.Controls.Add(this.cmbShift);
            this.grpDetails.Controls.Add(this.dtPicker2ndTo);
            this.grpDetails.Controls.Add(this.lblTo2);
            this.grpDetails.Controls.Add(this.dtPicker2ndFrom);
            this.grpDetails.Controls.Add(this.lblWorkHours2);
            this.grpDetails.Controls.Add(this.dtPicker3rdTo);
            this.grpDetails.Controls.Add(this.lblTo3);
            this.grpDetails.Controls.Add(this.dtPicker3rdFrom);
            this.grpDetails.Controls.Add(this.lblWorkHours3);
            this.grpDetails.Controls.Add(this.rdbShiftingTime);
            this.grpDetails.Controls.Add(this.rdbRegularTime);
            this.grpDetails.Controls.Add(this.cmbDayOff);
            this.grpDetails.Controls.Add(this.dtPicker1stTo);
            this.grpDetails.Controls.Add(this.label11);
            this.grpDetails.Controls.Add(this.dtPicker1stFrom);
            this.grpDetails.Controls.Add(this.label7);
            this.grpDetails.Controls.Add(this.label13);
            this.grpDetails.Controls.Add(this.cmbCompany);
            this.grpDetails.Controls.Add(this.label5);
            this.grpDetails.Controls.Add(this.label9);
            this.grpDetails.Controls.Add(this.cmbDepartment);
            this.grpDetails.Controls.Add(this.txtMidName);
            this.grpDetails.Controls.Add(this.label8);
            this.grpDetails.Controls.Add(this.txtFirstName);
            this.grpDetails.Controls.Add(this.txtLastName);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.Label3);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.txtEmpNo);
            this.grpDetails.Controls.Add(this.Label1);
            this.grpDetails.Location = new System.Drawing.Point(10, 61);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(438, 379);
            this.grpDetails.TabIndex = 30;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Employee Details";
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.rdbInactive);
            this.grpStatus.Controls.Add(this.rdbActive);
            this.grpStatus.Location = new System.Drawing.Point(348, 19);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(66, 59);
            this.grpStatus.TabIndex = 65;
            this.grpStatus.TabStop = false;
            // 
            // rdbInactive
            // 
            this.rdbInactive.AutoSize = true;
            this.rdbInactive.Location = new System.Drawing.Point(6, 32);
            this.rdbInactive.Name = "rdbInactive";
            this.rdbInactive.Size = new System.Drawing.Size(63, 17);
            this.rdbInactive.TabIndex = 66;
            this.rdbInactive.TabStop = true;
            this.rdbInactive.Text = "Inactive";
            this.rdbInactive.UseVisualStyleBackColor = true;
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Checked = true;
            this.rdbActive.Location = new System.Drawing.Point(6, 12);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(55, 17);
            this.rdbActive.TabIndex = 65;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "Active";
            this.rdbActive.UseVisualStyleBackColor = true;
            this.rdbActive.CheckedChanged += new System.EventHandler(this.rdbActive_CheckedChanged);
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(88, 190);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(237, 21);
            this.cmbBranch.TabIndex = 64;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged_1);
            // 
            // cmbEmployment
            // 
            this.cmbEmployment.FormattingEnabled = true;
            this.cmbEmployment.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbEmployment.Items.AddRange(new object[] {
            "Full-Time",
            "Part-Time"});
            this.cmbEmployment.Location = new System.Drawing.Point(87, 255);
            this.cmbEmployment.Name = "cmbEmployment";
            this.cmbEmployment.Size = new System.Drawing.Size(87, 21);
            this.cmbEmployment.TabIndex = 63;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "Employment:";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(85, 345);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(31, 13);
            this.lblShift.TabIndex = 61;
            this.lblShift.Text = "Shift:";
            // 
            // cmbShift
            // 
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbShift.Location = new System.Drawing.Point(116, 342);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(55, 21);
            this.cmbShift.TabIndex = 60;
            this.cmbShift.SelectedIndexChanged += new System.EventHandler(this.cmbShift_SelectedIndexChanged);
            // 
            // dtPicker2ndTo
            // 
            this.dtPicker2ndTo.Location = new System.Drawing.Point(348, 316);
            this.dtPicker2ndTo.Name = "dtPicker2ndTo";
            this.dtPicker2ndTo.Size = new System.Drawing.Size(66, 20);
            this.dtPicker2ndTo.TabIndex = 59;
            // 
            // lblTo2
            // 
            this.lblTo2.AutoSize = true;
            this.lblTo2.Location = new System.Drawing.Point(328, 319);
            this.lblTo2.Name = "lblTo2";
            this.lblTo2.Size = new System.Drawing.Size(20, 13);
            this.lblTo2.TabIndex = 58;
            this.lblTo2.Text = "To";
            // 
            // dtPicker2ndFrom
            // 
            this.dtPicker2ndFrom.Location = new System.Drawing.Point(257, 316);
            this.dtPicker2ndFrom.Name = "dtPicker2ndFrom";
            this.dtPicker2ndFrom.Size = new System.Drawing.Size(67, 20);
            this.dtPicker2ndFrom.TabIndex = 57;
            this.dtPicker2ndFrom.ValueChanged += new System.EventHandler(this.dtPicker2ndFrom_ValueChanged);
            // 
            // lblWorkHours2
            // 
            this.lblWorkHours2.AutoSize = true;
            this.lblWorkHours2.Location = new System.Drawing.Point(188, 319);
            this.lblWorkHours2.Name = "lblWorkHours2";
            this.lblWorkHours2.Size = new System.Drawing.Size(67, 13);
            this.lblWorkHours2.TabIndex = 56;
            this.lblWorkHours2.Text = "Work Hours:";
            // 
            // dtPicker3rdTo
            // 
            this.dtPicker3rdTo.Location = new System.Drawing.Point(348, 346);
            this.dtPicker3rdTo.Name = "dtPicker3rdTo";
            this.dtPicker3rdTo.Size = new System.Drawing.Size(66, 20);
            this.dtPicker3rdTo.TabIndex = 55;
            this.dtPicker3rdTo.DropDown += new System.EventHandler(this.dtPicker3rdTo_DropDown);
            // 
            // lblTo3
            // 
            this.lblTo3.AutoSize = true;
            this.lblTo3.Location = new System.Drawing.Point(328, 349);
            this.lblTo3.Name = "lblTo3";
            this.lblTo3.Size = new System.Drawing.Size(20, 13);
            this.lblTo3.TabIndex = 54;
            this.lblTo3.Text = "To";
            // 
            // dtPicker3rdFrom
            // 
            this.dtPicker3rdFrom.Location = new System.Drawing.Point(257, 346);
            this.dtPicker3rdFrom.Name = "dtPicker3rdFrom";
            this.dtPicker3rdFrom.Size = new System.Drawing.Size(67, 20);
            this.dtPicker3rdFrom.TabIndex = 53;
            this.dtPicker3rdFrom.DropDown += new System.EventHandler(this.dtPicker3rdFrom_DropDown);
            // 
            // lblWorkHours3
            // 
            this.lblWorkHours3.AutoSize = true;
            this.lblWorkHours3.Location = new System.Drawing.Point(188, 349);
            this.lblWorkHours3.Name = "lblWorkHours3";
            this.lblWorkHours3.Size = new System.Drawing.Size(67, 13);
            this.lblWorkHours3.TabIndex = 52;
            this.lblWorkHours3.Text = "Work Hours:";
            // 
            // rdbShiftingTime
            // 
            this.rdbShiftingTime.AutoSize = true;
            this.rdbShiftingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbShiftingTime.Location = new System.Drawing.Point(87, 313);
            this.rdbShiftingTime.Name = "rdbShiftingTime";
            this.rdbShiftingTime.Size = new System.Drawing.Size(86, 17);
            this.rdbShiftingTime.TabIndex = 51;
            this.rdbShiftingTime.Text = "Shifting Time";
            this.rdbShiftingTime.UseVisualStyleBackColor = true;
            this.rdbShiftingTime.CheckedChanged += new System.EventHandler(this.rdbShiftingTime_CheckedChanged);
            // 
            // rdbRegularTime
            // 
            this.rdbRegularTime.AutoSize = true;
            this.rdbRegularTime.Checked = true;
            this.rdbRegularTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRegularTime.Location = new System.Drawing.Point(87, 288);
            this.rdbRegularTime.Name = "rdbRegularTime";
            this.rdbRegularTime.Size = new System.Drawing.Size(88, 17);
            this.rdbRegularTime.TabIndex = 50;
            this.rdbRegularTime.TabStop = true;
            this.rdbRegularTime.Text = "Regular Time";
            this.rdbRegularTime.UseVisualStyleBackColor = true;
            this.rdbRegularTime.CheckedChanged += new System.EventHandler(this.rdbRegularTime_CheckedChanged);
            // 
            // cmbDayOff
            // 
            this.cmbDayOff.FormattingEnabled = true;
            this.cmbDayOff.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbDayOff.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturdaya"});
            this.cmbDayOff.Location = new System.Drawing.Point(257, 255);
            this.cmbDayOff.Name = "cmbDayOff";
            this.cmbDayOff.Size = new System.Drawing.Size(68, 21);
            this.cmbDayOff.TabIndex = 49;
            // 
            // dtPicker1stTo
            // 
            this.dtPicker1stTo.Location = new System.Drawing.Point(348, 287);
            this.dtPicker1stTo.Name = "dtPicker1stTo";
            this.dtPicker1stTo.Size = new System.Drawing.Size(66, 20);
            this.dtPicker1stTo.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "To";
            // 
            // dtPicker1stFrom
            // 
            this.dtPicker1stFrom.Location = new System.Drawing.Point(257, 287);
            this.dtPicker1stFrom.Name = "dtPicker1stFrom";
            this.dtPicker1stFrom.Size = new System.Drawing.Size(67, 20);
            this.dtPicker1stFrom.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Work Hours:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(212, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "DayOff:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Department:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbDepartment.Location = new System.Drawing.Point(87, 223);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(237, 21);
            this.cmbDepartment.TabIndex = 24;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // txtMidName
            // 
            this.txtMidName.Location = new System.Drawing.Point(87, 156);
            this.txtMidName.Name = "txtMidName";
            this.txtMidName.Size = new System.Drawing.Size(237, 20);
            this.txtMidName.TabIndex = 23;
            this.txtMidName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMidName_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(87, 121);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(237, 20);
            this.txtFirstName.TabIndex = 21;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(87, 87);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(237, 20);
            this.txtLastName.TabIndex = 20;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Branch:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(18, 123);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Last Name:";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(87, 58);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(238, 20);
            this.txtEmpNo.TabIndex = 6;
            this.txtEmpNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpNo_KeyPress);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 60);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(73, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Employee No:";
            // 
            // grpEmpList
            // 
            this.grpEmpList.BackColor = System.Drawing.Color.Transparent;
            this.grpEmpList.Controls.Add(this.grdEmployees);
            this.grpEmpList.Controls.Add(this.label6);
            this.grpEmpList.Controls.Add(this.txtSearch);
            this.grpEmpList.Location = new System.Drawing.Point(461, 61);
            this.grpEmpList.Name = "grpEmpList";
            this.grpEmpList.Size = new System.Drawing.Size(275, 392);
            this.grpEmpList.TabIndex = 31;
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
            this.FirstTimeFrom,
            this.FirstTimeTo,
            this.SecondTimeFrom,
            this.SecondTimeTo,
            this.ThirdTimeFrom,
            this.ThirdTimeTo,
            this.Emp_Status,
            this.Company_Name,
            this.Branch_Name,
            this.Department_Name});
            this.grdEmployees.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdEmployees.Location = new System.Drawing.Point(12, 54);
            this.grdEmployees.Name = "grdEmployees";
            this.grdEmployees.ReadOnly = true;
            this.grdEmployees.RowHeadersWidth = 20;
            this.grdEmployees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdEmployees.Size = new System.Drawing.Size(253, 324);
            this.grdEmployees.TabIndex = 18;
            this.grdEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmployees_CellClick);
            // 
            // empName
            // 
            this.empName.DataPropertyName = "EmpName";
            this.empName.HeaderText = "Employee";
            this.empName.Name = "empName";
            this.empName.ReadOnly = true;
            this.empName.Width = 250;
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
            // FirstTimeFrom
            // 
            this.FirstTimeFrom.DataPropertyName = "FirstTimeFrom";
            this.FirstTimeFrom.HeaderText = "FirstTimeFrom";
            this.FirstTimeFrom.Name = "FirstTimeFrom";
            this.FirstTimeFrom.ReadOnly = true;
            this.FirstTimeFrom.Visible = false;
            // 
            // FirstTimeTo
            // 
            this.FirstTimeTo.DataPropertyName = "FirstTimeTo";
            this.FirstTimeTo.HeaderText = "FirstTimeTo";
            this.FirstTimeTo.Name = "FirstTimeTo";
            this.FirstTimeTo.ReadOnly = true;
            this.FirstTimeTo.Visible = false;
            // 
            // SecondTimeFrom
            // 
            this.SecondTimeFrom.DataPropertyName = "SecondTimeFrom";
            this.SecondTimeFrom.HeaderText = "SecondTimeFrom";
            this.SecondTimeFrom.Name = "SecondTimeFrom";
            this.SecondTimeFrom.ReadOnly = true;
            this.SecondTimeFrom.Visible = false;
            // 
            // SecondTimeTo
            // 
            this.SecondTimeTo.DataPropertyName = "SecondTimeTo";
            this.SecondTimeTo.HeaderText = "SecondTimeTo";
            this.SecondTimeTo.Name = "SecondTimeTo";
            this.SecondTimeTo.ReadOnly = true;
            this.SecondTimeTo.Visible = false;
            // 
            // ThirdTimeFrom
            // 
            this.ThirdTimeFrom.DataPropertyName = "ThirdTimeFrom";
            this.ThirdTimeFrom.HeaderText = "ThirdTimeFrom";
            this.ThirdTimeFrom.Name = "ThirdTimeFrom";
            this.ThirdTimeFrom.ReadOnly = true;
            this.ThirdTimeFrom.Visible = false;
            // 
            // ThirdTimeTo
            // 
            this.ThirdTimeTo.DataPropertyName = "ThirdTimeTo";
            this.ThirdTimeTo.HeaderText = "ThirdTimeTo";
            this.ThirdTimeTo.Name = "ThirdTimeTo";
            this.ThirdTimeTo.ReadOnly = true;
            this.ThirdTimeTo.Visible = false;
            // 
            // Emp_Status
            // 
            this.Emp_Status.DataPropertyName = "Emp_Status";
            this.Emp_Status.HeaderText = "Emp_Status";
            this.Emp_Status.Name = "Emp_Status";
            this.Emp_Status.ReadOnly = true;
            this.Emp_Status.Visible = false;
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
            // frmEmployeeReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpEmpList);
            this.Name = "frmEmployeeReg";
            this.Text = "Register Employee";
            this.Load += new System.EventHandler(this.frmEmployeeReg_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.grpEmpList.ResumeLayout(false);
            this.grpEmpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        internal System.Windows.Forms.ComboBox cmbCompany;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.GroupBox grpDetails;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox cmbDepartment;
        internal System.Windows.Forms.TextBox txtMidName;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtEmpNo;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox grpEmpList;
        internal System.Windows.Forms.DataGridView grdEmployees;
        private System.Windows.Forms.DateTimePicker dtPicker1stTo;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtPicker1stFrom;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtPicker3rdTo;
        internal System.Windows.Forms.Label lblTo3;
        private System.Windows.Forms.DateTimePicker dtPicker3rdFrom;
        internal System.Windows.Forms.Label lblWorkHours3;
        private System.Windows.Forms.RadioButton rdbShiftingTime;
        private System.Windows.Forms.RadioButton rdbRegularTime;
        internal System.Windows.Forms.ComboBox cmbDayOff;
        internal System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.DateTimePicker dtPicker2ndTo;
        internal System.Windows.Forms.Label lblTo2;
        private System.Windows.Forms.DateTimePicker dtPicker2ndFrom;
        internal System.Windows.Forms.Label lblWorkHours2;
        internal System.Windows.Forms.Label lblShift;
        internal System.Windows.Forms.ComboBox cmbEmployment;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton rdbInactive;
        private System.Windows.Forms.RadioButton rdbActive;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstTimeFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstTimeTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondTimeFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondTimeTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdTimeFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdTimeTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department_Name;
    }
}