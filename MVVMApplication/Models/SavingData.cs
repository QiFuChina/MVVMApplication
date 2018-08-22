using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApplication.Models
{
    public  class SavingData
    {
        public int ID { get; set; }
        public string Title { get; set; }
    }


    public class SavingDataManager {
        public static List<SavingData> GetSavingofData()
        {
            var SavingofData = new List<SavingData>();
            SavingofData.Add(new SavingData { ID = 1, Title = "Vulpate" });
            SavingofData.Add(new SavingData { ID = 2, Title = "Mazim"});

            return SavingofData;
        }
    }
}
