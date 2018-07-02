using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biometric_Time_Attendance_System
{
    public class PublicVariable
    {
       

        private int varMaxRow;
        public int MaxRow
        {
            get { return this.varMaxRow; }
            set { this.varMaxRow = value; }
        }


        private string varDBDescription;
        public String DBDescription
        {
            get { return this.varDBDescription; }
            set { this.varDBDescription = "10.0.14.14"; }
        }

        //public int varEmployeeID;
        //public int EmployeeID
        //{
        //    get { return this.varEmployeeID; }
        //    set { this.varEmployeeID = value; }
        //}

      
      
    }

}
