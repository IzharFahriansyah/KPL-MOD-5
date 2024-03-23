using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302220056
{

   internal class Program
    {
        class SimpleDataBase<T>
        {
            List <T> storedData { get; set; }
            List <DateTime> inputDates { get; set; }
            

            public SimpleDataBase()
            {
                storedData = new List <T>();
                inputDates = new List <DateTime>();
            }
            public void AddNewData(T list)
            {
                storedData.Add(list);
                inputDates.Add(DateTime.Now);
            }
            public void printAllData()
            {
                for(int i = 0; i < storedData.Count; i++)
                {
                    Console.WriteLine("Data " + i + " berisi : " + storedData[i] + " yang disimpan pada waktu " + inputDates[i]);
                }
            }
        }
      


            static void Main(string[] args)
            {
                SimpleDataBase<int> Data = new SimpleDataBase<int>();
                Data.AddNewData(12); Data.AddNewData(34); Data.AddNewData(56);
                Data.printAllData();
                Console.ReadLine();
            }
      
    }
}
