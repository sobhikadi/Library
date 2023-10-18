using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]

    public class DBMemberHelper
    {
        private string connectionString = @"Data Source=127.0.0.1,1433;Database=Library;User Id=Sobhi;Password=Onzin2022";

        public void InsertMember(Member member)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string sql = "insert into Member (name, email, phoneNumber, address) values (@name, @email, @phoneNumber, @address);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", member.Name);
                cmd.Parameters.AddWithValue("@email", member.Email);
                cmd.Parameters.AddWithValue("@phoneNumber", member.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", member.Address);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<Member> GetAllMembers()
        {
            List<Member> members = new List<Member>();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string sql = "select id, name, email, phoneNumber, address from member order by id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Member member = new Member(Convert.ToInt32(dr[0]), (string)dr[1], (string)dr[2], (string)dr[3], (string)dr[4]);
                    members.Add(member);
                }
                conn.Close();
            }

            return members;
        }

        public void Delete(Member member)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string sql = "delete from member where id=@id;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", member.Id);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

    }
}
