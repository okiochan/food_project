using fox_food_vs.classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media.Imaging;

namespace fox_food_vs.DB {
    class DBfunc {
        
        public const string CONNECTION_STRING_PATH = @"..\..\mysql_connection_string.txt";

        public static MySqlConnection GetDBConnection() {
            MySqlConnection conn = new MySqlConnection(GetConnectionString());
            return conn;
        }

        public static List<FoodFolder> ReadFoodFolders() {
            List<FoodFolder> lst = new List<FoodFolder>();
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            string query = " SELECT * FROM tbFoodFolder ";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                int id = reader.GetInt32("id");
                string img = reader.GetString("img");
                string title = reader.GetString("title");
                lst.Add(new FoodFolder(id, img, title));
            }
            return lst;
        }

        public static List<FoodType> ReadFoodTypes(FoodFolder ff) {
            List<FoodType> lst = new List<FoodType>();
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            string query = " SELECT * FROM tbFoodType WHERE folder_id = @var1  ";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@var1", ff.id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                int id = reader.GetInt32("id");
                string title = reader.GetString("title");
                int gi = reader.GetInt32("gi");
                int ccal = reader.GetInt32("ccal");

                lst.Add(new FoodType(id, title, gi, ccal, ff.id) );
            }
            return lst;
        }

        public static void InsertFoodFolder(FoodFolder ff) {

            MySqlConnection conn = GetDBConnection();
            conn.Open();

            string query = "insert into tbFoodFolder (title,img) values (@var1,@var2)";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@var1", ff.title);
            cmd.Parameters.AddWithValue("@var2", ff.img);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public static void InsertFoodType(FoodType ft) {

            MySqlConnection conn = GetDBConnection();
            conn.Open();

            string query = "insert into tbFoodType (title, gi, ccal, folder_id) values (@var1,@var2,@var3,@var4)";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@var1", ft.title);
            cmd.Parameters.AddWithValue("@var2", ft.gi);
            cmd.Parameters.AddWithValue("@var3", ft.ccal);
            cmd.Parameters.AddWithValue("@var4", ft.folder_id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public static string GetConnectionString() {
            StreamReader reader = new StreamReader(CONNECTION_STRING_PATH);
            string res = reader.ReadLine();
            return res;
        }
    }
}
