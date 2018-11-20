using fox_food_vs.pages.home_page;
using System.Windows;
using System.Windows.Controls;

namespace fox_food_vs.Tests {
    class HomePageTest {

        public static void Test() {
            HomePageTest01();
        }

        public static void HomePageTest01() {
            HomePage home = new HomePage();
            Frame f = new Frame();
            f.Navigate(home);
            Window window = new Window();
            window.Content = f;
            window.ShowDialog();
        }
    }
}
