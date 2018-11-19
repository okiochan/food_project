using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fox_food_vs.classes
{
    public class FoodType
    {
        public int id, gi, ccal, folder_id;
        public string title;

        public FoodType() {
            id = -1;
            gi = -1;
            ccal = -1;
            folder_id = -1;
            title = "unknown";
        }

        public FoodType(int id, string title, int gi, int ccal, int folder_id) {
            this.id = id;
            this.gi = gi;
            this.ccal = ccal;
            this.folder_id = folder_id;
            this.title = title;
        }
    }
}
