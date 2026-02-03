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

namespace LibraryWinFormApp_PersentantionLayer.ShowDetails
{
    public partial class frmBookDetails : Form
    {

     
        clsBook _Book;
        

        public frmBookDetails(int _BooID)
        {
            InitializeComponent();

            _Book = clsBook.Find(_BooID);

            if (_Book == null)
            {
                MessageBox.Show("The Book Not Found?");
                this.Close();
            }
        }


        private void LoadDate()
        {
            lblBookID.Text = _Book.ID.ToString();
            lblTitle.Text = _Book.Title;
            lblISBN.Text = _Book.ISBN;
            lblPublictionDate.Text = _Book.PublictionDate.ToString();
            lblGenre.Text = _Book.Genre;

            lblAuother.Text = clsAuother.Find(_Book.AuotherID).FullName;

            if(_Book.AdditionalDetalis != null)
                lblAdditionalDetalis.Text = _Book.AdditionalDetalis;
            else
                lblAdditionalDetalis.Text = "Not Additional Detalis...";

            if (_Book.ImagePath != null)
                picBook.Image = Image.FromFile(_Book.ImagePath);
            else
                picBook.Image = Image.FromFile(@"LibraryWinFormApp_PersentantionLayer\Library Project Image\book.png");


        }


        private void frmBookDetails_Load(object sender, EventArgs e)
        {
            LoadDate();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
     
    }
}
