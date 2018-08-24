using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MVVMApplication.Data
{
    public class Event
    {
        public String Title { get; set; }

    }
    public class FakeService
    {
        public static String Name = "Fake Data Service.";
        public static List<Event> GetEvents()
        {
            Debug.WriteLine("Get Events");
            return new List<Event>()
            {
                new Event() { Title="First"}
            };

        }
        public static void Add(Event event){
            Debug.WriteLine("Add new event" + Event.Title);

        }
        }
    }
}
