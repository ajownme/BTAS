using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biometric_Time_Attendance_System
{
    
    public class GetDataDB : PublicVariable
    {

        public DataTable GetEmployee(string StrQuery)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            DataTable dtEmployee = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dtEmployee);
                con.Close();
                return dtEmployee;
            }
        }



        public DataTable GetCompany(string StrQuery)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            DataTable dtCompany = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {             
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);    
                dap.Fill(dtCompany);      
                con.Close();
                return dtCompany;  
            }  
        }


     
        public DataTable GetBranch(string StrQuery)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dtBranch);
                con.Close();
                return dtBranch;
            }

        }

        
        public DataTable GetDepartment(string StrQuery)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            DataTable dtDepartment = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dtDepartment);
                con.Close();
                return dtDepartment;
            }

        }


       
        //public  DataTable GetTime(string StrQuery)
        //{
        //    DataTable dt = new DataTable();
        //    string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
        //    using (SqlConnection con = new SqlConnection(connString))
        //    {
        //        SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
        //        dap.Fill(dt);
        //        con.Close();
        //        return dt;
        //    }
        //}

        public DataTable GetHoliday(string StrQuery)
        {
            DataTable dt = new DataTable();
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable GetRegulartTimeLog(string StrQuery)
        {
            DataTable dt = new DataTable();
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dt);
                con.Close();
                return dt;
            }
        }


        public DataTable GetLocation(string StrQuery)
        {
            DataTable dt = new DataTable();
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable GetUserAccount(string StrQuery)
        {
            DataTable dt = new DataTable();
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dt);
                con.Close();
                return dt;
            }
        }






    }
}
