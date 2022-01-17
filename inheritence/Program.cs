using System;

namespace inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Tohumlu Bitki*****");
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("*****Marti*****");
            Kuslar marti = new Kuslar();
   
            marti.Adaptasyon();
            marti.Ucmak();
        }
    }
}
