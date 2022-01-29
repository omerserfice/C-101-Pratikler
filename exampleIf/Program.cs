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


              int N = Convert.ToInt32(Console.ReadLine().Trim());
        
        if(N % 2 == 1){
            Console.WriteLine("Weird");
        }
        else if(N>2 && N<5){
            Console.WriteLine("Not Weird");
        }else if(N>6 && N<20){
            Console.WriteLine("Weird");
        }else if(N>=20 && N%2 == 0){
            Console.WriteLine("Not Weird");
        }else if(N>=20 && N%2 == 1){
            Console.WriteLine("Weird");
        }

        }
    }
}
