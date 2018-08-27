using MVVMApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApplication
{
    //a public static class and access it from anywhere
    //Global attribute
    class Globals
    {
        public static List<Item> Items;
        public static void clearItem()
        {
            Items.Clear();
        }
    }
}
