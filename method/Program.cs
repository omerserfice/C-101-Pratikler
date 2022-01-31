using System;

namespace method
{
    class Program
    {
         static void Main(string[] args)
        {
            int a = 2;
            int b= 3;
            int sonuc = Topla(a,b);
            System.Console.WriteLine(sonuc);

        Metotlar m=new Metotlar();
        m.EkranaYazdır(sonuc.ToString());
        
        int sonuc2 = m.ArttirVeTopla(ref a,ref b);
        m.EkranaYazdır(sonuc.ToString());
        m.EkranaYazdır(sonuc2.ToString());
        }

        static int Topla(int deger1,int deger2){
            return deger1+deger2;
        }
    }

     class Metotlar{
       public void EkranaYazdır(string veri){
            System.Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1,ref int deger2){
            deger1+=1;
            deger1+=1;

            return deger1+deger2;
        }
    }
}
