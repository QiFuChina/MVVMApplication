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
        
        public static String Name = "Fake Data Service.";

        public static List<Item> GetItem()
        {
            Debug.WriteLine("Get Item");
            
            //Debug.WriteLine(ToString());
            return new List<Item>() {
                new Item() { Title="Chris Cole" },
                new Item() { Title="Stf Ed" },
                new Item() { Title="Gd Bsgr" }

            };


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
