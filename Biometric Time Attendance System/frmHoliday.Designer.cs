namespace Biometric_Time_Attendance_System
{
    partial class frmHoliday
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
            this.dtpHoliday = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvHoliday = new System.Windows.Forms.DataGridView();
            this.Holiday_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Modify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Holiday_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Holiday_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Holiday_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.grpNew = new System.Windows.Forms.GroupBox();
            this.cmbHolidayType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHolidayName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoliday)).BeginInit();
            this.grpNew.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpHoliday
            // 
            this.dtpHoliday.Location = new System.Drawing.Point(96, 39);
            this.dtpHoliday.Name = "dtpHoliday";
            this.dtpHoliday.Size = new System.Drawing.Size(127, 20);
            this.dtpHoliday.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Date:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(63, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(113, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // dgvHoliday
            // 
            this.dgvHoliday.AllowUserToAddRows = false;
            this.dgvHoliday.AllowUserToDeleteRows = false;
            this.dgvHoliday.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvHoliday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoliday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Holiday_Name,
            this.Created_By,
            this.Date_Created,
            this.Modify_By,
            this.Date_Modify,
            this.Deleted,
            this.Holiday_ID,
            this.Holiday_Type,
            this.Holiday_Date});
            this.dgvHoliday.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvHoliday.Location = new System.Drawing.Point(12, 45);
            this.dgvHoliday.Name = "dgvHoliday";
            this.dgvHoliday.ReadOnly = true;
            this.dgvHoliday.RowHeadersWidth = 20;
            this.dgvHoliday.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHoliday.Size = new System.Drawing.Size(211, 129);
            this.dgvHoliday.TabIndex = 18;
            this.dgvHoliday.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoliday_CellClick);
            // 
            // Holiday_Name
            // 
            this.Holiday_Name.DataPropertyName = "Holiday_Name";
            this.Holiday_Name.HeaderText = "HolidayName";
            this.Holiday_Name.Name = "Holiday_Name";
            this.Holiday_Name.ReadOnly = true;
            this.Holiday_Name.Width = 200;
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
            // Holiday_ID
            // 
            this.Holiday_ID.DataPropertyName = "Holiday_ID";
            this.Holiday_ID.HeaderText = "Holiday_ID";
            this.Holiday_ID.Name = "Holiday_ID";
            this.Holiday_ID.ReadOnly = true;
            this.Holiday_ID.Visible = false;
            // 
            // Holiday_Type
            // 
            this.Holiday_Type.DataPropertyName = "Holiday_Type";
            this.Holiday_Type.HeaderText = "Holiday_Type";
            this.Holiday_Type.Name = "Holiday_Type";
            this.Holiday_Type.ReadOnly = true;
            this.Holiday_Type.Visible = false;
            // 
            // Holiday_Date
            // 
            this.Holiday_Date.DataPropertyName = "Holiday_Date";
            this.Holiday_Date.HeaderText = "Holiday_Date";
            this.Holiday_Date.Name = "Holiday_Date";
            this.Holiday_Date.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Search:";
            // 
            // grpNew
            // 
            this.grpNew.Controls.Add(this.cmbHolidayType);
            this.grpNew.Controls.Add(this.label1);
            this.grpNew.Controls.Add(this.txtHolidayName);
            this.grpNew.Controls.Add(this.label4);
            this.grpNew.Controls.Add(this.dtpHoliday);
            this.grpNew.Controls.Add(this.label2);
            this.grpNew.Location = new System.Drawing.Point(15, 52);
            this.grpNew.Name = "grpNew";
            this.grpNew.Size = new System.Drawing.Size(239, 92);
            this.grpNew.TabIndex = 47;
            this.grpNew.TabStop = false;
            // 
            // cmbHolidayType
            // 
            this.cmbHolidayType.FormattingEnabled = true;
            this.cmbHolidayType.Items.AddRange(new object[] {
            "Regular Holiday",
            "Special Non-Working Holiday"});
            this.cmbHolidayType.Location = new System.Drawing.Point(97, 63);
            this.cmbHolidayType.Name = "cmbHolidayType";
            this.cmbHolidayType.Size = new System.Drawing.Size(126, 21);
            this.cmbHolidayType.TabIndex = 46;
            this.cmbHolidayType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHolidayType_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Holiday Name:";
            // 
            // txtHolidayName
            // 
            this.txtHolidayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHolidayName.Location = new System.Drawing.Point(97, 13);
            this.txtHolidayName.Name = "txtHolidayName";
            this.txtHolidayName.Size = new System.Drawing.Size(126, 21);
            this.txtHolidayName.TabIndex = 29;
            this.txtHolidayName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHolidayName_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Enabled = false;
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
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.Enabled = false;
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
            this.toolStrip1.Size = new System.Drawing.Size(268, 50);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 47);
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.dgvHoliday);
            this.grpSearch.Controls.Add(this.label6);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Location = new System.Drawing.Point(15, 150);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(239, 186);
            this.grpSearch.TabIndex = 48;
            this.grpSearch.TabStop = false;
            // 
            // frmHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(268, 341);
            this.Controls.Add(this.grpNew);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpSearch);
            this.Name = "frmHoliday";
            this.Text = "frmHoliday";
            this.Load += new System.EventHandler(this.frmHoliday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoliday)).EndInit();
            this.grpNew.ResumeLayout(false);
            this.grpNew.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHoliday;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.DataGridView dgvHoliday;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpNew;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtHolidayName;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.ComboBox cmbHolidayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Holiday_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modify_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Modify;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Holiday_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Holiday_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Holiday_Date;
    }
}