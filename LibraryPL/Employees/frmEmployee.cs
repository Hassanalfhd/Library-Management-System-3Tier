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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void _RefreshEmployeeList()
        {

            dgvEmployee.DataSource = clsEmployee.GetAllEmployees();


            cbSearchBy.SelectedIndex = 0;

            

        }


        private void frmBook_Load(object sender, EventArgs e)
        {
            _RefreshEmployeeList();
        }


        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = "";

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Form frm = new Employees.frmAddUpdateEmployees(-1);
            frm.ShowDialog();

            _RefreshEmployeeList();

        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Employees.frmAddUpdateEmployees((int)dgvEmployee.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshEmployeeList();
        }


 

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you Sure You want to delete This Employee With ID = [" + (int)dgvEmployee.CurrentRow.Cells[0].Value + "] ", "Confierm", MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {

                if (clsEmployee.DeleteEmployee((int)dgvEmployee.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("This Employee Is Deleted");
                    _RefreshEmployeeList();
                }
                else
                {
                    MessageBox.Show("This Employee Is Not Deleted");
                
                }

            }

        }

      



    }
}