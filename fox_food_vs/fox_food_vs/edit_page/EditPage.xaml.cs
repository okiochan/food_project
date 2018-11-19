using fox_food_vs.classes;
using fox_food_vs.frige_page;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace fox_food_vs.pages.frige_page
{
    /// <summary>
    /// Interaction logic for EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private List<FoodType> foods;
        public EditPage()
        {
            InitializeComponent();
        }

        private void btnAddFolder_Click(object sender, RoutedEventArgs e) {
            Folder ff = new Folder();
            AddFolderWindow wind = new AddFolderWindow(ff);
            if (wind.ShowDialog() == true) {
                //save to BD!


            }else {
                //MessageBox.Show("Info not saved =(");
            }
        }

        private void btnAddFoodType_Click(object sender, RoutedEventArgs e) {

            FoodType ft = new FoodType();
            AddTypeWindow wind = new AddTypeWindow(ft);
            if (wind.ShowDialog() == true) {

            } else {
                //MessageBox.Show("Info not saved =(");
            }
        }

        private void Repaint() {
            //foods = db.read...

        }

        private void Page_Loaded(object sender, RoutedEventArgs e) {
            Repaint();
        }
    }
}
