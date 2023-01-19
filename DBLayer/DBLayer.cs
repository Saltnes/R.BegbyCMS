using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DBLayer
{
    public class DBLayer
    {
        /*SELECT Eier.Fornavn, Eier.Etternavn, Eier.Tlf, Bolig.PostNr, PostNr.Poststed, Bolig.Adresse,Bolig.Tomteareal, Bolig.Etasje, BoligType.Boligtype, Energimerking.Energimerking, Byggår.Byggår
FROM Bolig
         INNER JOIN Bolig_Eiere ON Bolig.Bolig_id = Bolig_Eiere.Bolig_id
         INNER JOIN Eier ON Bolig_Eiere.Eier_id = Eier.Eier_id
         INNER JOIN Energimerking ON Bolig.Energi_id = Energimerking.Energi_id
         INNER JOIN BoligType ON Bolig.BType_id = BoligType.BType_id
         INNER JOIN PostNr ON Bolig.PostNr = PostNr.PostNr
         INNER JOIN Byggår ON Bolig.Byggår = Byggår.Byggår
WHERE Bolig.PostNr = 1642

SELECT Eier.Fornavn, Eier.Etternavn, Eier.Tlf, Bolig.PostNr, PostNr.Poststed, Bolig.Adresse,Bolig.Tomteareal, Bolig.Etasje, BoligType.Boligtype, Energimerking.Energimerking, Byggår.Byggår
FROM Bolig
         INNER JOIN Bolig_Eiere ON Bolig.Bolig_id = Bolig_Eiere.Bolig_id
         INNER JOIN Eier ON Bolig_Eiere.Eier_id = Eier.Eier_id
         INNER JOIN Energimerking ON Bolig.Energi_id = Energimerking.Energi_id
         INNER JOIN BoligType ON Bolig.BType_id = BoligType.BType_id
         INNER JOIN PostNr ON Bolig.PostNr = PostNr.PostNr
         INNER JOIN Byggår ON Bolig.Byggår = Byggår.Byggår
WHERE Byggår.Byggår = 1920

SELECT Eier.Fornavn, Eier.Etternavn, Eier.Tlf, Bolig.PostNr, PostNr.Poststed, Bolig.Adresse,Bolig.Tomteareal, Bolig.Etasje, BoligType.Boligtype, Energimerking.Energimerking, Byggår.Byggår
FROM Bolig
         INNER JOIN Bolig_Eiere ON Bolig.Bolig_id = Bolig_Eiere.Bolig_id
         INNER JOIN Eier ON Bolig_Eiere.Eier_id = Eier.Eier_id
         INNER JOIN Energimerking ON Bolig.Energi_id = Energimerking.Energi_id
         INNER JOIN BoligType ON Bolig.BType_id = BoligType.BType_id
         INNER JOIN PostNr ON Bolig.PostNr = PostNr.PostNr
         INNER JOIN Byggår ON Bolig.Byggår = Byggår.Byggår
WHERE Energimerking.Energimerking = 'D'

SELECT Eier.Fornavn, Eier.Etternavn, Eier.Tlf, Bolig.PostNr, PostNr.Poststed, Bolig.Adresse,Bolig.Tomteareal, Bolig.Etasje, BoligType.Boligtype, Energimerking.Energimerking, Byggår.Byggår
FROM Bolig
         INNER JOIN Bolig_Eiere ON Bolig.Bolig_id = Bolig_Eiere.Bolig_id
         INNER JOIN Eier ON Bolig_Eiere.Eier_id = Eier.Eier_id
         INNER JOIN Energimerking ON Bolig.Energi_id = Energimerking.Energi_id
         INNER JOIN BoligType ON Bolig.BType_id = BoligType.BType_id
         INNER JOIN PostNr ON Bolig.PostNr = PostNr.PostNr
         INNER JOIN Byggår ON Bolig.Byggår = Byggår.Byggår
WHERE Bolig.Tomteareal > 80

SELECT Eier.Fornavn, Eier.Etternavn, Eier.Tlf, Bolig.PostNr, PostNr.Poststed, Bolig.Adresse,Bolig.Tomteareal, Bolig.Etasje, BoligType.Boligtype, Energimerking.Energimerking, Byggår.Byggår
FROM Bolig
         INNER JOIN Bolig_Eiere ON Bolig.Bolig_id = Bolig_Eiere.Bolig_id
         INNER JOIN Eier ON Bolig_Eiere.Eier_id = Eier.Eier_id
         INNER JOIN Energimerking ON Bolig.Energi_id = Energimerking.Energi_id
         INNER JOIN BoligType ON Bolig.BType_id = BoligType.BType_id
         INNER JOIN PostNr ON Bolig.PostNr = PostNr.PostNr
         INNER JOIN Byggår ON Bolig.Byggår = Byggår.Byggår
WHERE Eier.Tlf = 94812567

SELECT Eier.Fornavn, Eier.Etternavn, Eier.Tlf, Bolig.PostNr, PostNr.Poststed, Bolig.Adresse,Bolig.Tomteareal, Bolig.Etasje, BoligType.Boligtype, Energimerking.Energimerking, Byggår.Byggår
FROM Bolig
         INNER JOIN Bolig_Eiere ON Bolig.Bolig_id = Bolig_Eiere.Bolig_id
         INNER JOIN Eier ON Bolig_Eiere.Eier_id = Eier.Eier_id
         INNER JOIN Energimerking ON Bolig.Energi_id = Energimerking.Energi_id
         INNER JOIN BoligType ON Bolig.BType_id = BoligType.BType_id
         INNER JOIN PostNr ON Bolig.PostNr = PostNr.PostNr
         INNER JOIN Byggår ON Bolig.Byggår = Byggår.Byggår
WHERE Eier.Fornavn = 'Erik' AND Eier.Etternavn = 'Tesman'

SELECT Eier.Fornavn, Eier.Etternavn, Eier.Tlf, Bolig.PostNr, PostNr.Poststed, Bolig.Adresse,Bolig.Tomteareal, Bolig.Etasje, BoligType.Boligtype, Energimerking.Energimerking, Byggår.Byggår
FROM Bolig
         INNER JOIN Bolig_Eiere ON Bolig.Bolig_id = Bolig_Eiere.Bolig_id
         INNER JOIN Eier ON Bolig_Eiere.Eier_id = Eier.Eier_id
         INNER JOIN Energimerking ON Bolig.Energi_id = Energimerking.Energi_id
         INNER JOIN BoligType ON Bolig.BType_id = BoligType.BType_id
         INNER JOIN PostNr ON Bolig.PostNr = PostNr.PostNr
         INNER JOIN Byggår ON Bolig.Byggår = Byggår.Byggår
WHERE Byggår.Byggår BETWEEN 1920 AND 1945 */


        public DataTable GetBoligAndOwnersByTelefon(string tlf)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["BoligEier"].ConnectionString;
            DataTable dt = new DataTable();
            SqlParameter param;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                //den samme sql queryen her som dere allerede har testet i sql manager - her med et parameter, som er telefonnummeret
                SqlCommand cmd = new SqlCommand(
                    "select BoligEier.BoligId,Bolig.Adresse,Bolig.PostNummer,BoligEier.EierId, Eier.ForNavn,Eier.EtterNavn,Telefon.Telefon FROM BoligEier INNER JOIN Eier ON Eier.EierId = BoligEier.EierId INNER JOIN Telefon ON Eier.EierId = Telefon.EierId INNER JOIN Bolig ON Bolig.BoligId = BoligEier.BoligId where Telefon.Telefon = @tlf",
                    conn);
                cmd.CommandType = CommandType.Text;

                //params here
                param = new SqlParameter("@tlf", SqlDbType.NChar);
                param.Value =
                    tlf; //variabel som blir sendt inn til metoden. Kommer fra bruker som tastet dette inn i et tekstfelt.
                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                conn.Close();
            }

            return dt; //hele datasettet returneres. skal da kobles til feks en gridview
        }

        /// <summary>
        /// Returnerer alt fra tabellen boliger. Ikke hensiktsmessig om det er mange boliger.
        /// </summary>
        /// <returns></returns>
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
    }
}