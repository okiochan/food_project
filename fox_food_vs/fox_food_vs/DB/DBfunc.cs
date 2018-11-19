using MySql.Data.MySqlClient;
using System;
using System.IO;

namespace fox_food_vs.DB {
    class DBfunc {

        public const string CONNECTION_STRING_PATH = @"..\..\mysql_connection_string.txt";

        public static MySqlConnection GetDBConnection() {
            string connString = GetConnectionString();
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }

        public static string GetConnectionString() {
            StreamReader reader = new StreamReader(CONNECTION_STRING_PATH);
            string res = reader.ReadLine();
            return res;
        }
    }
}
