using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erişim Belirleyiciler
            // *Public
            // *Private
            // *Internal
            // *Protected

            Calisan calisan1 = new Calisan(), calisan2 = new Calisan();

            calisan1.Isim = "Alper";
            calisan1.Soyisim = "Tasci";
            calisan1.No = "1";
            calisan1.Departman = "Flying Department";

            calisan2.Isim = "Hulya";
            calisan2.Soyisim = "Ucakkus";
            calisan2.No = "2";
            calisan2.Departman = "Pazarlama";


            calisan1.GetCalisanBilgileri();
            calisan2.GetCalisanBilgileri();
        }


        class Calisan
        {
            public string Isim;
            public string Soyisim;
            public string No;
            public string Departman;

            public void GetCalisanBilgileri()
            {
                Console.WriteLine("Çalişan Adi {0}", Isim);
                Console.WriteLine("Çalişan Soyadi {0}", Soyisim);
                Console.WriteLine("Çalişanin Numarasi {0}", No);
                Console.WriteLine("Çalişanin Departmani {0}", Departman);
            }
        }
    }
}
