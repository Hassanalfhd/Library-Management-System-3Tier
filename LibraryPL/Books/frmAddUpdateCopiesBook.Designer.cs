namespace LibraryWinFormApp_PersentantionLayer.Books
{
    partial class frmAddUpdateCopiesBook
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbUnAvalible = new System.Windows.Forms.RadioButton();
            this.rbAvalible = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBooks = new System.Windows.Forms.ComboBox();
            this.lblCopyBookID = new System.Windows.Forms.Label();
            this.btnCasel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.panel1.Size = new System.Drawing.Size(534, 60);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.rbUnAvalible);
            this.panel2.Controls.Add(this.rbAvalible);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbBooks);
            this.panel2.Controls.Add(this.lblCopyBookID);
            this.panel2.Controls.Add(this.btnCasel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 212);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rbUnAvalible
            // 
            this.rbUnAvalible.AutoSize = true;
            this.rbUnAvalible.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnAvalible.Location = new System.Drawing.Point(303, 115);
            this.rbUnAvalible.Name = "rbUnAvalible";
            this.rbUnAvalible.Size = new System.Drawing.Size(93, 21);
            this.rbUnAvalible.TabIndex = 25;
            this.rbUnAvalible.TabStop = true;
            this.rbUnAvalible.Text = "UnAvalible";
            this.rbUnAvalible.UseVisualStyleBackColor = true;
            // 
            // rbAvalible
            // 
            this.rbAvalible.AutoSize = true;
            this.rbAvalible.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAvalible.Location = new System.Drawing.Point(303, 82);
            this.rbAvalible.Name = "rbAvalible";
            this.rbAvalible.Size = new System.Drawing.Size(76, 21);
            this.rbAvalible.TabIndex = 24;
            this.rbAvalible.TabStop = true;
            this.rbAvalible.Text = "Avalible";
            this.rbAvalible.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Books:";
            // 
            // cbBooks
            // 
            this.cbBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBooks.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbBooks.FormattingEnabled = true;
            this.cbBooks.Location = new System.Drawing.Point(299, 34);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(199, 31);
            this.cbBooks.TabIndex = 17;
            // 
            // lblCopyBookID
            // 
            this.lblCopyBookID.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyBookID.Location = new System.Drawing.Point(55, 44);
            this.lblCopyBookID.Name = "lblCopyBookID";
            this.lblCopyBookID.Size = new System.Drawing.Size(174, 21);
            this.lblCopyBookID.TabIndex = 16;
            // 
            // btnCasel
            // 
            this.btnCasel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCasel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasel.Location = new System.Drawing.Point(299, 153);
            this.btnCasel.Name = "btnCasel";
            this.btnCasel.Size = new System.Drawing.Size(154, 37);
            this.btnCasel.TabIndex = 15;
            this.btnCasel.Text = "Cansel";
            this.btnCasel.UseVisualStyleBackColor = true;
            this.btnCasel.Click += new System.EventHandler(this.btnCasel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(83, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 37);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddUpdateCopiesBook
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CancelButton = this.btnCasel;
            this.ClientSize = new System.Drawing.Size(534, 272);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateCopiesBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdate";
            this.Load += new System.EventHandler(this.frmAddUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAddUpdateTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCasel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCopyBookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rbUnAvalible;
        private System.Windows.Forms.RadioButton rbAvalible;
    }
}