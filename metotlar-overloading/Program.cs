using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Out parametreler
            string sayi = "444";
            bool isDone = int.TryParse(sayi, out int returnSayi);

            if(isDone)
                Console.WriteLine(sayi);
            else 
                Console.WriteLine("Hata var gardass!!");
            

            Metotlar.topla(5, 3, out int toplam);
            Console.WriteLine("Toplam : " + toplam);

            // Metot Overloading

            int yazdirilcakSayi = 5;
            string yazdirilcakYazi1 = "Hello";
            string yazdirilcakYazi2 = "World";
            Metotlar.EkranaYazdir(yazdirilcakSayi);
            Metotlar.EkranaYazdir(yazdirilcakYazi1);
            Metotlar.EkranaYazdir(yazdirilcakYazi1, yazdirilcakYazi2);
            // Metot Imzası
            /*
            Metot adı
            Parametre sayısı
            Parametre
            */
        }


        class Metotlar
        {
            public static void topla(int a, int b, out int returnVal)
            {
                returnVal = a + b; 
            }

            public static void EkranaYazdir(string str)
            {
                Console.WriteLine(str);
            }
            public static void EkranaYazdir(int sayi)
            {
                Console.WriteLine(sayi);
            }
            public static void EkranaYazdir(string str1, string str2)
            {
                Console.WriteLine(str1 + " " + str2);
            }
        }

    }
}
