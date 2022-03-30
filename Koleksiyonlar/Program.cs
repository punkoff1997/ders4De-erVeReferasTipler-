using System;
using System.Collections.Generic;

namespace Koleksyonlar
{
    class Program
    {
        static void Main(string[]args)
        {
            //string[] İsimler = new string[] {"Fırat","Murat","Kerem","Halil" };
            //Console.WriteLine(İsimler[0]);
            //Console.WriteLine(İsimler[1]);
            //Console.WriteLine(İsimler[2]);
            //Console.WriteLine(İsimler[3]);
            //İsimler = new string[5];
            //İsimler[4] = "İlker";
            //Console.WriteLine(İsimler[4]);
            //Console.WriteLine(İsimler[0]);

            List<string> isimler2 = new List<string> { "Fırat","Murat","Kerem","Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}