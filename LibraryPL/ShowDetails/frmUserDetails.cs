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
    public partial class frmUserDetails : Form
    {

     
        clsUser _Member;


        public frmUserDetails(int _MemberID)
        {
            InitializeComponent();

            _Member = clsUser.Find(_MemberID);

            if (_Member == null)
            {
                MessageBox.Show("The Member Not Found?");
                this.Close();
            }
        }


        private void LoadDate()
        {

            lblUserID.Text = _Member.UserID.ToString();

            txtFirstName.Text = _Member.FirstName;
            txtLastName.Text = _Member.LastName;

            txtEmail.Text = _Member.Email;
            txtLibraryNoCard.Text = _Member.LibraryCard;
            txtPhone.Text = _Member.Phone;
            txtPassword.Text = _Member.Password;
            if (_Member.Gender == 'M')
                rbMale.Checked = true;
            else
                rbFamle.Checked = true;

            //if (_Member.ImagePath != null)
            //    picUser.Image = Image.FromFile(_Member.ImagePath);
            //else
            //    picUser.Image = Image.FromFile(@"LibraryWinFormApp_PersentantionLayer\Library Project Image\book.png");


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
