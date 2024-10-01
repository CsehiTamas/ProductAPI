using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace bikicsunáj
{
    public class Connect
    {
        public MySqlConnection Connection { get; set; }
        public string ConnectionString { get; set; }
        private string Host;
        private string Password;
        private string Database;
        private string User;

        public Connect()
        {
            Host = "localhost";
            Database = "shop";
            User = "root";
            Password = "";


            ConnectionString = "SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + User + ";PASSWORD=" + Password + ";SslMode=None";

            Connection = new MySqlConnection(ConnectionString);
        }
    }
}
