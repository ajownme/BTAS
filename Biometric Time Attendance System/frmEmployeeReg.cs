using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biometric_Time_Attendance_System
{

    partial class frmEmployeeReg : Form
    {
        GetDataDB gdt = new GetDataDB();
        DataTable CompanyDT = new DataTable();
        DataTable BranchDT = new DataTable();
        DataTable DepartmentDT = new DataTable();
        DataTable EmpDT = new DataTable();
        int varShift { set; get; }
        int userID { set; get; }
        int companyID { set; get; }
        int branchID { set; get; }
        int deptID { set; get; }
        Boolean NeworEdit { set; get; }
        string dtpFrom2 { set; get; }
        string dtpTo2 { set; get; }
        string dtpFrom3 { set; get; }
        string dtpTo3 { set; get; }
        bool strEmpStatus { set; get; }



        #region UI frmEmployeeReg  EventHandler  Members:
        public frmEmployeeReg(int uid)
        {
            InitializeComponent();
            userID = uid;
        }

        private void frmEmployeeReg_Load(object sender, EventArgs e)
        {

            //    txtLastName.TabIndex = 1;
            //   txtLastName.TabStop = true;
            //   txtLastName.Focus();
            //MessageBox.Show(userID.ToString
            SetFormValue();

            UIEffect("Default");

        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            NeworEdit = false;
            UIEffect("New");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NeworEdit = true;
            UIEffect("Edit");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save this information ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (NeworEdit == false)
                {
                    GetFormValue();
                    InsertSP internetSP = new InsertSP();
                    internetSP.InsertEmployee(userID, txtLastName.Text, txtFirstName.Text, txtMidName.Text, companyID, branchID, deptID, cmbEmployment.Text, cmbDayOff.Text, varShift, dtPicker1stFrom.Text, dtPicker1stTo.Text, dtpFrom2, dtpTo2, dtpFrom3, dtpTo3 , strEmpStatus);
                    MessageBox.Show(" New SUCCESS");

                }
                else
                {
                    GetFormValue();
                    UpdateSP updateSP = new UpdateSP();
                    updateSP.UpdateEmployee(userID, int.Parse(txtEmpNo.Text), txtLastName.Text, txtFirstName.Text, txtMidName.Text, companyID, branchID, deptID, cmbEmployment.Text, cmbDayOff.Text, varShift, dtPicker1stFrom.Text, dtPicker1stTo.Text, dtpFrom2, dtpTo2, dtpFrom3, dtpTo3,strEmpStatus);
                    MessageBox.Show(" Edit SUCCESS");
                }
                UIEffect("Save");
                LoadToGrid();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetFormValue();
            UIEffect("Cancel");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GetFormValue();
            RemoveSP deleteSP = new RemoveSP();
            deleteSP.RemoveEmployee(userID, int.Parse(txtEmpNo.Text));
            MessageBox.Show(" Delete SUCCESS");
            SetFormValue();
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            companyID = int.Parse(CompanyDT.Rows[cmbCompany.SelectedIndex]["Company_ID"].ToString());
        }

        private void rdbRegularTime_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbRegularTime.Checked == true)
            {
                dtPicker2ndFrom.Format = DateTimePickerFormat.Custom;
                dtPicker2ndFrom.CustomFormat = "00:00:00";
                dtPicker2ndTo.Format = DateTimePickerFormat.Custom;
                dtPicker2ndTo.CustomFormat = "00:00:00";

                dtPicker3rdFrom.Format = DateTimePickerFormat.Custom;
                dtPicker3rdFrom.CustomFormat = "00:00:00";
                dtPicker3rdTo.Format = DateTimePickerFormat.Custom;
                dtPicker3rdTo.CustomFormat = "00:00:00";
            }

            UIEffect("ShiftEffect");

        }

        private void rdbShiftingTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbShiftingTime.Checked == true)
            {
                dtPicker2ndFrom.Format = DateTimePickerFormat.Custom;
                dtPicker2ndFrom.CustomFormat = "hh:mm tt";
                dtPicker2ndTo.Format = DateTimePickerFormat.Custom;
                dtPicker2ndTo.CustomFormat = "hh:mm tt";

                dtPicker3rdFrom.Format = DateTimePickerFormat.Custom;
                dtPicker3rdFrom.CustomFormat = "00:00:00";
                dtPicker3rdTo.Format = DateTimePickerFormat.Custom;
                dtPicker3rdTo.CustomFormat = "00:00:00";
            }
            UIEffect("ShiftEffect");
        }

        private void cmbShift_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CheckShiftValue()
        {
            switch (rdbShiftingTime.Checked)
            {
                case false:
                    varShift = 0;
                    break;
                default:
                    varShift = int.Parse(cmbShift.Text);
                    break;

            }
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            branchID = int.Parse(BranchDT.Rows[cmbBranch.SelectedIndex]["Branch_ID"].ToString());
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            deptID = int.Parse(DepartmentDT.Rows[cmbDepartment.SelectedIndex]["Department_ID"].ToString());
        }

        private void txtEmpNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }


        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) & !char.IsLetter(e.KeyChar) & !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsLetter(e.KeyChar) & !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtMidName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsLetter(e.KeyChar) & !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void cmbBranch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            branchID = int.Parse(BranchDT.Rows[cmbBranch.SelectedIndex]["Branch_ID"].ToString());
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // ForInputSecurity(txtSearch.Text);

            //EmpDT.DefaultView.RowFilter = "Emp_MidName  like '%" + txtSearch.Text + "%' or Emp_FirstName  like '%" + txtSearch.Text + "%'  or Emp_LastName  like '%" + txtSearch.Text + "%' ";
            // int n;
            // if (txtSearch.Text != "" &&  int.TryParse(txtSearch.Text , out n) == true )
            // {
            //     EmpDT.DefaultView.RowFilter = " Emp_ID  = '" + int.Parse(txtSearch.Text) + "'";
            // }

            EmpDT = gdt.GetEmployee(@"SELECT   CONCAT (Employee.Emp_LastName ,', ', Employee.Emp_FirstName,' ', Employee.Emp_MidName) as EmpName , Employee.Created_By, Employee.Date_Created, Employee.Modify_By, Employee.Date_Modify, Employee.Deleted, Employee.Emp_ID, Employee.Emp_LastName, Employee.Emp_FirstName, " +
                       @" Employee.Emp_MidName, Employee.Company_ID, Employee.Branch_ID, Employee.Department_ID, Employee.Emp_Type, Employee.Emp_DayOff, Employee.Emp_Shift," +
                       @" Employee.FirstTimeFrom, Employee.FirstTimeTo, Employee.SecondTimeFrom, Employee.SecondTimeTo, Employee.ThirdTimeFrom, Employee.ThirdTimeTo, Employee.Emp_Status , Company.Company_Name, Branch.Branch_Name, " +
                       @" Department.Department_Name FROM   Employee Left JOIN " +
                       @" Company ON Employee.Company_ID = Company.Company_ID  Left JOIN" +
                       @" Branch ON Employee.Branch_ID = Branch.Branch_ID INNER JOIN" +
                       @" Department ON Employee.Department_ID = Department.Department_ID " +
                       @"Where  Emp_LastName like '%" + txtSearch.Text + "%' or " +
                       @"Emp_FirstName like '%" + txtSearch.Text + "%' or " +
                       @"Emp_MidName like '%" + txtSearch.Text + "%' or " +
                       @"Emp_ID like '%" + txtSearch.Text + "%' and " +
                       @" Employee.Deleted =  0 " +
                       @"ORDER BY Employee.Emp_ID ");
            grdEmployees.DataSource = EmpDT;
            grdEmployees.Refresh();

        }
        private void grdEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridToFormObj();
        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtPicker2ndFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtPicker3rdFrom_DropDown(object sender, EventArgs e)
        {
            dtPicker3rdFrom.Format = DateTimePickerFormat.Custom;
            dtPicker3rdFrom.CustomFormat = "hh:mm tt";

        }

        private void dtPicker3rdTo_DropDown(object sender, EventArgs e)
        {
            dtPicker3rdTo.Format = DateTimePickerFormat.Custom;
            dtPicker3rdTo.CustomFormat = "hh:mm tt";
        }

        private void rdbActive_CheckedChanged(object sender, EventArgs e)
        {
            rdbAction();
        }

        #endregion

        #region  frmEmployeeReg Class Methods :
        private void GetFormValue()
        {
            CheckShiftValue();
            CheckDTPValue();

        }

        private void clearTextFields() {
            txtEmpNo.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMidName.Clear();
            
        }

        private void UIEffect(string Effect)
        {
            switch (Effect)
            {
                case "New":

                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = false;

                    grpDetails.Enabled = true;
                    grpEmpList.Enabled = false;
                    clearTextFields();
                    break;


                case "Edit":
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = false;

                    grpDetails.Enabled = true;
                    grpEmpList.Enabled = false;
             
                    break;
                case "Cancel":

                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = true;

                    grpDetails.Enabled = false;
                    grpEmpList.Enabled = true;
                    break;

                case "ShiftEffect":
                    ShiftingUIEffect();
                    break;

                case "Default":

                    grpDetails.Enabled = false;
                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = true;

                    //cmbCompany.Items.Clear();
                    cmbEmployment.SelectedIndex = 0;
                    cmbDayOff.SelectedIndex = 0;
                    cmbShift.SelectedIndex = 0;
                    cmbCompany.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbEmployment.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbDayOff.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbShift.DropDownStyle = ComboBoxStyle.DropDownList;


                    dtPicker1stFrom.Format = DateTimePickerFormat.Custom;
                    dtPicker1stFrom.CustomFormat = "hh:mm tt";
                    dtPicker1stTo.Format = DateTimePickerFormat.Custom;
                    dtPicker1stTo.CustomFormat = "hh:mm tt";

                    dtPicker2ndFrom.Format = DateTimePickerFormat.Custom;
                    dtPicker2ndFrom.CustomFormat = "hh:mm tt";
                    dtPicker2ndTo.Format = DateTimePickerFormat.Custom;
                    dtPicker2ndTo.CustomFormat = "hh:mm tt";


                    dtPicker3rdFrom.Format = DateTimePickerFormat.Custom;
                    dtPicker3rdFrom.CustomFormat = "hh:mm tt";
                    dtPicker3rdTo.Format = DateTimePickerFormat.Custom;
                    dtPicker3rdTo.CustomFormat = "hh:mm tt";

                      DT3rdEmptyUIEffect();

                   // ShiftingUIEffect();
                 
                    break;

            }

        }

        private void DT3rdEmptyUIEffect()
        {
            if (EmpDT.Rows[grdEmployees.CurrentRow.Index]["ThirdTimeFrom"].ToString() == string.Empty)
            {
                dtPicker3rdFrom.Format = DateTimePickerFormat.Custom;
                dtPicker3rdFrom.CustomFormat = "00:00:00";
            }
            else
            {
                dtPicker3rdFrom.Format = DateTimePickerFormat.Custom;
                dtPicker3rdFrom.CustomFormat = "00:00:00";
            }

            if (EmpDT.Rows[grdEmployees.CurrentRow.Index]["ThirdTimeTo"].ToString() == string.Empty)
            {
                dtPicker3rdTo.Format = DateTimePickerFormat.Custom;
                dtPicker3rdTo.CustomFormat = "00:00:00";
            }
            else
            {
                dtPicker3rdTo.Format = DateTimePickerFormat.Custom;
                dtPicker3rdTo.CustomFormat = "00:00:00";
            }

        }
        private void ShiftingUIEffect() {
            if (rdbRegularTime.Checked == true)
            {

                lblShift.Visible = false;
                cmbShift.Visible = false;
                lblWorkHours2.Visible = false;
                dtPicker2ndFrom.Visible = false;
                lblTo2.Visible = false;
                dtPicker2ndTo.Visible = false;
                lblWorkHours3.Visible = false;
                dtPicker3rdFrom.Visible = false;
                lblTo3.Visible = false;
                dtPicker3rdTo.Visible = false;
            }
            else {
                lblShift.Visible = true;
                cmbShift.Visible = true;
                lblWorkHours2.Visible = true;
                dtPicker2ndFrom.Visible = true;
                lblTo2.Visible = true;
                dtPicker2ndTo.Visible = true;
                lblWorkHours3.Visible = true;
                dtPicker3rdFrom.Visible = true;
                lblTo3.Visible = true;
                dtPicker3rdTo.Visible = true;
            }
        }

        private void SetFormValue()
        {
            dtPicker1stFrom.Text= "09:00";
            dtPicker1stTo.Text = "18:00";

            dtPicker2ndFrom.Text = "09:00";
            dtPicker2ndTo.Text = "18:00";

            dtPicker3rdFrom.Text = "09:00";
            dtPicker3rdTo.Text = "18:00";
            for (int a = 1; a < 365; a = a + 1)
            {
                switch (a) {
                    case 1:
                        cmbShift.Items.Add(a);
                        break;
                       default:
                        cmbShift.Items.Add(a);
                        break;
                }
                
            }

            CompanyDT=  gdt.GetCompany(@"Select Company_ID, Company_Name FROM Company ORDER BY Company_ID ASC");
            for (int i = 0; i < CompanyDT.Rows.Count; i++)
            {
                cmbCompany.Items.Add(CompanyDT.Rows[i]["Company_Name"].ToString());
            }

           BranchDT =  gdt.GetBranch(@"Select Branch_ID, Branch_Name FROM Branch ORDER BY Branch_ID ASC");
            for (int i = 0; i < BranchDT.Rows.Count; i++)
            {
                cmbBranch.Items.Add(BranchDT.Rows[i]["Branch_Name"].ToString());
            }

           DepartmentDT = gdt.GetDepartment(@"Select Department_ID, Department_Name FROM Department ORDER BY Department_ID ASC");
            for (int i = 0; i < DepartmentDT.Rows.Count; i++)
            {
                cmbDepartment.Items.Add(DepartmentDT.Rows[i]["Department_Name"].ToString());
            }


            LoadToGrid();
            GridToFormObj();
        }

   
        private void CheckDTPValue()
        {
               
            if (dtPicker2ndFrom.Visible == true)
            {
                dtpFrom2 = dtPicker2ndFrom.Text;          
            }else {
                dtpFrom2 = " ";
            }

            if (dtPicker2ndTo.Visible == true)
            {
                dtpTo2 = dtPicker2ndTo.Text;
              
            } else {
                dtpTo2 = " ";
            }

            if (dtPicker3rdFrom.Visible == true)
            {
                dtpFrom3 = dtPicker3rdFrom.Text;
              
            } else {
                dtpFrom3 = " ";
            }

            if (dtPicker3rdTo.Visible == true)
            {
                dtpTo3 = dtPicker3rdTo.Text;
              
            }  else {
                dtpTo3 = " ";
            }

        }

     

        private void LoadToGrid() {
           
            EmpDT = gdt.GetEmployee(@"SELECT   CONCAT (Employee.Emp_LastName ,', ', Employee.Emp_FirstName,' ', Employee.Emp_MidName) as EmpName , Employee.Created_By, Employee.Date_Created, Employee.Modify_By, Employee.Date_Modify, Employee.Deleted, Employee.Emp_ID, Employee.Emp_LastName, Employee.Emp_FirstName, " +
                        @" Employee.Emp_MidName, Employee.Company_ID, Employee.Branch_ID, Employee.Department_ID, Employee.Emp_Type, Employee.Emp_DayOff, Employee.Emp_Shift," +
                        @" Employee.FirstTimeFrom, Employee.FirstTimeTo, Employee.SecondTimeFrom, Employee.SecondTimeTo, Employee.ThirdTimeFrom, Employee.ThirdTimeTo,Employee.Emp_Status, Company.Company_Name, Branch.Branch_Name, " +
                        @" Department.Department_Name FROM   Employee Left JOIN " +
                        @" Company ON Employee.Company_ID = Company.Company_ID  Left JOIN" +
                        @" Branch ON Employee.Branch_ID = Branch.Branch_ID INNER JOIN" +
                        @" Department ON Employee.Department_ID = Department.Department_ID "+ 
                        @"Where Employee.Deleted =  0 "+
                        @"ORDER BY Employee.Emp_MidName");
     
            grdEmployees.DataSource = EmpDT;
        }

    

        private void GridToFormObj()
        {
     
            cmbCompany.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Company_Name"].ToString();
            txtEmpNo.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_ID"].ToString();
            txtLastName.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_LastName"].ToString();
            txtFirstName.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_FirstName"].ToString();
            txtMidName.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_MidName"].ToString();
            cmbBranch.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Branch_Name"].ToString();
            cmbDepartment.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Department_Name"].ToString();
            cmbEmployment.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_Type"].ToString();
            cmbDayOff.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_DayOff"].ToString();
            //string s = ;
            if (Convert.ToBoolean(EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_Shift"]) == false)
            {
                rdbRegularTime.Checked = true;
            }
            else
            {
                rdbShiftingTime.Checked = true;
            }
            dtPicker1stFrom.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["FirstTimeFrom"].ToString();
            dtPicker1stTo.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["FirstTimeTo"].ToString();

            dtPicker2ndFrom.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["SecondTimeFrom"].ToString();
            dtPicker2ndTo.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["SecondTimeTo"].ToString();

            dtPicker3rdFrom.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["ThirdTimeFrom"].ToString();
            dtPicker3rdTo.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["ThirdTimeTo"].ToString();

            if (Convert.ToBoolean(EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_Status"]) == false)
            {
                rdbActive.Checked = true;
            }
            else
            {
                rdbInactive.Checked = true;
            }


        }

    
        private void rdbAction() {
            if (rdbActive.Checked ==true) {
                strEmpStatus = false;
                rdbInactive.Checked = false;
            } else if (rdbInactive.Checked == true) {
                strEmpStatus = true;
                rdbActive.Checked = false;
            }
        }

        #endregion

        //private void ForInputSecurity(string strApp) {
        //    var list = new List<string>();
        //    list.Add("Select");
        //    list.Add("*");
        //    list.Add("From");
        //    list.Add("Where");
        //    list.Add("null");
        //    list.Add("/");
        //    list.Add("-");
        //    list.Add("'");
        //    list.Add("\"");
        //    list.Add(";");
        //    list.Add("<");
        //    list.Add(">");

        //    if (list.Contains(strApp, StringComparer.OrdinalIgnoreCase))
        //    {
        //        MessageBox.Show("ALA!");
        //    }       
        //}

        //private void txtLastName_TextChanged(object sender, EventArgs e)
        //{
        //    ForInputSecurity(txtLastName.Text);
        //}
    }
}
