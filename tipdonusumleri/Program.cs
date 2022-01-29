using System;

namespace tipdonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
           // implcit conversion
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            System.Console.WriteLine("d:"+d);
            
            long  h = d;
            System.Console.WriteLine("h:"+h);
           
            string e = "ömer";
            char f = 'k';

            object g = e+f+d;
            System.Console.WriteLine("g:"+g);
            


           //Explicit conversion

               int x = 4;
              byte y = (byte)x;
              System.Console.WriteLine("y:"+y);
              

        }
    }
}
