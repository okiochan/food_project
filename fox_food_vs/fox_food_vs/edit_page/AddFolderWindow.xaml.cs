using fox_food_vs.classes;
using fox_food_vs.DB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace fox_food_vs.pages.frige_page {
    /// <summary>
    /// Interaction logic for AddFolderWindow.xaml
    /// </summary>
    public partial class AddFolderWindow : Window
    {
        private const string IMAGE_PATH= @"..\..\..\img\food_folders_icons";
        
        private FoodFolder ff;
        public AddFolderWindow(FoodFolder ff)
        {
            InitializeComponent();
            this.ff = ff;
        }

        List<FoodImage> allImages = new List<FoodImage>();
        FoodImage selected;

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            DirectoryInfo directory = new DirectoryInfo(IMAGE_PATH);
            FileInfo[] imageFiles = directory.GetFiles();
            int id = 0;
            foreach (FileInfo imageFile in imageFiles) {

                // read the bitmap
                FileStream imageReader = new FileStream(imageFile.FullName, FileMode.Open, FileAccess.Read);
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = imageReader;
                bitmap.EndInit();

                // contruct the image
                FoodImage image = new FoodImage(id);
                image.Source = bitmap;
                image.MaxHeight = 100;
                image.MaxWidth = 100;
                image.ImageSelected += HandleSelection;
                allImages.Add(image);
                id++;

                // image inside border
                Border border = new Border();
                border.BorderBrush = Brushes.DarkSalmon;
                border.BorderThickness = new Thickness(2);
                border.Child = image;

                imagePanel.Children.Add(border);
            }
        }

        private void HandleSelection(object sender, EventArgs e) {
            selected = (FoodImage)sender;
            foreach(var im in allImages) {
                Border parent = (Border)im.Parent;
                if (selected.id != im.id) {
                    parent.BorderBrush = Brushes.DarkSalmon;
                } else {
                    parent.BorderBrush = Brushes.Black;
                }
            }
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
        private class FoodImage : Image {
            public FoodImage(int id) {
                this.id = id;
                MouseDown += ImageClicked;
            }

            void ImageClicked(object sender, MouseEventArgs e) {
                if (e.LeftButton == MouseButtonState.Pressed) { // handle your event
                    ImageSelected?.Invoke(this, EventArgs.Empty);
                }
            }

            public event EventHandler ImageSelected;
            public int id;
        }
    }
}
