using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Library
{
    public partial class Form1 : Form
    {
        Library library;
        
        public Form1()
        {
            InitializeComponent();
            library = new Library("My Library");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                lboxMembers.DataSource = library.Members;
                lboxBooks.DataSource = library.Books;
            }
            catch (SqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }

            lboxMembers.ClearSelected();
            lboxBooks.ClearSelected();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.ToLower();
            string email = tbEmail.Text;
            string phoneNumber = tbPhoneNumber.Text;
            string address = tbAddress.Text;

            if (string.IsNullOrEmpty(name)) { MessageBox.Show("Please enter name!"); }
            else if (string.IsNullOrEmpty(email)) { MessageBox.Show("Please enter email!"); }
            else if (string.IsNullOrEmpty(phoneNumber)) { MessageBox.Show("Please enter phone number!"); }
            else
            {
                try
                {
                    library.AddMember(name, email, phoneNumber, address);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                lboxMembers.DataSource = null;
                lboxMembers.DataSource = library.Members;

                tbName.Clear();
                tbEmail.Clear();
                tbPhoneNumber.Clear();
                tbAddress.Clear();

                try
                {
                    SaveToFile();
                }
                catch (SerializationException ex) { MessageBox.Show(ex.Message); }
                //MessageBox.Show("Something went wrong with serialization");
            }
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            try
            {
                library.RemoveMember((Member)lboxMembers.SelectedItem);
            }
            catch (SqlException ex) 
            {
                MessageBox.Show(ex.Message); 
            }

            lboxMembers.DataSource = null;
            lboxMembers.DataSource = library.Members;

            try
            {
                SaveToFile();
            }
            catch (SerializationException) { MessageBox.Show("Something went wrong with serialization"); }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text.ToLower();
            string author = tbAuthor.Text.ToLower();
            string genre = tbGenre.Text.ToLower();
            string description = tbDescription.Text;
            DateTime publishDate = dtPublishDate.Value.Date;
            string ISBN = tbIsbn.Text;

            if (string.IsNullOrEmpty(title)) { MessageBox.Show("Please enter title!"); return; }
            if (string.IsNullOrEmpty(author)) { MessageBox.Show("Please enter author!"); return; }
            if (string.IsNullOrEmpty(genre)) { MessageBox.Show("Please enter genre!"); return; }
            if (string.IsNullOrEmpty(description)) { MessageBox.Show("Please enter description!"); return; }
            if (string.IsNullOrEmpty(ISBN)) { MessageBox.Show("Please enter ISBN!"); return; }
            else
            {
                try
                {
                    library.AddBook(title, author, genre, description, publishDate, ISBN, Convert.ToInt32(tbNoOfCopies.Text), Convert.ToInt32(tbNoOfPages.Text));
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Input for numer of copies/pages was wrongly entered or there was no input");
                    return;
                }
                
            }
            lboxBooks.DataSource = null;
            lboxBooks.DataSource = library.Books;

            tbAuthor.Clear();
            tbTitle.Clear();
            tbGenre.Clear();
            tbDescription.Clear();
            tbIsbn.Clear();
            tbNoOfCopies.Clear();
            tbNoOfPages.Clear();
            dtPublishDate.ResetText();

            try
            {
                SaveToFile();
            }
            catch (SerializationException) { MessageBox.Show("Something went wrong with serialization"); }
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            try
            {
                library.RemoveBook((Book)lboxBooks.SelectedItem);
            }
            catch (SqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }

            lboxBooks.DataSource = null;
            lboxBooks.DataSource = library.Books;

            try
            {
                SaveToFile();
            }
            catch (SerializationException) { MessageBox.Show("Something went wrong with serialization"); }
        }

        private void tbSearchBook_TextChanged(object sender, EventArgs e)
        {
            string[] searchBook = tbSearchBook.Text.ToLower().Split(' ');
            

            lboxFoundBooks.Items.Clear();

            if (searchBook.Length == 1)
            {
                foreach (Book book in library.Books)
                {
                    if (book.Title.Contains(searchBook[0]) || book.Author.Contains(searchBook[0]) || book.Genre.Contains(searchBook[0]))
                    {
                        lboxFoundBooks.Items.Add(book);
                    }
                }
            }
            if (searchBook.Length > 1) 
            {
                foreach (Book book in library.Books)
                {
                    if (book.Title.Contains(searchBook[0]) && book.Genre.Contains(searchBook[1]))
                    {
                        lboxFoundBooks.Items.Add(book);
                    }
                }
            }
            if (string.IsNullOrEmpty(tbSearchBook.Text)) { lboxFoundBooks.Items.Clear(); }
        }

        private void tbSearchMember_TextChanged(object sender, EventArgs e)
        {
            string searchMember = tbSearchMember.Text.Trim();

            lboxFoundMembers.Items.Clear();

            foreach (Member member in library.Members) 
            {
                if (member.Name.Contains(searchMember)) lboxFoundMembers.Items.Add(member); 
            }
            if (string.IsNullOrEmpty(searchMember)) { lboxFoundMembers.Items.Clear(); }
        }

        private void btnLendBook_Click(object sender, EventArgs e)
        {
            Book book = (Book)lboxFoundBooks.SelectedItem;
            Member member = (Member)lboxFoundMembers.SelectedItem;
            DateTime borrowDate = DateTime.Now;
            bool processed = false;

            try
            {
                processed = library.LendBook(member, book, borrowDate);
            }
            catch (SqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }

            if (processed) MessageBox.Show("Lending book is processed successfully");
            else MessageBox.Show("Lending has not been processed successfully book is already loaned");

            try
            {
                SaveToFile();
            }
            catch (SerializationException) { MessageBox.Show("Something went wrong with serialization"); }

        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            Book book = (Book)lboxFoundBooks.SelectedItem;
            Member member = (Member)lboxFoundMembers.SelectedItem;
            DateTime returnDate = DateTime.Now;
            bool processed = false;

            try
            {
                processed = library.ReturnBook(member, book, returnDate);
            }
            catch (SqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            if (processed) MessageBox.Show("Thank you, i hope you enjoyed it!");
            else MessageBox.Show("something went wrong please select the right book and the right person.");

            try
            {
                SaveToFile();
            }
            catch (SerializationException) { MessageBox.Show("Something went wrong with serialization"); }

        }

        private void lboxFoundBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book selectedBook = (Book)lboxFoundBooks.SelectedItem;

            lboxCurrentBorrower.Items.Clear();
            lboxBorrowingHistory.Items.Clear();

            foreach (BorrowReturnController borrowedBook in library.BorrowHistory)  
            {
                if (borrowedBook.BookId == selectedBook.Id && borrowedBook.ReturnDate == null)
                {
                    lboxCurrentBorrower.Items.Add(borrowedBook);
                }
                else if (borrowedBook.BookId == selectedBook.Id && borrowedBook.ReturnDate != null)
                {
                    lboxBorrowingHistory.Items.Add(borrowedBook);
                }
            }
        }

        public void SaveToFile()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;


            fs = new FileStream("../../../LibraryData.txt", FileMode.OpenOrCreate, FileAccess.Write);
            bf = new BinaryFormatter();
            bf.Serialize(fs, library);

            fs.Close();

        }

    }
}