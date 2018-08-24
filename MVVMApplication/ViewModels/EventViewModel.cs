using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMApplication.Data;
using MVVMApplication.Models;

namespace MVVMApplication.ViewModels
{
    public class EventViewModel : NotificationBase<Event>
    {
        public EventViewModel(Event event = null) : base(event) { }
            public string Title {
            get { return This.Title; }
            set { SetProperty(This.Title, value, () => This.Title = value); }
        }
    }
    }
       


    




