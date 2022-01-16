using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 5;
            dikdortgen.UzunKenar = 7;
            Console.WriteLine("Class alan hesaplama {0}", dikdortgen.AlanHesapla().ToString());
            Dikdortgen_Struct dikdortgen_struct;
            dikdortgen_struct.KisaKenar = 5;
            dikdortgen_struct.UzunKenar = 7;
            Console.WriteLine("Struct alan hesaplama {0}", dikdortgen_struct.AlanHesapla().ToString());
        }
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla() { return this.KisaKenar * this.UzunKenar; }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;
        public long AlanHesapla() { return this.KisaKenar * this.UzunKenar; }
    }
}
