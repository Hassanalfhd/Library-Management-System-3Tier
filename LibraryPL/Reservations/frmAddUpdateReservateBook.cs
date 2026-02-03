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

namespace LibraryWinFormApp_PersentantionLayer.Reservations
{
    public partial class frmAddUpdateReservateBook: Form
    {
        private enum enMode {AddMode = 0, UpdateMode = 1 }
        private enMode _Mode;
         int _ReservationID { set; get; }
         clsReservation _ReservationBook;

         public frmAddUpdateReservateBook(int ReservationID)
        {
            InitializeComponent();

            this._ReservationID = ReservationID;

            if (ReservationID == -1)
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

            if (clsBookCopies.Find(Convert.ToInt32(cbCopies.Text)).AvailabilityStauts)
            {
                MessageBox.Show("This Book Copy Is Not Borrowring");
                return;
            }


            if (string.IsNullOrEmpty (cbMembers.Text))
            {
                MessageBox.Show("Choies Members, Please?");

                return;
            }


            int MemberID = clsUser.Find(cbMembers.Text).UserID;
            int CopyID = clsBookCopies.Find(Convert.ToInt32(cbCopies.Text)).CopyID;



            _ReservationBook.UserID = MemberID;

            _ReservationBook.CopyID = CopyID;


            if (_ReservationBook.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
            }


            _Mode = enMode.UpdateMode;
            lbAddUpdateTitle.Text = "Edit Reservation Book ID = " + _ReservationBook.ReservationID;
            lblReservationBookID.Text = _ReservationBook.ReservationID.ToString();

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
            _FillCopiesInComBox();
            _FillMembersInComBox();


            if (_Mode == enMode.AddMode)
            {
                lbAddUpdateTitle.Text = "Add New Reservation Record";
                _ReservationBook = new clsReservation();
                return;
            }


            _ReservationBook = clsReservation.Find(_ReservationID);


            if (_ReservationBook == null)
            {
                MessageBox.Show("This form will be closed because No Reservation with ID = " + _ReservationID);
                this.Close();

                return;
            }


            lbAddUpdateTitle.Text = "Edit Reservation ID = " + _ReservationID;
            dtpReservationDate.Value = _ReservationBook.ReservationDate;
            
            cbCopies.SelectedItem =  clsBookCopies.Find(_ReservationBook.CopyID).CopyID;
                
                        
            cbMembers.SelectedIndex = cbMembers.FindString(clsUser.Find(_ReservationBook.UserID).FirstName);

            lblReservationBookID.Text = _ReservationBook.ReservationID.ToString();
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
