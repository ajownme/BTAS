
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using System.IO;

namespace Biometric_Time_Attendance_System
{
    delegate void Function();
    public delegate void OnTemplateEventHandler(DPFP.Template template);
    

    public partial class frmFingerReg : Form, DPFP.Capture.EventHandler
    {
        DataTable EmpDT = new DataTable();
        GetDataDB gdt = new GetDataDB();
        DataTable CompanyDT = new DataTable();
        DataTable BranchDT = new DataTable();
        DataTable DepartmentDT = new DataTable();

         byte[] serializedTemplate { get; set; }
        string strEmpNo { get; set; }
        string strLastName { get; set; }
        string strFirstName { get; set; }
        string strMidName { get; set; }
        string strCompany { get; set; }
        string strBranch { get; set; }
        string strDept { get; set; }
        string strUIEffect { get; set; }
        int userID { set; get; }
        public frmFingerReg(int uid, string en, string ln, string fn, string mn, string cn, string bn, string dn ,string  ui)
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

        //public frmFingerReg(int uid)
        //{
        //    InitializeComponent();

        //    userID = uid;   

        //    EmpListToThisForm();
        //}

        private void EmpListToThisForm() {
            txtEmpNo.Text = strEmpNo;
            txtLastName.Text = strLastName;
            txtFirstName.Text = strFirstName;
            txtMidName.Text = strMidName;
            txtCompany.Text = strCompany.ToString();
            txtBranch.Text = strBranch;
            txtDept.Text = strDept;
        }
        protected virtual void Process(DPFP.Sample Sample)
        {
            // Draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));
        }
        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();  // Create a sample convertor.
            Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);                                 // TODO: return bitmap as a result
            return bitmap;
        }


        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate ()
            {
              
                    switch (Enroller.FeaturesNeeded)
                    {
                        case 4:
                            Picture1.Image = new Bitmap(bitmap, Picture1.Size);   // fit the image into the picture box
                            break;
                        case 3:
                            Picture2.Image = new Bitmap(bitmap, Picture1.Size);   // fit the image into the picture box
                            break;
                        case 2:
                            Picture3.Image = new Bitmap(bitmap, Picture1.Size);   // fit the image into the picture box
                            break;
                        case 1:
                            Picture4.Image = new Bitmap(bitmap, Picture1.Size);   // fit the image into the picture box
                            break;
                    }
                                        
            }));
        }

        //private void UpdateStatus()
        //{
        //    // Show number of samples needed.
        //    SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
        //}
 
        protected void SetStatus(string status)
        {
            this.Invoke(new Function(delegate ()
            {
                Prompt.Text = status;
            }));
        }


        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetStatus("Can't terminate capture!");
                }
            }
        }

        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if (null != Capturer)
                    Capturer.EventHandler = this;					// Subscribe for capturing events.
                else
                    SetStatus("Can't initiate capture operation");
            }
            catch
            {
                SetStatus("Can't initiate capture operation");
            }
        }


        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetStatus("Using the fingerprint reader, scan your fingerprint.");
                }
                catch
                {
                    SetStatus("Using the fingerprint reader, scan your fingerprint");
                }
            }
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                //  VerifyButton.Enabled = SaveButton.Enabled = (Template != null);
                //if (Template != null)
                //    MakeReport("The fingerprint template is ready for fingerprint verification.");
                //else
                //    MakeReport("The fingerprint template is not valid. Repeat fingerprint enrollment.");
            }));
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }




        #region Enroll Biometric EventHandler  Members:
        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            try {
         
            // Check quality of the sample and add to enroller if it's good
            if (features != null)
                try
                {
                    //MakeReport("The fingerprint feature set was created.");
                    Enroller.AddFeatures(features);     // Add feature set to template.
                }
                finally
                {
                   // UpdateStatus();

                    // Check if template has been created.
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:   // report success and stop capturing
                            OnTemplate(Enroller.Template);
                                SetStatus("FingerPrint samples complete. Click \"Save\" .");
                                MemoryStream str = new MemoryStream();
                                Enroller.Template.Serialize(str);
                                serializedTemplate = str.ToArray();
                                Stop();
                            break;

                        case DPFP.Processing.Enrollment.Status.Failed:  // report failure and restart capturing
                            Enroller.Clear();
                            Stop();
                          // UpdateStatus();
                          // OnTemplate(null);
                          //  Start();
                            break;
                    }
                }

            }
            catch (Exception )
            {
                SetStatus("Invalid FingerPrint Enrollment! ");
            }
        }


        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
    
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
          //  throw new NotImplementedException();
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
          //  throw new NotImplementedException();
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {

           // throw new NotImplementedException();
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            {
                if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                    SetStatus("The quality of the fingerprint sample is good.");
                else
                    SetStatus("The quality of the fingerprint sample is poor.");
            }
        }
        #endregion

        #region UI frmFingerReg  EventHandler  Members:
        private void Form1_Load(object sender, EventArgs e)
        {
            SetFormValue();
            UIEffect("Default");
       
          
        }
    
        private void btnCancel_Click(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Template == null) {
               MessageBox.Show("Incomplete Sample.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //    DialogResult result = MessageBox.Show("Do you want to save this information ?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{


            //    InsertSP insertSP = new InsertSP();
            //    insertSP.InsertEmpFingerPrint(userID, int.Parse(txtEmpNo.Text), serializedTemplate ,cmbFingerList.Text);
            //    MessageBox.Show(" Insert SUCCESS");

            //    UIEffect("Save");
            //   LoadToGrid();
            //}
              
            
        }

        private void btnAddFPrint_Click(object sender, EventArgs e)
        {
           // EmpListToThisForm();
            UIEffect("New");
            //if (txtEmpNo.Text != string.Empty)
            //{
            //    MessageBox.Show("Select in the \"Finger Use\" for fingerprint sample.");

            //    UIEffect("New");
            //}
            //else {
            //    MessageBox.Show("Must select an Employee.");
            //}              
        }

        private void grdEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridToFormObj();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            EmpDT = gdt.GetEmployee(@"SELECT   CONCAT (Employee.Emp_LastName ,', ', Employee.Emp_FirstName,' ', Employee.Emp_MidName) as EmpName , Employee.Created_By, Employee.Date_Created, Employee.Modify_By, Employee.Date_Modify, Employee.Deleted, Employee.Emp_ID, Employee.Emp_LastName, Employee.Emp_FirstName, " +
                       @" Employee.Emp_MidName, Employee.Company_ID, Employee.Branch_ID, Employee.Department_ID, Employee.Emp_Type, Employee.Emp_DayOff, Employee.Emp_Shift," +
                       @" Employee.FirstTimeFrom, Employee.FirstTimeTo, Employee.SecondTimeFrom, Employee.SecondTimeTo, Employee.ThirdTimeFrom, Employee.ThirdTimeTo, Company.Company_Name, Branch.Branch_Name, " +
                       @" Department.Department_Name ,EmpFingerPrint.Finger_Type " +
                       @" FROM   Employee Left JOIN " +
                       @" Company ON Employee.Company_ID = Company.Company_ID  INNER JOIN" +
                       @" Branch ON Employee.Branch_ID = Branch.Branch_ID INNER JOIN" +
                       @" Department ON Employee.Department_ID = Department.Department_ID  INNER JOIN" +
                       @" EmpFingerPrint ON Employee.Emp_ID = EmpFingerPrint.Emp_ID " +
                       @" Where  Emp_LastName like '%" + txtSearch.Text + "%' or " +
                       @" Emp_FirstName like '%" + txtSearch.Text + "%' or " +
                       @" Emp_MidName like '%" + txtSearch.Text + "%' or " +
                       @"  Employee.Emp_ID like '%" + txtSearch.Text + "%' and " +
                       @" Employee.Deleted =  0 " +
                       @" ORDER BY Employee.Emp_ID ");
            grdEmployees.DataSource = EmpDT;
            grdEmployees.Refresh();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            SetFormValue();
            UIEffect("Cancel");
        }

        private void cmbFingerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFingerList.Text != string.Empty)
            {
                StartHere();
            }

        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{

        //    DeleteSP deleteSP = new DeleteSP();
        //    deleteSP.DeleteEmpFingerPrint(userID, int.Parse(txtEmpNo.Text));
        //    MessageBox.Show(" Delete SUCCESS");
        //    SetFormValue();
        //    GridToFormObj();
        //}

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        #endregion

        private DPFP.Template Template;
        // public event OnTemplateEventHandler OnTemplate;
        private DPFP.Processing.Enrollment Enroller;
        private DPFP.Capture.Capture Capturer;

     


        #region  frmFingerReg Class Methods :
        private void LoadToGrid()
        {

            EmpDT = gdt.GetEmployee(@"SELECT   CONCAT (Employee.Emp_LastName ,', ', Employee.Emp_FirstName,' ', Employee.Emp_MidName) as EmpName , Employee.Created_By, Employee.Date_Created, Employee.Modify_By, Employee.Date_Modify, Employee.Deleted, Employee.Emp_ID, Employee.Emp_LastName, Employee.Emp_FirstName, " +
                        @" Employee.Emp_MidName, Employee.Company_ID, Employee.Branch_ID, Employee.Department_ID, Employee.Emp_Type, Employee.Emp_DayOff, Employee.Emp_Shift," +
                        @" Company.Company_Name, Branch.Branch_Name, " +
                        @" Department.Department_Name ,EmpFingerPrint.Finger_Type FROM   Employee Left JOIN " +
                        @" Company ON Employee.Company_ID = Company.Company_ID  INNER JOIN" +
                        @" Branch ON Employee.Branch_ID = Branch.Branch_ID INNER JOIN" +
                        @" Department ON Employee.Department_ID = Department.Department_ID   INNER JOIN" +
                        @" EmpFingerPrint ON Employee.Emp_ID = EmpFingerPrint.Emp_ID " +
                        @" Where Employee.Deleted =  0 " +
                        @" ORDER BY Employee.Emp_MidName");
            grdEmployees.DataSource = EmpDT;
        }

        private void UIEffect(string Effect)
        {

            switch (Effect)
            {
                case "Search" :
                    grpDetails.Enabled = false;
                    grpEmpList.Enabled = false;

                    btnSearch.Enabled = false;
                    btnAddFPrint.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = true;
                    break;

                case "New":
                    grpDetails.Enabled = true;
                    grpEmpList.Enabled = false;

                    btnSearch.Enabled = false;
                    btnAddFPrint.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                   
                    SetStatus("Select in the \"Finger Use\" for fingerprint sample.");
                    break;
                case "Cancel":
                    grpDetails.Enabled = false;
                    grpEmpList.Enabled = true;
                    btnAddFPrint.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    grdEmployees.Rows[0].Cells[0].Selected = false;

                  //  clearComboBoxFields();
                    clearTextFields();
                    break;
                case "Save":
                    grpDetails.Enabled = false;
                    grpEmpList.Enabled = true;
                    btnSearch.Enabled = true;
                    btnAddFPrint.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    clearPictureBox();
                    SetStatus("Fingerprint sample successfully saved.");
                    break;

                case "Default":
                    //grpDetails.Enabled = false;
                    //grpEmpList.Enabled = true;

                    //btnSearch.Enabled = true;
                    //btnAddFPrint.Enabled = false;
                    //btnSave.Enabled = false;
                    //btnCancel.Enabled = false;
                    if (EmpDT.Rows.Count > 0)
                    {
                        grdEmployees.Rows[0].Cells[0].Selected = false;
                    }

 
                  
                    //cmbCompany.DropDownStyle = ComboBoxStyle.DropDownList;
                    //cmbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
                    //cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;

                    break;
            }
        }

        private void clearPictureBox() {
            Picture1.Image = null;
            Picture2.Image = null;
            Picture3.Image = null;
            Picture4.Image = null;
        }
  
    
        private void GridToFormObj()
        {

            txtCompany.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Company_Name"].ToString();
            txtEmpNo.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_ID"].ToString();
            txtLastName.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_LastName"].ToString();
            txtFirstName.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_FirstName"].ToString();
            txtMidName.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Emp_MidName"].ToString();
            txtBranch.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Branch_Name"].ToString();
            txtDept.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Department_Name"].ToString();
            cmbFingerList.Text = EmpDT.Rows[grdEmployees.CurrentRow.Index]["Finger_Type"].ToString();


        }

     
        private void SetFormValue()
        {
           
            //CompanyDT = gdt.GetCompany(@"Select Company_ID, Company_Name FROM Company ORDER BY Company_ID ASC");
            //for (int i = 0; i < CompanyDT.Rows.Count; i++)
            //{
            //    cmbCompany.Items.Add(CompanyDT.Rows[i]["Company_Name"].ToString());
            //}

            //BranchDT = gdt.GetBranch(@"Select Branch_ID, Branch_Name FROM Branch ORDER BY Branch_ID ASC");
            //for (int i = 0; i < BranchDT.Rows.Count; i++)
            //{
            //    cmbBranch.Items.Add(BranchDT.Rows[i]["Branch_Name"].ToString());
            //}

            //DepartmentDT = gdt.GetDepartment(@"Select Department_ID, Department_Name FROM Department ORDER BY Department_ID ASC");
            //for (int i = 0; i < DepartmentDT.Rows.Count; i++)
            //{
            //    cmbDepartment.Items.Add(DepartmentDT.Rows[i]["Department_Name"].ToString());
            //}

            LoadToGrid();
          //  GridToFormObj();
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

        private void StartHere() {
            Init();
            Enroller = new DPFP.Processing.Enrollment();
            Start();
        }




        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
           

            frmEmployeeSearch frmEmployeeSearch = new frmEmployeeSearch("frmFingerReg");
            frmEmployeeSearch.Show();
            frmEmployeeSearch.Activate();
            this.Hide();

          
        }
    }
}
