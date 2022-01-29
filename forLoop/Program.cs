using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Lütfen bir sayı girin:");
           int sayac = int.Parse(Console.ReadLine());
           for (int i = 0; i < sayac; i++)
           {
               if (i%2 == 1)
               {
                   System.Console.WriteLine(i);
               }
           }
           int tekToplam = 0;
           int ciftToplam = 0;
           for (int i = 0; i < 10; i++)
           {
               if (i % 2 == 1)
               {
                   tekToplam+=i;
               }else{
                   ciftToplam+=i;
               }
           }
           System.Console.WriteLine("Teklerin toplamı:"+tekToplam);
           System.Console.WriteLine("Çiftlerin toplamı:"+ciftToplam);
        }
    }
}
