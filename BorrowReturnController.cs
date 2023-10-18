using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public class BorrowReturnController
    {
        public int MemberId { get; private set; }

        public string MemberName { get; private set; }

        public int BookId { get; private set; }

        public DateTime BorrowDate { get; private set; }

        public DateTime? ReturnDate { get; private set; } = null;

        public BorrowReturnController(int memberId, string memberName, int bookId, DateTime borrowDate)
        {
            MemberId = memberId;
            MemberName = memberName;
            BookId = bookId;
            BorrowDate = borrowDate;
        }

        public BorrowReturnController(int memberId, string memberName, int bookId, DateTime borrowDate, DateTime returnDate)
        {
            MemberId = memberId;
            MemberName = memberName;
            BookId = bookId;
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
        }

        public override string ToString()
        {
            if (ReturnDate == null)
            {
                return $"Borrowed by Id({MemberId}) - {MemberName} at {BorrowDate} ";
            }
            else
            {
                return $"Borrowed by Id({MemberId}) - {MemberName} at {BorrowDate} returned at {ReturnDate} ";
            }
        }
    }
}
