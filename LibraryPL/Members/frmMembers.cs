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
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }

        private void _RefreshMembersList()
        {

            dgvBooks.DataSource = clsUser.GetAllUsers();


            cbSearchBy.SelectedIndex = 0;


        }


        private void frmBook_Load(object sender, EventArgs e)
        {
            _RefreshMembersList();
        }


        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = "";

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Form frm = new Members.frmAddUpdateUsers(-1);
            frm.ShowDialog();

            _RefreshMembersList();

        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Members.frmAddUpdateUsers((int)dgvBooks.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshMembersList();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you want to Delete this Member with ID [ " + (int)dgvBooks.CurrentRow.Cells[0].Value + "]", "Confierm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {

                if (clsUser.DeleteUser((int)dgvBooks.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("The Member Deleted");
                    _RefreshMembersList();
                    return;
                }

            }




        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }


    }
}