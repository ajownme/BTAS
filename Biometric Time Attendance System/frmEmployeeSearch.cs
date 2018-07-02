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
    public partial class frmEmployeeSearch  : Form  
    {
        DataTable EmpDT = new DataTable();
        GetDataDB gdt = new GetDataDB();
        string strWhereFrom { get; set; }
        public frmEmployeeSearch(string whereFrom)
        {
            InitializeComponent();
            strWhereFrom = whereFrom;
        }

        private void frmEmployeeSearch_Load(object sender, EventArgs e)
        {
            LoadToGrid();
            //frmFingerReg frmFingerReg = new frmFingerReg(1,
            // string.Empty,
            //   string.Empty,
            //    string.Empty,
            //  string.Empty,
            //    string.Empty,
            //   string.Empty,
            //   string.Empty
            //   );

            //frmFingerReg.Close();
        }

        private void LoadToGrid()
        {
            EmpDT = gdt.GetEmployee(@"SELECT   CONCAT (Employee.Emp_LastName ,', ', Employee.Emp_FirstName,' ', Employee.Emp_MidName) as EmpName , Employee.Created_By, Employee.Date_Created, Employee.Modify_By, Employee.Date_Modify, Employee.Deleted, Employee.Emp_ID, Employee.Emp_LastName, Employee.Emp_FirstName, " +
                           @" Employee.Emp_MidName, Employee.Company_ID, Employee.Branch_ID, Employee.Department_ID, Employee.Emp_Type, Employee.Emp_DayOff, Employee.Emp_Shift," +
                           @" Employee.FirstTimeFrom, Employee.FirstTimeTo, Employee.SecondTimeFrom, Employee.SecondTimeTo, Employee.ThirdTimeFrom, Employee.ThirdTimeTo, Company.Company_Name, Branch.Branch_Name, " +
                           @" Department.Department_Name FROM   Employee Left JOIN " +
                           @" Company ON Employee.Company_ID = Company.Company_ID  Left JOIN" +
                           @" Branch ON Employee.Branch_ID = Branch.Branch_ID INNER JOIN" +
                           @" Department ON Employee.Department_ID = Department.Department_ID " +
                           @"Where  Emp_LastName like '%" + txtSearch.Text + "%' or " +
                           @"Emp_FirstName like '%" + txtSearch.Text + "%' or " +
                           @"Emp_MidName like '%" + txtSearch.Text + "%' or " +
                           @"Emp_ID like '%" + txtSearch.Text + "%' and " +
                           @" Employee.Deleted =  0 " +
                           @"ORDER BY Employee.Emp_ID ");
            grdEmployees.DataSource = EmpDT;
            grdEmployees.Refresh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadToGrid();
        }

      
        private void grdEmployees_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (strWhereFrom == "frmFingerReg")
            {
                frmFingerReg frmFingerReg = new frmFingerReg(1,
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_ID"].ToString(),
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_LastName"].ToString(),
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_FirstName"].ToString(),
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_MidName"].ToString(),
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Company_Name"].ToString(),
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Branch_Name"].ToString(),
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Department_Name"].ToString(),
                "Search");
                frmFingerReg.Show();
                this.Close();
            }
            else if (strWhereFrom == "frmManual")
            {

                frmManual frmManual = new frmManual(1,
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_ID"].ToString(),
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_LastName"].ToString(),
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_FirstName"].ToString(),
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_MidName"].ToString(),
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Company_Name"].ToString(),
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Branch_Name"].ToString(),
                EmpDT.Rows[grdEmployees.CurrentRow.Index]["Department_Name"].ToString(),
                "Search");
                frmManual.Show();
                this.Close();

            }
        }

     
    }
}
