using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fox_food_vs.classes
{
    public class FoodType
    {
        public int id, GI, ccal;
        public string title;

        public FoodType() {
            id = -1;
            GI = -1;
            ccal = -1;
            title = "unknown";
        }
    }
}
