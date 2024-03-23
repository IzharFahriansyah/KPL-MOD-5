using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302220056
{

    class Penjumlahan<T>
    {
        public dynamic JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic a = angka1;
            dynamic b = angka2;
            dynamic c = angka3;

            return a + b + c;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan<int> JumlahTigaAngka = new Penjumlahan<int>();

            Console.WriteLine(JumlahTigaAngka.JumlahTigaAngka(13, 02, 22));
        }
    }
}
