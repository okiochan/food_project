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

        private BitmapImage createImg(string name) {
            var bitmap = new BitmapImage();
            string path = "../../../img/main_window/" + name;

            using (var stream = new FileStream(path, FileMode.Open)) {
                bitmap.BeginInit();
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.StreamSource = stream;
                bitmap.EndInit();
                bitmap.Freeze();
            }
            return bitmap;
        }

        private void Repaint() {
            img.Source = createImg("title.png");
            img.MaxWidth = 500;

            imgFrige.Source = createImg("frige.png");
            imgFrige.MaxHeight = 250;

            imgGI.Source = createImg("gi_table.png");
            imgGI.MaxHeight = 200;

            imgRecipies.Source = createImg("recipies.png");
            imgRecipies.MaxHeight = 300;


        }
       
        private void Page_Loaded(object sender, RoutedEventArgs e) {
            Repaint();
        }
        
        private void btnGoToClick(object sender, RoutedEventArgs e) {

            string a = ((Button)sender).Name;

            switch (((Button)sender).Name) {
                case "btnFrige":
                    OnHandlerRepaintMainPage(new EventArgsWithString { str = "Frige" });
                    break;
                case "btnGI":
                    OnHandlerRepaintMainPage(new EventArgsWithString { str = "GI" });
                    break;
                case "btnRecipies":
                    OnHandlerRepaintMainPage(new EventArgsWithString { str = "Recipies" });
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            
        }

        ///EVENTS
        
        public event EventHandler<EventArgsWithString> HandlerRepaintMainPage;
        protected virtual void OnHandlerRepaintMainPage(EventArgsWithString e) {
            HandlerRepaintMainPage?.Invoke(this, e);
        }
        
    }
}
