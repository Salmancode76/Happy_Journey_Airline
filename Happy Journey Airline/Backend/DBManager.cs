﻿using System;
using System.Collections.Generic;
using System.Configuration;
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



        //FOR THE LOVE OF GOD DON'T OVERWRITE OR DELETE MY CONNECTION STRING JUST COMMENT IT
        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\salma\\OneDrive\\Desktop\\Codes\\C#\\Happy Journey Airline\\Happy Journey Airline\\Happy Journey Airline\\Backend\\Database.mdf;Integrated Security=True";


        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sharm\\Documents\\GitHub\\Happy_Journey_Airline\\Happy Journey Airline\\Backend\\Database.mdf\";Integrated Security=True";
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sharm\\Documents\\GitHub\\Happy_Journey_Airline\\Happy Journey Airline\\Backend\\Database.mdf\";Integrated Security=True";

        private DBManager()
        {
            connection = new SqlConnection(connectionString);
        }

        public static DBManager getInstance()
        {
            if (instance == null)
            {
                return instance = new DBManager();  
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
