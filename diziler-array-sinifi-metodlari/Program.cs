using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] sayiDizisi = {3, 5, 22, 11, 1, 4, 0, -5};
            Console.WriteLine("**UNSORTED**");
            foreach(int i in sayiDizisi)
                Console.WriteLine(i);
            
            Array.Sort(sayiDizisi);
            Console.WriteLine("**SORTED**");
            foreach(int i in sayiDizisi)
                Console.WriteLine(i);

            // Clear

            Console.WriteLine("***Array Clear***");
            // sayiDizisi elemanlarının 4. indeksten itibaren 2 elemanı sıfırlar
            Array.Clear(sayiDizisi, 4, 2);
            foreach(int i in sayiDizisi)
                Console.WriteLine(i);

            // Reverse
            Console.WriteLine("***Array Reverse***");
            Array.Reverse(sayiDizisi);

            foreach(int i in sayiDizisi)
                Console.WriteLine(i);

            // IndexOf
            Console.WriteLine("***Array IndexOf***");
           
            Console.WriteLine(Array.IndexOf(sayiDizisi, 3));

            // Resize
            Console.WriteLine("***Array Resize***");
            Array.Resize<int>(ref sayiDizisi, 15);

            sayiDizisi[13] = 52; // Test
            foreach(int i in sayiDizisi)
                Console.WriteLine(i);
        }
    }
}
