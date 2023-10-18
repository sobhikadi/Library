using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public class Library
    {
        DBMemberHelper memberDbHelper;
        DBBookHelper bookDbHelper;
        BorrowReturnDBHelper borrowReturnDBHelper;
        
        public string Name { get; private set; }

        public List<Book> Books { get; private set; }

        public List<Member> Members { get; private set; }

        public List<BorrowReturnController> BorrowHistory { get; private set; }

        public Library(string name) 
        {
            Name = name;
            Books = new List<Book>();
            Members = new List<Member>();
            BorrowHistory = new List<BorrowReturnController>();
            memberDbHelper = new DBMemberHelper();
            bookDbHelper = new DBBookHelper();
            borrowReturnDBHelper = new BorrowReturnDBHelper();

            Books = bookDbHelper.GetAllBooks();
            Members = memberDbHelper.GetAllMembers();
            BorrowHistory = borrowReturnDBHelper.GetBorrowHistory();
        }
        #region Books
        public void AddBook(string title, string author, string genre, string description, DateTime publishDate,  string isbn, int nrOfCopies, int pages) 
        {
            Book newBook = new Book(title, author, genre, description, publishDate, isbn, nrOfCopies, pages);

            bookDbHelper.InsertBook(newBook);
            Books.Clear();
            Books = bookDbHelper.GetAllBooks();
        }

        public void RemoveBook(Book book) 
        {
            bookDbHelper.Delete(book);
            Books.Clear();
            Books = bookDbHelper.GetAllBooks();
        }
        #endregion

        public void AddMember(string name, string email, string phoneNumber,string address)
        {
            Member newMember = new Member(name, email, phoneNumber, address);

            memberDbHelper.InsertMember(newMember);
            Members.Clear();
            Members = memberDbHelper.GetAllMembers();
        }

        public void RemoveMember(Member member) 
        {
            memberDbHelper.Delete(member);
            Members.Clear();
            Members = memberDbHelper.GetAllMembers();
        }

        public bool LendBook(Member member, Book book, DateTime borrowDate) 
        {
            if (book.NrCopiesAvailable <= 0) return false;
            
            BorrowReturnController lendBook = new BorrowReturnController(member.Id, member.Name, book.Id, borrowDate);
            book.ReduceBookStock();
            bookDbHelper.UpdateBook(book);
            borrowReturnDBHelper.InsertBorrowReturn(lendBook);
            BorrowHistory.Clear();
            BorrowHistory = borrowReturnDBHelper.GetBorrowHistory();
            return true;
        }

        public bool ReturnBook(Member member, Book book, DateTime returnDate) 
        {
            foreach (BorrowReturnController borrowedBook in BorrowHistory) 
            {
                if (borrowedBook.MemberId == member.Id && borrowedBook.BookId == book.Id)
                {
                    borrowReturnDBHelper.UpdateReturnDate(borrowedBook, returnDate);
                    BorrowHistory.Clear();
                    BorrowHistory = borrowReturnDBHelper.GetBorrowHistory();
                    book.IncreaseBookStock();
                    bookDbHelper.UpdateBook(book);
                    return true;
                }
            }
            return false;
        }

    }
}
