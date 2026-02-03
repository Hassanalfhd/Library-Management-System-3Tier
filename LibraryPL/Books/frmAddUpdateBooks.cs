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
    public partial class frmAddUpdateBooks : Form
    {
        private enum enMode {AddMode = 0, UpdateMode = 1 }
        private enMode _Mode;
         int _BorrowingBookID { set; get; }
         clsBook _BorrowingBook;

         public frmAddUpdateBooks(int BookID)
        {
            InitializeComponent();

            this._BorrowingBookID = BookID;

            if (BookID == -1)
                _Mode = enMode.AddMode;
            else
                _Mode = enMode.UpdateMode;

        }

        private void _FillAuothersInComBox()
        {
            DataTable AuothersDataTable = clsAuother.GetAllAuothers();

            foreach (DataRow row in AuothersDataTable.Rows)
            {
                cbAuothres.Items.Add(row["FirstName"] );
            }

        }


        private void SaveAddData()
        {
            int AuotherID = clsAuother.Find(cbAuothres.Text).AuotherID;

            _BorrowingBook.Title = txtTitle.Text;
            _BorrowingBook.ISBN = txtISBN.Text;
            _BorrowingBook.PublictionDate = dtpPublictionDate.Value;
            _BorrowingBook.Genre = txtGerne.Text;
            _BorrowingBook.AuotherID = AuotherID;
         
            if (picImage.ImageLocation != null)
                _BorrowingBook.ImagePath = picImage.ImageLocation;
            else
                _BorrowingBook.ImagePath = "";

            if (txtAdditionalDetalis.Text != "")
                _BorrowingBook.AdditionalDetalis = txtAdditionalDetalis.Text;
            else
                _BorrowingBook.AdditionalDetalis = "";



            if (_BorrowingBook.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
            }


            _Mode = enMode.UpdateMode;
            lbAddUpdateTitle.Text = "Edit Book ID = " + _BorrowingBook.ID;
            lblBookID.Text = _BorrowingBook.ID.ToString();
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
            _FillAuothersInComBox();

            cbAuothres.SelectedIndex = 0;

            if (_Mode == enMode.AddMode)
            {
                lbAddUpdateTitle.Text = "Add New Book";
                _BorrowingBook = new clsBook();
                return;
            }


            _BorrowingBook = clsBook.Find(_BorrowingBookID);

            if (_BorrowingBook == null)
            {
                MessageBox.Show("This form will be closed because No Book with ID = " + _BorrowingBookID);
                this.Close();

                return;
            }

            lbAddUpdateTitle.Text = "Edit Book ID = " + _BorrowingBookID;
            txtTitle.Text = _BorrowingBook.Title;
            txtISBN.Text = _BorrowingBook.ISBN;
            txtGerne.Text = _BorrowingBook.Genre;
            dtpPublictionDate.Value = _BorrowingBook.PublictionDate;
            txtAdditionalDetalis.Text = _BorrowingBook.AdditionalDetalis;

            if (_BorrowingBook.ImagePath != "")
            {
                picImage.Load(_BorrowingBook.ImagePath);
            }

            cbAuothres.SelectedIndex = cbAuothres.FindString(clsAuother.Find(_BorrowingBook.AuotherID).FirstName);
            lblBookID.Text = _BorrowingBook.ID.ToString();
        }


        private void btnCasel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnChoiesImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                picImage.Load(selectedFilePath);
                // ...
            }

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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }



    }


}
