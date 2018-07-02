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
    public partial class frmDepartment : Form
    {
        GetDataDB gdt = new GetDataDB();
        DataTable EmpDT = new DataTable();

        int deptId { get; set; }
        bool NewOrEdit { get; set; }
        int userID { set; get; }

        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            LoadToGrid();
            UIEffect("Default");
        }

        private void UIEffect(string Effect)
        {
            switch (Effect)
            {


                case "New":
                    grpSearch.Enabled = false;
                    grpNew.Enabled = true;

                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = false;

                    txtDeptName.Clear();


                    //   ManualObj("New");
                    break;


                case "Edit":
                    grpSearch.Enabled = false;
                    grpNew.Enabled = true;

                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = false;
                    break;
                case "Cancel":
                    grpSearch.Enabled = true;
                    grpNew.Enabled = false;

                    btnNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = false;

                    //   clearTextFields();
                    break;

                case "Save":
                    grpSearch.Enabled = true;
                    grpNew.Enabled = false;
                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = true;

                    break;

                case "Delete":

                    grpSearch.Enabled = true;
                    grpNew.Enabled = false;

                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = true;


                    break;
                case "Default":

                    grpSearch.Enabled = true;
                    grpNew.Enabled = false;

                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = true;

                    if (EmpDT.Rows.Count > 0)
                    {
                        grdDept.Rows[0].Cells[0].Selected = false;
                    }

                    break;
            }
        }


        private void LoadToGrid()
        {

            EmpDT = gdt.GetEmployee(@"SELECT  * From Department WHERE Deleted = 0 ORDER BY Department_Name ");
            grdDept.DataSource = EmpDT;

            GridToFormObj();
        }

        private void GridToFormObj()
        {
            deptId = int.Parse(EmpDT.Rows[grdDept.CurrentRow.Index]["Department_ID"].ToString());
            txtDeptName.Text = EmpDT.Rows[grdDept.CurrentRow.Index]["Department_Name"].ToString();

        }

        private void grdDept_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridToFormObj();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewOrEdit = true;
            UIEffect("New");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (NewOrEdit == true)
            {
                InsertSP insertSP = new InsertSP();
                insertSP.InsertDepartment(deptId, txtDeptName.Text);
                MessageBox.Show(" New SUCCESS");
            }
            else
            {

                UpdateSP updateSP = new UpdateSP();
                updateSP.UpdateDepartment(userID, deptId, txtDeptName.Text);
                MessageBox.Show(" Edit SUCCESS");
            }

            LoadToGrid();
            UIEffect("Save");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewOrEdit = false;
            UIEffect("Edit");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RemoveSP removeSP = new RemoveSP();
            removeSP.RemoveDepartment(userID, deptId);
            MessageBox.Show(" Delete SUCCESS");
            LoadToGrid();
            UIEffect("Delete");
        }

        private void txtDeptName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            EmpDT = gdt.GetDepartment(@"SELECT  * From Department " +
            @" Where  Department_Name like '%" + txtSearch.Text + "%' or " +
            @" Department.Department_ID like '%" + txtSearch.Text + "%' and " +
            @" Department.Deleted =  0 " +
            @" ORDER BY Department.Department_Name ");
            grdDept.DataSource = EmpDT;
            grdDept.Refresh();
        }
    }


}
