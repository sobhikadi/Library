using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Library
{
    [Serializable]
    internal class BorrowReturnDBHelper
    {
        private string connectionString = @"Data Source=127.0.0.1,1433;Database=Library;User Id=Sobhi;Password=Onzin2022";

        public void InsertBorrowReturn(BorrowReturnController lendBook)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {

                conn.Open();
                string sql = "insert into BorrowReturnHistory (memberId, BorrowerName, bookId, borrowDate) values (@memberId, @BorrowerName, @bookId, @borrowDate);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@memberId", lendBook.MemberId);
                cmd.Parameters.AddWithValue("@BorrowerName", lendBook.MemberName);
                cmd.Parameters.AddWithValue("@bookId", lendBook.BookId);
                cmd.Parameters.AddWithValue("@borrowDate", lendBook.BorrowDate);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<BorrowReturnController> GetBorrowHistory()
        {
            List<BorrowReturnController> borrowHistory = new List<BorrowReturnController>();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string sql = "select MemberId, BorrowerName, BookId, BorrowDate, ReturnDate from BorrowReturnHistory order by MemberId;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr[4] == DBNull.Value)
                    {
                        BorrowReturnController lendBook = new BorrowReturnController(Convert.ToInt32(dr[0]), (string)dr[1], Convert.ToInt32(dr[2]), Convert.ToDateTime(dr[3]));
                        borrowHistory.Add(lendBook);
                    }
                    else 
                    {
                        BorrowReturnController lendBook = new BorrowReturnController(Convert.ToInt32(dr[0]), (string)dr[1], Convert.ToInt32(dr[2]), Convert.ToDateTime(dr[3]), Convert.ToDateTime(dr[4]));
                        borrowHistory.Add(lendBook);
                    }
                }
                conn.Close();
            }
            return borrowHistory;
        }

        public void UpdateReturnDate(BorrowReturnController returnedBook, DateTime returnDate)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string sql = "update borrowReturnHistory set returnDate=@returnDate where memberId=@memberId and bookId=@bookId;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@returnDate", returnDate);
                cmd.Parameters.AddWithValue("@memberId", returnedBook.MemberId);
                cmd.Parameters.AddWithValue("@bookId", returnedBook.BookId);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
