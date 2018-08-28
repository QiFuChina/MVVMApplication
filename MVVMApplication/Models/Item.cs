using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApplication.Models
{
    class Item
    {
        public string Title { get; set; }

        public string Location { get; set; }

        public string Date { get; set; }

        public string Events { get; set; }

     

        public Item() { }

        public Item(string Title, string Location, string Date, string Events)
        {
            this.Title = Title;
            this.Location = Location;
            this.Date = Date;
            this.Events = Events;
          
        }
    }
}
