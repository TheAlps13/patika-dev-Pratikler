using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayıya kadar olan çift sayıları ekrana yazdır

            int sayi = int.Parse(Console.ReadLine());
            for(int i = 0; i < sayi; i++)
                if(i % 2 == 0)
                    Console.WriteLine(i);


            int tekToplam = 0, ciftToplam = 0;
            // 1 ile 1000 arasındaki tek ve çift sayıların toplamını ekrana yazdırır

            for(int i = 0; i < 1000; i++)
                if(i % 2 == 0)
                    ciftToplam += i;
                else
                    tekToplam += i;

            Console.WriteLine("Tek toplam :" + tekToplam);
            Console.WriteLine("Çift toplam :" + ciftToplam);

            // break ve continue

            for(int i = 0; i < 10; i++) // break
            {
                Console.WriteLine(i);
                if(i == 7)
                    break; // stop here
            }

            for(int i = 0; i < 10; i++) // continue
            {
                 if(i == 5)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
