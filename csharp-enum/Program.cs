using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sicaklik = 30;
            if (sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine("Henuz yeterince sicak degil, azcik daha bekleyin lutfen");
            if (sicaklik == (int)HavaDurumu.Normal)
                Console.WriteLine("Disari cikmak icin cok guzel bir gun ! Yihuuu");
            if (sicaklik >= (int)HavaDurumu.Sicak)
                Console.WriteLine("Hava cok sicak");
        }
    }

    enum Gunler { Pazartesi , Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar }

    enum HavaDurumu { Soguk = 5, Normal = 24, Sicak = 30, CokSicak = 37 }
}
