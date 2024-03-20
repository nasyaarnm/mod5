using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod5_1302223148.SimpleDataBase
{
    internal class SimpleDataBase<T>
    {
        private List<T> storeData;
        private List<DateTime> inputDate;

       public SimpleDataBase()
        {
            this.storeData = new List<T>();
            this.inputDate = new List<DateTime>();
        }

        public void addNewData(T masukkan)
        {
            storeData.Add(masukkan);
            inputDate.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for(int i = 0; i < storeData.Count; i++)
            {
                Console.WriteLine("Data " +  i+ "berisi: " + this.storeData[i] + "yang disimpan pada waktu UTC: " + this.inputDate[i]);
            }
        }
    }
}

