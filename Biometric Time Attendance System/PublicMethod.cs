using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biometric_Time_Attendance_System
{
    class PublicMethod
    {
        GetDataDB gdb = new GetDataDB();

        string strTimeValue { set; get; }

        public bool CheckHolidate(string date)
        {
            DataTable HolidayDT = new DataTable();
            HolidayDT = gdb.GetHoliday(@"Select Holiday_Date FROM Holiday ORDER BY Holiday_Name ASC");
            for (int i = 0; i < HolidayDT.Rows.Count; i++)
            {
                DateTime dt = DateTime.Parse(HolidayDT.Rows[i]["Holiday_Date"].ToString());
                if (dt.ToString("yyyy-MM-dd") == date)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckDayOff(int EmpId , string mdate) {
            DataTable EmpDT = new DataTable();
            EmpDT = gdb.GetEmployee(@"Select Emp_ID FROM Employee WHERE  Emp_ID ='" + EmpId + "' and Emp_DayOff = '" + mdate + "'");
           
               // DateTime dt = DateTime.Parse(EmpDT.Rows[i]["Emp_DayOff"].ToString());
                if (EmpDT.Rows.Count > 0 )
                {
                    return true;
                }
            return false;
        }

        public int CheckLate(int EmpId , string inputHour)
        {
            DataTable EmpDT = new DataTable();
            EmpDT = gdb.GetEmployee(@"SELECT DATEDIFF(Minute, FirstTimeFrom, '" + inputHour + "') as 'MinutesLate' FROM Employee WHERE  Emp_ID ='" + EmpId.ToString() + "'");
            if (int.Parse(EmpDT.Rows[0]["MinutesLate"].ToString()) > 0) {
                return int.Parse(EmpDT.Rows[0]["MinutesLate"].ToString());
            }    
           return 0;
        }

        public int CheckUnderTime(int EmpId, string inputHour)
        {
            DataTable EmpDT = new DataTable();
            EmpDT = gdb.GetEmployee(@"SELECT DATEDIFF(Minute, FirstTimeTo, '" + inputHour + "') as 'UnderTime' FROM Employee WHERE  Emp_ID ='" + EmpId.ToString() + "'");
            if (int.Parse(EmpDT.Rows[0]["UnderTime"].ToString()) < 0)
            {
                return int.Parse(EmpDT.Rows[0]["UnderTime"].ToString());
            }
            return 0;
        }

     
        public bool CheckAwol(int EmpId, string date , string timetype)
        {
            DataTable RegTimeDT = new DataTable();
            RegTimeDT = gdb.GetRegulartTimeLog(@"SELECT EmpNo ,LogDate, TimeIn,TimeOut FROM RegularTimeLog WHERE  EmpNo ='" + EmpId.ToString() + "' and LogDate ='" + date + "' ");
            if (RegTimeDT.Rows.Count > 0)
            {
                if (timetype == "TimeIn") {
                    if (RegTimeDT.Rows[0]["TimeOut"].ToString() == string.Empty)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (timetype == "TimeOut")
                {
                    if (RegTimeDT.Rows[0]["TimeIn"].ToString() == string.Empty)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        public String CheckRegTime(int EmpId, string date  ) {
            DataTable RegTimeDT = new DataTable();
            RegTimeDT = gdb.GetRegulartTimeLog(@"SELECT EmpNo , LogDate, TimeIn , TimeOut FROM RegularTimeLog WHERE  EmpNo ='" + EmpId.ToString() + "' and LogDate ='" + date + "' ");
            if (RegTimeDT.Rows.Count > 0)
            { 
                if (RegTimeDT.Rows[0]["TimeIn"].ToString() != string.Empty && RegTimeDT.Rows[0]["TimeOut"].ToString() == string.Empty)
                {
                    strTimeValue= RegTimeDT.Rows[0]["TimeIn"].ToString(); 
                    return "HasTimeIn";
                }
                else if (RegTimeDT.Rows[0]["TimeIn"].ToString() == string.Empty && RegTimeDT.Rows[0]["TimeOut"].ToString() != string.Empty)
                {
                    strTimeValue = RegTimeDT.Rows[0]["TimeOut"].ToString();
                    return "HasTimeOut";
                }
                else if (RegTimeDT.Rows[0]["TimeIn"].ToString() != string.Empty && RegTimeDT.Rows[0]["TimeOut"].ToString() != string.Empty)
                {
                    return "HasAllTime";
                }
            }
            return "None";
        }

        public String CheckValueRegTime() {
            return strTimeValue;
        }



        public String CheckManualTime(int EmpId, string date , string type)
        {
            DataTable RegTimeDT = new DataTable();
            RegTimeDT = gdb.GetRegulartTimeLog(@"SELECT Emp_ID  FROM Manual WHERE  Emp_ID ='" + EmpId.ToString() + "' and Manual_Date ='" + date + "'  and Manual_Type ='" + type + "' ");
            if (RegTimeDT.Rows.Count > 0)
            {
                return "Exist";
            }
            return "None";
        }




    }
}
