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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private void _RefreshBookList()
        {

            dgvBooks.DataSource = clsBook.GetAllBook();


            cbSearchBy.SelectedIndex = 0;

            

        }


        private void frmBook_Load(object sender, EventArgs e)
        {
            _RefreshBookList();
        }


        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = "";

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Form frm = new Books.frmAddUpdateBooks(-1);
            frm.ShowDialog();

            _RefreshBookList();

        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Books.frmAddUpdateBooks((int) dgvBooks.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshBookList();
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
            if (MessageBox.Show("Are you Sure You want to delete This Book With ID = [" + (int)dgvBooks.CurrentRow.Cells[0].Value + "] ", "Confierm", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {

                if (clsBook.DeleteBook((int)dgvBooks.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("This Book Is Deleted");
                    _RefreshBookList();
                }
                else
                {
                    MessageBox.Show("This Book Is Not Deleted");

                }

            }
        }

        private void showCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Books.frmBookCopies((int)dgvBooks.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void bookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookID =(int)dgvBooks.CurrentRow.Cells[0].Value;


            Form frm = new ShowDetails.frmBookDetails(BookID);

            frm.ShowDialog();
        }

    

        private void _SearchDataByID(string ID)
        {
            if (string.IsNullOrWhiteSpace(ID))
            {
                _RefreshBookList();
                return;
            }

            DataTable dt = clsBook.GetAllBook();

            DataView dv = dt.DefaultView;

            try
            {
                dv.RowFilter = "ID = " + ID;
                dgvBooks.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Number Value or " + ex.Message, "Confierm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void _SearchDataByTitle(string Title)
        {
            if (string.IsNullOrWhiteSpace(Title))
            {
                _RefreshBookList();
                return;
            }

            DataTable dt = clsBook.GetAllBook();

            DataView dv = dt.DefaultView;


            dv.RowFilter = "Title = '" + Title +'\'';

            dgvBooks.DataSource = dv;



        }


        private void _SearchDataByISBN(string ISBN)
        {
            if (string.IsNullOrWhiteSpace(ISBN))
            {
                _RefreshBookList();
                return;
            }

            DataTable dt = clsBook.GetAllBook();

            DataView dv = dt.DefaultView;


            dv.RowFilter = "ISBN = '" + ISBN + '\'';

            dgvBooks.DataSource = dv;



        }


        private void _SearchDataByGenre(string Genre)
        {
            if (string.IsNullOrWhiteSpace(Genre))
            {
                _RefreshBookList();
                return;
            }

            DataTable dt = clsBook.GetAllBook();

            DataView dv = dt.DefaultView;


            dv.RowFilter = "Genre = '" + Genre + '\'';

            dgvBooks.DataSource = dv;



        }


        private void _SearchDataByAuother(string Auother)
        {
            if (string.IsNullOrWhiteSpace(Auother))
            {
                _RefreshBookList();
                return;
            }

            DataTable dt = clsBook.GetAllBook();

            DataView dv = dt.DefaultView;


            dv.RowFilter = "AuotherName Like '" + Auother + "\'";

            dgvBooks.DataSource = dv;



        }

        private void SearchDataIndgvBook()
        {
            switch (cbSearchBy.Text)
            {
                case "ID":
                    _SearchDataByID(txtSearch.Text);

                    break;
                case "Genre":
                    _SearchDataByGenre(txtSearch.Text);

                    break;
                case "Title":
                    _SearchDataByTitle(txtSearch.Text);
                    break;
                case "ISBN":
                    _SearchDataByISBN(txtSearch.Text);
                    break;
                case "Auother":
                    _SearchDataByAuother(txtSearch.Text);
                    break;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (txtSearch.Text == "")
            {
                _RefreshBookList();
                return;
            }

            SearchDataIndgvBook();

        }


      
  

      

      


    }
}