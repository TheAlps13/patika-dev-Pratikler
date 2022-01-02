using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kuzu", "Tilki", "Kedi", "Tavuk"};

            int[] dizi;
            dizi = new int[10];

            // Dizilere değer atama ve erişim
            renkler[3] = "Kırmızı";

            dizi[2] = 10;

            Console.WriteLine(hayvanlar[2]);
            Console.WriteLine(renkler[3]);
            Console.WriteLine(dizi[2]);

            // Döngüler ile dizi kullanımı
            // Klavyeden girilen n sayısının ortalamasını hesaplayan kod
            Console.Write("Lütfen dizinin boyutunu giriniz: ");
            int diziBoyutu = int.Parse(Console.ReadLine());
            
            int[] sayiDizisi = new int[diziBoyutu];
            int toplam = 0;

            for(int i = 0; i < diziBoyutu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz : ", i + 1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int i in sayiDizisi)
            {
                toplam += i;
            }
            Console.WriteLine("Ortalama : " + toplam / diziBoyutu);
        }
    }
}
