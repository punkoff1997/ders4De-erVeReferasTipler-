using System;
namespace GenerickIntro
{
    class Program
    {
        static void Main(string[]args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Fırat");
            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);

        }

    }
}
