using MySql.Data.MySqlClient;

namespace consumption_news_weather_api.Model
{
    class Connection{
        public static MySqlConnection Connect(){
            string server = "localhost";
            string database = "newsweatherapi";
            string user = "root";
            string password = "123456";
            string port = "3306";
            string sslM = "none";

            string connString = string.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                return mySqlConnection;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message + connString);

                return null;
            }
        }
    }
}
