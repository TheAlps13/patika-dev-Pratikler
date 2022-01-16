using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Alper", "Tasci", "Coding");
            Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Suleyman", "Bilik", "Food Department");
            Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);

            Islemler.Cikar(20, 5);
            Islemler.Topla(100, 200);
        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi; }
        private string isim;
        private string soyisim;
        private string departman;

        static Calisan() { calisanSayisi = 0; }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi++;
        }

    }

    static class Islemler
    {
        public static void Topla(int sayi1, int sayi2) { Console.WriteLine("Toplama isleminin sonucu: " + (sayi1 + sayi2).ToString()); }
        public static void Cikar(int sayi1, int sayi2) { Console.WriteLine("Cikarma isleminin sonucu: " + (sayi1 - sayi2).ToString()); }

    }
}
