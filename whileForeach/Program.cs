using System;

namespace whileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int i=0;
            int toplam = 0;
            while(i<=sayi){
                toplam += i;
                i++;
            }
            System.Console.WriteLine("Toplam:"+toplam);

            string[] arabalar = {"Opel","Mustang","Wolkswagen","Toyota"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
