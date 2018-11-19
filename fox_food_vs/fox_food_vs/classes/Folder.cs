using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace fox_food_vs.classes
{
    public class Folder
    {
        public BitmapImage img;
        public int id;
        public string title;

        public Folder() {
            img = null;
            id = -1;
            title = "unknown";
        }
    }
}
