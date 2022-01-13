using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList prime = new ArrayList();
            ArrayList nonPrime = new ArrayList();
            int input = 0;

            Console.WriteLine("20 tane sıfırdan büyük sayı giriniz...");
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    input = Int32.Parse(Console.ReadLine());

                    if (input <= 0)
                        throw new FormatException();

                    if (input != 1)
                    {
                        if (input.CheckPrime())
                            prime.Add(input);
                        else
                            nonPrime.Add(input);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hata ettin gardaşım ! Sadece sıfırdan büyük sayıları girebilirsin");
                    i = i > 0 ? i - 1 : 0; // Bu döngü boşa gittiği için bir geri sarıyoruz
                }
            }

            prime.Sort();
            nonPrime.Sort();

            foreach (int i in prime)
                Console.WriteLine("Asal Sayilar: " + i.ToString());

            foreach (int i in nonPrime)
                Console.WriteLine("Asal Olmayan Sayilar: " + i.ToString());

            Console.WriteLine("***Eleman Sayilari ve Ortalamalari");
            Console.WriteLine("Asal Sayi Listesi Eleman Sayisi: " + prime.Count.ToString());
            Console.WriteLine("Asal Olmayan Sayi Listesi Eleman Sayisi: " + nonPrime.Count.ToString());
            Console.WriteLine("Asal Sayi Listesi Ortalamasi: " + prime.CalcAverage().ToString());
            Console.WriteLine("Asal Olmayan Sayi Listesi Ortalamasi: " + nonPrime.CalcAverage().ToString());
            
        }
    }

    public static class Operations
    {
        public static bool CheckPrime(this int param)
        {
            if (param == 2)
                return true;

            for (int i = 2; i < param; i++) // Eger kendisi ve 1 haricinde herhangi bir sayıya tam bölünüyorsa... çık dışarı...
                if (param % i == 0)
                    return false;

            return true;
        }

        public static float CalcAverage(this ArrayList arrayList)
        {
            float sum = 0f;
            foreach (int i in arrayList)
                sum += i;
            
            return sum / 2f;
        }
    }
}
