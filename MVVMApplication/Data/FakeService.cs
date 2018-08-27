using MVVMApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApplication.Data
{
    
    class FakeService
    {
        private static List<Item> ItemList;
        public static String Name = "Fake Data Service.";

        public static List<Item> GetItem()
        {
            Debug.WriteLine("Get Item");
            ItemList = Globals.Items;
            Debug.WriteLine(ItemList.ToString());
            return ItemList;

        }
        public static void Write(Item item)
        {
            Debug.WriteLine("Add new item" + item.Title);

        }
        public static void Delete(Item item)
        {
            Debug.WriteLine("DELETE person with name " + item.Title);
        }
    }
}
