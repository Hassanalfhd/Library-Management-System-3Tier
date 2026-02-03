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

namespace LibraryWinFormApp_PersentantionLayer.Reservations
{
    public partial class frmReservations : Form
    {

        public frmReservations()
        {
            InitializeComponent();
        }

        private void _RefreshReservationsList()
        {

            dgvReservations.DataSource = clsReservation.GetAllReservations();


            cbSearchBy.SelectedIndex = 0;

            

        }


        private void frmBook_Load(object sender, EventArgs e)
        {
            _RefreshReservationsList();
        }


        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            txtSearch.Clear() ;

        }

      


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Reservations.frmAddUpdateReservateBook((int)dgvReservations.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshReservationsList();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowCopies_Click(object sender, EventArgs e)
        {
            Form frm = new Books.frmBookCopies(-1);
            frm.ShowDialog();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure You want to delete This Resrvation Record With ID = [" + (int)dgvReservations.CurrentRow.Cells[0].Value + "] ", "Confierm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {

                if (clsReservation.DeleteResrvation((int)dgvReservations.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("This Resrvation Record Is Deleted");
                    _RefreshReservationsList();
                }
                else
                {
                    MessageBox.Show("This Resrvation Record Is Not Deleted");

                }

            }
        }


        private void showCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Books.frmBookCopies((int)dgvReservations.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }







        private void bookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookID = clsBookCopies.Find((int)dgvReservations.CurrentRow.Cells[1].Value).BookID;


            Form frm = new ShowDetails.frmBookDetails(BookID);

            frm.ShowDialog();
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int UserID = clsUser.Find((int)dgvReservations.CurrentRow.Cells[2].Value).UserID;
            Form frm = new ShowDetails.frmUserDetails(UserID);

            frm.ShowDialog();
        }

        private void btnResertvation_Click(object sender, EventArgs e)
        {
            Form frm = new Reservations.frmAddUpdateReservateBook(-1);
            frm.ShowDialog();
            _RefreshReservationsList();

        }


        private void _SearchRservationByReservationID(string ReservationID)
        {
            if (string.IsNullOrWhiteSpace(ReservationID))
            {
                _RefreshReservationsList();
                return;
            }

            DataTable dt = clsReservation.GetAllReservations();

            DataView dv = dt.DefaultView;


            try
            {
                dv.RowFilter = "ReservationID = " + ReservationID;
                dgvReservations.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Number Value or " + ex.Message, "Confierm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void _SearchRservationByCopyID(string CopyID)
        {
            if (string.IsNullOrWhiteSpace(CopyID))
            {
                _RefreshReservationsList();
                return;
            }

            DataTable dt = clsReservation.GetAllReservations();

            DataView dv = dt.DefaultView;

            try
            {
                dv.RowFilter = "CopyID = " + CopyID;
                dgvReservations.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Number Value or " + ex.Message, "Confierm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void _SearchRservationByMemberID(string MemberID)
        {
            if (string.IsNullOrWhiteSpace(MemberID))
            {
                _RefreshReservationsList();
                return;
            }

            DataTable dt = clsReservation.GetAllReservations();

            DataView dv = dt.DefaultView;

           
            try
            {
                dv.RowFilter = "UserID = " + MemberID;
                dgvReservations.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Number Value or " + ex.Message, "Confierm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void SearchIndgvRsercationTable()
        {

            switch (cbSearchBy.Text)
            {
                case "ReservationID":
                    _SearchRservationByReservationID(txtSearch.Text);

                    break;
                case "CopyID":
                    _SearchRservationByCopyID(txtSearch.Text);

                    break;
                case "MemberID":
                    _SearchRservationByMemberID(txtSearch.Text);

                    break;
            }
        
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchIndgvRsercationTable();
        }

       


    }
}