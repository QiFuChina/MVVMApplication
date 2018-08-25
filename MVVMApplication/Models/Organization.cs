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
        public List<Item> Item { get; set; }
        public String Name { get; set; }

        public Organization(String databaseName) {
            Name = databaseName;
            Item = FakeService.GetItem();
        }

        public void Add(Item item)
        {
            if (!Item.Contains(item))
            {
                Item.Add(item);
                FakeService.Write(item);
            }

        }
        public void Delete(Item item)
        {
            if (Item.Contains(item))
            {
                Item.Remove(item);
                FakeService.Delete(item);
            }
        }

        public void Update(Item item)
        {
            FakeService.Write(item);
        }


    }
}
