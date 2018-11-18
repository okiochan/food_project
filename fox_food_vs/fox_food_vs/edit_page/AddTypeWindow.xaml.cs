using fox_food_vs.classes;
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

namespace fox_food_vs.frige_page
{
    /// <summary>
    /// Interaction logic for AddTypeWindow.xaml
    /// </summary>
    public partial class AddTypeWindow : Window
    {
        private FoodType food;
        public AddTypeWindow(FoodType food)
        {
            InitializeComponent();
            this.food = food;
        }

        private void btnApply_Click(object sender, RoutedEventArgs e) {
            food.title = txtTitle.Text;
            food.ccal = Int32.Parse( txtCcal.Text );
            food.GI = Int32.Parse(txtGI.Text);
            //food.id = ?

            DialogResult = true;
        }

        private void btnDiscard_Click(object sender, RoutedEventArgs e) {
            DialogResult = false;
        }
    }
}
