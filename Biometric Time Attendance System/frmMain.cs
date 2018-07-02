using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biometric_Time_Attendance_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void employeeRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeReg frmEmployeeReg = new frmEmployeeReg(1);
            frmEmployeeReg.Show();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManual frmManual = new frmManual(1, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            frmManual.Show();
        }

        private void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBranch frmBranch = new frmBranch();
            frmBranch.Show();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompany frmCompany = new frmCompany();
            frmCompany.Show();
        }


        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment frmDepartment = new frmDepartment();
            frmDepartment.Show();
        }

        private void fingerRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmFingerReg frmFingerReg = new frmFingerReg(1, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,string.Empty);
           // frmFingerReg frmFingerReg = new frmFingerReg(1);
            frmFingerReg.Show();
        }

        private void holidayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoliday frmHoliday = new frmHoliday();
            frmHoliday.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocation frmLocation = new frmLocation();
            frmLocation.Show();
        }

        private void timeSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimeLimit frmTimeLimit = new frmTimeLimit();
            frmTimeLimit.Show();
        }

        private void userAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserAccount frmUserAccount = new frmUserAccount();
            frmUserAccount.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
