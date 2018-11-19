using MySql.Data.MySqlClient;
using System;

namespace fox_food_vs.DB {
    class DBfunc {

        public static MySqlConnection GetDBConnection() {
            String connString = "server=127.0.0.1;uid=fox_food;pwd=123;database=db";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
