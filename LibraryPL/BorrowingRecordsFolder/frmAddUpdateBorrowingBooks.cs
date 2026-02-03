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

namespace LibraryWinFormApp_PersentantionLayer.BorrowingRecordsFolder
{
    public partial class frmAddUpdateBorrowingBooks : Form
    {
        private enum enMode {AddMode = 0, UpdateMode = 1 }
        private enMode _Mode;
         int _BorrowingBooksID { set; get; }
         clsBorrowingRecord _BorrowingBooks;

         public frmAddUpdateBorrowingBooks(int BorrowingBooksID)
        {
            InitializeComponent();

            this._BorrowingBooksID = BorrowingBooksID;

            if (BorrowingBooksID == -1)
                _Mode = enMode.AddMode;
            else
                _Mode = enMode.UpdateMode;

        }

        private void _FillMembersInComBox()
        {
            DataTable MembersDataTable = clsUser.GetAllUsers();

            foreach (DataRow row in MembersDataTable.Rows)
            {
                cbMembers.Items.Add(row["FirstName"] );
            }

        }

        private void _FillCopiesInComBox()
        {
            DataTable CopiesDataTable = clsBookCopies.GetAllBookCopies();

            foreach (DataRow row in CopiesDataTable.Rows)
            {
                cbCopies.Items.Add(row["CopyID"]);
            }

        }

    
        private void SaveAddData()
        {

            if (!clsBookCopies.Find(Convert.ToInt32(cbCopies.Text)).AvailabilityStauts)
            {
                MessageBox.Show("This Book Copy Is Alreaday Borrowred");
                return;
            }


            if (string.IsNullOrEmpty (cbMembers.Text))
            {
                MessageBox.Show("Choies Members, Please?");

                return;
            }



            int MemberID = clsUser.Find(cbMembers.Text).UserID;
            int CopyID = clsBookCopies.Find(Convert.ToInt32(cbCopies.Text)).CopyID;

            


            _BorrowingBooks.UserID = MemberID;

            _BorrowingBooks.CopyID = CopyID;

            _BorrowingBooks.BorrowingDate = DateTime.Now;

            _BorrowingBooks.DueDate = (_BorrowingBooks.BorrowingDate.AddDays(clsSetting.DefaultBorrowDays));
 
            

            if (_BorrowingBooks.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
                UpdateCopiesTable(false);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
            }


            _Mode = enMode.UpdateMode;
            lbAddUpdateTitle.Text = "Edit Borrowing Book ID = " + _BorrowingBooks.BorrowingRecordID;
            lblBorroingBookID.Text = _BorrowingBooks.BorrowingRecordID.ToString();
        }
     
        private void Save_Click(object sender, EventArgs e)
        {
            SaveAddData();

        }


        private void frmAddUpdate_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void UpdateCopiesTable(bool AvailabilityStauts)
        {
            clsBookCopies BookCopy = clsBookCopies.Find(_BorrowingBooks.CopyID);


            if (BookCopy != null)
            {
                BookCopy.AvailabilityStauts = AvailabilityStauts;

            }


            BookCopy.Save();



        }


        private void _LoadData()
        {
            _FillCopiesInComBox();
            _FillMembersInComBox();


           


            if (_Mode == enMode.AddMode)
            {
                lbAddUpdateTitle.Text = "Add New Borrowing Record";
                _BorrowingBooks = new clsBorrowingRecord();
                return;
            }


            _BorrowingBooks = clsBorrowingRecord.Find(_BorrowingBooksID);

            if (_BorrowingBooks == null)
            {
                MessageBox.Show("This form will be closed because No Borrowing Record with ID = " + _BorrowingBooksID);
                this.Close();

                return;
            }


            lbAddUpdateTitle.Text = "Edit Borrowing Record ID = " + _BorrowingBooksID;
            dtpBorrowingDate.Value = _BorrowingBooks.BorrowingDate;
            dtpDueDate.Value = _BorrowingBooks.DueDate;
            
            if(_BorrowingBooks.ActualReturnDate != null)
                dtpActualReturnDate.Value = (DateTime)_BorrowingBooks.ActualReturnDate;
            else
                dtpActualReturnDate.Visible = false ;

            UpdateCopiesTable(true);

            cbCopies.SelectedItem =  clsBookCopies.Find(_BorrowingBooks.CopyID).CopyID;
                
                        
            cbMembers.SelectedIndex = cbMembers.FindString(clsUser.Find(_BorrowingBooks.UserID).FirstName);

            lblBorroingBookID.Text = _BorrowingBooks.BorrowingRecordID.ToString();
        }


        private void btnCasel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCopies_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbCopies_SelectedValueChanged(object sender, EventArgs e)
        {
           


        }



       
    }


}
