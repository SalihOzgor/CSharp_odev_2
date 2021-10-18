using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            */

            int [] sayılar = new int[20];
            int n = 0;
            

            while (n<20)
            {
                Console.WriteLine("Lütfen {0}. tam sayıyı giriniz: ",n+1);
                 if(int.TryParse(Console.ReadLine(), out int sayı))
                 {
                     sayılar[n] = sayı;
                     n++;
                 }
                 else
                 {
                     Console.WriteLine("Hatalı giriş yaptınız.");
                 }
            }
            
            Array.Sort(sayılar);
            int [] sayılarBuyuk = new int[3];
            int [] sayılarKucuk = new int[3];
            int sayılarKucukToplam = 0;
            int sayılarBuyukToplam = 0;

            for (int i = 0; i < 3; i++)
            {
                sayılarKucuk[i] = sayılar[i];
                sayılarKucukToplam += sayılarKucuk[i];
                sayılarBuyuk[i] = sayılar[i+17];
                sayılarBuyukToplam += sayılarBuyuk[i];
            }
            double kucukOrt = (double)sayılarKucukToplam/3;
            double buyukort = (double)sayılarBuyukToplam/3;

            Console.WriteLine("Girdiğiniz sayılardan en küçük üçünün ortalaması {0}, en büyük üçünün ortalaması {1} ve bu ortalamaların toplamı {2}",kucukOrt,buyukort,kucukOrt+buyukort);
        }
    }
}
