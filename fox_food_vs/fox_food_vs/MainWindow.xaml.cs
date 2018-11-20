using fox_food_vs.classes;
using fox_food_vs.DB;
using fox_food_vs.MyEventArgs;
using fox_food_vs.pages.frige_page;
using fox_food_vs.pages.home_page;
using fox_food_vs.Tests;
using System;
using System.Collections.Generic;
using System.Windows;

namespace fox_food_vs {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {

            //AddFolderWindowTest.Test();

            //Folder ff = new Folder();
            //AddFolderWindow wnd = new AddFolderWindow(ff);
            //wnd.ShowDialog();

            //DirectoryInfo d = new DirectoryInfo(@".");//Assuming Test is your Folder
            //FileInfo[] Files = d.GetFiles(); //Getting Text files
            //string str = "";
            //foreach (FileInfo file in Files) {
            //    str = str + ", " + file.Name;
            //}

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
                case "GI":
                    Console.WriteLine("create GI");
                    break;
                case "Recipies":
                    Console.WriteLine("create Recipies");
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
