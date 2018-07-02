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
    public partial class frmHoliday : Form
    {
        GetDataDB gdt = new GetDataDB();
        DataTable EmpDT = new DataTable();

        int HolidayId { get; set; }
        bool NewOrEdit { get; set; }
        int userID { set; get; }
        public frmHoliday()
        {
            InitializeComponent();
        }

        private void frmHoliday_Load(object sender, EventArgs e)
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

                    txtHolidayName.Clear();
                    cmbHolidayType.Text = " ";
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
                    dtpHoliday.Format = DateTimePickerFormat.Custom;
                    dtpHoliday.CustomFormat = "MMM-dd-yyyy ";

                    grpSearch.Enabled = true;
                    grpNew.Enabled = false;

                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = true;

                    if (EmpDT.Rows.Count > 0)
                    {
                        dgvHoliday.Rows[0].Cells[0].Selected = false;
                    }



                    break;
            }
        }


        private void LoadToGrid()
        {

            EmpDT = gdt.GetEmployee(@"SELECT  * From Holiday WHERE Deleted = 0 ORDER BY Holiday_Name ");
            dgvHoliday.DataSource = EmpDT;

            GridToFormObj();
        }

        private void GridToFormObj()
        {

            HolidayId = int.Parse(EmpDT.Rows[dgvHoliday.CurrentRow.Index]["Holiday_ID"].ToString());
            txtHolidayName.Text = EmpDT.Rows[dgvHoliday.CurrentRow.Index]["Holiday_Name"].ToString();
            dtpHoliday.Text= EmpDT.Rows[dgvHoliday.CurrentRow.Index]["Holiday_Date"].ToString();
            cmbHolidayType.Text = EmpDT.Rows[dgvHoliday.CurrentRow.Index]["Holiday_Type"].ToString();
        }

        private void dgvHoliday_CellClick(object sender, DataGridViewCellEventArgs e)
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
                insertSP.InsertHoliday(HolidayId, txtHolidayName.Text , dtpHoliday.Text , cmbHolidayType.Text);
                MessageBox.Show(" New SUCCESS");
            }
            else
            {

                UpdateSP updateSP = new UpdateSP();
                updateSP.UpdateHoliday(userID, HolidayId, txtHolidayName.Text , dtpHoliday.Text, cmbHolidayType.Text);
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
            removeSP.RemoveHoliday(userID, HolidayId);
            MessageBox.Show(" Delete SUCCESS");
            LoadToGrid();
            UIEffect("Delete");
        }

        private void txtHolidayName_KeyPress(object sender, KeyPressEventArgs e)
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
            EmpDT = gdt.GetHoliday(@"SELECT  * From Holiday " +
        @" Where  Holiday_Name like '%" + txtSearch.Text + "%' or " +
        @" Holiday.Holiday_ID like '%" + txtSearch.Text + "%' and " +
        @" Holiday.Deleted =  0 " +
        @" ORDER BY Holiday.Holiday_Name ");
            dgvHoliday.DataSource = EmpDT;
            dgvHoliday.Refresh();
        }

        private void cmbHolidayType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
