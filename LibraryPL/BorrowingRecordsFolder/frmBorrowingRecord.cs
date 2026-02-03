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

namespace LibraryWinFormApp_PersentantionLayer.BorrowingRecordsFolder
{
    public partial class frmBorrowingRecord : Form
    {

        public frmBorrowingRecord()
        {
            InitializeComponent();
        }

        private void _RefreshBorrowingRecordsList()
        {

            dgvBorrowingBook.DataSource = clsBorrowingRecord.GetAllBorrowingRecords();


            cbSearchBy.SelectedIndex = 0;


        }


        private void frmBook_Load(object sender, EventArgs e)
        {
            _RefreshBorrowingRecordsList();
        }


        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = "";

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Form frm = new BorrowingRecordsFolder.frmAddUpdateBorrowingBooks(-1);
            frm.ShowDialog();

            _RefreshBorrowingRecordsList();

        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new BorrowingRecordsFolder.frmAddUpdateBorrowingBooks((int)dgvBorrowingBook.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshBorrowingRecordsList();
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
            if (MessageBox.Show("Are you Sure You want to delete This Borrowing Record With ID = [" + (int)dgvBorrowingBook.CurrentRow.Cells[0].Value + "] ", "Confierm", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {

                if (clsBorrowingRecord.DeleteBorrowingRecord((int)dgvBorrowingBook.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("This Borrowing Record Is Deleted");
                    _RefreshBorrowingRecordsList();
                }
                else
                {
                    MessageBox.Show("This Borrowing Record Is Not Deleted");

                }

            }
        }


        private void showCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Books.frmBookCopies((int)dgvBorrowingBook.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }


        private void UpdateCopiesTable(bool AvailabilityStauts)
        {
            clsBookCopies BookCopy = clsBookCopies.Find((int)dgvBorrowingBook.CurrentRow.Cells[1].Value);

            if (BookCopy != null)
            {
                BookCopy.AvailabilityStauts = AvailabilityStauts;

            }


            BookCopy.Save();



        }

    
        private bool IsActualReturnDateNull(clsBorrowingRecord BorrowingBook)
        { 
            return  (BorrowingBook.ActualReturnDate == null);
        }


        private bool IsActualReturnDate(clsBorrowingRecord BorrowingBook)
        {
            if (BorrowingBook != null)
            {
                if (IsActualReturnDateNull(BorrowingBook) )
                {
                    UpdateCopiesTable(true);
                    BorrowingBook.ActualReturnDate = DateTime.Now;

                    return true;
                }
            }

            return false;
        }

        private void ReturnBookCopy()
        {
            clsBorrowingRecord BorrowingBook = clsBorrowingRecord.Find((int)dgvBorrowingBook.CurrentRow.Cells[0].Value);


            if (!IsActualReturnDate(BorrowingBook))
            {
                MessageBox.Show("Erro:This Book Not Reurn Successflly");
                return;
            }

            if (BorrowingBook.Save())
            {
                _RefreshBorrowingRecordsList();
                MessageBox.Show("This Book Returned Successflly");
                AddNewFineToTable(BorrowingBook);
                NotfiyIconReturnBook(BorrowingBook);
            }
            else
            {
                MessageBox.Show("Erro:This Book Not Reurn Successflly");
            
            }

        }

        private short GetDiffrintDate(DateTime Date1 , DateTime Date2)
        {
            short Days = 0 ;

             Days =  (short)((Date1 < Date2)? Date2.Subtract(Date1).Days : Date1.Subtract(Date2).Days);  
            
            return Days;

        }

        private bool IsActualReturnDateBigThanDueDate(DateTime ActualReturnDate, DateTime DueDate)
        {
            short Days = (short)ActualReturnDate.Date.Subtract(DueDate.Date).Days;

            return (Days > 0) ;

        }

        private bool AddNewFine(clsBorrowingRecord BorrowingBook)
        {
            clsFine Fine = new clsFine();
            Fine.UserID = BorrowingBook.UserID;
            Fine.BorrowingRecordsID = BorrowingBook.BorrowingRecordID;

            Fine.NumberOfLateDays = GetDiffrintDate(BorrowingBook.DueDate, (DateTime)BorrowingBook.ActualReturnDate);
            

            Fine.FineAmount = (Fine.NumberOfLateDays * clsSetting.DefaultFinePerDay);

            if (Fine.Save())
                return true;

            return false;

        }
       
        private void AddNewFineToTable(clsBorrowingRecord BorrowingBook)
        {
            if (IsActualReturnDateBigThanDueDate((DateTime)BorrowingBook.ActualReturnDate, BorrowingBook.DueDate))
            {
                AddNewFine(BorrowingBook);
            }

        }


        private void NotfiyIconReturnBook(clsBorrowingRecord BorrowingBook)
        {
            if (IsActualReturnDateNull(BorrowingBook))
            {
                return;
            }


            nficonReturnBook.Icon = SystemIcons.Application;
            nficonReturnBook.BalloonTipIcon = ToolTipIcon.Info;
            nficonReturnBook.BalloonTipTitle = "Retrun Book From Member CardLibraryNumber is: [" + clsUser.Find(BorrowingBook.UserID).LibraryCard + "]";

            nficonReturnBook.BalloonTipText = "The Member with ID : [" + BorrowingBook.UserID + "] Return The Copy Book  With ID: ["
                +BorrowingBook.CopyID+"]";

            nficonReturnBook.ShowBalloonTip(150);
            
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookCopy();
        }

      

        private void bookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookID = clsBookCopies.Find((int)dgvBorrowingBook.CurrentRow.Cells[1].Value).BookID;

            Form frm = new ShowDetails.frmBookDetails(BookID);

            frm.ShowDialog();
        }

        private void btnResertvation_Click(object sender, EventArgs e)
        {
            Form frm = new Reservations.frmAddUpdateReservateBook(-1);
            frm.ShowDialog();
            

        }

        private void _SearchBorrowingByBorrowingID(string BorrowingID)
        {
            if (string.IsNullOrWhiteSpace(BorrowingID))
            {
                _RefreshBorrowingRecordsList();
                return;
            }


            DataTable dt = clsBorrowingRecord.GetAllBorrowingRecords();

            DataView dv = dt.DefaultView;

            try
            {
                dv.RowFilter = "BorrowingRecordsID = " + BorrowingID;
                dgvBorrowingBook.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Number Value or " + ex.Message, "Confierm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void _SearchBorrowingByCopyID(string CopyID)
        {
            if (string.IsNullOrWhiteSpace(CopyID))
            {
                _RefreshBorrowingRecordsList();
                return;
            }


            DataTable dt = clsBorrowingRecord.GetAllBorrowingRecords();

            DataView dv = dt.DefaultView;

            try
            {
                dv.RowFilter = "CopyID = " + CopyID;
                dgvBorrowingBook.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Number Value or " + ex.Message, "Confierm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _SearchBorrowingByMemberID(string MemberID)
        {
            if (string.IsNullOrWhiteSpace(MemberID))
            {
                _RefreshBorrowingRecordsList();
                return;
            }


            DataTable dt = clsBorrowingRecord.GetAllBorrowingRecords();

            DataView dv = dt.DefaultView;

            try
            {
                dv.RowFilter = "UserID = " + MemberID;
                dgvBorrowingBook.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Number Value or " + ex.Message, "Confierm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void SearchDataIndgbBorrowingBook()
        {
            switch (cbSearchBy.Text)
            { 
                case "BorrowingID":
                    _SearchBorrowingByBorrowingID(txtSearch.Text);
                    break;
                case "CopyID":
                    _SearchBorrowingByCopyID(txtSearch.Text);
                    break;
                case "MemberID":
                    _SearchBorrowingByMemberID(txtSearch.Text);
                    break;
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchDataIndgbBorrowingBook();
        }

        private void memberDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = clsBorrowingRecord.Find((int)dgvBorrowingBook.CurrentRow.Cells[0].Value).UserID;

            Form frm = new ShowDetails.frmUserDetails(UserID);

            frm.ShowDialog();
        }


    }
}