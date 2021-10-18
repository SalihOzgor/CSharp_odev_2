using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            */
            
            Console.WriteLine("Lütfen bir cümle yazınız: ");
            string cümle  = Console.ReadLine();
            char[] harfList = new char[8];
            int n = 0;
            

            foreach (char harf in cümle)
            {
                if(harf == 'a' || harf == 'e' || harf == 'ı' || harf == 'i' || harf == 'o' || harf == 'ö' || harf == 'u' || harf == 'ü'){
                    
                    if (Array.IndexOf(harfList,harf) == -1)
                    {
                        harfList[n] = harf;
                        Console.WriteLine(n);
                        n++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Array.Resize<char>(ref harfList,n);

            Array.Sort(harfList);

            Console.WriteLine("Girdiğiniz cümledeki sesli harfler şunlar:");

            foreach (char item in harfList)
            {
                if (item == harfList[n-1])
                {
                    Console.Write(item);
                }
                else
                {
                    Console.Write(item+", ");
                }
            }
        }
    }
}
