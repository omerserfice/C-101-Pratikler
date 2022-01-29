using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = {"Ayı","Arı","Eşek","At","Yılan"};

            int[] dizi ;

            dizi= new int[5];

            renkler[1] = "Yeşil";
            dizi[3] = 5;

            System.Console.WriteLine(hayvanlar[3]);
            System.Console.WriteLine(dizi[3]);
            System.Console.WriteLine("renk"+renkler[1]);
         
         System.Console.WriteLine("******************döngülerle dizi**************");
         
         System.Console.Write("Dizi sayısını gir:");
         int diziSayisi = int.Parse(Console.ReadLine());
         int[] sayilar = new int[diziSayisi];

         for (int i = 0; i < sayilar.Length; i++)
         {
             Console.Write("Lütfen {0}. sayıyı giriniz:",i+1);
             sayilar[i] = int.Parse(Console.ReadLine());
         }
         int toplam = 0;
         int ort = 0;
         foreach (var item in sayilar)
         {
             System.Console.WriteLine(item);
             toplam += item;
         }
         ort = toplam/diziSayisi;
         System.Console.WriteLine("Toplam:{0} Ortalama:{1}",toplam,ort);


         



          
         }
    }
}
