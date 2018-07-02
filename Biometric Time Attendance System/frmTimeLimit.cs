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
    public partial class frmTimeLimit : Form
    {
        public frmTimeLimit()
        {
            InitializeComponent();
        }

        private void frmTimeLimit_Load(object sender, EventArgs e)
        {
            LoadTreeViewOpen();
            DatePickerSet();
        }

        private void LoadTreeViewOpen() {
            trvTime.ItemHeight = 23;

            trvTime.Nodes.Add("1st Work Hours Settings"); ;
            trvTime.Nodes[0].Nodes.Add("1st Regular Time");
            trvTime.Nodes[0].Nodes.Add("1st Short Break Time");
            trvTime.Nodes[0].Nodes.Add("1st Meal Break Time");
            trvTime.Nodes[0].Nodes.Add("1st Official Bussiness Time");

            trvTime.Nodes.Add("2nd Work Hours Settings");
            trvTime.Nodes[1].Nodes.Add("2nd Regular Time");
            trvTime.Nodes[1].Nodes.Add("2nd Short Break Time");
            trvTime.Nodes[1].Nodes.Add("2nd Meal Break Time");
            trvTime.Nodes[1].Nodes.Add("2nd Official Bussiness Time");

            trvTime.Nodes.Add("3rd Work Hours Settings");
            trvTime.Nodes[2].Nodes.Add("3rd Regular Time");
            trvTime.Nodes[2].Nodes.Add("3rd Short Break Time");
            trvTime.Nodes[2].Nodes.Add("3rd Meal Break Time");
            trvTime.Nodes[2].Nodes.Add("3rd Official Bussiness Time");

            trvTime.Nodes[0].Expand();
            trvTime.Nodes[1].Expand();
            trvTime.Nodes[2].Expand();
        }



        private void trvTime_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNodeText = e.Node.Text;
            if (selectedNodeText == "1st Work Hours Settings")
            {
               // panel1.Visible = true;
                pnl1stRegTime.Visible = false;
                pnl1stShortBTime.Visible = false;
                pnl1stMealBTime.Visible = false;

            }
            else if (selectedNodeText == "1st Regular Time") {
              //  panel1.Visible = false;
                pnl1stRegTime.Visible = true;
                pnl1stShortBTime.Visible = false;
                pnl1stMealBTime.Visible = false;

            } else if (selectedNodeText== "1st Short Break Time") {
               // panel1.Visible = false;
                pnl1stRegTime.Visible = false;
                pnl1stShortBTime.Visible = true;
                pnl1stMealBTime.Visible = false;
            }
            else if (selectedNodeText == "1st Meal Break Time")
            {
               // panel1.Visible = false;
                pnl1stRegTime.Visible = false;
                pnl1stShortBTime.Visible = false;
                pnl1stMealBTime.Visible = true;
            }

        }

        private void DatePickerSet()
        {
           
            dtpRegStart1.Format = DateTimePickerFormat.Custom;
            dtpRegStart1.CustomFormat = "hh:mm tt";
            dtpRegEnd1.Format = DateTimePickerFormat.Custom;
            dtpRegEnd1.CustomFormat = "hh:mm tt";

            dtp1ShortBLength.Format = DateTimePickerFormat.Custom;
            dtp1ShortBLength.CustomFormat = "mm";

            dtp1ShortBStartFisrtHalf.Format = DateTimePickerFormat.Custom;
            dtp1ShortBStartFisrtHalf.CustomFormat = "hh:mm tt";

            dtp1ShortBEndFisrtHalf.Format = DateTimePickerFormat.Custom;
            dtp1ShortBEndFisrtHalf.CustomFormat = "hh:mm tt";


            dtp1ShortBStartSecondHalf.Format = DateTimePickerFormat.Custom;
            dtp1ShortBStartSecondHalf.CustomFormat = "hh:mm tt";

            dtp1ShortBEndSecondHalf.Format = DateTimePickerFormat.Custom;
            dtp1ShortBEndSecondHalf.CustomFormat = "hh:mm tt";


            //dtp1ShortBLength.AllowDrop = false;
        }

        private void grp1stMealBTime_Enter(object sender, EventArgs e)
        {

        }
    }
}
