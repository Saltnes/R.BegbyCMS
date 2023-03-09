using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DBLayer
{
    public class DbLayer
    {
        public void SaveWebContent1(string content)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Huan"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd =
                    new SqlCommand("INSERT INTO Contents (content, date_published) VALUES (@content, @date_published)",
                        conn);
                cmd.CommandType = CommandType.Text;
                var paramContent = new SqlParameter("@content", SqlDbType.VarChar);
                paramContent.Value = content;

                cmd.Parameters.Add(paramContent);
                var paramDatePublished = new SqlParameter("@date_published", SqlDbType.DateTime);
                paramDatePublished.Value = DateTime.Now;
                cmd.Parameters.Add(paramDatePublished);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public string GetWebContent()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Huan"].ConnectionString;
            DataTable dt = new DataTable();
            string textFromDb = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP(1) content FROM Contents ORDER BY id DESC", conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    textFromDb = (string)reader[0];
                }

                reader.Close();
                conn.Close();
            }

            return textFromDb;
        }

        public string GetWebContent2()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Huan"].ConnectionString;
            DataTable dt = new DataTable();
            string textFromDb = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP(1) content FROM Contents2 ORDER BY id DESC", conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    textFromDb = (string)reader[0];
                }

                reader.Close();
                conn.Close();
            }

            return textFromDb;
        }

        public void SaveWebContent2(string content)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Huan"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd =
                    new SqlCommand("INSERT INTO Contents2 (content, date_published) VALUES (@content, @date_published)",
                        conn);
                cmd.CommandType = CommandType.Text;
                var paramContent = new SqlParameter("@content", SqlDbType.VarChar);
                paramContent.Value = content;

                cmd.Parameters.Add(paramContent);
                var paramDatePublished = new SqlParameter("@date_published", SqlDbType.DateTime);
                paramDatePublished.Value = DateTime.Now;
                cmd.Parameters.Add(paramDatePublished);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}