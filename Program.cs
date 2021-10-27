using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sairler = new MyDictionary<int, string>();
            sairler.Add(1852, "Abdülhak Hamit Tahran");
            sairler.Add(1927, "Ahmed Arif");
            sairler.Add(1916, "Behçet Necatigil");
            sairler.Add(1941, "Metin Altıok");
            sairler.Add(1939, "Erdem Bayazıt");


            Console.WriteLine("Doğum Yılı: " + sairler.fonk1[0] + " Adı: " + sairler.fonk2[0]);
            Console.WriteLine("Doğum Yılı: " + sairler.fonk1[1] + " Adı: " + sairler.fonk2[1]);
            Console.WriteLine("Doğum Yılı: " + sairler.fonk1[2] + " Adı: " + sairler.fonk2[2]);
            Console.WriteLine("Doğum Yılı: " + sairler.fonk1[3] + " Adı: " + sairler.fonk2[3]);
            Console.WriteLine("Doğum Yılı: " + sairler.fonk1[4] + " Adı: " + sairler.fonk2[4]);
        }
    }
}
