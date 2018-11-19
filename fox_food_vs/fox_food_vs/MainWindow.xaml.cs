using fox_food_vs.classes;
using fox_food_vs.DB;
using fox_food_vs.MyEventArgs;
using fox_food_vs.pages.frige_page;
using fox_food_vs.pages.home_page;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows;
using static fox_food_vs.pages.home_page.HomePage;

namespace fox_food_vs {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {

            //Folder ff = new Folder();
            //AddFolderWindow wnd = new AddFolderWindow(ff);
            //wnd.ShowDialog();

            //DirectoryInfo d = new DirectoryInfo(@".");//Assuming Test is your Folder
            //FileInfo[] Files = d.GetFiles(); //Getting Text files
            //string str = "";
            //foreach (FileInfo file in Files) {
            //    str = str + ", " + file.Name;
            //}

            //READER
            //var c = DBfunc.GetDBConnection();
            //c.Open();
            //string sql = " SELECT * FROM tbFoodFolder  ";
            //MySqlCommand cmd = new MySqlCommand(sql, c);
            //MySqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read()) {
            //    int txt = reader.GetInt32("id");
            //    string txt2 = reader.GetString("img");
            //}

            //INSERT
            //MySqlConnection conn = DBfunc.GetDBConnection();
            //conn.Open();
            //string query = "insert into tbFoodFolder (title,img) values (@var1,@var2)";
            //MySqlCommand cmd = new MySqlCommand(query, conn);
            //cmd.Parameters.AddWithValue("@var1", "dfsdf");
            //cmd.Parameters.AddWithValue("@var2", "aaasas");
            //cmd.Prepare();
            //cmd.ExecuteNonQuery();




            InitializeComponent();


        }

        //event
        private void Repaint(string name) {

            switch (name) {
                case "Home":
                    HomePage ph = new HomePage();
                    ph.HandlerRepaintMainPage += EventRepaint;
                    mainFrame.Navigate(ph);
                    break;
                case "Frige":
                    FrigePage fp = new FrigePage();
                    fp.HandlerRepaintMainWind += EventRepaint;
                    mainFrame.Navigate(fp);
                    break;
                case "Edit":
                    EditPage ep = new EditPage();
                    mainFrame.Navigate(ep);
                    break;
                default:
                    HomePage page = new HomePage();
                    mainFrame.Navigate(page);
                    break;
            }

        }


        private void Window_Loaded(object sender, RoutedEventArgs e) {
            Repaint("Home");
        }

        //EVENTS
        private void EventRepaint(object sender, EventArgsWithString e) {
            Repaint(e.str);
        }
    }
}
