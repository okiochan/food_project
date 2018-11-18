using fox_food_vs.MyEventArgs;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace fox_food_vs.pages.home_page {
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page {

        public HomePage() {
            InitializeComponent();
        }

        private void Repaint() {

            var bitmap = new BitmapImage();
            using (var stream = new FileStream("../../img/main_window/title.png", FileMode.Open)) {
                bitmap.BeginInit();
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.StreamSource = stream;
                bitmap.EndInit();
                bitmap.Freeze(); // optional
            }
            img.Source = bitmap;
            img.Width = 594;
            img.Height = 80;

            bitmap = new BitmapImage();
            using (var stream = new FileStream("../../img/main_window/frige.png", FileMode.Open)) {
                bitmap.BeginInit();
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.StreamSource = stream;
                bitmap.EndInit();
                bitmap.Freeze(); // optional
            }
            imgFrige.Source = bitmap;
            imgFrige.Width = 287;
            imgFrige.Height = 300;
        }
       
        private void Page_Loaded(object sender, RoutedEventArgs e) {
            Repaint();
        }
        
        private void btnFrige_Click(object sender, RoutedEventArgs e) {
            OnHandlerRepaintMainPage(new EventArgsWithString { str = "Frige" });
        }

        ///EVENTS
        
        public event EventHandler<EventArgsWithString> HandlerRepaintMainPage;
        protected virtual void OnHandlerRepaintMainPage(EventArgsWithString e) {
            HandlerRepaintMainPage?.Invoke(this, e);
        }

    }
}
