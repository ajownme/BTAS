using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biometric_Time_Attendance_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          // Application.Run(new frmFingerReg(1, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty));
            //  Application.Run(new frmFingerReg(1));
            // Application.Run(new frmManual(1));
            Application.Run(new frmMain());
        }
    }
}
