using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMApplication.Data;

namespace MVVMApplication.Models
{
    class Organization
    {
        public List<Event> Event { get; set; }
        public string Title { get; set; }


        public Organization() {
            
            Event = FakeService.GetEvents();
        }
        public void Add(Event event)
        {
            if (!events.Cotains(events))
            {
                events.Add(event);
                FakeService.Write(event);
            }
        }
        
    }
}
