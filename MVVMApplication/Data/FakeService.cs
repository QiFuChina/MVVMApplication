using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MVVMApplication.Data
{
    public class Item
    {
        public String Title { get; set; }

    }
    public class FakeService
    {
        public static String Name = "Fake Data Service.";

        public static List<Item> GetItem()
        {
            Debug.WriteLine("Get Item");
            return new List<Item>()
            {
                new Item() { Title="First"},
                new Item() { Title="Secend"}
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
