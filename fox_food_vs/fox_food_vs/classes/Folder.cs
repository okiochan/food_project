using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace fox_food_vs.classes
{
    public class Folder
    {
        BitmapImage img;
        int id;
        string title;

        Folder() {
            img = null;
            id = -1;
            title = "unknown";
        }
    }
}
