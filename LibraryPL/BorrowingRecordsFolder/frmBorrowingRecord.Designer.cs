namespace LibraryWinFormApp_PersentantionLayer.BorrowingRecordsFolder
{
    partial class frmBorrowingRecord
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvBorrowingBook = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nficonReturnBook = new System.Windows.Forms.NotifyIcon(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvBorrowingRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResertvation = new System.Windows.Forms.Button();
            this.btnShowCopies = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowingBook)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnResertvation);
            this.panel2.Controls.Add(this.btnShowCopies);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnAddBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 110);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbSearchBy);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(373, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 110);
            this.panel3.TabIndex = 0;
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbSearchBy.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "BorrowingID",
            "CopyID",
            "MemberID"});
            this.cbSearchBy.Location = new System.Drawing.Point(247, 32);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(130, 31);
            this.cbSearchBy.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSearch.Location = new System.Drawing.Point(10, 66);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(348, 25);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click_1);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvBorrowingBook
            // 
            this.dgvBorrowingBook.AllowUserToAddRows = false;
            this.dgvBorrowingBook.AllowUserToDeleteRows = false;
            this.dgvBorrowingBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvBorrowingBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowingBook.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBorrowingBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrowingBook.Location = new System.Drawing.Point(0, 110);
            this.dgvBorrowingBook.MultiSelect = false;
            this.dgvBorrowingBook.Name = "dgvBorrowingBook";
            this.dgvBorrowingBook.ReadOnly = true;
            this.dgvBorrowingBook.Size = new System.Drawing.Size(765, 401);
            this.dgvBorrowingBook.TabIndex = 3;
            this.dgvBorrowingBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.dgvBorrowingRecords,
            this.returnToolStripMenuItem,
            this.bookDetailsToolStripMenuItem,
            this.memberDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 124);
            // 
            // bookDetailsToolStripMenuItem
            // 
            this.bookDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bookDetailsToolStripMenuItem.Name = "bookDetailsToolStripMenuItem";
            this.bookDetailsToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.bookDetailsToolStripMenuItem.Text = "Book Details";
            this.bookDetailsToolStripMenuItem.Click += new System.EventHandler(this.bookDetailsToolStripMenuItem_Click);
            // 
            // memberDetailsToolStripMenuItem
            // 
            this.memberDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.memberDetailsToolStripMenuItem.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.employee;
            this.memberDetailsToolStripMenuItem.Name = "memberDetailsToolStripMenuItem";
            this.memberDetailsToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.memberDetailsToolStripMenuItem.Text = "Member Details";
            this.memberDetailsToolStripMenuItem.Click += new System.EventHandler(this.memberDetailsToolStripMenuItem_Click);
            // 
            // nficonReturnBook
            // 
            this.nficonReturnBook.Text = "nficonReturnBook";
            this.nficonReturnBook.Visible = true;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.editToolStripMenuItem.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.Edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // dgvBorrowingRecords
            // 
            this.dgvBorrowingRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.dgvBorrowingRecords.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.Delete;
            this.dgvBorrowingRecords.Name = "dgvBorrowingRecords";
            this.dgvBorrowingRecords.Size = new System.Drawing.Size(189, 24);
            this.dgvBorrowingRecords.Text = "Delete";
            this.dgvBorrowingRecords.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.returnToolStripMenuItem.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.Retrun;
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // btnResertvation
            // 
            this.btnResertvation.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnResertvation.FlatAppearance.BorderSize = 0;
            this.btnResertvation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnResertvation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnResertvation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResertvation.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResertvation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnResertvation.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.Subscription_Periods;
            this.btnResertvation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResertvation.Location = new System.Drawing.Point(77, 0);
            this.btnResertvation.Name = "btnResertvation";
            this.btnResertvation.Size = new System.Drawing.Size(139, 110);
            this.btnResertvation.TabIndex = 4;
            this.btnResertvation.Text = "Reservate Book";
            this.btnResertvation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResertvation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResertvation.UseVisualStyleBackColor = true;
            this.btnResertvation.Click += new System.EventHandler(this.btnResertvation_Click);
            // 
            // btnShowCopies
            // 
            this.btnShowCopies.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowCopies.FlatAppearance.BorderSize = 0;
            this.btnShowCopies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnShowCopies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnShowCopies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCopies.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCopies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShowCopies.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.drop_down_menu;
            this.btnShowCopies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCopies.Location = new System.Drawing.Point(216, 0);
            this.btnShowCopies.Name = "btnShowCopies";
            this.btnShowCopies.Size = new System.Drawing.Size(157, 110);
            this.btnShowCopies.TabIndex = 3;
            this.btnShowCopies.Text = "Show All Copies";
            this.btnShowCopies.UseVisualStyleBackColor = true;
            this.btnShowCopies.Click += new System.EventHandler(this.btnShowCopies_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.searching;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search  Boroing Book By: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddBook.Image = global::LibraryWinFormApp_PersentantionLayer.Properties.Resources.plus;
            this.btnAddBook.Location = new System.Drawing.Point(0, 0);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(93, 110);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // frmBorrowingRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 511);
            this.Controls.Add(this.dgvBorrowingBook);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBorrowingRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBook";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowingBook)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBorrowingBook;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnShowCopies;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dgvBorrowingRecords;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookDetailsToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon nficonReturnBook;
        private System.Windows.Forms.Button btnResertvation;
        private System.Windows.Forms.ToolStripMenuItem memberDetailsToolStripMenuItem;
    }
}