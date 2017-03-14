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

        public static DataBase GetInstance()
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

      
        public DataTable CheckLogin(String login, String haslo)
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

        public DataTable ShowInvites()
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

        public DataTable ShowUsers()
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

        public void GetCoachId(int id)
        {
            //string query = "select id from uzytkownicy where login = '" + login + "'";
            //DataTable d = ExecuteStoredProcedure(query);
            //DataRow r = d.Rows[0];
            //String tempId = r["id"].ToString();
            idLoggedCoach = id; //int.Parse(tempId);
        }

        public void ConfirmInvite(string id)
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

        public void DeclineInvite(string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "usunZaproszenie";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@p_id_zaprosz", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się potwierdzić zaproszenia. " + ex);
            }
        }

        public DataTable GetCoachSpecs()
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

        public void AddSpec(string id, string dataOd)
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

        public void RemoveSpec(string id)
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

        public DataTable ShowWorkouts(string id_planu)
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "pobierzTreningi";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@p_id_progr", id_planu);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się załadować planu. " + ex);
                return null;
            }
        }

        public DataTable GetExercisesList()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "wypiszListeCwiczen";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się załadować planu. " + ex);
                return null;
            }
        }

        public DataTable InsertSingleExercise(string exerciseId, string intensity, string workoutId, string queueNumber)
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "dodajCwiczenieTreningu";
                cmd.Parameters.AddWithValue("@p_id_cw_sp", exerciseId);
                cmd.Parameters.AddWithValue("@p_intensywnosc", intensity);
                cmd.Parameters.AddWithValue("@p_id_treningu", workoutId);
                cmd.Parameters.AddWithValue("@p_num_porz", queueNumber);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się dodać ćwiczenia. " + ex);
                return null;
            }
        }


        public DataTable GetWorkoutExercises(string workoutId)
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "wypiszCwiczeniaTreningu";
                cmd.Parameters.AddWithValue("@p_id_treningu", workoutId);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się załadować planu. " + ex);
                return null;
            }
        }

        public void DeleteWorkoutExercise(int exerciseId, int workoutId, int queueNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "usunCwiczenieTreningu";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@p_id_cwicz", exerciseId);
                cmd.Parameters.AddWithValue("@p_id_treningu", workoutId);
                cmd.Parameters.AddWithValue("@p_num_porz", queueNumber);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się usunąć ćwiczenia " + ex);
            }
        }

        public void DeleteUser(int programId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "odepnijUzytkownika";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@p_id_programu", programId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się usunąć użytkownika.  " + ex);
            }
        }

        public int GetUserId(string login)
        {
            string query = "select id from uzytkownicy where login = '" + login + "'";
            DataTable d = ExecuteStoredProcedure(query);
            DataRow r = d.Rows[0];
            String tempId = r["id"].ToString();
            return int.Parse(tempId);
        }

        public DataTable GetMessages(string adresat)
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "wypiszWiadomosci2";
                cmd.Parameters.AddWithValue("@p_adresat_id", adresat);
                cmd.Parameters.AddWithValue("@p_nadawca_id", idLoggedCoach.ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się załadować rozmowy. " + ex);
                return null;
            }
        }

        public DataTable GetHistoryMessages(string adresat)
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "wypiszWszystkieWiadomosci";
                cmd.Parameters.AddWithValue("@p_adresat_id", adresat);
                cmd.Parameters.AddWithValue("@p_nadawca_id", idLoggedCoach.ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się załadować rozmowy. " + ex);
                return null;
            }
        }

        public void SendMessage(string user_id, string content)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "wyslijWiadomosc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@p_id_nadawcy", idLoggedCoach);
                cmd.Parameters.AddWithValue("@p_id_odbiorcy", user_id);
                cmd.Parameters.AddWithValue(@"p_text", content);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się usunąć użytkownika.  " + ex);
            }
        }
    }
}
