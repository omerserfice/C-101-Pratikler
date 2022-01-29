using System;

namespace arrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehir = {"Zonguldak","Bursa","Ankara","Sivas","Kocaeli","Denizli"};
            
            System.Console.WriteLine("***********************************");
            Array.Sort(sehir);
            foreach (var item in sehir)
            {
                System.Console.WriteLine(item);
            }
             System.Console.WriteLine("***********************************");
             Array.Reverse(sehir);
               foreach (var item in sehir)
            {
                System.Console.WriteLine(item);
            }

             System.Console.WriteLine("***********************************");
             Array.Clear(sehir,2,2);
              foreach (var item in sehir)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
