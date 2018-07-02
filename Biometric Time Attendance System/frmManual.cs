using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biometric_Time_Attendance_System
{
    public partial class frmManual : Form
    {
        GetDataDB gdt = new GetDataDB();
        PublicMethod pm = new PublicMethod();
        DataTable EmpDT = new DataTable();
        DataTable HolidayDT = new DataTable();

        string strEmpNo { get; set; }
        string strLastName { get; set; }
        string strFirstName { get; set; }
        string strMidName { get; set; }
        string strCompany { get; set; }
        string strBranch { get; set; }
        string strDept { get; set; }
        string strUIEffect { get; set; }
        int userID { set; get; }
        bool NeworEdit { set; get; }
        string StrManualTime { set; get; }
        string strForTimeIn { set; get; }
        string strForTimeOut { set; get; }
        bool HasHoliday { get; set; }
        bool HasDayOff { get; set; }

        int HasLate { get; set; }

        int HasUnderTime { get; set; }

        bool HasAwol { get; set; }

        bool NewOrEdit { set; get; }

        string HasRegTime { set; get; }
        string strRegTimeValue { set; get; }

        public frmManual(int uid, string en, string ln, string fn, string mn, string cn, string bn, string dn, string ui)
        {
            InitializeComponent();

            userID = uid;
            strEmpNo = en;
            strLastName = ln;
            strFirstName = fn;
            strMidName = mn;
            strCompany = cn;
            strBranch = bn;
            strDept = dn;
            strUIEffect = ui;

            EmpListToThisForm();
            UIEffect(strUIEffect);
        }

        private void EmpListToThisForm()
        {
            txtEmpNo.Text = strEmpNo;
            txtLastName.Text = strLastName;
            txtFirstName.Text = strFirstName;
            txtMidName.Text = strMidName;
            txtCompany.Text = strCompany.ToString();
            txtBranch.Text = strBranch;
            txtDept.Text = strDept;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NeworEdit = false;
            UIEffect("New");
        }


        private void UIEffect(string Effect)
        {
            switch (Effect)
            {
                case "Search":
                    grpDetails.Enabled = true;
                    grpEmpList.Enabled = false;

                    btnNew.Enabled = true;
                    btnSearch.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = true;
                    break;

                case "New":
                    grpDetails.Enabled = true;
                    grpEmpList.Enabled = false;

                    btnSearch.Enabled = false;
                    btnNew.Enabled = false;
            
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    



                    ManualObj("New");
                    break;


                //case "Edit":
                //    btnSave.Enabled = false;
                //    btnNew.Enabled = false;
                
                //    btnSave.Enabled = true;
                //    btnCancel.Enabled = true;
                    
                //    grpDetails.Enabled = true;
                //    grpEmpList.Enabled = false;
                //    ManualObj("Edit");
                //    break;
                case "Cancel":
                    btnSearch.Enabled = true;
                    btnNew.Enabled = false;
              
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    

                    grpDetails.Enabled = false;
                    grpEmpList.Enabled = true;

                    clearTextFields();
                    break;

                case "Save":
                    btnSearch.Enabled = true;
                    btnSave.Enabled = false;
                    btnNew.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    grpDetails.Enabled = false;
                    grpEmpList.Enabled = true;

                    break;

                case "SelectGrid":
                    DatePickerSet();
                    btnSearch.Enabled = true;
                    btnNew.Enabled = false;
             
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    
                    break;
                case "Default":
          
                    
                    dtPickerManual.Format = DateTimePickerFormat.Custom;
                    dtPickerManual.CustomFormat = " ";
                    dtFromHr.Format = DateTimePickerFormat.Custom;
                    dtFromHr.CustomFormat = "00:00:00";
                    dtToHr.Format = DateTimePickerFormat.Custom;
                    dtToHr.CustomFormat = "00:00:00";

                    lblMDate.Enabled = false;
                    lblMHours.Enabled = false;
                    lblMType.Enabled = false;
                    lblReason.Enabled = false;
                    lblMTo.Enabled = false;
                    dtPickerManual.Enabled = false;
                    dtFromHr.Enabled = false;
                    dtToHr.Enabled = false;
                    cmbManType.Enabled = false;
                    rtbReason.Enabled = false;

                    if (EmpDT.Rows.Count > 0) {
                        grdEmployees.Rows[0].Cells[0].Selected = false;
                    }


                    break;
            }

        }
        private void clearTextFields()
        {
            txtEmpNo.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMidName.Clear();
            txtBranch.Clear();
            txtCompany.Clear();
            txtDept.Clear();

        }
        private void DatePickerSet() {
            if (txtEmpNo.Text == string.Empty) {
                dtPickerManual.Format = DateTimePickerFormat.Custom;
                dtPickerManual.CustomFormat = " ";
                dtFromHr.Format = DateTimePickerFormat.Custom;
                dtFromHr.CustomFormat = "00:00:00";
                dtToHr.Format = DateTimePickerFormat.Custom;
                dtToHr.CustomFormat = "00:00:00";
            } else if (txtEmpNo.Text != string.Empty)
            {
                dtPickerManual.Format = DateTimePickerFormat.Custom;
                dtPickerManual.CustomFormat = " dddd-  MMMM dd, yyyy ";
                dtFromHr.Format = DateTimePickerFormat.Custom;
                dtFromHr.CustomFormat = "hh:mm tt";
                dtToHr.Format = DateTimePickerFormat.Custom;
                dtToHr.CustomFormat = "hh:mm tt";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rtbReason.Text == string.Empty)
            {
               // AutoClosingMessageBox.Show("Text", "Caption", 1000);
                MessageBox.Show("Incomplete Input", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            { 
                DialogResult result = MessageBox.Show("Do you want to save this information ?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (pm.CheckManualTime(int.Parse(txtEmpNo.Text), dtPickerManual.Value.ToString("yyyy-MM-dd"), cmbManType.Text) == "None")
                    {

                        GetFormValue();
                        InsertSP insertSP = new InsertSP();
                        insertSP.InsertManual(userID, int.Parse(txtEmpNo.Text), dtPickerManual.Value.ToString("yyyy-MM-dd"), DateTime.Parse(StrManualTime.ToString()), cmbManType.Text, rtbReason.Text);
                        CheckDataToDb();
                        if (HasRegTime == "None")
                        {
                            insertSP.InsertManRegTime(int.Parse(txtEmpNo.Text), dtPickerManual.Value.ToString("yyyy-MM-dd"), strForTimeIn, strForTimeOut, txtBranch.Text, HasHoliday, false, true, HasDayOff, Math.Abs(HasLate), Math.Abs(HasUnderTime), HasAwol);
                        }
                        else
                        { //update employee timelog then add time out
                            UpdateSP updateSP = new UpdateSP();
                            updateSP.UpdateManRegTime(HasRegTime, strRegTimeValue, dtPickerManual.Value.ToString("yyyy-MM-dd"), int.Parse(txtEmpNo.Text), strForTimeIn, strForTimeOut, HasHoliday, false, HasDayOff, Math.Abs(HasLate), Math.Abs(HasUnderTime), HasAwol);
                        }

                        MessageBox.Show(" New SUCCESS");
                        LoadToGrid();
                        UIEffect("Save");
                    }              
                }
            }
        }

        private void frmManual_Load(object sender, EventArgs e)
        {
          
            LoadToGrid();
            UIEffect("Default");
          
        }

        private void grdEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            GridToFormObj();           
            UIEffect("SelectGrid");
        }

        private void LoadToGrid()
        {

            EmpDT = gdt.GetEmployee(@"SELECT   CONCAT (Employee.Emp_LastName ,', ', Employee.Emp_FirstName,' ', Employee.Emp_MidName) as EmpName , Employee.Created_By, Employee.Date_Created, Employee.Modify_By, Employee.Date_Modify, Employee.Deleted, Employee.Emp_ID, Employee.Emp_LastName, Employee.Emp_FirstName, " +
                        @" Employee.Emp_MidName, Employee.Company_ID, Employee.Branch_ID, Employee.Department_ID, Employee.Emp_Type, Employee.Emp_DayOff, Employee.Emp_Shift," +
                        @" Company.Company_Name, Branch.Branch_Name, " +
                        @" Department.Department_Name , Manual.Manual_Date, Manual.Manual_Time , Manual.Manual_Type , Manual.Reason FROM   Employee Left JOIN  " +
                        @" Company ON Employee.Company_ID = Company.Company_ID  INNER JOIN" +
                        @" Branch ON Employee.Branch_ID = Branch.Branch_ID INNER JOIN" +
                        @" Department ON Employee.Department_ID = Department.Department_ID   INNER JOIN" +
                        @" Manual ON Employee.Emp_ID =Manual.Emp_ID " +
                        @" Where Employee.Deleted =  0 " +
                        @" ORDER BY Emp_LastName");
            grdEmployees.DataSource = EmpDT;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            EmpDT = gdt.GetEmployee(@"SELECT   CONCAT (Employee.Emp_LastName ,', ', Employee.Emp_FirstName,' ', Employee.Emp_MidName) as EmpName , Employee.Created_By, Employee.Date_Created, Employee.Modify_By, Employee.Date_Modify, Employee.Deleted, Employee.Emp_ID, Employee.Emp_LastName, Employee.Emp_FirstName, " +
                   @" Employee.Emp_MidName, Employee.Company_ID, Employee.Branch_ID, Employee.Department_ID, Employee.Emp_Type, Employee.Emp_DayOff, Employee.Emp_Shift," +
                   @" Employee.FirstTimeFrom, Employee.FirstTimeTo, Employee.SecondTimeFrom, Employee.SecondTimeTo, Employee.ThirdTimeFrom, Employee.ThirdTimeTo, Company.Company_Name, Branch.Branch_Name, Department.Department_Name , " +
                   @" Manual.Manual_Date , Manual.Manual_Time , Manual.Manual_Type , Manual.Reason " +
                   @" FROM   Employee Left JOIN " +
                   @" Company ON Employee.Company_ID = Company.Company_ID  Left JOIN" +
                   @" Branch ON Employee.Branch_ID = Branch.Branch_ID Left JOIN" +
                   @" Department ON Employee.Department_ID = Department.Department_ID Left JOIN" +
                   @" Manual On Employee.Emp_ID = Manual.Emp_ID " +
                   @" Where  Emp_LastName like '%" + txtSearch.Text + "%' or " +
                   @" Emp_FirstName like '%" + txtSearch.Text + "%' or " +
                   @" Emp_MidName like '%" + txtSearch.Text + "%' or " +
                   @" Employee.Emp_ID like '%" + txtSearch.Text + "%' and " +
                   @" Employee.Deleted =  0 " +
                   @" ORDER BY Emp_LastName");
            grdEmployees.DataSource = EmpDT;
            grdEmployees.Refresh();
        }

        private void GridToFormObj()
        {

          
            txtEmpNo.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_ID"].ToString();
            txtLastName.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_LastName"].ToString();
            txtFirstName.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_FirstName"].ToString();
            txtMidName.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_MidName"].ToString();
            txtBranch.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Branch_Name"].ToString();
            txtDept.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Department_Name"].ToString();
            txtCompany.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Company_Name"].ToString();
            dtPickerManual.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Manual_Date"].ToString();
            dtFromHr.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Manual_Time"].ToString();
            dtToHr.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Manual_Time"].ToString();
            cmbManType.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Manual_Type"].ToString();
            rtbReason.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Reason"].ToString();


        }

        private void ManualObj (string eff){
            dtPickerManual.Format = DateTimePickerFormat.Custom;
            dtPickerManual.CustomFormat = " dddd-  MMMM dd, yyyy ";
            dtFromHr.Format = DateTimePickerFormat.Custom;
            dtFromHr.CustomFormat = "hh:mm tt";
            dtToHr.Format = DateTimePickerFormat.Custom;
            dtToHr.CustomFormat = "hh:mm tt";

            lblMDate.Enabled = true;
            lblMHours.Enabled = true;
            lblMType.Enabled = true;
            lblReason.Enabled = true;
            lblMTo.Enabled = true;
            dtPickerManual.Enabled = true;
            dtFromHr.Enabled = true;
            dtToHr.Enabled = true;
            rtbReason.Enabled = true;
            if (eff == "New") {
                cmbManType.Enabled = true;
            }
            else if (eff == "Edit")
            {
                cmbManType.Enabled = false;
            } 
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            frmEmployeeSearch frmEmployeeSearch = new frmEmployeeSearch("frmManual");
            frmEmployeeSearch.ShowDialog(this);
            frmEmployeeSearch.Show();
            frmEmployeeSearch.Activate();
            this.Hide();
        }

        private void rtbReason_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbManType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbManType.Text == "TimeIn")
            {
                dtToHr.Visible = false;
                dtFromHr.Visible = true;
            }
            else if (cmbManType.Text == "TimeOut")
            {
                dtToHr.Visible = true;
                dtFromHr.Visible = false;
            }
        }

        private void GetFormValue() {
            if (dtFromHr.Visible == true)
            {
                StrManualTime = dtFromHr.Value.ToString("hh:mm:ss tt");
                strForTimeIn = dtFromHr.Value.ToString("hh:mm:ss tt");
                strForTimeOut = string.Empty;

            } else if (dtToHr.Visible == true) {
                StrManualTime = dtToHr.Value.ToString("hh:mm:ss tt");
                strForTimeIn = string.Empty;
                strForTimeOut = dtToHr.Value.ToString("hh:mm:ss tt"); ;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(HasAwol.ToString());
            //GetFormValue();
            //if (dtToHr.Visible == true)
            //{
            //    HasUnderTime = pm.CheckUnderTime(int.Parse(txtEmpNo.Text), StrManualTime);
            //    MessageBox.Show(HasAwol.ToString());
            //}

            UIEffect("Cancel");
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void CheckDataToDb()
        {


            if (pm.CheckHolidate(dtPickerManual.Value.ToString("yyyy-MM-dd")) == true)
            {
                HasHoliday = true;  
            }


            if (pm.CheckDayOff(int.Parse(txtEmpNo.Text) , dtPickerManual.Value.ToString("dddd")) == true)
            {
                HasDayOff = true;
               // MessageBox.Show(HasHoliday.ToString());
            }

          
            if (dtFromHr.Visible == true)
            {
                HasLate = pm.CheckLate(int.Parse(txtEmpNo.Text), StrManualTime);
             //   MessageBox.Show(HasLate.ToString());
            }


            if (dtToHr.Visible == true)
            {
                HasUnderTime = pm.CheckUnderTime(int.Parse(txtEmpNo.Text), StrManualTime);
              //  MessageBox.Show(HasUnderTime.ToString());
            }

            HasAwol = pm.CheckAwol(int.Parse(txtEmpNo.Text), dtPickerManual.Value.ToString("yyyy-MM-dd"), cmbManType.Text);

            HasRegTime = pm.CheckRegTime(int.Parse(txtEmpNo.Text), dtPickerManual.Value.ToString("yyyy-MM-dd"));
            strRegTimeValue = pm.CheckValueRegTime();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }



        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    UpdateSP updateSP = new UpdateSP();
        //    updateSP.UpdateManual(userID , int.Parse(txtEmpNo.Text), dtPickerManual.Value.ToString("yyyy-MM-dd"), DateTime.Parse(DateTime.Now.ToString()),"fdf");
        //    MessageBox.Show("Edit success");
        //}
    }
}
