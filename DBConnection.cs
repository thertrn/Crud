using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Crud
{
    public class DBConnection
    {
        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }   

        public MySqlConnection Connection { get; set; }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }
        private bool Initialize()
        {
            try
            {
                string connstring = $"Server={Server}; database={DatabaseName}; UID={UserName}; password={Password}; port={Port}";
                Connection = new MySqlConnection(connstring);
                Connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(DatabaseName))
                    return false;
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, DatabaseName, UserName, Password);
                Connection = new MySqlConnection(connstring);
                Connection.Open();
            }
            return true;
        }

        public void Close()
        {
            Connection.Close();
            Connection = null;
        }
    }
}
