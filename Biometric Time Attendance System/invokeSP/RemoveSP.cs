using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biometric_Time_Attendance_System
{
    class RemoveSP:PublicVariable
    {

        public void RemoveEmployee( int eb ,int en)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Emp_ID", SqlDbType.Int).Value = en;
                    cmd.Parameters.Add("@Modify_by", SqlDbType.Int).Value = eb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }

        //public void DeleteEmpFingerPrint(int eb, int en)
        //{
        //    string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
        //    using (SqlConnection con = new SqlConnection(connString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("RemoveEmpFingerPrint", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add("@Emp_ID", SqlDbType.Int).Value = en;
        //            cmd.Parameters.Add("@Modify_by", SqlDbType.Int).Value = eb;
        //            cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            con.Dispose();
        //        }
        //    }
        //}


        public void RemoveBranch(int eb, int bid)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteBranch", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Branch_ID", SqlDbType.Int).Value = bid;
                    cmd.Parameters.Add("@Modify_by", SqlDbType.Int).Value = eb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }


        public void RemoveCompany(int eb, int cid)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteCompany", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Company_ID", SqlDbType.Int).Value = cid;
                    cmd.Parameters.Add("@Modify_by", SqlDbType.Int).Value = eb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }


        public void RemoveDepartment(int eb, int did)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteDepartment", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Department_ID", SqlDbType.Int).Value = did;
                    cmd.Parameters.Add("@Modify_by", SqlDbType.Int).Value = eb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }

        public void RemoveHoliday(int eb, int RHid)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteHoliday", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Holiday_ID", SqlDbType.Int).Value = RHid;
                    cmd.Parameters.Add("@Modify_by", SqlDbType.Int).Value = eb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }

        public void RemoveLocation(int eb, int rid)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteLocation", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Location_ID", SqlDbType.Int).Value = rid;
                    cmd.Parameters.Add("@Modify_by", SqlDbType.Int).Value = eb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }

        public void RemoveUserAccount(int eb, int UAid)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteUserAccount", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@UserAccess_ID", SqlDbType.Int).Value = UAid;
                    cmd.Parameters.Add("@Modify_by", SqlDbType.Int).Value = eb;
                    cmd.Parameters.Add("@Date_Modify", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }








    }
}
