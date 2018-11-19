using fox_food_vs.classes;
using fox_food_vs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace fox_food_vs.pages.frige_page
{
    /// <summary>
    /// Interaction logic for AddFolderWindow.xaml
    /// </summary>
    public partial class AddFolderWindow : Window
    {
        private FoodFolder ff;
        public AddFolderWindow(FoodFolder ff)
        {
            InitializeComponent();
            this.ff = ff;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

        }
        
        // save to DB
        private void btnApply_Click(object sender, RoutedEventArgs e) {
            ff.title = txtTitle.Text;
            ff.img = "none";
            DialogResult = true;
        }

        private void btnDiscard_Click(object sender, RoutedEventArgs e) {
            DialogResult = false;
        }
    }
}
