using System;

namespace inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Kuslar marti = new Kuslar();
            marti.Adaptasyon();
            marti.Ucmak();
        }
    }
}
