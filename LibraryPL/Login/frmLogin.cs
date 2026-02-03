using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryBusinessLaryer;

namespace LibraryWinFormApp_PersentantionLayer.Login
{
    public partial class frmLogin : Form
    {
        public int FailedTiesNumber = 3;

        public frmLogin()
        {
            InitializeComponent();

        }
     
        private void OpenfrmHome(string UserName, string Password)
        {
            this.Hide();
            Form frm = new frmHome(UserName, Password);
            frm.WindowState = FormWindowState.Maximized;    
            frm.ShowDialog();

        }

        private void CleartxtBox()
        {
            txtPassword.Clear();
            txtUserName.Clear();
        }
     
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
      
        private bool IsRightUserNameAndPassword(string UserName, string Password)
        { 
            return clsEmployee.IsEmployeeExist(UserName,Password);
        }


        private void LoginEmployeeToSystem()
        {
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;

            if (string.IsNullOrEmpty(UserName) && string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please, Enter Value to Filed!");
                return;
            }



            if (!IsRightUserNameAndPassword(UserName, Password))
            {
                FailedTiesNumber--;
                lblFailedTries.Text = "The Email Or Password Is Failed.\nYou have [" + (FailedTiesNumber) + "] Try(ies)." ;
                CleartxtBox();
                if (FailedTiesNumber <= 0)
                {
                    MessageBox.Show("You Tried a Lot, Then  For Secrety We Close The System ","Confier",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    this.Close();
                }

                return;
            }


            OpenfrmHome(UserName, Password);
            CleartxtBox();

        }

 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginEmployeeToSystem();

        }

        private void chShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowPassword.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

    
      

    }
}
