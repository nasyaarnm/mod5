using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod5_1302223148.Penjumlahan
{
    internal class Penjumlahan<T>
    {
        public void jumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic T1 = angka1;
            dynamic T2 = angka2;
            dynamic T3 = angka3;

            Console.WriteLine(T1+T2+T3);
        }
    }
}
