using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace fox_food_vs.classes
{
    public class FoodFolder
    {
        public string img;
        public int id;
        public string title;

        public FoodFolder() {
            img = "none";
            id = -1;
            title = "unknown";
        }

        public FoodFolder(int id, string img, string title) {
            this.id = id;
            this.title = title;
            this.img = img;
        }
    }
}
