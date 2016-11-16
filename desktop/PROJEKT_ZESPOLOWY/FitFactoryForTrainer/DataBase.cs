using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FitFactoryForTrainer
{
    class DataBase
    {
        private static DataBase instance = new DataBase();
        private int idLoggedCoach;
        private SqlConnection connection;
        private string connectionString =
               "Server = tcp:fitfactory.database.windows.net,1433; Initial Catalog = fitfactory_database; Persist Security Info = False; User ID = fitfactoryadmin; Password = &(@#(*$yh383; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
        private DataBase()
        {
            this.connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public static DataBase getInstance()
        {
            return instance;
        }

        public DataTable ExecuteStoredProcedure(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się przeprowadzić operacji na bazie. " + ex.ToString());
                return null;
            }
        }

      
        public DataTable checkLogin(String login, String haslo)
        {
            
            DataTable result = new DataTable();
          //  result.Columns.Add(new DataColumn("wynik"));
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "czyLoginHasloIstnieje";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@p_login", login);
                cmd.Parameters.AddWithValue("@p_haslo", haslo);
                cmd.Parameters.AddWithValue("@p_typ", "T");
                //cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
                return result;
            }
            catch (Exception ex )
            {
                MessageBox.Show("Nie udało się przeprowadzić operacji na bazie. " + ex.ToString());
                return null;
            }
  
        }

        public DataTable InsertIntoDb(String login,String mail, String imie,String imie2, String nazwisko, String plec, String data_ur, String haslo, String typ)
        {

            DataTable result = new DataTable();
           // result.Columns.Add(new DataColumn("wynik"));
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "wstawUzytkownika";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@p_login", login);
                cmd.Parameters.AddWithValue("@p_imie", imie);
                cmd.Parameters.AddWithValue("@p_imie2", imie2);
                cmd.Parameters.AddWithValue("@p_nazwisko", nazwisko);
                cmd.Parameters.AddWithValue("@p_plec", plec);
                cmd.Parameters.AddWithValue("@p_mail", mail);
                cmd.Parameters.AddWithValue("@p_data_ur", data_ur);
                cmd.Parameters.AddWithValue("@p_haslo", haslo);
                cmd.Parameters.AddWithValue("@p_typ", "T");
                //cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się przeprowadzić operacji na bazie. " + ex.ToString());
                return null;
            }
        }

        public DataTable showInvites()
        {
            DataTable result = new DataTable();
           // result.Columns.Add(new DataColumn("wynik"));
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "wypiszZaproszenia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@p_id_trenera", idLoggedCoach);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się przeprowadzić operacji na bazie. " + ex.ToString());
                return null;
            }
        }

        public DataTable showUsers()
        {
            DataTable result = new DataTable();
           // result.Columns.Add(new DataColumn("wynik"));
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "wypiszPrzypisaneUz";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@p_id_trenera", idLoggedCoach);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się przeprowadzić operacji na bazie. " + ex.ToString());
                return null;
            }
        }

        public void getCoachId(string login)
        {
            string query = "select id from uzytkownicy where login = '" + login + "'";
            DataTable d = ExecuteStoredProcedure(query);
            DataRow r = d.Rows[0];
            String tempId = r["id"].ToString();
            idLoggedCoach = int.Parse(tempId);
        }

        public void confirmInvite(string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "potwierdzZaproszenie";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@p_id_zapr", id);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nie udało się potwierdzić zaproszenia. " + ex);
            }
        }

        public DataTable getCoachSpecs()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "wypiszListeSpecjalizacjiTrenera";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@p_id_trenera", idLoggedCoach);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się załadować specjalizacji. " + ex);
                return null;
            }
        }

        public void addSpec(string id, string dataOd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "dodajSpecjalizacjeTrenera";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@p_id_trenera", idLoggedCoach);
                cmd.Parameters.AddWithValue("@p_id_spec", id);
                cmd.Parameters.AddWithValue("@p_od", dataOd);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się dodać specjalizacji " + ex);
            }
        }

        public void removeSpec(string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "usunSpecjalizacjeTrenera";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@p_id_trenera", idLoggedCoach);
                cmd.Parameters.AddWithValue("@p_id_spec", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się usunąć specjalizacji " + ex);
            }
        }
    }
}
