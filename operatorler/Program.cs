using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //atama ve işlemler
            int x = 3;
            int y = 3;
            y = y+2;

            Console.WriteLine(y);

            y+=2;
              Console.WriteLine(y);
            y/=2;
              Console.WriteLine(y);
            x*=2;
              Console.WriteLine(x);

              //mantıksal operatorler

              bool isSuccess = false;
              bool isCompleted = false;
              if (isSuccess && isCompleted)
              {
                  Console.WriteLine("Perfect");
              }
              if (isSuccess || isCompleted)
              {
                  System.Console.WriteLine("Great");
              }
              if (isSuccess && !isCompleted)
              {
                  System.Console.WriteLine("Fine");
              }

           bool a = true;
           bool b = false;
            System.Console.WriteLine(a^b);

        }
    }
}
