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

namespace LibraryWinFormApp_PersentantionLayer.Books
{
    public partial class frmBookCopies : Form
    {
        enum enMode {ShowAllCopies = 0 , ShowBookCopies = 2 }
        enMode _Mode ;
        public int _BookID {set;get;}

        public frmBookCopies(int BookID)
        {
            InitializeComponent();

            this._BookID = BookID;
            if (BookID == -1)
                _Mode = enMode.ShowAllCopies;
            else
                _Mode = enMode.ShowBookCopies;

        }

        private void _RefershBookCopies()
        {
            if (_Mode == enMode.ShowAllCopies)
                dgvBookCopies.DataSource = clsBookCopies.GetAllBookCopies();
            else
            {

                dgvBookCopies.DataSource = clsBookCopies.GetAllBookCopies(this._BookID);

               
            }
           
        }

        private void frmBookCopies_Load(object sender, EventArgs e)
        {
            _RefershBookCopies();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Form frm = new Books.frmAddUpdateCopiesBook(-1);
            frm.ShowDialog();
            _RefershBookCopies();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Books.frmAddUpdateCopiesBook((int)dgvBookCopies.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefershBookCopies();
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure You want to delete This Copy Book With ID = [" + (int)dgvBookCopies.CurrentRow.Cells[0].Value + "] ", "Confierm", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {

                if (clsBookCopies.DeleteBookCopy((int)dgvBookCopies.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("This Copy Book Is Deleted");
                    _RefershBookCopies();
                }
                else
                {
                    MessageBox.Show("This Copy Book Is Not Deleted");

                }

            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(46, 51, 73);

        }
    }
}
