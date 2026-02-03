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

namespace LibraryWinFormApp_PersentantionLayer.Members
{
    public partial class frmAddUpdateUsers : Form
    {

        private enum enMode {AddMode = 0, UpdateMode = 1 }
        private enMode _Mode;
         int _UserID { set; get; }
         clsUser _User;


         public frmAddUpdateUsers(int UserID)
        {
            InitializeComponent();

            this._UserID = UserID;

            if (UserID == -1)
                _Mode = enMode.AddMode;
            else
                _Mode = enMode.UpdateMode;

        }

     


        private void SaveAddData()
        {

            int x = 1;
            _User.FirstName = txtFirstName.Text;
            _User.LastName = txtLastName.Text;
            _User.Email = txtEmail.Text;
            _User.LibraryCard = txtLibraryNoCard.Text ;
            _User.Password = txtPassword.Text;
            _User.Phone = txtPhone.Text;

            if (rbMale.Checked)
                _User.Gender = 'M';
            else
                _User.Gender = 'F';


            if (_User.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
            }

            x++;
            _Mode = enMode.UpdateMode;
            lbAddUpdateTitle.Text = "Edit Book ID = " + _User.UserID;
            lblUserID.Text = _User.UserID.ToString();
        }
     
        private void Save_Click(object sender, EventArgs e)
        {
            SaveAddData();

        }


        private void frmAddUpdate_Load(object sender, EventArgs e)
        {
            _LoadData();
        }


        private void _LoadData()
        {

            rbMale.Checked = true;
           

            if (_Mode == enMode.AddMode)
            {
                lbAddUpdateTitle.Text = "Add New Member";
                _User = new clsUser();
                return;
            }


            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("This form will be closed because No User with ID = " + _UserID);
                this.Close();

                return;
            }

            lbAddUpdateTitle.Text = "Edit Book ID = " + _UserID;
            txtFirstName.Text = _User.FirstName;
            txtLastName.Text = _User.LastName;
            txtEmail.Text = _User.Email;
            txtLibraryNoCard.Text = _User.LibraryCard;
            txtPhone.Text = _User.Phone;
            txtPassword.Text = _User.Password;


            if (_User.Gender == 'M')
                rbMale.Checked = true;
            else
                rbFamle.Checked = true;
            
            
            lblUserID.Text = _User.UserID.ToString();
        }



        private void btnCasel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtValidation_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtValidation = sender as TextBox;

            if (string.IsNullOrEmpty(txtValidation.Text))
            {
                e.Cancel = true;
                txtValidation.Focus();
                errorProvider1.SetError(txtValidation, "Should have a value!");
            }
            else
            {

                e.Cancel = false;
                errorProvider1.SetError(txtValidation, "");
            }

        }

    }


}
