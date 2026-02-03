namespace LibraryWinFormApp_PersentantionLayer
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAuothers = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnfrmEmployee = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnFines = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnBorrowingBook = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picEmployeeHomeImage = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.picMinimum = new System.Windows.Forms.PictureBox();
            this.picMaximum = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pnlAddFormsTo = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeeHomeImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnAuothers);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnfrmEmployee);
            this.panel1.Controls.Add(this.btnMember);
            this.panel1.Controls.Add(this.btnFines);
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Controls.Add(this.btnBorrowingBook);
            this.panel1.Controls.Add(this.btnBooks);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 710);
            this.panel1.TabIndex = 1;
            // 
            // btnAuothers
            // 
            this.btnAuothers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuothers.FlatAppearance.BorderSize = 0;
            this.btnAuothers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAuothers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAuothers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuothers.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuothers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAuothers.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.Auother2;
            this.btnAuothers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAuothers.Location = new System.Drawing.Point(0, 598);
            this.btnAuothers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAuothers.Name = "btnAuothers";
            this.btnAuothers.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnAuothers.Size = new System.Drawing.Size(248, 52);
            this.btnAuothers.TabIndex = 2;
            this.btnAuothers.Text = "Auothers";
            this.btnAuothers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuothers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAuothers.UseVisualStyleBackColor = true;
            this.btnAuothers.Click += new System.EventHandler(this.btnAuothers_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLogOut.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.LogOutExit;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.Location = new System.Drawing.Point(0, 658);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(248, 52);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnfrmEmployee
            // 
            this.btnfrmEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnfrmEmployee.FlatAppearance.BorderSize = 0;
            this.btnfrmEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnfrmEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnfrmEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfrmEmployee.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfrmEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnfrmEmployee.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.group1;
            this.btnfrmEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfrmEmployee.Location = new System.Drawing.Point(0, 546);
            this.btnfrmEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfrmEmployee.Name = "btnfrmEmployee";
            this.btnfrmEmployee.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnfrmEmployee.Size = new System.Drawing.Size(248, 52);
            this.btnfrmEmployee.TabIndex = 1;
            this.btnfrmEmployee.Text = "Employees";
            this.btnfrmEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfrmEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnfrmEmployee.UseVisualStyleBackColor = true;
            this.btnfrmEmployee.Click += new System.EventHandler(this.btnfrmEmployee_Click);
            // 
            // btnMember
            // 
            this.btnMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMember.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.people3;
            this.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMember.Location = new System.Drawing.Point(0, 494);
            this.btnMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMember.Name = "btnMember";
            this.btnMember.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnMember.Size = new System.Drawing.Size(248, 52);
            this.btnMember.TabIndex = 1;
            this.btnMember.Text = "Members";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnFines
            // 
            this.btnFines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFines.FlatAppearance.BorderSize = 0;
            this.btnFines.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnFines.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFines.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnFines.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.Payments;
            this.btnFines.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFines.Location = new System.Drawing.Point(0, 442);
            this.btnFines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFines.Name = "btnFines";
            this.btnFines.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnFines.Size = new System.Drawing.Size(248, 52);
            this.btnFines.TabIndex = 1;
            this.btnFines.Text = "Fines";
            this.btnFines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFines.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFines.UseVisualStyleBackColor = true;
            this.btnFines.Click += new System.EventHandler(this.btnFines_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnReservation.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.Subscription_Periods;
            this.btnReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReservation.Location = new System.Drawing.Point(0, 390);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnReservation.Size = new System.Drawing.Size(248, 52);
            this.btnReservation.TabIndex = 1;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnBorrowingBook
            // 
            this.btnBorrowingBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrowingBook.FlatAppearance.BorderSize = 0;
            this.btnBorrowingBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnBorrowingBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnBorrowingBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowingBook.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowingBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBorrowingBook.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.borrow;
            this.btnBorrowingBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrowingBook.Location = new System.Drawing.Point(0, 338);
            this.btnBorrowingBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrowingBook.Name = "btnBorrowingBook";
            this.btnBorrowingBook.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnBorrowingBook.Size = new System.Drawing.Size(248, 52);
            this.btnBorrowingBook.TabIndex = 1;
            this.btnBorrowingBook.Text = "Borrowing ";
            this.btnBorrowingBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowingBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBorrowingBook.UseVisualStyleBackColor = true;
            this.btnBorrowingBook.Click += new System.EventHandler(this.btnBorrowingBook_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBooks.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.books;
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBooks.Location = new System.Drawing.Point(0, 283);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnBooks.Size = new System.Drawing.Size(248, 55);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Tag = "Book";
            this.btnBooks.Text = "Books";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHome.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.dashboard1;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(0, 231);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(248, 52);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picEmployeeHomeImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 231);
            this.panel2.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lblUserName.Location = new System.Drawing.Point(52, 167);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(137, 24);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Some User her";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(33, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "EmployeeName:";
            // 
            // picEmployeeHomeImage
            // 
            this.picEmployeeHomeImage.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.userEmployee;
            this.picEmployeeHomeImage.Location = new System.Drawing.Point(56, 15);
            this.picEmployeeHomeImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picEmployeeHomeImage.Name = "picEmployeeHomeImage";
            this.picEmployeeHomeImage.Size = new System.Drawing.Size(141, 106);
            this.picEmployeeHomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmployeeHomeImage.TabIndex = 0;
            this.picEmployeeHomeImage.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(248, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 81);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(296, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblDate);
            this.panel4.Controls.Add(this.lblTime);
            this.panel4.Controls.Add(this.picMinimum);
            this.panel4.Controls.Add(this.picMaximum);
            this.panel4.Controls.Add(this.picClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(545, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 81);
            this.panel4.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDate.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDate.Location = new System.Drawing.Point(70, 0);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(77, 26);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTime.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 26);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            // 
            // picMinimum
            // 
            this.picMinimum.Dock = System.Windows.Forms.DockStyle.Right;
            this.picMinimum.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.minus;
            this.picMinimum.Location = new System.Drawing.Point(302, 0);
            this.picMinimum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picMinimum.Name = "picMinimum";
            this.picMinimum.Size = new System.Drawing.Size(61, 81);
            this.picMinimum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimum.TabIndex = 2;
            this.picMinimum.TabStop = false;
            this.picMinimum.Click += new System.EventHandler(this.picMinimum_Click);
            // 
            // picMaximum
            // 
            this.picMaximum.Dock = System.Windows.Forms.DockStyle.Right;
            this.picMaximum.Location = new System.Drawing.Point(363, 0);
            this.picMaximum.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.picMaximum.Name = "picMaximum";
            this.picMaximum.Size = new System.Drawing.Size(52, 81);
            this.picMaximum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMaximum.TabIndex = 1;
            this.picMaximum.TabStop = false;
            this.picMaximum.Tag = "Normal";
            this.picMaximum.Click += new System.EventHandler(this.picMaximum_Click);
            // 
            // picClose
            // 
            this.picClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.picClose.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.Close1;
            this.picClose.Location = new System.Drawing.Point(415, 0);
            this.picClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(60, 81);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // pnlAddFormsTo
            // 
            this.pnlAddFormsTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddFormsTo.Location = new System.Drawing.Point(248, 81);
            this.pnlAddFormsTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAddFormsTo.Name = "pnlAddFormsTo";
            this.pnlAddFormsTo.Size = new System.Drawing.Size(1020, 629);
            this.pnlAddFormsTo.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1268, 710);
            this.Controls.Add(this.pnlAddFormsTo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHome";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeeHomeImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picEmployeeHomeImage;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnfrmEmployee;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnFines;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnBorrowingBook;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimum;
        private System.Windows.Forms.PictureBox picMaximum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAuothers;
        private System.Windows.Forms.Panel pnlAddFormsTo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;

    }
}

