using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)



            *Negatif ve numeric olmayan girişleri engelleyin.
            *Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            *Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/

            
            ArrayList asalSayılar = new ArrayList();
            ArrayList asalOlmayanSayılar = new ArrayList();
            int n = 0;
            

            while (n<20)
            {
                Console.WriteLine("Lütfen {0}. pozitif tam sayıyı giriniz: ",n+1);
                 if(int.TryParse(Console.ReadLine(), out int sayı))
                 {
                     if (sayı>0)
                     {
                         if (asalMi(sayı) == true)
                         {
                             asalSayılar.Add(sayı);
                         }
                         else
                         {
                             asalOlmayanSayılar.Add(sayı);
                         }
                         n++;
                     }
                     else
                     {
                        Console.WriteLine("Hatalı giriş yaptınız.");
                     }
                 }
                 else
                 {
                     Console.WriteLine("Hatalı giriş yaptınız.");
                 }
            }
            asalSayılar.Sort();
            asalOlmayanSayılar.Sort();
            int asalToplam = 0;
            int asalCount = asalSayılar.Count;
            int asalOlmayanCount = asalOlmayanSayılar.Count;
            int asalOlmayanToplam = 0;

            Console.WriteLine("Asal sayılar şunlar: ");
            foreach (int asalSayı in asalSayılar)
            {
                asalToplam += asalSayı;
                
                if (asalSayı != (int)asalSayılar[asalSayılar.Count-1])
                {
                    Console.Write(asalSayı+", ");
                }else
                {
                    Console.Write(asalSayı+"\n");
                }
                
            }
            Console.WriteLine("Asal olmayan sayılar şunlar: ");
            foreach (int asalOlmayanSayı in asalOlmayanSayılar)
            {
                asalOlmayanToplam += asalOlmayanSayı;
                if (asalOlmayanSayı != (int)asalOlmayanSayılar[asalOlmayanSayılar.Count-1])
                {
                    Console.Write(asalOlmayanSayı+", ");
                }else
                {
                    Console.Write(asalOlmayanSayı+"\n");
                }
            }

            Console.WriteLine("Asal sayılar dizisinde {0} eleman bulunuyor.",asalCount);
            Console.WriteLine("Asal olmayan sayılar dizisinde {0} eleman bulunuyor.",asalOlmayanCount);
            Console.WriteLine("Asal sayılar dizisindeki elemanların ortalaması {0}",asalToplam/asalCount);
            Console.WriteLine("Asal olmayan sayılar dizisindeki elemanların ortalaması {0}",asalOlmayanToplam/asalOlmayanCount);



        }

        static bool asalMi(int a)
        {
            bool kontrol = true;
            if (a == 2)
            {
                kontrol = true;
            }
            else if (a == 1)
            {
                kontrol = false;
            }
            else
            {
                for (int i = 2; i < a; i++)
                {
                    if (a%i == 0)
                    {
                        kontrol = false;
                    }
                }
            }
            return kontrol;
        }
    }
}
