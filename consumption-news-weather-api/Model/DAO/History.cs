using MySql.Data.MySqlClient;

namespace consumption_news_weather_api.Model.DAO
{
    public class History{

        public bool Save(Entity.History history){
            string query = "INSERT INTO history VALUES (NULL, '" + history.city + "')";
            
            MySqlConnection mySqlConnection = Connection.Connect();
            if (mySqlConnection == null) {
                return false;
            }

            MySqlCommand commandDatabase = new MySqlCommand(query, mySqlConnection);
            try
            {
                mySqlConnection.Open();
                commandDatabase.ExecuteReader();
                mySqlConnection.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + query);

                return false;
            }
        }

        public List<Entity.History> GetAll()
        {
            string query = "SELECT * FROM history";
            List<Entity.History> listHistory = new List<Entity.History>();

            MySqlConnection mySqlConnection = Connection.Connect();
            if (mySqlConnection == null)
            {
                return listHistory;
            }

            MySqlCommand commandDatabase = new MySqlCommand(query, mySqlConnection);
            try
            {
                mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = commandDatabase.ExecuteReader();

                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        listHistory.Add(new Entity.History(
                            mySqlDataReader.GetInt32(0),mySqlDataReader.GetString(1)));
                    }
                }
                else
                {
                    return listHistory;
                }

                return listHistory;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + query);

                return listHistory;
            }
        }


    }
}
