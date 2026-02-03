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

namespace LibraryWinFormApp_PersentantionLayer
{
    public partial class frmHomeItems : Form
    {


        public frmHomeItems()
        {
            InitializeComponent();
        }

        int GetBooksCount()
        {
            DataTable BookTable = clsBook.GetAllBook();

            int CountOfBooks = Convert.ToInt32(BookTable.Compute("COUNT(ID)", string.Empty));


            return CountOfBooks;
        }

        int GetMembersCount()
        {
            DataTable MembersTable = clsUser.GetAllUsers() ;

            int CountOfMembers = Convert.ToInt32(MembersTable.Compute("COUNT(UserID)", string.Empty));


            return CountOfMembers;
        }

        int GetAuothersCount()
        {
            DataTable AuothersTable =clsAuother.GetAllAuothers();

            int AuothersCount = Convert.ToInt32(AuothersTable.Compute("COUNT(AuotherID)", string.Empty));


            return AuothersCount;
        }


        int GetEmployeesCount()
        {
            DataTable EmployeesTable = clsEmployee.GetAllEmployees();

            int EmployeesCount = Convert.ToInt32(EmployeesTable.Compute("COUNT(EmployeeID)", string.Empty));


            return EmployeesCount;
        }

        string GetTime()
        {
            DateTime Time = DateTime.Now;

            string sTime = Time.Hour + ":" + Time.Minute + ":" + Time.Second;

            return sTime;

        }

        

        private void frmHomeItems_Load(object sender, EventArgs e)
        {
            lblCountOfBooks.Text = GetBooksCount().ToString();
            lblMemberCount.Text = GetMembersCount().ToString();
            lblEmployeesCount.Text = GetEmployeesCount().ToString();
            lblAuothersCount.Text = GetAuothersCount().ToString();

            lblTime.Text = GetTime();
            lblDate.Text = DateTime.Now.Date.ToShortDateString();    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = GetTime();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //_FillPanelContainerWithForm(new frmBook());
        }

        //private void _FillPanelContainerWithForm(Form form)
        //{
        //    Form myForm = form;

        //    myForm.TopLevel = false;
        //    myForm.FormBorderStyle = FormBorderStyle.None;
        //    myForm.Dock = DockStyle.Fill;

        //    pnlCont.Controls.Clear();
        //    pnlCont.Controls.Add(myForm);
        //    myForm.Show();
        //}



    }
}
