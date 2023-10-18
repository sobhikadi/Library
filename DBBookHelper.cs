using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library
{
    [Serializable]
    public class DBBookHelper
    {
        private string connectionString = @"Data Source=127.0.0.1,1433;Database=Library;User Id=Sobhi;Password=Onzin2022";

        public void InsertBook(Book book)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                
                conn.Open();
                string sql = "insert into Book (title, author, genre, description, publishDate, isbn, noOfCopies, noOfCopiesAvailable, noOfpages) values (@title, @author, @genre, @description, @publishDate, @isbn, @noOfCopies, @noOfCopiesAvailable, @noOfpages);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@title", book.Title);
                cmd.Parameters.AddWithValue("@author", book.Author);
                cmd.Parameters.AddWithValue("@genre", book.Genre);
                cmd.Parameters.AddWithValue("@description", book.Description);
                cmd.Parameters.AddWithValue("@publishDate", book.PublishDate);
                cmd.Parameters.AddWithValue("@isbn", book.ISBN);
                cmd.Parameters.AddWithValue("@noOfCopies", book.NrOfCopies);
                cmd.Parameters.AddWithValue("@noOfCopiesAvailable", book.NrCopiesAvailable);
                cmd.Parameters.AddWithValue("@noOfpages", book.NrOfPages);
                
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string sql = "select id, title, author, genre, description, publishDate, noOfCopies, noOfPages, isbn from book order by id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Book book = new Book(Convert.ToInt32(dr[0]), (string)dr[1], (string)dr[2], (string)dr[3], (string)dr[4], Convert.ToDateTime(dr[5]), (string)dr[8], Convert.ToInt32(dr[6]), Convert.ToInt32(dr[7]));
                    books.Add(book);
                }
                conn.Close();
            }

            return books;
        }

        public void UpdateBook(Book book)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string sql = "update book set NoOfCopiesAvailable=@NoOfCopiesAvailable where id=@id;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NoOfCopiesAvailable", book.NrCopiesAvailable);
                cmd.Parameters.AddWithValue("@id", book.Id);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void Delete(Book book)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string sql = "delete from book where id=@id;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", book.Id);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
