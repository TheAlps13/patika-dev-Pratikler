using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 den başlayarak girilen sayıya kadar(sayı dahil) ortalamasını veren program
            Console.WriteLine("Lütfen sayiyi giriniz");

            int sayac = 1;
            int sayi = int.Parse(Console.ReadLine());
            int toplam = 0;

            while(sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine("Ortalama: " + toplam / sayi);

            // a dan z ye kadar tüm harfleri konsola yazdıran program
            char ch = 'a';

            while(ch <= 'z')
            {
                Console.WriteLine(ch);
                ch++;
            }
            
            Console.WriteLine("\n****FOR EACH STARTS HERE*****");

            string[] arabalar = {"BMW", "Honda", "One Beygir", "Bugatti"};
            foreach(string str in arabalar)
                Console.WriteLine(str);
        }
    }
}
