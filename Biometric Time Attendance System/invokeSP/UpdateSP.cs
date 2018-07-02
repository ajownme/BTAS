using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Biometric_Time_Attendance_System
{
    class UpdateSP: PublicVariable
    {
        public void UpdateEmployee(int eb, int en, string ln, string fn, string mn, int cID, int bID, int dID, string et, string edo, int es, string tf1, string tt1, string tf2, string tt2, string tf3, string tt3, bool empStatus )
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("EditEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Modify_By", SqlDbType.Int).Value = eb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("@Emp_ID", SqlDbType.Int).Value = en;
                    cmd.Parameters.Add("@Emp_LastName", SqlDbType.VarChar).Value = fn;
                    cmd.Parameters.Add("@Emp_FirstName", SqlDbType.VarChar).Value = fn;
                    cmd.Parameters.Add("@Emp_MidName", SqlDbType.VarChar).Value = mn;
                    cmd.Parameters.Add("@Company_ID", SqlDbType.Int).Value = cID;
                    cmd.Parameters.Add("@Branch_ID", SqlDbType.Int).Value = bID;
                    cmd.Parameters.Add("@Department_ID", SqlDbType.Int).Value = dID;
                    cmd.Parameters.Add("@Emp_Type", SqlDbType.VarChar).Value = et;
                    cmd.Parameters.Add("@Emp_DayOff", SqlDbType.VarChar).Value = edo;
                    cmd.Parameters.Add("@Emp_Shift", SqlDbType.Int).Value = es;
                    cmd.Parameters.Add("@FirstTimeFrom", SqlDbType.DateTime).Value = DateTime.Parse(tf1.ToString());
                    cmd.Parameters.Add("@FirstTimeTo", SqlDbType.DateTime).Value = DateTime.Parse(tt1.ToString());
                    if (tf2 != " ")
                    {
                        cmd.Parameters.Add("@SecondTimeFrom", SqlDbType.DateTime).Value = DateTime.Parse(tf2.ToString());
                    }
                    else
                    {
                        cmd.Parameters.Add("@SecondTimeFrom", SqlDbType.DateTime).Value = DBNull.Value;
                    }

                    if (tt2 != " ")
                    {
                        cmd.Parameters.Add("@SecondTimeTo", SqlDbType.DateTime).Value = DateTime.Parse(tt2.ToString());
                    }
                    else
                    {
                        cmd.Parameters.Add("@SecondTimeTo", SqlDbType.DateTime).Value = DBNull.Value;
                    }

                    if (tf3 != " ")
                    {
                        cmd.Parameters.Add("@ThirdTimeFrom", SqlDbType.DateTime).Value = DateTime.Parse(tf3.ToString());
                    }
                    else
                    {
                        cmd.Parameters.Add("@ThirdTimeFrom", SqlDbType.DateTime).Value = DBNull.Value;
                    }


                    if (tt3 != " ")
                    {
                        cmd.Parameters.Add("@ThirdTimeTo", SqlDbType.DateTime).Value = DateTime.Parse(tt3.ToString());
                    }
                    else
                    {
                        cmd.Parameters.Add("@ThirdTimeTo", SqlDbType.DateTime).Value = DBNull.Value;
                    }
                    cmd.Parameters.Add("@Emp_Status", SqlDbType.Bit).Value = empStatus;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }


        public void UpdateManual(int eb, int en, string md, DateTime mt, string r)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("EditManual", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Modify_By", SqlDbType.Int).Value = eb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("@Emp_ID", SqlDbType.Int).Value = en;
                    cmd.Parameters.Add("@Manual_Date", SqlDbType.Date).Value = md;
                    cmd.Parameters.Add("@Manual_Time", SqlDbType.Time).Value = mt.ToString("hh:mm:ss");
                    cmd.Parameters.Add("@Manual_Type", SqlDbType.VarChar).Value = "TimeIn";
                    cmd.Parameters.Add("@Reason", SqlDbType.NVarChar).Value = DBNull.Value;             
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }


        public void UpdateManRegTime(string validation , string valTime ,string valDate,  int en, string ti, string to,  bool h, bool l,  bool dayo, int late, int ut, bool awol)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";

            if (validation == "HasTimeIn")
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("EditManRegTimeOut", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@EmpNo", SqlDbType.Int).Value = en;
                        cmd.Parameters.Add("@LogDate", SqlDbType.Date).Value = valDate;

                        //DateTime dti = DateTime.Parse(ti.ToString());
                        cmd.Parameters.Add("@TimeIn", SqlDbType.Time).Value = valTime;

                        DateTime dto = DateTime.Parse(to.ToString());
                        cmd.Parameters.Add("@TimeOut", SqlDbType.Time).Value = dto.ToString("hh:mm:ss");

                        cmd.Parameters.Add("@Holiday", SqlDbType.Bit).Value = h;
                        cmd.Parameters.Add("@Leave", SqlDbType.Bit).Value = l;
                        cmd.Parameters.Add("@DayOff", SqlDbType.Bit).Value = dayo;
                        cmd.Parameters.Add("@Late", SqlDbType.Int).Value = late;
                        cmd.Parameters.Add("@UTime", SqlDbType.Int).Value = ut;
                        cmd.Parameters.Add("@Awol", SqlDbType.Bit).Value = awol;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Dispose();
                    }
                }
            } else if (validation == "HasTimeOut") {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("EditManRegTimeIn", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@EmpNo", SqlDbType.Int).Value = en;
                        cmd.Parameters.Add("@LogDate", SqlDbType.Date).Value = valDate;
                        DateTime dti = DateTime.Parse(ti.ToString());
                        cmd.Parameters.Add("@TimeIn", SqlDbType.Time).Value = dti.ToString("hh:mm:ss");

                       // DateTime dto = DateTime.Parse(to.ToString());
                        cmd.Parameters.Add("@TimeOut", SqlDbType.Time).Value = valTime;

                        cmd.Parameters.Add("@Holiday", SqlDbType.Bit).Value = h;
                        cmd.Parameters.Add("@Leave", SqlDbType.Bit).Value = l;
                        cmd.Parameters.Add("@DayOff", SqlDbType.Bit).Value = dayo;
                        cmd.Parameters.Add("@Late", SqlDbType.Int).Value = late;
                        cmd.Parameters.Add("@UTime", SqlDbType.Int).Value = ut;
                        cmd.Parameters.Add("@Awol", SqlDbType.Bit).Value = awol;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Dispose();
                    }
                }
            }

          
        }


        public void UpdateBranch(int cb, int bid ,string bname)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("EditBranch", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Modify_By", SqlDbType.Int).Value = cb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("@Branch_ID", SqlDbType.Int).Value = bid;
                    cmd.Parameters.Add("@Branch_Name", SqlDbType.NVarChar).Value = bname;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }


        public void UpdateCompany(int cb, int bid, string cname)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("EditCompany", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Modify_By", SqlDbType.Int).Value = cb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("@Company_ID", SqlDbType.Int).Value = bid;
                    cmd.Parameters.Add("@Company_Name", SqlDbType.NVarChar).Value = cname;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }

        public void UpdateDepartment(int cb, int did, string dname)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("EditDepartment", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Modify_By", SqlDbType.Int).Value = cb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("@Department_ID", SqlDbType.Int).Value = did;
                    cmd.Parameters.Add("@Department_Name", SqlDbType.NVarChar).Value = dname;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }

        public void UpdateHoliday(int cb, int hid, string hname , string hdate , string htype)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("EditHoliday", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Modify_By", SqlDbType.Int).Value = cb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("@Holiday_ID", SqlDbType.Int).Value = hid;
                    cmd.Parameters.Add("@Holiday_Name", SqlDbType.NVarChar).Value = hname;
                    DateTime dth = DateTime.Parse(hdate.ToString());
                    cmd.Parameters.Add("@Holiday_Date", SqlDbType.Date).Value = dth.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@Holiday_Type", SqlDbType.VarChar).Value = htype;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }

        public void UpdateLocation(int cb, int bid, string bname)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("EditLocation", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Modify_By", SqlDbType.Int).Value = cb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("@Location_ID", SqlDbType.Int).Value = bid;
                    cmd.Parameters.Add("@Location_Name", SqlDbType.NVarChar).Value = bname;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }
        public void UpdateUserAccount(int cb,int UAid, string UAname, string pass, bool EmpReg, bool FPrintReg, bool br, bool co, bool dept, bool ho, bool lo, bool TimeL, bool UAcess, bool rr, bool sbr, bool mbr, bool obr, bool manual)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("EditUserAccount", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Modify_By", SqlDbType.VarChar).Value = cb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("@UserAccess_ID", SqlDbType.Int).Value = UAid;
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UAname;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = pass;
                    cmd.Parameters.Add("@EmpRegistry", SqlDbType.Bit).Value = EmpReg;
                    cmd.Parameters.Add("@FPrintRegistry", SqlDbType.Bit).Value = FPrintReg;
                    cmd.Parameters.Add("@Branch", SqlDbType.Bit).Value = br;
                    cmd.Parameters.Add("@Company", SqlDbType.Bit).Value = co;
                    cmd.Parameters.Add("@Department", SqlDbType.Bit).Value = dept;
                    cmd.Parameters.Add("@Holiday", SqlDbType.Bit).Value = ho;
                    cmd.Parameters.Add("@Location", SqlDbType.Bit).Value = lo;
                    cmd.Parameters.Add("@TimeLimit", SqlDbType.Bit).Value = TimeL;
                    cmd.Parameters.Add("@UserAccess", SqlDbType.Bit).Value = UAcess;
                    cmd.Parameters.Add("@RegReports", SqlDbType.Bit).Value = rr;
                    cmd.Parameters.Add("@ShortBReports", SqlDbType.Bit).Value = sbr;
                    cmd.Parameters.Add("@MealBReports", SqlDbType.Bit).Value = mbr;
                    cmd.Parameters.Add("@OBReports", SqlDbType.Bit).Value = obr;
                    cmd.Parameters.Add("@Manual", SqlDbType.Bit).Value = manual;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }
















    }
}
