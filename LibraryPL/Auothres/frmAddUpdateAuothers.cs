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

namespace LibraryWinFormApp_PersentantionLayer.Auothers
{
    public partial class frmAddUpdateAuothers : Form
    {

        private enum enMode {AddMode = 0, UpdateMode = 1 }
        private enMode _Mode;
         int _AuotherID { set; get; }
         clsAuother _Auother;


         public frmAddUpdateAuothers(int UserID)
        {
            InitializeComponent();

            this._AuotherID = UserID;

            if (UserID == -1)
                _Mode = enMode.AddMode;
            else
                _Mode = enMode.UpdateMode;

        }

     


        private void SaveAddData()
        {

            int x = 1;
            _Auother.FirstName = txtFirstName.Text;
            _Auother.LastName = txtLastName.Text;
            _Auother.Email = txtEmail.Text;
            _Auother.Phone = txtPhone.Text;

            if (rbMale.Checked)
                _Auother.Gender = 'M';
            else
                _Auother.Gender = 'F';


            if (_Auother.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
            }

            x++;
            _Mode = enMode.UpdateMode;
            lbAddUpdateTitle.Text = "Edit Auother ID = " + _Auother.AuotherID;
            lblUserID.Text = _Auother.AuotherID.ToString();
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
                lbAddUpdateTitle.Text = "Add New Auother";
                _Auother = new clsAuother();
                return;
            }


            _Auother = clsAuother.Find(_AuotherID);

            if (_Auother == null)
            {
                MessageBox.Show("This form will be closed because No Auother with ID = " + _AuotherID);
                this.Close();

                return;
            }

            lbAddUpdateTitle.Text = "Edit Auother ID = " + _AuotherID;
            txtFirstName.Text = _Auother.FirstName;
            txtLastName.Text = _Auother.LastName;
            txtEmail.Text = _Auother.Email;
            txtPhone.Text = _Auother.Phone;


            if (_Auother.Gender == 'M')
                rbMale.Checked = true;
            else
                rbFamle.Checked = true;


            lblUserID.Text = _Auother.AuotherID.ToString();
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
