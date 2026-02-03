namespace LibraryWinFormApp_PersentantionLayer.BorrowingRecordsFolder
{
    partial class frmAddUpdateBorrowingBooks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAddUpdateTitle = new System.Windows.Forms.Label();
            this.btnCasel = new System.Windows.Forms.Button();
            this.lblBorroingBookID = new System.Windows.Forms.Label();
            this.cbMembers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBorrowingDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCopies = new System.Windows.Forms.ComboBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpActualReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbAddUpdateTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 60);
            this.panel1.TabIndex = 0;
            // 
            // lbAddUpdateTitle
            // 
            this.lbAddUpdateTitle.AutoSize = true;
            this.lbAddUpdateTitle.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddUpdateTitle.Location = new System.Drawing.Point(208, 21);
            this.lbAddUpdateTitle.Name = "lbAddUpdateTitle";
            this.lbAddUpdateTitle.Size = new System.Drawing.Size(22, 21);
            this.lbAddUpdateTitle.TabIndex = 0;
            this.lbAddUpdateTitle.Text = "0";
            // 
            // btnCasel
            // 
            this.btnCasel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCasel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasel.Location = new System.Drawing.Point(316, 285);
            this.btnCasel.Name = "btnCasel";
            this.btnCasel.Size = new System.Drawing.Size(154, 37);
            this.btnCasel.TabIndex = 15;
            this.btnCasel.Text = "Cansel";
            this.btnCasel.UseVisualStyleBackColor = true;
            this.btnCasel.Click += new System.EventHandler(this.btnCasel_Click);
            // 
            // lblBorroingBookID
            // 
            this.lblBorroingBookID.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorroingBookID.Location = new System.Drawing.Point(56, 44);
            this.lblBorroingBookID.Name = "lblBorroingBookID";
            this.lblBorroingBookID.Size = new System.Drawing.Size(174, 28);
            this.lblBorroingBookID.TabIndex = 16;
            // 
            // cbMembers
            // 
            this.cbMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMembers.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbMembers.FormattingEnabled = true;
            this.cbMembers.Location = new System.Drawing.Point(443, 97);
            this.cbMembers.Name = "cbMembers";
            this.cbMembers.Size = new System.Drawing.Size(199, 31);
            this.cbMembers.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Members:";
            // 
            // dtpBorrowingDate
            // 
            this.dtpBorrowingDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dtpBorrowingDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dtpBorrowingDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dtpBorrowingDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dtpBorrowingDate.Location = new System.Drawing.Point(51, 210);
            this.dtpBorrowingDate.Name = "dtpBorrowingDate";
            this.dtpBorrowingDate.Size = new System.Drawing.Size(194, 20);
            this.dtpBorrowingDate.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Borrowing Date:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Copies:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Due Date:";
            // 
            // cbCopies
            // 
            this.cbCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbCopies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCopies.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCopies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbCopies.FormattingEnabled = true;
            this.cbCopies.Location = new System.Drawing.Point(51, 97);
            this.cbCopies.Name = "cbCopies";
            this.cbCopies.Size = new System.Drawing.Size(199, 31);
            this.cbCopies.TabIndex = 27;
            this.cbCopies.SelectedIndexChanged += new System.EventHandler(this.cbCopies_SelectedIndexChanged);
            this.cbCopies.SelectedValueChanged += new System.EventHandler(this.cbCopies_SelectedValueChanged);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dtpDueDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dtpDueDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dtpDueDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.Location = new System.Drawing.Point(443, 210);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(194, 20);
            this.dtpDueDate.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpActualReturnDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpDueDate);
            this.panel2.Controls.Add(this.cbCopies);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpBorrowingDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbMembers);
            this.panel2.Controls.Add(this.lblBorroingBookID);
            this.panel2.Controls.Add(this.btnCasel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 354);
            this.panel2.TabIndex = 1;
            // 
            // dtpActualReturnDate
            // 
            this.dtpActualReturnDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dtpActualReturnDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dtpActualReturnDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dtpActualReturnDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dtpActualReturnDate.Enabled = false;
            this.dtpActualReturnDate.Location = new System.Drawing.Point(443, 35);
            this.dtpActualReturnDate.Name = "dtpActualReturnDate";
            this.dtpActualReturnDate.Size = new System.Drawing.Size(194, 20);
            this.dtpActualReturnDate.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Actual Return Date:";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(100, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 37);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // frmAddUpdateBorrowingBooks
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CancelButton = this.btnCasel;
            this.ClientSize = new System.Drawing.Size(772, 414);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateBorrowingBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdate";
            this.Load += new System.EventHandler(this.frmAddUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAddUpdateTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCasel;
        private System.Windows.Forms.Label lblBorroingBookID;
        private System.Windows.Forms.ComboBox cbMembers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBorrowingDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCopies;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpActualReturnDate;
        private System.Windows.Forms.Label label2;
    }
}