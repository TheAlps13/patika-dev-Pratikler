using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erişim belirteci, geri dönüş tipi, metod adı(parametreListesi/argumen)
            // {
                // Komutlar
            // }

            int a = 3;
            int b = 4;
            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar metot = new Metotlar();
            metot.EkranaYazdir("hey");

            int sonuc2 = metot.ArttirVeTopla(ref a, ref b);
            Console.WriteLine("Artir ve topla metotundan dönen: " + sonuc2);
            Console.WriteLine("a + b: " + (a + b));
        }
        static int Topla(int deger1, int deger2)
         {
            return deger1 + deger2;
         }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;

            return deger1 + deger2;
        }
    }
}
