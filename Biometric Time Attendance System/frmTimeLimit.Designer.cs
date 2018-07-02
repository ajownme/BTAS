namespace Biometric_Time_Attendance_System
{
    partial class frmTimeLimit
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
            this.trvTime = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pnl1stMealBTime = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp1MealBStart = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtp1MealBEnd = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnl1stRegTime = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRegEnd1 = new System.Windows.Forms.DateTimePicker();
            this.dtpRegStart1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl1stShortBTime = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp1ShortBLength = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.grp1morningsbreak = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp1ShortBStartFisrtHalf = new System.Windows.Forms.DateTimePicker();
            this.dtp1ShortBEndFisrtHalf = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.grp1afternoonsbreak = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp1ShortBStartSecondHalf = new System.Windows.Forms.DateTimePicker();
            this.dtp1ShortBEndSecondHalf = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblempty = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.pnl1stMealBTime.SuspendLayout();
            this.pnl1stRegTime.SuspendLayout();
            this.pnl1stShortBTime.SuspendLayout();
            this.grp1morningsbreak.SuspendLayout();
            this.grp1afternoonsbreak.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvTime
            // 
            this.trvTime.Location = new System.Drawing.Point(34, 73);
            this.trvTime.Name = "trvTime";
            this.trvTime.Size = new System.Drawing.Size(204, 361);
            this.trvTime.TabIndex = 0;
            this.trvTime.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvTime_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnCancel,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1304, 50);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 47);
            // 
            // pnl1stMealBTime
            // 
            this.pnl1stMealBTime.Controls.Add(this.label12);
            this.pnl1stMealBTime.Controls.Add(this.dtp1MealBStart);
            this.pnl1stMealBTime.Controls.Add(this.label14);
            this.pnl1stMealBTime.Controls.Add(this.label11);
            this.pnl1stMealBTime.Controls.Add(this.label17);
            this.pnl1stMealBTime.Controls.Add(this.dtp1MealBEnd);
            this.pnl1stMealBTime.Controls.Add(this.label13);
            this.pnl1stMealBTime.Controls.Add(this.dateTimePicker1);
            this.pnl1stMealBTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl1stMealBTime.Location = new System.Drawing.Point(448, 458);
            this.pnl1stMealBTime.Name = "pnl1stMealBTime";
            this.pnl1stMealBTime.Size = new System.Drawing.Size(425, 365);
            this.pnl1stMealBTime.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Start Time:";
            // 
            // dtp1MealBStart
            // 
            this.dtp1MealBStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp1MealBStart.Location = new System.Drawing.Point(157, 78);
            this.dtp1MealBStart.Name = "dtp1MealBStart";
            this.dtp1MealBStart.ShowUpDown = true;
            this.dtp1MealBStart.Size = new System.Drawing.Size(140, 22);
            this.dtp1MealBStart.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Meal Break Length:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(206, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "minute/s";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 322);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(368, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "The first Meal Break time or the default Meal Break work time.";
            // 
            // dtp1MealBEnd
            // 
            this.dtp1MealBEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp1MealBEnd.Location = new System.Drawing.Point(157, 115);
            this.dtp1MealBEnd.Name = "dtp1MealBEnd";
            this.dtp1MealBEnd.ShowUpDown = true;
            this.dtp1MealBEnd.Size = new System.Drawing.Size(140, 22);
            this.dtp1MealBEnd.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(63, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "End Time:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(49, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // pnl1stRegTime
            // 
            this.pnl1stRegTime.Controls.Add(this.label3);
            this.pnl1stRegTime.Controls.Add(this.label1);
            this.pnl1stRegTime.Controls.Add(this.dtpRegEnd1);
            this.pnl1stRegTime.Controls.Add(this.dtpRegStart1);
            this.pnl1stRegTime.Controls.Add(this.label2);
            this.pnl1stRegTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl1stRegTime.Location = new System.Drawing.Point(258, 73);
            this.pnl1stRegTime.Name = "pnl1stRegTime";
            this.pnl1stRegTime.Size = new System.Drawing.Size(425, 365);
            this.pnl1stRegTime.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "The first regular time or the default work time.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Time:";
            // 
            // dtpRegEnd1
            // 
            this.dtpRegEnd1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRegEnd1.Location = new System.Drawing.Point(155, 132);
            this.dtpRegEnd1.Name = "dtpRegEnd1";
            this.dtpRegEnd1.ShowUpDown = true;
            this.dtpRegEnd1.Size = new System.Drawing.Size(140, 22);
            this.dtpRegEnd1.TabIndex = 8;
            // 
            // dtpRegStart1
            // 
            this.dtpRegStart1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRegStart1.Location = new System.Drawing.Point(155, 95);
            this.dtpRegStart1.Name = "dtpRegStart1";
            this.dtpRegStart1.ShowUpDown = true;
            this.dtpRegStart1.Size = new System.Drawing.Size(140, 22);
            this.dtpRegStart1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "End Time:";
            // 
            // pnl1stShortBTime
            // 
            this.pnl1stShortBTime.Controls.Add(this.label10);
            this.pnl1stShortBTime.Controls.Add(this.label9);
            this.pnl1stShortBTime.Controls.Add(this.dtp1ShortBLength);
            this.pnl1stShortBTime.Controls.Add(this.label4);
            this.pnl1stShortBTime.Controls.Add(this.grp1morningsbreak);
            this.pnl1stShortBTime.Controls.Add(this.grp1afternoonsbreak);
            this.pnl1stShortBTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl1stShortBTime.Location = new System.Drawing.Point(879, 448);
            this.pnl1stShortBTime.Name = "pnl1stShortBTime";
            this.pnl1stShortBTime.Size = new System.Drawing.Size(425, 365);
            this.pnl1stShortBTime.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "minute/s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Short Break Length:";
            // 
            // dtp1ShortBLength
            // 
            this.dtp1ShortBLength.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp1ShortBLength.Location = new System.Drawing.Point(150, 24);
            this.dtp1ShortBLength.Name = "dtp1ShortBLength";
            this.dtp1ShortBLength.ShowUpDown = true;
            this.dtp1ShortBLength.Size = new System.Drawing.Size(49, 22);
            this.dtp1ShortBLength.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "The first Short Break time or the default Short Break work time.";
            // 
            // grp1morningsbreak
            // 
            this.grp1morningsbreak.Controls.Add(this.label6);
            this.grp1morningsbreak.Controls.Add(this.dtp1ShortBStartFisrtHalf);
            this.grp1morningsbreak.Controls.Add(this.dtp1ShortBEndFisrtHalf);
            this.grp1morningsbreak.Controls.Add(this.label5);
            this.grp1morningsbreak.Location = new System.Drawing.Point(34, 71);
            this.grp1morningsbreak.Name = "grp1morningsbreak";
            this.grp1morningsbreak.Size = new System.Drawing.Size(352, 101);
            this.grp1morningsbreak.TabIndex = 11;
            this.grp1morningsbreak.TabStop = false;
            this.grp1morningsbreak.Text = "Morning Short Break";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Start Time:";
            // 
            // dtp1ShortBStartFisrtHalf
            // 
            this.dtp1ShortBStartFisrtHalf.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp1ShortBStartFisrtHalf.Location = new System.Drawing.Point(116, 29);
            this.dtp1ShortBStartFisrtHalf.Name = "dtp1ShortBStartFisrtHalf";
            this.dtp1ShortBStartFisrtHalf.ShowUpDown = true;
            this.dtp1ShortBStartFisrtHalf.Size = new System.Drawing.Size(140, 22);
            this.dtp1ShortBStartFisrtHalf.TabIndex = 1;
            // 
            // dtp1ShortBEndFisrtHalf
            // 
            this.dtp1ShortBEndFisrtHalf.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp1ShortBEndFisrtHalf.Location = new System.Drawing.Point(116, 63);
            this.dtp1ShortBEndFisrtHalf.Name = "dtp1ShortBEndFisrtHalf";
            this.dtp1ShortBEndFisrtHalf.ShowUpDown = true;
            this.dtp1ShortBEndFisrtHalf.Size = new System.Drawing.Size(140, 22);
            this.dtp1ShortBEndFisrtHalf.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "End Time:";
            // 
            // grp1afternoonsbreak
            // 
            this.grp1afternoonsbreak.Controls.Add(this.label7);
            this.grp1afternoonsbreak.Controls.Add(this.dtp1ShortBStartSecondHalf);
            this.grp1afternoonsbreak.Controls.Add(this.dtp1ShortBEndSecondHalf);
            this.grp1afternoonsbreak.Controls.Add(this.label8);
            this.grp1afternoonsbreak.Location = new System.Drawing.Point(34, 189);
            this.grp1afternoonsbreak.Name = "grp1afternoonsbreak";
            this.grp1afternoonsbreak.Size = new System.Drawing.Size(352, 101);
            this.grp1afternoonsbreak.TabIndex = 12;
            this.grp1afternoonsbreak.TabStop = false;
            this.grp1afternoonsbreak.Text = "Afternoon Short Break";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Start Time:";
            // 
            // dtp1ShortBStartSecondHalf
            // 
            this.dtp1ShortBStartSecondHalf.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp1ShortBStartSecondHalf.Location = new System.Drawing.Point(116, 28);
            this.dtp1ShortBStartSecondHalf.Name = "dtp1ShortBStartSecondHalf";
            this.dtp1ShortBStartSecondHalf.ShowUpDown = true;
            this.dtp1ShortBStartSecondHalf.Size = new System.Drawing.Size(140, 22);
            this.dtp1ShortBStartSecondHalf.TabIndex = 1;
            // 
            // dtp1ShortBEndSecondHalf
            // 
            this.dtp1ShortBEndSecondHalf.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp1ShortBEndSecondHalf.Location = new System.Drawing.Point(116, 65);
            this.dtp1ShortBEndSecondHalf.Name = "dtp1ShortBEndSecondHalf";
            this.dtp1ShortBEndSecondHalf.ShowUpDown = true;
            this.dtp1ShortBEndSecondHalf.Size = new System.Drawing.Size(140, 22);
            this.dtp1ShortBEndSecondHalf.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "End Time:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblempty);
            this.panel1.Location = new System.Drawing.Point(12, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 365);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // lblempty
            // 
            this.lblempty.AutoSize = true;
            this.lblempty.Location = new System.Drawing.Point(61, 136);
            this.lblempty.Name = "lblempty";
            this.lblempty.Size = new System.Drawing.Size(45, 13);
            this.lblempty.TabIndex = 0;
            this.lblempty.Text = "lblempty";
            // 
            // frmTimeLimit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1304, 741);
            this.Controls.Add(this.pnl1stMealBTime);
            this.Controls.Add(this.pnl1stShortBTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl1stRegTime);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.trvTime);
            this.Name = "frmTimeLimit";
            this.Text = "Time Limit";
            this.Load += new System.EventHandler(this.frmTimeLimit_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnl1stMealBTime.ResumeLayout(false);
            this.pnl1stMealBTime.PerformLayout();
            this.pnl1stRegTime.ResumeLayout(false);
            this.pnl1stRegTime.PerformLayout();
            this.pnl1stShortBTime.ResumeLayout(false);
            this.pnl1stShortBTime.PerformLayout();
            this.grp1morningsbreak.ResumeLayout(false);
            this.grp1morningsbreak.PerformLayout();
            this.grp1afternoonsbreak.ResumeLayout(false);
            this.grp1afternoonsbreak.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvTime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel pnl1stMealBTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp1MealBStart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtp1MealBEnd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnl1stRegTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpRegEnd1;
        private System.Windows.Forms.DateTimePicker dtpRegStart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl1stShortBTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp1ShortBLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grp1morningsbreak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp1ShortBStartFisrtHalf;
        private System.Windows.Forms.DateTimePicker dtp1ShortBEndFisrtHalf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grp1afternoonsbreak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp1ShortBStartSecondHalf;
        private System.Windows.Forms.DateTimePicker dtp1ShortBEndSecondHalf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblempty;
    }
}