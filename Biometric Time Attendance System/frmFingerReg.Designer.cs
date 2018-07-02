namespace Biometric_Time_Attendance_System
{
    partial class frmFingerReg
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
            this.Prompt = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.cmbFingerList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnAddFPrint = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Picture4 = new System.Windows.Forms.PictureBox();
            this.Picture3 = new System.Windows.Forms.PictureBox();
            this.Picture2 = new System.Windows.Forms.PictureBox();
            this.Picture1 = new System.Windows.Forms.PictureBox();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Finger_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetails.SuspendLayout();
            this.grpEmpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // Prompt
            // 
            this.Prompt.AutoSize = true;
            this.Prompt.BackColor = System.Drawing.Color.Transparent;
            this.Prompt.Location = new System.Drawing.Point(12, 439);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(16, 13);
            this.Prompt.TabIndex = 12;
            this.Prompt.Text = "...";
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpDetails.Controls.Add(this.txtDept);
            this.grpDetails.Controls.Add(this.txtBranch);
            this.grpDetails.Controls.Add(this.txtCompany);
            this.grpDetails.Controls.Add(this.cmbFingerList);
            this.grpDetails.Controls.Add(this.label7);
            this.grpDetails.Controls.Add(this.label5);
            this.grpDetails.Controls.Add(this.label9);
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
            this.grpDetails.Size = new System.Drawing.Size(438, 249);
            this.grpDetails.TabIndex = 19;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Employee Details";
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(89, 85);
            this.txtDept.Name = "txtDept";
            this.txtDept.ReadOnly = true;
            this.txtDept.Size = new System.Drawing.Size(125, 20);
            this.txtDept.TabIndex = 33;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(89, 54);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.ReadOnly = true;
            this.txtBranch.Size = new System.Drawing.Size(125, 20);
            this.txtBranch.TabIndex = 32;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(89, 23);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(125, 20);
            this.txtCompany.TabIndex = 31;
            // 
            // cmbFingerList
            // 
            this.cmbFingerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFingerList.FormattingEnabled = true;
            this.cmbFingerList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbFingerList.Items.AddRange(new object[] {
            "Left Thumb",
            "Left Index",
            "Left Middle",
            "Left Ring",
            "Left Pinky",
            "Right Thumb",
            "Right Index",
            "Right Middle",
            "Right Ring",
            "Right Pinky"});
            this.cmbFingerList.Location = new System.Drawing.Point(337, 115);
            this.cmbFingerList.Name = "cmbFingerList";
            this.cmbFingerList.Size = new System.Drawing.Size(88, 21);
            this.cmbFingerList.TabIndex = 30;
            this.cmbFingerList.SelectedIndexChanged += new System.EventHandler(this.cmbFingerList_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Finger Use:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Company:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Department:";
            // 
            // txtMidName
            // 
            this.txtMidName.Location = new System.Drawing.Point(88, 216);
            this.txtMidName.Name = "txtMidName";
            this.txtMidName.ReadOnly = true;
            this.txtMidName.Size = new System.Drawing.Size(237, 20);
            this.txtMidName.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(88, 181);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(237, 20);
            this.txtFirstName.TabIndex = 21;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(88, 147);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(237, 20);
            this.txtLastName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Branch:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(18, 183);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Last Name:";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(89, 117);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.ReadOnly = true;
            this.txtEmpNo.Size = new System.Drawing.Size(124, 20);
            this.txtEmpNo.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 120);
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
            this.grpEmpList.Location = new System.Drawing.Point(461, 57);
            this.grpEmpList.Name = "grpEmpList";
            this.grpEmpList.Size = new System.Drawing.Size(275, 392);
            this.grpEmpList.TabIndex = 22;
            this.grpEmpList.TabStop = false;
            this.grpEmpList.Text = "List of Employees who have FingerPrint Sample/s.";
            // 
            // grdEmployees
            // 
            this.grdEmployees.AllowUserToAddRows = false;
            this.grdEmployees.AllowUserToDeleteRows = false;
            this.grdEmployees.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee,
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
            this.Finger_Type});
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
            this.btnSearch,
            this.btnAddFPrint,
            this.btnSave,
            this.btnCancel,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 50);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = global::Biometric_Time_Attendance_System.Properties.Resources.search_person1;
            this.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 55);
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.ToolTipText = "Employee Main List";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddFPrint
            // 
            this.btnAddFPrint.AutoSize = false;
            this.btnAddFPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddFPrint.Enabled = false;
            this.btnAddFPrint.Image = global::Biometric_Time_Attendance_System.Properties.Resources.Fingerprint;
            this.btnAddFPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddFPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFPrint.Name = "btnAddFPrint";
            this.btnAddFPrint.Size = new System.Drawing.Size(50, 55);
            this.btnAddFPrint.ToolTipText = "Enable FingerPrint Scanner";
            this.btnAddFPrint.Click += new System.EventHandler(this.btnAddFPrint_Click);
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 47);
            // 
            // Picture4
            // 
            this.Picture4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Picture4.Location = new System.Drawing.Point(347, 318);
            this.Picture4.Name = "Picture4";
            this.Picture4.Size = new System.Drawing.Size(101, 117);
            this.Picture4.TabIndex = 17;
            this.Picture4.TabStop = false;
            // 
            // Picture3
            // 
            this.Picture3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Picture3.Location = new System.Drawing.Point(233, 318);
            this.Picture3.Name = "Picture3";
            this.Picture3.Size = new System.Drawing.Size(101, 117);
            this.Picture3.TabIndex = 16;
            this.Picture3.TabStop = false;
            // 
            // Picture2
            // 
            this.Picture2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Picture2.Location = new System.Drawing.Point(121, 318);
            this.Picture2.Name = "Picture2";
            this.Picture2.Size = new System.Drawing.Size(101, 117);
            this.Picture2.TabIndex = 15;
            this.Picture2.TabStop = false;
            // 
            // Picture1
            // 
            this.Picture1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Picture1.Location = new System.Drawing.Point(10, 318);
            this.Picture1.Name = "Picture1";
            this.Picture1.Size = new System.Drawing.Size(101, 117);
            this.Picture1.TabIndex = 14;
            this.Picture1.TabStop = false;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "EmpName";
            this.Employee.HeaderText = "Employee";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.Width = 250;
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
            // Finger_Type
            // 
            this.Finger_Type.DataPropertyName = "Finger_Type";
            this.Finger_Type.HeaderText = "Finger_Type";
            this.Finger_Type.Name = "Finger_Type";
            this.Finger_Type.ReadOnly = true;
            this.Finger_Type.Visible = false;
            // 
            // frmFingerReg
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpEmpList);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.Picture4);
            this.Controls.Add(this.Picture3);
            this.Controls.Add(this.Picture2);
            this.Controls.Add(this.Picture1);
            this.Controls.Add(this.Prompt);
            this.Name = "frmFingerReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register FingerPrint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpEmpList.ResumeLayout(false);
            this.grpEmpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Prompt;
        internal System.Windows.Forms.GroupBox grpDetails;
        internal System.Windows.Forms.TextBox txtEmpNo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox Picture4;
        internal System.Windows.Forms.PictureBox Picture3;
        internal System.Windows.Forms.PictureBox Picture2;
        internal System.Windows.Forms.PictureBox Picture1;
        private System.Windows.Forms.GroupBox grpEmpList;
        internal System.Windows.Forms.DataGridView grdEmployees;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtMidName;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnAddFPrint;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbFingerList;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton btnSearch;
        internal System.Windows.Forms.TextBox txtDept;
        internal System.Windows.Forms.TextBox txtBranch;
        internal System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Finger_Type;
    }
}

