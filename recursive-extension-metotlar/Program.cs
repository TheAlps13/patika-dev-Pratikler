using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive - Özyinelemeli metotlar
            // 2 ^ 4 = 2 * 2 * 2 * 2 = 16;

            int sonuc = 2;
            // For loop ile ;
            for (int i = 1; i < 4; i++)
                sonuc *= 2;

            System.Console.WriteLine(sonuc);

            // Recursive metot ile 
            System.Console.WriteLine(Islemler.ExpoNumb(2, 4));

            // Extension metotlar
            int sayi = 5, negatifSayi = -3;
            System.Console.WriteLine("Is sayi negative ?: " + sayi.IsNegative());
            System.Console.WriteLine("Is negatifSayi negative ?: " + negatifSayi.IsNegative());

            string str = "Bu string-bir zamanlar-bosluklar iceriyordu";
            System.Console.WriteLine(str.RemoveWhiteSpaces());

            int[] sayiDizisi = { 23, 12, 11, 10, 4, 17, 33, 62, 11 };

            System.Console.WriteLine("**UNSORTED**");
            sayiDizisi.EkranaYazdir();

            sayiDizisi.IntegerSort(); //Sort

            System.Console.WriteLine("**SORTED**");
            sayiDizisi.EkranaYazdir();

            //  Cift mi tek mi ?
            System.Console.WriteLine("\n" + 5.IsEvenNumb());
        }
    }

    public static class Islemler
    {
        public static int ExpoNumb(int numb, int exponent)
        {
            if (exponent < 2)
                return numb;

            return numb * (ExpoNumb(numb, exponent - 1));
        }

        public static bool IsNegative(this int i) { return i < 0 ? true : false; }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] arr = param.Split(" ");
            return string.Join("", arr);
        }

        public static string MakeUpperCase(this string param) { return param.ToUpper(); }

        public static string MakeLowerCase(this string param) { return param.ToLower(); }

        public static void IntegerSort(this int[] param) { Array.Sort(param); }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (int i in param)
                System.Console.WriteLine(i);
        }

        public static bool IsEvenNumb(this int param) { return param % 2 == 0 ? true : false; }

        public static char GetFirstChar(this string param) { return param[0]; }
    }
}
