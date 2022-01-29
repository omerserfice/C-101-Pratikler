using System;

namespace exampleIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time>6 && time<11)
            {
                System.Console.WriteLine("Günaydın");
            }else if (time<=18)
            {
                System.Console.WriteLine("İyi Günler");
            }
            else{
                System.Console.WriteLine("İyi geceler");
            }

            string sonuc = time<=18 ? "İyigünler" : "iyi geceler";
            System.Console.WriteLine(sonuc);
        }
    }
}
