using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // Systems.Collections.Generic
            // T -> object türündedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(5);
            sayiListesi.Add(232);
            sayiListesi.Add(3);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Mor");
            renkListesi.Add("Mavi");

            // Count 
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            //Foreach ve List.ForEach ile elemanlara erişim
            foreach (int i in sayiListesi)
                Console.WriteLine(i);

            foreach (string str in renkListesi)
                Console.WriteLine(str);
            
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden eleman çıkarma

            sayiListesi.Remove(5);
            renkListesi.Remove("Mavi");

            // Liste içerisinde arama
            if(sayiListesi.Contains(5))
            Console.WriteLine("5 sayi listesi içinde bulundu");

            // Eleman ile index'e erişme
            // Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));
            Console.WriteLine(renkListesi.BinarySearch("Turuncu"));
            Console.WriteLine(renkListesi.BinarySearch("Mavi"));

            // Diziyi List'e çevirme
            string[] hayvanlar = {"At", "Eşek", "Kedi"};
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            // Clear
            hayvanlarListesi.Clear();

            // List içerisinde nesne tutmak
            List<Kullanicilar> kullanicilarListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();

            kullanici1.Isim = "Alper";
            kullanici1.Soyisim = "Tasci";
            kullanici1.Yas = 30;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Mahmut";
            kullanici2.Soyisim = "Tuncer";
            kullanici2.Yas = 38;

            kullanicilarListesi.Add(kullanici1);
            kullanicilarListesi.Add(kullanici2);
            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Ali",
                Soyisim = "Baldan",
                Yas = 23
            });

            foreach(Kullanicilar kullanici in kullanicilarListesi)
            {
                Console.WriteLine("Kullanıcı Adı: "  + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: " + kullanici.Yas);
            }

        }
    }

    public class Kullanicilar
    {
        private string isim, soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
