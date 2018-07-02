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
    public partial class frmUserAccount : Form
    {
        GetDataDB gdt = new GetDataDB();
        DataTable EmpDT = new DataTable();

        int UAccountId { get; set; }
        bool NewOrEdit { get; set; }
        int userID { set; get; }
        bool EmpReg { set; get; }
        bool FPrintReg { set; get; }
        bool br { set; get; }
        bool co { set; get; }
        bool dept { set; get; }
        bool ho { set; get; }
        bool lo { set; get; }
        bool TimeL { set; get; }
        bool UAcess { set; get; }
        bool rr { set; get; }
        bool sbr { set; get; }
        bool mbr { set; get; }
        bool obr { set; get; }
        bool manual { set; get; }


        public frmUserAccount()
        {
            InitializeComponent();
        }

        private void frmUserAccount_Load(object sender, EventArgs e)
        {
            TreeViewSetUp();
            LoadToGrid();
            UIEffect("Default");

        }

        private void TreeViewSetUp()
        {
            trvPermission.ItemHeight = 23;
            trvPermission.Nodes.Add("Employee Registry");
            trvPermission.Nodes.Add("FingerPrint Registry");
            trvPermission.Nodes.Add("Manual");
            trvPermission.Nodes.Add("Branch");
            trvPermission.Nodes.Add("Company");
            trvPermission.Nodes.Add("Department");
            trvPermission.Nodes.Add("Holiday");
            trvPermission.Nodes.Add("Location");
            trvPermission.Nodes.Add("Time Limit");
            trvPermission.Nodes.Add("User Access");
            trvPermission.Nodes.Add("Regular Time Reports");
            trvPermission.Nodes.Add("Short Break Time Reports");
            trvPermission.Nodes.Add("Meal Break Time Reports");
            trvPermission.Nodes.Add("Official Bussiness Time Reports");
        }

        private void UIEffect(string Effect)
        {
            switch (Effect)
            {


                case "New":
                    grpSearch.Enabled = false;
                    grpAcctDetails.Enabled = true;
                    grpPermission.Enabled = true;

                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = false;

                    clearTextFields();
                    ClearTreeNodes();
                    break;


                case "Edit":
                    grpSearch.Enabled = false;
                    grpAcctDetails.Enabled = true;
                    grpPermission.Enabled = true;

                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = false;
                    break;
                case "Cancel":
                    grpSearch.Enabled = true;
                    grpAcctDetails.Enabled = false;
                    grpPermission.Enabled = false;

                    btnNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = false;

                    clearTextFields();
                    ClearTreeNodes();
                    break;

                case "Save":
                    grpSearch.Enabled = true;
                    grpAcctDetails.Enabled = false;
                    grpPermission.Enabled = false;

                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = true;

                    break;

                case "Delete":

                    grpSearch.Enabled = true;
                    grpAcctDetails.Enabled = false;
                    grpPermission.Enabled = false;

                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = true;


                    break;
                case "Default":

                    grpSearch.Enabled = true;
                    grpAcctDetails.Enabled = false;
                    grpPermission.Enabled = false;

                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = true;

                    //if (EmpDT.Rows.Count > 0)
                    //{
                    //    dgvAccount.Rows[0].Cells[0].Selected = false;
                    //}



                    break;
            }
        }

        private void clearTextFields()
        {
            txtNewPass.Clear();
            txtOldPass.Clear();
            txtUserName.Clear();
        }

        private void ClearTreeNodes()
        {
            trvPermission.Nodes[0].Checked = false;
            trvPermission.Nodes[1].Checked = false;
            trvPermission.Nodes[2].Checked = false;
            trvPermission.Nodes[3].Checked = false;
            trvPermission.Nodes[4].Checked = false;
            trvPermission.Nodes[5].Checked = false;
            trvPermission.Nodes[6].Checked = false;
            trvPermission.Nodes[7].Checked = false;
            trvPermission.Nodes[8].Checked = false;
            trvPermission.Nodes[9].Checked = false;
            trvPermission.Nodes[10].Checked = false;
            trvPermission.Nodes[11].Checked = false;
            trvPermission.Nodes[12].Checked = false;
            trvPermission.Nodes[13].Checked = false;
        }

        private void LoadToGrid()
        {

            EmpDT = gdt.GetEmployee(@"SELECT  * From UserAccount WHERE Deleted = 0 ORDER BY UserName ");
            dgvAccount.DataSource = EmpDT;

            GridToFormObj();
        }

        private void GridToFormObj()
        {
            UAccountId = int.Parse(EmpDT.Rows[dgvAccount.CurrentRow.Index]["UserAccess_ID"].ToString());
            txtUserName.Text = EmpDT.Rows[dgvAccount.CurrentRow.Index]["UserName"].ToString();
            txtOldPass.Text = EmpDT.Rows[dgvAccount.CurrentRow.Index]["Password"].ToString();

            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["EmpRegistry"]) == true)
            {
                trvPermission.Nodes[0].Checked = true;
            }else { trvPermission.Nodes[0].Checked = false; }
            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["FPrintRegistry"]) == true)
            {
                trvPermission.Nodes[1].Checked = true;
            }else { trvPermission.Nodes[1].Checked = false; }
            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["Manual"]) == true)
            {
                trvPermission.Nodes[2].Checked = true;
            }else { trvPermission.Nodes[2].Checked = false; }
            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["Branch"]) == true)
            {
                trvPermission.Nodes[3].Checked = true;
            }else { trvPermission.Nodes[3].Checked = false; }
            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["Company"]) == true)
            {
                trvPermission.Nodes[4].Checked = true;
            } else { trvPermission.Nodes[4].Checked = false; }
            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["Department"]) == true)
            {
                trvPermission.Nodes[5].Checked = true;
            }else { trvPermission.Nodes[5].Checked = false; }
            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["Holiday"]) == true)
            {
                trvPermission.Nodes[6].Checked = true;
            }else { trvPermission.Nodes[6].Checked = false; }
            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["Location"]) == true)
            {
                trvPermission.Nodes[7].Checked = true;
            }else { trvPermission.Nodes[7].Checked = false; }
            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["TimeLimit"]) == true)
            {
                trvPermission.Nodes[8].Checked = true;
            }else { trvPermission.Nodes[8].Checked = false; }
            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["UserAccess"]) == true)
            {
                trvPermission.Nodes[9].Checked = true;
            }else { trvPermission.Nodes[9].Checked = false; }
            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["RegReports"]) == true)
            {
                trvPermission.Nodes[10].Checked = true;
            }else { trvPermission.Nodes[10].Checked = false; }
            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["ShortBReports"]) == true)
            {
                trvPermission.Nodes[11].Checked = true;
            }else { trvPermission.Nodes[11].Checked = false; }
            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["MealBReports"]) == true)
            {
                trvPermission.Nodes[12].Checked = true;
            }else { trvPermission.Nodes[12].Checked = false; }
            if (Convert.ToBoolean(EmpDT.Rows[dgvAccount.CurrentRow.Index]["OBReports"]) == true)
            {
                trvPermission.Nodes[13].Checked = true;
            }else { trvPermission.Nodes[13].Checked = false; }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewOrEdit = true;
            UIEffect("New");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewOrEdit = false;
            UIEffect("Edit");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UIEffect("Cancel");
            GridToFormObj();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            getTNodesValue();
            if (NewOrEdit == true)
            {
                InsertSP insertSP = new InsertSP();
                insertSP.InsertUserAccount(userID, txtUserName.Text, txtNewPass.Text , EmpReg , FPrintReg , br , co, dept, ho, lo, TimeL, UAcess, rr, sbr, mbr, obr, manual);
                MessageBox.Show(" New SUCCESS");
            }
            else
            {

                UpdateSP updateSP = new UpdateSP();
                updateSP.UpdateUserAccount(userID, UAccountId,txtUserName.Text, txtNewPass.Text, EmpReg, FPrintReg, br, co, dept, ho, lo, TimeL, UAcess, rr, sbr, mbr, obr, manual);
                MessageBox.Show(" Edit SUCCESS");
            }

            LoadToGrid();
            UIEffect("Save");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RemoveSP removeSP = new RemoveSP();
            removeSP.RemoveUserAccount(userID, UAccountId);
            MessageBox.Show(" Delete SUCCESS");
            LoadToGrid();
            UIEffect("Delete");
        }

        private void getTNodesValue() {
            if (trvPermission.Nodes[0].Checked == true)
            {
                EmpReg = true;
            }
            else {
                EmpReg = false;
            }

            if (trvPermission.Nodes[1].Checked == true)
            {
                FPrintReg = true;
            }
            else
            {
                FPrintReg = false;
            }

            if (trvPermission.Nodes[2].Checked == true)
            {
                manual = true;
            }
            else
            {
                manual = false;
            }
            if (trvPermission.Nodes[3].Checked == true)
            {
                br = true;
            }
            else
            {
                br = false;
            }
            if (trvPermission.Nodes[4].Checked == true)
            {
                co = true;
            }
            else
            {
                co = false;
            }
            if (trvPermission.Nodes[5].Checked == true)
            {
                dept = true;
            }
            else
            {
                dept = false;
            }
            if (trvPermission.Nodes[6].Checked == true)
            {
                ho = true;
            }
            else
            {
                ho = false;
            }
            if (trvPermission.Nodes[7].Checked == true)
            {
                lo = true;
            }
            else
            {
                lo = false;
            }
            if (trvPermission.Nodes[8].Checked == true)
            {
                TimeL = true;
            }
            else
            {
                TimeL = false;
            }
            if (trvPermission.Nodes[9].Checked == true)
            {
                UAcess = true;
            }
            else
            {
                UAcess = false;
            }
            if (trvPermission.Nodes[10].Checked == true)
            {
                rr = true;
            }
            else
            {
                rr = false;
            }
            if (trvPermission.Nodes[11].Checked == true)
            {
                sbr = true;
            }
            else
            {
                sbr = false;
            }
            if (trvPermission.Nodes[12].Checked == true)
            {
                mbr = true;
            }
            else
            {
                mbr = false;
            }
            if (trvPermission.Nodes[13].Checked == true)
            {
                obr = true;
            }
            else
            {
                obr = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            EmpDT = gdt.GetCompany(@"SELECT  * From UserAccount " +
                @" Where  UserName like '%" + txtSearch.Text + "%' or " +
                @" UserAccount.UserAccess_ID like '%" + txtSearch.Text + "%' and " +
                @" UserAccount.Deleted =  0 " +
                @" ORDER BY UserAccount.UserName ");
            dgvAccount.DataSource = EmpDT;
            dgvAccount.Refresh();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridToFormObj();
        }
        private void ForInputSecurity(string strApp , TextBox s)
        {
            var list = new List<string>();
            list.Add("Select");
            list.Add("*");
            list.Add("From");
            list.Add("Where");
            list.Add("null");
            list.Add("/");
            list.Add("-");
            list.Add("'");
            list.Add("\"");
            list.Add("<");
            list.Add(">");

            if (list.Contains(strApp, StringComparer.OrdinalIgnoreCase))
            {
                s.Clear();
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            ForInputSecurity(txtUserName.Text , txtUserName);
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            ForInputSecurity(txtOldPass.Text, txtOldPass);
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            ForInputSecurity(txtNewPass.Text, txtNewPass);
        }
    }
}
