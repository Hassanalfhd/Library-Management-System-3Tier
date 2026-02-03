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

namespace LibraryWinFormApp_PersentantionLayer.Employees
{
    public partial class frmAddUpdateEmployees: Form
    {

        private enum enMode {AddMode = 0, UpdateMode = 1 }
        private enMode _Mode;
         int _EmployeeID { set; get; }
         clsEmployee _Employee ;




         public frmAddUpdateEmployees(int _EmployeeID)
        {
            InitializeComponent();

            this._EmployeeID = _EmployeeID;

            if (_EmployeeID == -1)
                _Mode = enMode.AddMode;
            else
                _Mode = enMode.UpdateMode;

        }


         private int Permissions()
         {
             int PermissinNo = 0;

             if (ckAll.Checked)
                 return -1;


             if(ckBook.Checked)
                 PermissinNo += (int) clsEmployee.enPermissinos.pBook ;

             
                if(ckBorrowing.Checked)
                    PermissinNo += (int)clsEmployee.enPermissinos.pBorrowing;


                if (ckEmployees.Checked)
                    PermissinNo += (int)clsEmployee.enPermissinos.pEmployees;

                if (ckFines.Checked)
                    PermissinNo += (int)clsEmployee.enPermissinos.pFines;
 
             if (ckMembers.Checked)
                 PermissinNo += (int)clsEmployee.enPermissinos.pMembers;
 
             if (ckReservation.Checked)
                 PermissinNo += (int)clsEmployee.enPermissinos.pReservation;


             if (ckAuothers.Checked)
                 PermissinNo += (int)clsEmployee.enPermissinos.pAuother;


             return PermissinNo;
         }


        private void SaveAddData()
        {

            _Employee.FirstName = txtFirstName.Text;
            _Employee.LastName = txtLastName.Text;
            _Employee.Email = txtEmail.Text;
            _Employee.Password = txtPassword.Text;
            _Employee.Phone = txtPhone.Text;

            _Employee.UserName = txtUserName.Text;

            _Employee.Permissions = Permissions();

            if (rbMale.Checked)
                _Employee.Gender = 'M';
            else
                _Employee.Gender = 'F';


            if (!string.IsNullOrEmpty(picEmployeeImage.ImageLocation))
                _Employee.ImagePath = picEmployeeImage.ImageLocation;
            else
                _Employee.ImagePath = "";

            if (nudSalary.Value <= 0)
            {
                MessageBox.Show("No value in salary!", "Confierm",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _Employee.Salary =  nudSalary.Value;

            if (_Employee.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
            }

         
            _Mode = enMode.UpdateMode;
            lbAddUpdateTitle.Text = "Edit Employee ID = " + _Employee.EmployeeID;
            lblEmployeeID.Text = _Employee.EmployeeID.ToString();

        }
     

        private void Save_Click(object sender, EventArgs e)
        {
            SaveAddData();

        }


        private void frmAddUpdate_Load(object sender, EventArgs e)
        {
            _LoadData();
        }


        private void LoadPermissionTockPermissions()
        {
            int PermissinNo = clsEmployee.Find(_EmployeeID).Permissions;

            if (PermissinNo  == -1)
            {
                ckAll.Checked = true;
                return;
            }


                if((PermissinNo & (int)clsEmployee.enPermissinos.pBook) == (int)clsEmployee.enPermissinos.pBook)
                    ckBook.Checked = true;


                if ((PermissinNo & (int)clsEmployee.enPermissinos.pBorrowing) == (int)clsEmployee.enPermissinos.pBorrowing)
                    ckBorrowing.Checked = true;

                if ((PermissinNo & (int)clsEmployee.enPermissinos.pEmployees) == (int)clsEmployee.enPermissinos.pEmployees)
                    ckEmployees.Checked = true;

                if ((PermissinNo & (int)clsEmployee.enPermissinos.pFines) == (int)clsEmployee.enPermissinos.pFines)
                    ckFines.Checked = true;

                if ((PermissinNo & (int)clsEmployee.enPermissinos.pMembers) == (int)clsEmployee.enPermissinos.pMembers)
                    ckMembers.Checked = true;


                if ((PermissinNo & (int)clsEmployee.enPermissinos.pReservation) == (int)clsEmployee.enPermissinos.pReservation)
                    ckReservation.Checked = true;

                if ((PermissinNo & (int)clsEmployee.enPermissinos.pAuother) == (int)clsEmployee.enPermissinos.pAuother)
                    ckAuothers.Checked = true;


        }



        private void _LoadData()
        {

            rbMale.Checked = true;

            ckAll.Checked = true;
            

            if (_Mode == enMode.AddMode)
            {
                lbAddUpdateTitle.Text = "Add New Employee";
                _Employee = new clsEmployee();
                return;
            }


            _Employee = clsEmployee.Find(_EmployeeID);


           
            if (_Employee == null)
            {
                MessageBox.Show("This form will be closed because No Employee with ID = " + _Employee);
                this.Close();

                return;
            }


            lbAddUpdateTitle.Text = "Edit Book ID = " + _EmployeeID;
            txtFirstName.Text = _Employee.FirstName;
            txtLastName.Text = _Employee.LastName;
            txtEmail.Text = _Employee.Email;
            txtUserName.Text = _Employee.UserName;
            txtPhone.Text = _Employee.Phone;
            txtPassword.Text = _Employee.Password;

            nudSalary.Value = _Employee.Salary;
            LoadPermissionTockPermissions();

            if (!string.IsNullOrEmpty(_Employee.ImagePath))
                picEmployeeImage.Load(_Employee.ImagePath);
            



            if (_Employee.Gender == 'M')
                rbMale.Checked = true;
            else
                rbFamle.Checked = true;

            lblEmployeeID.Text = _Employee.EmployeeID.ToString();

        }



        private void btnCasel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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


        private void btnChoiesImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string SelectedFilePath = openFileDialog1.FileName;

                picEmployeeImage.Load(SelectedFilePath);
            }
        }



    }


}
