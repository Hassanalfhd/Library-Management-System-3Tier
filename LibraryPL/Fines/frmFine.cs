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

namespace LibraryWinFormApp_PersentantionLayer.Fines
{
    public partial class frmFine : Form
    {

        public frmFine()
        {
            InitializeComponent();
        }

        private void _RefreshFinesList()
        {

            dgvFines.DataSource = clsFine.GetAllFinesJoinData();


            cbSearchBy.SelectedIndex = 0;

        }


        private void frmBook_Load(object sender, EventArgs e)
        {
            _RefreshFinesList();
        }


        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = "";

        }


        private void btnShowCopies_Click(object sender, EventArgs e)
        {
            Form frm = new Books.frmBookCopies(-1);
            frm.ShowDialog();

        }


        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new BorrowingRecordsFolder.frmAddUpdateBorrowingBooks((int)dgvFines.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshFinesList();
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure You want to delete This Fine  With ID = [" + (int)dgvFines.CurrentRow.Cells[0].Value + "] ", "Confierm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {

                if (clsFine.DeleteFine((int)dgvFines.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("This Fine  Is Deleted");
                    _RefreshFinesList();
                }
                else
                {
                    MessageBox.Show("This Borrowing Record Is Not Deleted");

                }

            }
        }

        private void memberDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = clsFine.Find((int)dgvFines.CurrentRow.Cells[0].Value).UserID;

            Form frm = new ShowDetails.frmUserDetails(UserID);

            frm.ShowDialog();

        }

        private void PaymentFine()
        {
            clsFine Fine = clsFine.Find((int)dgvFines.CurrentRow.Cells[0].Value);

            if (Fine == null)
                return;


            if (Fine.PaymentStauts != false)
            {
                MessageBox.Show("The Member Is Paid Fine", "Confirem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Fine.PaymentStauts = true;

            if (MessageBox.Show("Are you sure, You want to pay Fine? ", "Confirem", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                if (Fine.Save())
                {
                    MessageBox.Show("You Pay The Fine", "Confirem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshFinesList();
                }
            }

        }


        private void payFineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PaymentFine();

        }
    }
}