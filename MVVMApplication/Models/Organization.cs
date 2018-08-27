using MVVMApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApplication.Models
{
    class Organization
    {
        public List<Item> Items { get; set; }
        public String Name { get; set; }

        public Organization(String databaseName)
        {
            Name = databaseName;
            Items = FakeService.GetItem();
        }

        public Organization()
        {
        }

        public void Add(Item item)
        {
            if (!Items.Contains(item))
            {
                Items.Add(item);
                FakeService.Write(item);
            }

        }
        public void Delete(Item item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
                FakeService.Delete(item);
            }
        }

        public void Update(Item item)
        {
            FakeService.Write(item);
        }


    }
}
