using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Collections.Generic
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(1, "Alper Taşçı");
            kullanicilar.Add(3, "Ümit Besen");
            kullanicilar.Add(7, "Awesome John");
            kullanicilar.Add(5, "Bahri Karabal");

            // Dictionarynin elemanlarına erişim
            Console.WriteLine("**** Elemanlara Erişim ****");
            Console.WriteLine(kullanicilar[5]);
            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            // Count
            Console.WriteLine("***Count***");
            Console.WriteLine(kullanicilar.Count);

            // Contains
            Console.WriteLine("***Contains***");
            Console.WriteLine(kullanicilar.ContainsValue("Alper Taşçı"));
            Console.WriteLine(kullanicilar.ContainsKey(5));

            // Remove
            Console.WriteLine("***Remove***");
            kullanicilar.Remove(1);
            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            // Keys
            Console.WriteLine("***Keys***");
            foreach (var item in kullanicilar.Keys)
                Console.WriteLine(item);

            // Values
            Console.WriteLine("***Values***");
            foreach (var item in kullanicilar.Values)
                Console.WriteLine(item);

        }
    }
}
