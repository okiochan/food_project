using fox_food_vs.classes;
using fox_food_vs.DB;
using fox_food_vs.pages.frige_page;
using System.Collections.Generic;

namespace fox_food_vs.Tests {
    class AddFolderWindowTest {

        public static void Test() {
            AddFolderWindowTest01();
        }

        public static void AddFolderWindowTest01() {
            List<Folder> f = DBfunc.ReadFoodFolders();
            AddFolderWindow page = new AddFolderWindow(f[0]);
            page.ShowDialog();
        }
    }
}
