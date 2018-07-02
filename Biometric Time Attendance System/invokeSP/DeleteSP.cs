using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biometric_Time_Attendance_System
{
    class DeleteSP:PublicVariable
    {

        public void DeleteEmployee( int eb ,int en)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("RemoveEmployee", con))
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

        public void DeleteEmpFingerPrint(int eb, int en)
        {
            string connString = "Data Source='" + DBDescription + "';Initial Catalog=BTASDB;Persist Security Info=True;User ID=sa;Password=sa";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("RemoveEmpFingerPrint", con))
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





    }
}
