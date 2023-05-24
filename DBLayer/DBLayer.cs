using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DBLayer
{
    public class DbLayer
    {
        public DataTable GetAllElev()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Huan"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Elev", conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                conn.Close();
            }

            return dt;
        }

        public DataTable GetInfoFromFornavn(string fornavn)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Huan"].ConnectionString;
            DataTable dt = new DataTable();
            SqlParameter param;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT Elev.Fornavn, Elev.Etternavn, Fag.Fagnavn, Elev.Adresse, Elev.PostNr, Poststeder.Poststed, Elev.KlasseID, Klasse.KlasseNavn FROM Elev INNER JOIN Klasse ON Elev.KlasseID = Klasse.KlasseID INNER JOIN FagElev ON Elev.ElevID = FagElev.ElevID INNER JOIN Fag ON FagElev.FagKode = Fag.FagKode INNER JOIN Poststeder ON Elev.PostNr = Poststeder.PostNr WHERE Elev.Fornavn = @Fornavn"
                    , conn);
                cmd.CommandType = CommandType.Text;


                param = new SqlParameter("@Fornavn", SqlDbType.VarChar);
                param.Value =
                    fornavn;
                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                conn.Close();
            }

            return dt;
        }

        public int GetNumOfElever()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Huan"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT count(ElevID) from Elev", conn);
                cmd.CommandType = CommandType.Text;
                int num = (Int32)cmd
                    .ExecuteScalar(); 

                conn.Close();
                return num;
            }
        }
    }
}