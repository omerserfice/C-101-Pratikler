using System;

namespace extension_recursive_method
{
    class Program
    {
        static void Main(string[] args)
        {
            // rekrsif fonksiyon 
            // 3^4
            int result = 1;
            for (int i = 1; i < 5; i++)
            
                result*=3;
             System.Console.WriteLine(result);
         
           Islemler islemler=new Islemler();
           System.Console.WriteLine(islemler.Expo(3,4)); 

          //extension fonksiyonlar

          string ifade = "Ömer Serfice";
          bool sonuc = ifade.CheckSpaces();
          Console.WriteLine(sonuc);
          if (sonuc)
          
              System.Console.WriteLine(ifade.RemoveWhiteSpaces());
              System.Console.WriteLine(ifade.MakeUpperCase());
               System.Console.WriteLine(ifade.MakeLowerCase());

               int[] dizi = {9,3,2,14,5,11,1};
              dizi.SortArray();
              foreach (var item in dizi)
              {
                  System.Console.WriteLine(item);
              }
        }
    
    }

    public class Islemler{
        public int Expo(int sayi,int üs){
            if (üs<2)
             return sayi;
             return Expo(sayi,üs-1)*sayi;
        }
        
    }

    public static class Extension{
        public static bool CheckSpaces(this string param){
               return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param){
              string[] dizi = param.Split(' ');
              return string.Join("",dizi);
        }
        
        public static string MakeUpperCase(this string param){
              
              return param.ToUpper();
        }

         public static string MakeLowerCase(this string param){
              
              return param.ToLower();
        }

        public static int[] SortArray(this int[] param){
               Array.Sort(param);
               return param;
        }

        }
    
}
