using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            /*list.Add("Alper");
            list.Add(29);
            list.Add("Is-Halayable?");
            list.Add(false);
            list.Add('Y');*/

            foreach (var item in list)
                Console.WriteLine(item);

            // AddRange (Birden fazla elemanı toplu halde ekleme)
            Console.WriteLine("****Add Range****");
            //string[] renkler = { "Sarı, kırmızı, mavi, yeşil, baklava sarısı" };
            List<int> sayilar = new List<int>() { 1, 3, 5, 2, 4, 1, 15, 10, 13, 9 };

            // list.AddRange(renkler);
            list.AddRange(sayilar);

            foreach (var item in list)
                Console.WriteLine(item);


            // ArrayList in içine farklı türleri koyarsak hata verir 
            list.Sort();
            foreach (int i in list)
                Console.WriteLine(i);

            // Binary Search
            Console.WriteLine("***Binary Search****");
            Console.WriteLine(list.BinarySearch(10));

            // Reverse
            Console.WriteLine("***Reverse****");
            list.Reverse();
            foreach (int i in list)
                Console.WriteLine(i);

            // Clear
            Console.WriteLine("***Clear***");
            list.Clear();
            foreach (int i in list)
                Console.WriteLine(i);

            Console.WriteLine("Hey i am empty...nothing to see here");
        }
    }
}
