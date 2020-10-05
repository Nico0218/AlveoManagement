using System.Data.SQLite;
using System.IO;

namespace AlveoManagementServer.SQLite
{
    class Database
    {
        public SQLiteConnection dataConnection;

        public Database()
        {
            dataConnection = new SQLiteConnection("Data Source=databasealven.sqlite");
            if (!File.Exists("./databasealven.sqlite"))
            {
                SQLiteConnection.CreateFile("databasealven.sqlite");
                System.Console.WriteLine("Database File Created");
            }
        }

        public void OpenConnection()
        {
            if (dataConnection.State != System.Data.ConnectionState.Open)
            {
                dataConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (dataConnection.State != System.Data.ConnectionState.Closed)
            {
                dataConnection.Close();
            }
        }
    }
}
