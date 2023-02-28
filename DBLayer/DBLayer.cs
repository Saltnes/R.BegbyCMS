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
                SqlCommand cmd = new SqlCommand("INSERT INTO Contents (content) VALUES (@content)", conn);
                cmd.CommandType = CommandType.Text;

                var param = new SqlParameter("@content", SqlDbType.VarChar);
                param.Value =
                    content;
                cmd.Parameters.Add(param);

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
    }
}