using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biometric_Time_Attendance_System
{
    class IncrementID
       
    {
        GetDataDB gdt = new GetDataDB();

        int EmployeeID { get; set; }
        int BranchID { get; set; }
        int CompanyID { get; set; }
        int DeptID { get; set; }
        int HolidayID { get; set; }
        int LocationID { get; set; }
        int UAccountID { get; set; }
        public int EmployeeIncrement()
        {
            DataTable dtIncrement = new DataTable();
            dtIncrement = gdt.GetEmployee(@"Select * From Employee ORDER BY Emp_ID Desc");
            switch (dtIncrement.Rows.Count) {
                case 0:
                  return  EmployeeID = 1;

                default:
                   return EmployeeID= int.Parse(dtIncrement.Rows[0]["Emp_ID"].ToString()) + 1;
                    
            }
        }

        public int BranchIncrement()
        {
            DataTable dtIncrement = new DataTable();
            dtIncrement = gdt.GetBranch(@"Select * From Branch ORDER BY Branch_ID Desc");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return BranchID = 1;

                default:
                    return BranchID = int.Parse(dtIncrement.Rows[0]["Branch_ID"].ToString()) + 1;

            }
        }


        public int CompanyIncrement()
        {
            DataTable dtIncrement = new DataTable();
            dtIncrement = gdt.GetCompany(@"Select * From Company ORDER BY Company_ID Desc");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return CompanyID = 1;

                default:
                    return CompanyID = int.Parse(dtIncrement.Rows[0]["Company_ID"].ToString()) + 1;

            }
        }

        public int DepartmentIncrement()
        {
            DataTable dtIncrement = new DataTable();
            dtIncrement = gdt.GetDepartment(@"Select * From Department ORDER BY Department_ID Desc");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return CompanyID = 1;

                default:
                    return CompanyID = int.Parse(dtIncrement.Rows[0]["Department_ID"].ToString()) + 1;

            }
        }


        public int HolidayIncrement()
        {
            DataTable dtIncrement = new DataTable();
            dtIncrement = gdt.GetHoliday(@"Select * From Holiday ORDER BY Holiday_ID Desc");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return HolidayID = 1;

                default:
                    return HolidayID = int.Parse(dtIncrement.Rows[0]["Holiday_ID"].ToString()) + 1;

            }
        }
        public int LocationIncrement()
        {
            DataTable dtIncrement = new DataTable();
            dtIncrement = gdt.GetLocation(@"Select * From Location ORDER BY Location_ID Desc");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return LocationID = 1;

                default:
                    return LocationID = int.Parse(dtIncrement.Rows[0]["Location_ID"].ToString()) + 1;

            }
        }

        public int UserAccountIncrement()
        {
            DataTable dtIncrement = new DataTable();
            dtIncrement = gdt.GetUserAccount(@"Select * From UserAccount ORDER BY UserAccess_ID Desc");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return UAccountID = 1;

                default:
                    return UAccountID = int.Parse(dtIncrement.Rows[0]["UserAccess_ID"].ToString()) + 1;

            }
        }












    }
}
