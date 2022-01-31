using System;
using System.Collections.Generic;

namespace odevler
{
    class Program
    {
        static void Main(string[] args)
        {
        //    // Odev1
        //    int sayi;
           
        //    System.Console.Write("Bir sayı giriniz:");
        //    sayi = int.Parse(Console.ReadLine());
        //    int[] sayilar=new int[sayi];
        // for (int i = 0; i < sayi; i++)
        // { 
        // Console.Write("{0}.sayıyı giriniz: ",i+1);
        //   sayilar[i] = int.Parse(Console.ReadLine());
        
        // }
        //  System.Console.WriteLine("*********Dizideki çift sayılar*********");
        // foreach (var item in sayilar)
        // {
        //     if (item % 2 == 0)
        //     {
               
        //         System.Console.WriteLine(item);
        //     }
        // }

        // Odev2
        //    int sayi1,sayi2;
        //    System.Console.WriteLine("İki adet sayı giriniz:");
        //    System.Console.Write("Birinci sayi:");
        //    sayi1 = int.Parse(Console.ReadLine());
        //    System.Console.Write("İkinci sayi:");
        //    sayi2 = int.Parse(Console.ReadLine());
        //     Bol(sayi1,sayi2);

        // ODev3
         
        //  int sayi3;
        
        //  System.Console.Write("Bir sayi giriniz:");
        //  sayi3 = int.Parse(Console.ReadLine());
        //  Sirala(sayi3);
       
       //Odev4
          
          System.Console.WriteLine("Lütfen cümle giriniz:");
          string cumle = Console.ReadLine();
          toplamKelimeHarf(cumle);

        }

        public static void Bol(int n,int m){
            System.Console.WriteLine("{0} adet sayı giriniz:",n);
            int[] sayi = new int[n];
            for(int i=0;i<n;i++){
                sayi[i]=int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Girilen sayilardan{0} ye eşit olan ve{0} ye tam bölünen sayılar",m);
            foreach (var item in sayi)
            {
                if (item == m || item%m == 0)
                {
                    System.Console.WriteLine(item);
                }
            }
        }

        public static void Sirala(int n){
            System.Console.WriteLine("lütfen {0} adet kelime giriniz:",n);
            string[] kelime=new string[n];
            for (int i = 0; i < n; i++)
            {
             System.Console.Write("{0}.kelimeyi giriniz:",i+1);
             kelime[i] = Console.ReadLine();   
            }
           Array.Reverse(kelime);
           foreach (var item in kelime)
           {
               System.Console.WriteLine(item);
           }

        }

        public static void toplamKelimeHarf(string cumle){
        
           cumle.Split(' ');

           foreach (var item in cumle)
           {
               System.Console.WriteLine(item);
           }
           
        }
    }
}
