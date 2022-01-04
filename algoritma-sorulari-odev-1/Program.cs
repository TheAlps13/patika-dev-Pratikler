using System;

namespace algoritma_sorulari_odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odevler.Odev_1(); // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Odevler.Odev_2(); // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Odevler.Odev_3(); // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Odevler.Odev_4(); // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        }
    }

    // Ödevin içinde 4 farklı problem var çözülmesi gereken, bunları 4 ayrı metoda böldüm 
    public class Odevler
    {
        // ÖDEV 1 
        public static void Odev_1()
        {
            int[] arr = Operations.ReadIntArr();
            System.Console.WriteLine("Girilen sayilar icindeki cift sayilar;");
            arr.PrintEven();
        }

        // ÖDEV 2
        public static void Odev_2()
        {
            int m = 0;
            int[] arr = Operations.ReadIntArr();
            System.Console.Write("Kendisine esit ya da tam bolunenlerin bulunmasini istediginiz sayiyi giriniz: ");
            m.Read();
            System.Console.WriteLine("Girdiginiz sayilardan {0} sayisina esit olanlar veya tam bolunenler;", m);
            Operations.PrintEqualOrDivisible(m, arr);
        }
        // ÖDEV 3
        public static void Odev_3()
        {
            string[] str = Operations.ReadStringArr();
            System.Console.WriteLine("\nGirdiginiz Kelimeler;\n");
            str.PrintReverse();
        }
        // ÖDEV 4
        public static void Odev_4()
        {
            System.Console.WriteLine("Cumleyi yaziniz..");
            Operations.PrintSentenceInfo(Console.ReadLine());
        }
    }
    public static class Operations
    {
        public static void Read(this ref int param) // Read int from console
        {
            try
            {
                param = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Hata ! sayi konsoldan okunamadi");
            }
        }
        public static int[] ReadIntArr() // Read int array from console
        {
            System.Console.Write("Sayi adetini giriniz: ");
            int size = 0;
            size.Read();
            int[] arr = new int[size];
            System.Console.WriteLine(size + " adet pozitif sayi giriniz");

            for (int i = 0; i < size; i++)
            {
                try
                {
                    arr[i] = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine("Hata, veri tipi yalnizca sayi olmali !");
                    i--;
                }
            }
            return arr;
        }

        public static string[] ReadStringArr()
        {
            System.Console.Write("Kelime adetini giriniz: ");
            int size = 0;
            size.Read();
            string[] arr = new string[size];
            System.Console.WriteLine(size + " adet kelime giriniz");

            for (int i = 0; i < size; i++)
            {
                arr[i] = Console.ReadLine();
            }

            return arr;
        }
        public static void PrintEven(this int[] param) // Print even numbers
        {
            foreach (int i in param)
                if (i % 2 == 0)
                    System.Console.WriteLine(i);
        }

        public static void PrintEqualOrDivisible(int m, int[] arr)
        {
            foreach (int i in arr)
                if (i == m || i % m == 0) // Equal or fully divisible
                    System.Console.WriteLine(i);
        }

        public static void PrintReverse(this string[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
                System.Console.WriteLine(arr[i]);
        }

        public static void PrintSentenceInfo(string sentence)
        {
            int kelimeSayisi = 1, noktalamaIsaretleri = 0;
            foreach (char ch in sentence)
            {
                if (ch.Equals(' '))
                    kelimeSayisi++;

                if (ch.Equals('.') || ch.Equals(',') || ch.Equals('!') || ch.Equals('?') || ch.Equals(' '))
                    noktalamaIsaretleri++;
            }

            System.Console.WriteLine("Kelime sayisi: " + kelimeSayisi + "\nHarf sayisi: " + (sentence.Length - noktalamaIsaretleri));
        }
    }
}
