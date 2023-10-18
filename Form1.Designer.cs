namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpageAddMember = new System.Windows.Forms.TabPage();
            this.gboxRemoveMember = new System.Windows.Forms.GroupBox();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.lblRemoveMember = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.lboxMembers = new System.Windows.Forms.ListBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabpageAddBook = new System.Windows.Forms.TabPage();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.dtPublishDate = new System.Windows.Forms.DateTimePicker();
            this.gboxRemoveBook = new System.Windows.Forms.GroupBox();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lboxBooks = new System.Windows.Forms.ListBox();
            this.tbNoOfPages = new System.Windows.Forms.TextBox();
            this.lblNopages = new System.Windows.Forms.Label();
            this.tbNoOfCopies = new System.Windows.Forms.TextBox();
            this.lblNoOfCopies = new System.Windows.Forms.Label();
            this.tbIsbn = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabPageLendReturn = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.lblSelectBook = new System.Windows.Forms.Label();
            this.lblBorrowingHistory = new System.Windows.Forms.Label();
            this.lblCurrentBorrower = new System.Windows.Forms.Label();
            this.lboxBorrowingHistory = new System.Windows.Forms.ListBox();
            this.lboxCurrentBorrower = new System.Windows.Forms.ListBox();
            this.btnLendBook = new System.Windows.Forms.Button();
            this.lblFoundMembers = new System.Windows.Forms.Label();
            this.lblFoundBooks = new System.Windows.Forms.Label();
            this.tbSearchMember = new System.Windows.Forms.TextBox();
            this.lblSearchMember = new System.Windows.Forms.Label();
            this.lboxFoundMembers = new System.Windows.Forms.ListBox();
            this.lboxFoundBooks = new System.Windows.Forms.ListBox();
            this.tbSearchBook = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabpageAddMember.SuspendLayout();
            this.gboxRemoveMember.SuspendLayout();
            this.tabpageAddBook.SuspendLayout();
            this.gboxRemoveBook.SuspendLayout();
            this.tabPageLendReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpageAddMember);
            this.tabControl1.Controls.Add(this.tabpageAddBook);
            this.tabControl1.Controls.Add(this.tabPageLendReturn);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1322, 774);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpageAddMember
            // 
            this.tabpageAddMember.Controls.Add(this.gboxRemoveMember);
            this.tabpageAddMember.Controls.Add(this.tbPhoneNumber);
            this.tabpageAddMember.Controls.Add(this.lblPhoneNumber);
            this.tabpageAddMember.Controls.Add(this.tbAddress);
            this.tabpageAddMember.Controls.Add(this.lblAddress);
            this.tabpageAddMember.Controls.Add(this.tbEmail);
            this.tabpageAddMember.Controls.Add(this.lblEmail);
            this.tabpageAddMember.Controls.Add(this.lblMembers);
            this.tabpageAddMember.Controls.Add(this.lboxMembers);
            this.tabpageAddMember.Controls.Add(this.btnAddMember);
            this.tabpageAddMember.Controls.Add(this.tbName);
            this.tabpageAddMember.Controls.Add(this.lblName);
            this.tabpageAddMember.Location = new System.Drawing.Point(4, 29);
            this.tabpageAddMember.Name = "tabpageAddMember";
            this.tabpageAddMember.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageAddMember.Size = new System.Drawing.Size(1314, 741);
            this.tabpageAddMember.TabIndex = 0;
            this.tabpageAddMember.Text = "Add Member";
            this.tabpageAddMember.UseVisualStyleBackColor = true;
            // 
            // gboxRemoveMember
            // 
            this.gboxRemoveMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxRemoveMember.Controls.Add(this.btnRemoveMember);
            this.gboxRemoveMember.Controls.Add(this.lblRemoveMember);
            this.gboxRemoveMember.Location = new System.Drawing.Point(32, 589);
            this.gboxRemoveMember.Name = "gboxRemoveMember";
            this.gboxRemoveMember.Size = new System.Drawing.Size(841, 135);
            this.gboxRemoveMember.TabIndex = 11;
            this.gboxRemoveMember.TabStop = false;
            this.gboxRemoveMember.Text = "RemoveMember";
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveMember.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveMember.Location = new System.Drawing.Point(554, 54);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(270, 45);
            this.btnRemoveMember.TabIndex = 12;
            this.btnRemoveMember.Text = "Remove Member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // lblRemoveMember
            // 
            this.lblRemoveMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemoveMember.AutoSize = true;
            this.lblRemoveMember.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRemoveMember.Location = new System.Drawing.Point(21, 49);
            this.lblRemoveMember.Name = "lblRemoveMember";
            this.lblRemoveMember.Size = new System.Drawing.Size(258, 50);
            this.lblRemoveMember.TabIndex = 12;
            this.lblRemoveMember.Text = "Select a member from the list\r\nof members to remove:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPhoneNumber.Location = new System.Drawing.Point(182, 206);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(691, 32);
            this.tbPhoneNumber.TabIndex = 10;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.Location = new System.Drawing.Point(32, 209);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(144, 25);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAddress.Location = new System.Drawing.Point(182, 274);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PlaceholderText = "This field is optional!";
            this.tbAddress.Size = new System.Drawing.Size(691, 32);
            this.tbAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(32, 277);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(83, 25);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address:";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(182, 136);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(691, 32);
            this.tbEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(32, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 25);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // lblMembers
            // 
            this.lblMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMembers.Location = new System.Drawing.Point(896, 31);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(95, 25);
            this.lblMembers.TabIndex = 4;
            this.lblMembers.Text = "Members:";
            // 
            // lboxMembers
            // 
            this.lboxMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxMembers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboxMembers.FormattingEnabled = true;
            this.lboxMembers.ItemHeight = 25;
            this.lboxMembers.Location = new System.Drawing.Point(896, 72);
            this.lboxMembers.Name = "lboxMembers";
            this.lboxMembers.Size = new System.Drawing.Size(410, 654);
            this.lboxMembers.Sorted = true;
            this.lboxMembers.TabIndex = 3;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddMember.Location = new System.Drawing.Point(603, 340);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(270, 45);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(182, 69);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(691, 32);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(32, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // tabpageAddBook
            // 
            this.tabpageAddBook.Controls.Add(this.btnAddBook);
            this.tabpageAddBook.Controls.Add(this.dtPublishDate);
            this.tabpageAddBook.Controls.Add(this.gboxRemoveBook);
            this.tabpageAddBook.Controls.Add(this.lblBooks);
            this.tabpageAddBook.Controls.Add(this.lboxBooks);
            this.tabpageAddBook.Controls.Add(this.tbNoOfPages);
            this.tabpageAddBook.Controls.Add(this.lblNopages);
            this.tabpageAddBook.Controls.Add(this.tbNoOfCopies);
            this.tabpageAddBook.Controls.Add(this.lblNoOfCopies);
            this.tabpageAddBook.Controls.Add(this.tbIsbn);
            this.tabpageAddBook.Controls.Add(this.lblIsbn);
            this.tabpageAddBook.Controls.Add(this.lblPublishDate);
            this.tabpageAddBook.Controls.Add(this.tbDescription);
            this.tabpageAddBook.Controls.Add(this.lblDescription);
            this.tabpageAddBook.Controls.Add(this.tbGenre);
            this.tabpageAddBook.Controls.Add(this.lblGenre);
            this.tabpageAddBook.Controls.Add(this.tbAuthor);
            this.tabpageAddBook.Controls.Add(this.lblAuthor);
            this.tabpageAddBook.Controls.Add(this.tbTitle);
            this.tabpageAddBook.Controls.Add(this.lblTitle);
            this.tabpageAddBook.Location = new System.Drawing.Point(4, 29);
            this.tabpageAddBook.Name = "tabpageAddBook";
            this.tabpageAddBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageAddBook.Size = new System.Drawing.Size(1314, 741);
            this.tabpageAddBook.TabIndex = 1;
            this.tabpageAddBook.Text = "Add Book";
            this.tabpageAddBook.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.Location = new System.Drawing.Point(404, 553);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(255, 45);
            this.btnAddBook.TabIndex = 14;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // dtPublishDate
            // 
            this.dtPublishDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPublishDate.Location = new System.Drawing.Point(158, 345);
            this.dtPublishDate.Name = "dtPublishDate";
            this.dtPublishDate.Size = new System.Drawing.Size(321, 32);
            this.dtPublishDate.TabIndex = 21;
            // 
            // gboxRemoveBook
            // 
            this.gboxRemoveBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxRemoveBook.Controls.Add(this.btnRemoveBook);
            this.gboxRemoveBook.Controls.Add(this.label1);
            this.gboxRemoveBook.Location = new System.Drawing.Point(8, 616);
            this.gboxRemoveBook.Name = "gboxRemoveBook";
            this.gboxRemoveBook.Size = new System.Drawing.Size(651, 112);
            this.gboxRemoveBook.TabIndex = 20;
            this.gboxRemoveBook.TabStop = false;
            this.gboxRemoveBook.Text = "RemoveBook";
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveBook.Location = new System.Drawing.Point(371, 43);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(255, 45);
            this.btnRemoveBook.TabIndex = 13;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select a book from the list\r\nof books to remove:";
            // 
            // lblBooks
            // 
            this.lblBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBooks.Location = new System.Drawing.Point(678, 25);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(62, 25);
            this.lblBooks.TabIndex = 19;
            this.lblBooks.Text = "Books";
            // 
            // lboxBooks
            // 
            this.lboxBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxBooks.FormattingEnabled = true;
            this.lboxBooks.ItemHeight = 20;
            this.lboxBooks.Location = new System.Drawing.Point(678, 64);
            this.lboxBooks.Name = "lboxBooks";
            this.lboxBooks.Size = new System.Drawing.Size(628, 664);
            this.lboxBooks.Sorted = true;
            this.lboxBooks.TabIndex = 18;
            // 
            // tbNoOfPages
            // 
            this.tbNoOfPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNoOfPages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNoOfPages.Location = new System.Drawing.Point(158, 496);
            this.tbNoOfPages.Name = "tbNoOfPages";
            this.tbNoOfPages.Size = new System.Drawing.Size(501, 32);
            this.tbNoOfPages.TabIndex = 17;
            // 
            // lblNopages
            // 
            this.lblNopages.AutoSize = true;
            this.lblNopages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNopages.Location = new System.Drawing.Point(24, 499);
            this.lblNopages.Name = "lblNopages";
            this.lblNopages.Size = new System.Drawing.Size(122, 25);
            this.lblNopages.TabIndex = 16;
            this.lblNopages.Text = "No. of pages:";
            // 
            // tbNoOfCopies
            // 
            this.tbNoOfCopies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNoOfCopies.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNoOfCopies.Location = new System.Drawing.Point(158, 447);
            this.tbNoOfCopies.Name = "tbNoOfCopies";
            this.tbNoOfCopies.Size = new System.Drawing.Size(501, 32);
            this.tbNoOfCopies.TabIndex = 15;
            // 
            // lblNoOfCopies
            // 
            this.lblNoOfCopies.AutoSize = true;
            this.lblNoOfCopies.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoOfCopies.Location = new System.Drawing.Point(24, 450);
            this.lblNoOfCopies.Name = "lblNoOfCopies";
            this.lblNoOfCopies.Size = new System.Drawing.Size(126, 25);
            this.lblNoOfCopies.TabIndex = 14;
            this.lblNoOfCopies.Text = "No. of copies:";
            // 
            // tbIsbn
            // 
            this.tbIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIsbn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbIsbn.Location = new System.Drawing.Point(158, 398);
            this.tbIsbn.Name = "tbIsbn";
            this.tbIsbn.Size = new System.Drawing.Size(501, 32);
            this.tbIsbn.TabIndex = 13;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIsbn.Location = new System.Drawing.Point(24, 401);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(56, 25);
            this.lblIsbn.TabIndex = 12;
            this.lblIsbn.Text = "ISBN:";
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPublishDate.Location = new System.Drawing.Point(24, 345);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(122, 25);
            this.lblPublishDate.TabIndex = 10;
            this.lblPublishDate.Text = "Publish Date:";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescription.Location = new System.Drawing.Point(158, 162);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(501, 161);
            this.tbDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(24, 165);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 25);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description:";
            // 
            // tbGenre
            // 
            this.tbGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGenre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbGenre.Location = new System.Drawing.Point(158, 111);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(501, 32);
            this.tbGenre.TabIndex = 7;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.Location = new System.Drawing.Point(24, 114);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(67, 25);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre:";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuthor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAuthor.Location = new System.Drawing.Point(158, 64);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(501, 32);
            this.tbAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.Location = new System.Drawing.Point(24, 67);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(74, 25);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author:";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTitle.Location = new System.Drawing.Point(158, 22);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(501, 32);
            this.tbTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(24, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // tabPageLendReturn
            // 
            this.tabPageLendReturn.Controls.Add(this.label2);
            this.tabPageLendReturn.Controls.Add(this.btnReturnBook);
            this.tabPageLendReturn.Controls.Add(this.lblSelectBook);
            this.tabPageLendReturn.Controls.Add(this.lblBorrowingHistory);
            this.tabPageLendReturn.Controls.Add(this.lblCurrentBorrower);
            this.tabPageLendReturn.Controls.Add(this.lboxBorrowingHistory);
            this.tabPageLendReturn.Controls.Add(this.lboxCurrentBorrower);
            this.tabPageLendReturn.Controls.Add(this.btnLendBook);
            this.tabPageLendReturn.Controls.Add(this.lblFoundMembers);
            this.tabPageLendReturn.Controls.Add(this.lblFoundBooks);
            this.tabPageLendReturn.Controls.Add(this.tbSearchMember);
            this.tabPageLendReturn.Controls.Add(this.lblSearchMember);
            this.tabPageLendReturn.Controls.Add(this.lboxFoundMembers);
            this.tabPageLendReturn.Controls.Add(this.lboxFoundBooks);
            this.tabPageLendReturn.Controls.Add(this.tbSearchBook);
            this.tabPageLendReturn.Controls.Add(this.lblSearch);
            this.tabPageLendReturn.Location = new System.Drawing.Point(4, 29);
            this.tabPageLendReturn.Name = "tabPageLendReturn";
            this.tabPageLendReturn.Size = new System.Drawing.Size(1314, 741);
            this.tabPageLendReturn.TabIndex = 2;
            this.tabPageLendReturn.Text = "Lend/Return Book";
            this.tabPageLendReturn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Select a book and a member to lend or to return book:";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturnBook.Location = new System.Drawing.Point(778, 407);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(255, 45);
            this.btnReturnBook.TabIndex = 21;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // lblSelectBook
            // 
            this.lblSelectBook.AutoSize = true;
            this.lblSelectBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectBook.Location = new System.Drawing.Point(20, 455);
            this.lblSelectBook.Name = "lblSelectBook";
            this.lblSelectBook.Size = new System.Drawing.Size(508, 25);
            this.lblSelectBook.TabIndex = 20;
            this.lblSelectBook.Text = "Select a book to show current borrower or borroing history";
            // 
            // lblBorrowingHistory
            // 
            this.lblBorrowingHistory.AutoSize = true;
            this.lblBorrowingHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBorrowingHistory.Location = new System.Drawing.Point(20, 601);
            this.lblBorrowingHistory.Name = "lblBorrowingHistory";
            this.lblBorrowingHistory.Size = new System.Drawing.Size(168, 25);
            this.lblBorrowingHistory.TabIndex = 19;
            this.lblBorrowingHistory.Text = "Borrowing History:";
            // 
            // lblCurrentBorrower
            // 
            this.lblCurrentBorrower.AutoSize = true;
            this.lblCurrentBorrower.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentBorrower.Location = new System.Drawing.Point(20, 480);
            this.lblCurrentBorrower.Name = "lblCurrentBorrower";
            this.lblCurrentBorrower.Size = new System.Drawing.Size(183, 25);
            this.lblCurrentBorrower.TabIndex = 18;
            this.lblCurrentBorrower.Text = "Current Borrower(s):";
            // 
            // lboxBorrowingHistory
            // 
            this.lboxBorrowingHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxBorrowingHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboxBorrowingHistory.FormattingEnabled = true;
            this.lboxBorrowingHistory.ItemHeight = 25;
            this.lboxBorrowingHistory.Location = new System.Drawing.Point(20, 629);
            this.lboxBorrowingHistory.Name = "lboxBorrowingHistory";
            this.lboxBorrowingHistory.Size = new System.Drawing.Size(1274, 104);
            this.lboxBorrowingHistory.Sorted = true;
            this.lboxBorrowingHistory.TabIndex = 17;
            // 
            // lboxCurrentBorrower
            // 
            this.lboxCurrentBorrower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxCurrentBorrower.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboxCurrentBorrower.FormattingEnabled = true;
            this.lboxCurrentBorrower.ItemHeight = 25;
            this.lboxCurrentBorrower.Location = new System.Drawing.Point(20, 508);
            this.lboxCurrentBorrower.Name = "lboxCurrentBorrower";
            this.lboxCurrentBorrower.Size = new System.Drawing.Size(1274, 79);
            this.lboxCurrentBorrower.Sorted = true;
            this.lboxCurrentBorrower.TabIndex = 16;
            // 
            // btnLendBook
            // 
            this.btnLendBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLendBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLendBook.Location = new System.Drawing.Point(1039, 407);
            this.btnLendBook.Name = "btnLendBook";
            this.btnLendBook.Size = new System.Drawing.Size(255, 45);
            this.btnLendBook.TabIndex = 15;
            this.btnLendBook.Text = "Lend Book";
            this.btnLendBook.UseVisualStyleBackColor = true;
            this.btnLendBook.Click += new System.EventHandler(this.btnLendBook_Click);
            // 
            // lblFoundMembers
            // 
            this.lblFoundMembers.AutoSize = true;
            this.lblFoundMembers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFoundMembers.Location = new System.Drawing.Point(20, 258);
            this.lblFoundMembers.Name = "lblFoundMembers";
            this.lblFoundMembers.Size = new System.Drawing.Size(153, 25);
            this.lblFoundMembers.TabIndex = 11;
            this.lblFoundMembers.Text = "Found Members:";
            // 
            // lblFoundBooks
            // 
            this.lblFoundBooks.AutoSize = true;
            this.lblFoundBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFoundBooks.Location = new System.Drawing.Point(20, 108);
            this.lblFoundBooks.Name = "lblFoundBooks";
            this.lblFoundBooks.Size = new System.Drawing.Size(124, 25);
            this.lblFoundBooks.TabIndex = 10;
            this.lblFoundBooks.Text = "Found Books:";
            // 
            // tbSearchMember
            // 
            this.tbSearchMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchMember.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearchMember.Location = new System.Drawing.Point(218, 66);
            this.tbSearchMember.Name = "tbSearchMember";
            this.tbSearchMember.PlaceholderText = "Enter member Name";
            this.tbSearchMember.Size = new System.Drawing.Size(705, 32);
            this.tbSearchMember.TabIndex = 9;
            this.tbSearchMember.TextChanged += new System.EventHandler(this.tbSearchMember_TextChanged);
            // 
            // lblSearchMember
            // 
            this.lblSearchMember.AutoSize = true;
            this.lblSearchMember.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchMember.Location = new System.Drawing.Point(20, 69);
            this.lblSearchMember.Name = "lblSearchMember";
            this.lblSearchMember.Size = new System.Drawing.Size(192, 25);
            this.lblSearchMember.TabIndex = 8;
            this.lblSearchMember.Text = "Search for a member:";
            // 
            // lboxFoundMembers
            // 
            this.lboxFoundMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxFoundMembers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboxFoundMembers.FormattingEnabled = true;
            this.lboxFoundMembers.ItemHeight = 25;
            this.lboxFoundMembers.Location = new System.Drawing.Point(20, 297);
            this.lboxFoundMembers.Name = "lboxFoundMembers";
            this.lboxFoundMembers.Size = new System.Drawing.Size(1274, 104);
            this.lboxFoundMembers.Sorted = true;
            this.lboxFoundMembers.TabIndex = 7;
            // 
            // lboxFoundBooks
            // 
            this.lboxFoundBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxFoundBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboxFoundBooks.FormattingEnabled = true;
            this.lboxFoundBooks.ItemHeight = 25;
            this.lboxFoundBooks.Location = new System.Drawing.Point(20, 146);
            this.lboxFoundBooks.Name = "lboxFoundBooks";
            this.lboxFoundBooks.Size = new System.Drawing.Size(1274, 104);
            this.lboxFoundBooks.Sorted = true;
            this.lboxFoundBooks.TabIndex = 6;
            this.lboxFoundBooks.SelectedIndexChanged += new System.EventHandler(this.lboxFoundBooks_SelectedIndexChanged);
            // 
            // tbSearchBook
            // 
            this.tbSearchBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearchBook.Location = new System.Drawing.Point(190, 13);
            this.tbSearchBook.Name = "tbSearchBook";
            this.tbSearchBook.PlaceholderText = "Enter title, author or genre";
            this.tbSearchBook.Size = new System.Drawing.Size(733, 32);
            this.tbSearchBook.TabIndex = 5;
            this.tbSearchBook.TextChanged += new System.EventHandler(this.tbSearchBook_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(20, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(164, 25);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search for a Book:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 774);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpageAddMember.ResumeLayout(false);
            this.tabpageAddMember.PerformLayout();
            this.gboxRemoveMember.ResumeLayout(false);
            this.gboxRemoveMember.PerformLayout();
            this.tabpageAddBook.ResumeLayout(false);
            this.tabpageAddBook.PerformLayout();
            this.gboxRemoveBook.ResumeLayout(false);
            this.gboxRemoveBook.PerformLayout();
            this.tabPageLendReturn.ResumeLayout(false);
            this.tabPageLendReturn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabpageAddMember;
        private TabPage tabpageAddBook;
        private Label lblMembers;
        private ListBox lboxMembers;
        private Button btnAddMember;
        private TextBox tbName;
        private Label lblName;
        private TextBox tbAddress;
        private Label lblAddress;
        private TextBox tbEmail;
        private Label lblEmail;
        private TextBox tbPhoneNumber;
        private Label lblPhoneNumber;
        private GroupBox gboxRemoveMember;
        private Button btnRemoveMember;
        private Label lblRemoveMember;
        private TextBox tbDescription;
        private Label lblDescription;
        private TextBox tbGenre;
        private Label lblGenre;
        private TextBox tbAuthor;
        private Label lblAuthor;
        private TextBox tbTitle;
        private Label lblTitle;
        private TextBox tbNoOfPages;
        private Label lblNopages;
        private TextBox tbNoOfCopies;
        private Label lblNoOfCopies;
        private TextBox tbIsbn;
        private Label lblIsbn;
        private Label lblPublishDate;
        private Label lblBooks;
        private ListBox lboxBooks;
        private GroupBox gboxRemoveBook;
        private Button btnRemoveBook;
        private Label label1;
        private DateTimePicker dtPublishDate;
        private Button btnAddBook;
        private TabPage tabPageLendReturn;
        private TextBox tbSearchBook;
        private Label lblSearch;
        private ListBox lboxFoundMembers;
        private ListBox lboxFoundBooks;
        private TextBox tbSearchMember;
        private Label lblSearchMember;
        private Label lblFoundMembers;
        private Label lblFoundBooks;
        private Button btnLendBook;
        private Label lblSelectBook;
        private Label lblBorrowingHistory;
        private Label lblCurrentBorrower;
        private ListBox lboxBorrowingHistory;
        private ListBox lboxCurrentBorrower;
        private Label label2;
        private Button btnReturnBook;
    }
}