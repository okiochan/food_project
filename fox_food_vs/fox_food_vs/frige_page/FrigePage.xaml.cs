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

    }
}
