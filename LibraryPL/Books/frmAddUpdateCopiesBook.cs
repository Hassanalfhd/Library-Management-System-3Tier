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

namespace LibraryWinFormApp_PersentantionLayer.Books
{
    public partial class frmAddUpdateCopiesBook : Form
    {
        private enum enMode {AddMode = 0, UpdateMode = 1 }
        private enMode _Mode;
         int _CopyBookID { set; get; }
         clsBookCopies _CopyBook;

         public frmAddUpdateCopiesBook(int CopyBookID)
        {
            InitializeComponent();

            this._CopyBookID = CopyBookID;

            if (CopyBookID == -1)
                _Mode = enMode.AddMode;
            else
                _Mode = enMode.UpdateMode;

        }


        private void _FillBooksInComBox()
        {
            DataTable BooksDataTable = clsBook.GetAllBook();

            foreach (DataRow row in BooksDataTable.Rows)
            {
                cbBooks.Items.Add(row["Title"] );
            }

        }


        private void SaveAddData()
        {
            int BookID = clsBook.Find(cbBooks.Text).ID;

            _CopyBook.BookID = BookID;

            if (rbAvalible.Checked)
                _CopyBook.AvailabilityStauts = true;
            else
                _CopyBook.AvailabilityStauts = false;



            if (_CopyBook.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
            }


            _Mode = enMode.UpdateMode;
            lbAddUpdateTitle.Text = "Edit Copy Book ID = " + _CopyBook.CopyID;
            lblCopyBookID.Text = _CopyBook.CopyID.ToString();
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
            _FillBooksInComBox();

            cbBooks.SelectedIndex = 0;

            if (_Mode == enMode.AddMode)
            {
                lbAddUpdateTitle.Text = "Add New Copy Of Book";
                _CopyBook = new clsBookCopies();
                return;
            }


            _CopyBook = clsBookCopies.Find(_CopyBookID);

            if (_CopyBook == null)
            {
                MessageBox.Show("This form will be closed because No _Copy of Book with ID = " + _CopyBookID);
                this.Close();

                return;
            }


            lbAddUpdateTitle.Text = "Edit Book ID = " + _CopyBookID;

            if (_CopyBook.AvailabilityStauts)
                rbAvalible.Checked = true;
            else
                rbUnAvalible.Checked = true ;

            cbBooks.SelectedIndex = cbBooks.FindString(clsBook.Find(_CopyBook.BookID).Title);
            lblCopyBookID.Text = _CopyBook.CopyID.ToString();


        }


        private void btnCasel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


       

        }
    }



