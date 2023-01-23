using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DBLayer
{
    public class DBLayer
    {
        public DataTable GetAllBolig()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["BoligEier"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Bolig", conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                conn.Close();
            }

            return dt;
        }

        public DataTable GetBoligInfoByPostnr(string postnr)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["BoligEier"].ConnectionString;
            DataTable dt = new DataTable();
            SqlParameter param;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT Eier.Fornavn, Eier.Etternavn, Eier.Tlf, Bolig.PostNr, PostNr.Poststed, Bolig.Adresse,Bolig.Tomteareal, Bolig.Etasje, BoligType.Boligtype, Energimerking.Energimerking, Byggår.Byggår FROM Bolig INNER JOIN Bolig_Eiere ON Bolig.Bolig_id = Bolig_Eiere.Bolig_id INNER JOIN Eier ON Bolig_Eiere.Eier_id = Eier.Eier_id INNER JOIN Energimerking ON Bolig.Energi_id = Energimerking.Energi_id INNER JOIN BoligType ON Bolig.BType_id = BoligType.BType_id INNER JOIN PostNr ON Bolig.PostNr = PostNr.PostNr INNER JOIN Byggår ON Bolig.Byggår = Byggår.Byggår WHERE Bolig.PostNr = @postnr",
                    conn);
                cmd.CommandType = CommandType.Text;

                //params here
                param = new SqlParameter("@postnr", SqlDbType.NChar);
                param.Value =
                    postnr;
                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                conn.Close();
            }

            return dt;
        }

        public int GetNumOfBoliger()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["BoligEier"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT count(Bolig_id) from Bolig", conn);
                cmd.CommandType = CommandType.Text;
                int num = (Int32)cmd
                    .ExecuteScalar(); //returner den første raden og den første kolonnen. sjekk i sql manager. Unboxing eksempel.

                conn.Close();
                return num;
            }
        }
    }
}