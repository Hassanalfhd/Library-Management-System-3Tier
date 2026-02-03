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

namespace LibraryWinFormApp_PersentantionLayer
{
    public partial class frmAuothers : Form
    {
        public frmAuothers()
        {
            InitializeComponent();
        }

        private void _RefreshAuothersList()
        {

            dgvAuothers.DataSource = clsAuother.GetAllAuothers();


            cbSearchBy.SelectedIndex = 0;



        }



        private void frmBook_Load(object sender, EventArgs e)
        {
            _RefreshAuothersList();
        }


        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = "";

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Form frm = new Auothers.frmAddUpdateAuothers(-1);
            frm.ShowDialog();

            _RefreshAuothersList();

        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Auothers.frmAddUpdateAuothers((int)dgvAuothers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshAuothersList();
        }



    

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to Delete this Auotehr with ID [ " + (int)dgvAuothers.CurrentRow.Cells[0].Value + "]", "Confierm", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {

                if (clsAuother.DeleteAuother((int)dgvAuothers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("The Auother Deleted");
                    _RefreshAuothersList();
                    return;
                }
                else
                {
                    MessageBox.Show("The Auother Not Deleted");
                
                }
            }




        }
    }
}