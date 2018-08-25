using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMApplication.Data;

namespace MVVMApplication.ViewModels
{
    public class ItemViewModel : NotificationBase<Item>
    {
        public ItemViewModel(Item item = null) : base(item) { }
        public String Title
        {
            get { return This.Title; }
            set { SetProperty(This.Title, value, () => This.Title = value); }
        }
    }
}
