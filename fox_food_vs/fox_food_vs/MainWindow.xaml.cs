using fox_food_vs.DB;
using fox_food_vs.MyEventArgs;
using fox_food_vs.pages.frige_page;
using fox_food_vs.pages.home_page;
using MySql.Data.MySqlClient;
using System.Windows;
using static fox_food_vs.pages.home_page.HomePage;

namespace fox_food_vs {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
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
