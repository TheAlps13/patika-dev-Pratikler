using System;

namespace inheritence
{
    class Hayvanlar : Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir");
        }
    }

    class Surungenler : Hayvanlar
    {
        public void SurunerekHareketEt()
        {
            Console.WriteLine("Surungenler surunerek hareket eder");
        }
    }
    class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.UyaranlaraTepki();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuslar ucar");
        }
    }
}