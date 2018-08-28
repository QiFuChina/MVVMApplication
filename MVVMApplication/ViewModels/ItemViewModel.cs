using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMApplication.Data;
using MVVMApplication.Models;

namespace MVVMApplication.ViewModels
{
    class ItemViewModel : NotificationBase<Item>
    {
        public ItemViewModel(Item item = null) : base(item) { }

        public String Title
        {
            get { return This.Title; }
            set { SetProperty(This.Title, value, () => This.Title = value); }
        }
        public String Location
        {
            get { return This.Location; }
            set { SetProperty(This.Location, value, () => This.Location = value); }
        }
        public String Date
        {
            get { return This.Date; }
            set { SetProperty(This.Date, value, () => This.Date = value); }
        }
        public String Events
        {
            get { return This.Title; }
            set { SetProperty(This.Events, value, () => This.Events = value); }
        }
    }
}
