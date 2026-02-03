using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryWinFormApp_PersentantionLayer.Properties;
using LibraryBusinessLaryer;

namespace LibraryWinFormApp_PersentantionLayer
{
    public partial class frmHome : Form
    {
        private clsEmployee _Employee;


        public frmHome(string UserName, string Password)
        {
            InitializeComponent();
            _Employee = clsEmployee.Find(UserName, Password);
          

        }

        private void LoadEmployeeDataToHome(string ImagePath)
        {
            if (!string.IsNullOrEmpty(ImagePath))
              picEmployeeHomeImage.Load(_Employee.ImagePath);
            



    
            lblUserName.Text = _Employee.FullName;
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

     
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMaximum_Click(object sender, EventArgs e)
        {
            if (picMaximum.Tag == "Normal")
            {
                picMaximum.Image= Resources.maximize;

                this.WindowState = FormWindowState.Normal;
                picMaximum.Tag = "Maximzed";
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                picMaximum.Image = Resources.Normal;
                picMaximum.Tag = "Normal";
            }

        }

     

        private Form ActiveForm = null;

        private void OpenChiledForm(Form ChiledForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();

            ActiveForm = ChiledForm;

            ChiledForm.TopLevel = false;
            ChiledForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ChiledForm.Dock = DockStyle.Fill;

            pnlAddFormsTo.Controls.Add(ChiledForm);
            pnlAddFormsTo.Tag = ChiledForm;

            ChiledForm.BringToFront();

            ChiledForm.Show();

        }


        public bool IsCheckAcsessPermisionRight(clsEmployee.enPermissinos Permissinos)
        {

            if (_Employee.ChackAccessPermissinos(Permissinos))
            {
                return true;
            }

            return false;
        }



        private void btnBooks_Click(object sender, EventArgs e)
        {

            if (!IsCheckAcsessPermisionRight(clsEmployee.enPermissinos.pBook))
            {

                MessageBox.Show("Access Denied! Contact your Access admin", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            Form frm = new frmBook();
            OpenChiledForm(frm);
        }


        private void btnHome_Click(object sender, EventArgs e)
        {

            Form frm = new frmHomeItems();
            OpenChiledForm(frm);
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            if (!IsCheckAcsessPermisionRight(clsEmployee.enPermissinos.pMembers))
            {

                MessageBox.Show("Access Denied! Contact your Access admin", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnMember.Visible = false;
                return;
            }

            Form frm = new frmMembers();
            OpenChiledForm(frm);
        }

        private void CheckPermissionsAndHiddeButton()
        {
            if (!IsCheckAcsessPermisionRight(clsEmployee.enPermissinos.pEmployees))
            {
                btnfrmEmployee.Visible = false;
             
            }


            if (!IsCheckAcsessPermisionRight(clsEmployee.enPermissinos.pMembers))
            {
                btnMember.Visible = false;
            }


            if (!IsCheckAcsessPermisionRight(clsEmployee.enPermissinos.pBorrowing))
            {
                btnAuothers.Visible = false;
            }

        }

        private void btnfrmEmployee_Click(object sender, EventArgs e)
        {
            if (!IsCheckAcsessPermisionRight(clsEmployee.enPermissinos.pEmployees))
            {

                MessageBox.Show("Access Denied! Contact your Access admin", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form frm = new frmEmployee();
            OpenChiledForm(frm);
        }

      
        private void btnAuothers_Click(object sender, EventArgs e)
        {
            if (!IsCheckAcsessPermisionRight(clsEmployee.enPermissinos.pAuother))
            {

                MessageBox.Show("Access Denied! Contact your Access admin", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAuothers.Visible = false;
                return;
            }
            
            Form frm = new frmAuothers();
            OpenChiledForm(frm);
        }


        private void btnBorrowingBook_Click(object sender, EventArgs e)
        {
            if (!IsCheckAcsessPermisionRight(clsEmployee.enPermissinos.pBorrowing))
            {

                MessageBox.Show("Access Denied! Contact your Access admin", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Form frm = new BorrowingRecordsFolder.frmBorrowingRecord();
            OpenChiledForm(frm);
        }


        private void btnReservations_Click(object sender, EventArgs e)
        {
            if (!IsCheckAcsessPermisionRight(clsEmployee.enPermissinos.pReservation))
            {

                MessageBox.Show("Access Denied! Contact your Access admin", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form frm = new Reservations.frmReservations();
            OpenChiledForm(frm);
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            if (!IsCheckAcsessPermisionRight(clsEmployee.enPermissinos.pFines))
            {

                MessageBox.Show("Access Denied! Contact your Access admin", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Form frm = new Fines.frmFine();
            OpenChiledForm(frm);
        }

        string GetTime()
        {
            DateTime Time = DateTime.Now;

            string sTime = Time.Hour + ":" + Time.Minute + ":" + Time.Second;

            return sTime;

        }


        private void frmHome_Load(object sender, EventArgs e)
        {
                LoadEmployeeDataToHome(_Employee.ImagePath);
                CheckPermissionsAndHiddeButton();

                Form frm = new frmHomeItems();
                OpenChiledForm(frm);

                picMaximum.Image = Resources.maximize;
                lblTime.Text = GetTime();
                lblDate.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = GetTime();
        }



    }
}
