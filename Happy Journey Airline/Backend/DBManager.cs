using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Journey_Airline
{
    public class DBManager
    {
        private static DBManager instance;
        private SqlConnection connection;

        private DBManager(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public static DBManager getInstance(string connectionString)
        {
            if (instance == null)
            {
                return instance = new DBManager(connectionString);  
            }
            return instance;
        }

        public SqlConnection OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public SqlConnection CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
