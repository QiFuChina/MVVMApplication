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
        private static List<Item> Item;
        public static String Name = "Fake Data Service.";

        public static List<Item> GetItem()
        {
            Debug.WriteLine("Get Item");
            //Item = Globals.Items;
            Debug.WriteLine(Item.ToString());
            return Item;

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
