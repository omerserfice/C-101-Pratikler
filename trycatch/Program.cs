using System;

namespace trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
           try
           {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int c = a+b;
                 System.Console.WriteLine(c);
           }
           catch (Exception ex)
           {
               System.Console.WriteLine("Bir hata oluştu:"+ex.Message);
               
           }
           finally{
               System.Console.WriteLine("İşlem tamamlandı.");
           }

        }
    }
}
