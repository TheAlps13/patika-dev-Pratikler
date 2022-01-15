using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Alper";
            ogrenci1.Soyisim = "Tasci";
            ogrenci1.OgrenciNo = 265;
            ogrenci1.Sinif = 3;

            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Suleyman", "Bilik", 5, 1);

            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();
        }
    }


    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sinif En Az 1 Olabilir!");
                    this.sinif = 1;
                }
                else
                    sinif = value;
            }
        }



        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.ogrenciNo = ogrenciNo;
            this.sinif = sinif;
        }

        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("**************Ogrenci Bilgileri**************");
            Console.WriteLine("Ogrenci Adi: {0}", this.Isim);
            Console.WriteLine("Ogrenci Soyadi: {0}", this.Soyisim);
            Console.WriteLine("Ogrenci No: {0}", this.OgrenciNo);
            Console.WriteLine("Ogrenci Sinif: {0}", this.Sinif);
        }

        public void SinifAtla() { this.Sinif++; }

        public void SinifDusur() { this.Sinif--; }

    }
}
