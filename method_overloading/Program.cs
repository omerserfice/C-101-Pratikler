using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
           string sayi = "999";
           int outSayi;
           bool sonuc = int.TryParse(sayi,out outSayi);
           if(sonuc){
                 System.Console.WriteLine("Başarılı");
                 System.Console.WriteLine(outSayi);
           }else{
               System.Console.WriteLine("Başarısız");
           }
           
           Metotlar m=new Metotlar();
           m.Topla(2,3,out int tplamsonucu);
           System.Console.WriteLine(tplamsonucu);
           ///////
           int ifade = 999;
           m.EkranaBas(Convert.ToString(ifade));
           m.EkranaBas("Ömer","Serfice");
        }

        class Metotlar{
            public void Topla(int a,int b,out int toplam){
                toplam = a+b;
            }

            public void EkranaBas(string veri){
                     System.Console.WriteLine(veri);
            }
             public void EkranaBas(int veri){
                     System.Console.WriteLine(veri);
            }
            public void EkranaBas(string veri1,string veri2){
                     System.Console.WriteLine(veri1+veri2);
            }
        }
    }
}
