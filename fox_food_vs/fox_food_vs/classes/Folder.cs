using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace fox_food_vs.classes
{
    public class Folder
    {
        public string imgPath;
        public int id;
        public string title;

        public Folder() {
            imgPath = "none";
            id = -1;
            title = "unknown";
        }

        public Folder(int id, string img, string title) {
            this.id = id;
            this.title = title;
            this.imgPath = img;
        }
    }
}
