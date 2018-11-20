using fox_food_vs.classes;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace fox_food_vs.frige_page {
    /// <summary>
    /// Interaction logic for ItemFrige.xaml
    /// </summary>
    public partial class ItemFrige : Page {

        private Folder ff;

        public ItemFrige(Folder ff) {
            InitializeComponent();
            this.ff = ff;
        }

        private void Repaint() {

            if(ff.imgPath != "none") {
                var bitmap = new BitmapImage();
                using (var stream = new FileStream(@"..\..\..\img\food_folders_icons\" + ff.imgPath, FileMode.Open)) {
                    bitmap.BeginInit();
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.StreamSource = stream;
                    bitmap.EndInit();
                    bitmap.Freeze(); // optional
                }
                imgItem.Source = bitmap;
                imgItem.MaxHeight = 100;
                imgItem.MaxWidth = 100;
            }

            txtTitle.Text = ff.title;
        }

        //open food types
        private void btnGoTO_Click(object sender, System.Windows.RoutedEventArgs e) {

        }

        private void Page_Loaded(object sender, System.Windows.RoutedEventArgs e) {
            Repaint();
        }
    }
}
