using fox_food_vs.classes;
using fox_food_vs.DB;
using fox_food_vs.frige_page;
using fox_food_vs.MyEventArgs;
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
    /// Interaction logic for FrigePage.xaml
    /// </summary>
    public partial class FrigePage : Page
    {
        private List<Folder> lst;

        public FrigePage()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e) {
            OnHandlerRepaintA(new EventArgsWithString { str = "Edit" });
        }

        //EVENTS

        //create handler with custom args
        public event EventHandler<EventArgsWithString> HandlerRepaintMainWind;
        protected virtual void OnHandlerRepaintA(EventArgsWithString e) {
            HandlerRepaintMainWind?.Invoke(this, e);
        }

        private void Repaint() {
            panelFolders.Children.Clear();

            lst = DBfunc.ReadFoodFolders();
            StackPanel sp = new StackPanel();
            int cnt = 0;

            foreach (var x in lst) {

                if(cnt%10 == 0) {
                    sp = new StackPanel();
                    sp.Orientation = Orientation.Horizontal;
                    panelFolders.Children.Add(sp);
                }

                Frame myFrame = new Frame();
                myFrame.Margin = new Thickness(20, 20, 20, 20);
                myFrame.Navigate(new ItemFrige(x));
                sp.Children.Add(myFrame);

                cnt++;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) {
            Repaint();
        }
    }
}
