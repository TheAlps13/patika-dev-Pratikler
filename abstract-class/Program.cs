using System;

namespace abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            NewHonda newHonda = new();
            OneBeygir oneBeygir = new();
            NewToyota newToyota = new();

            Console.WriteLine(newHonda.HangiMarkaninAraci().ToString());
            Console.WriteLine(newHonda.KacTekerlektenOlusur().ToString());
            Console.WriteLine(newHonda.StandartRengiNe().ToString());

            Console.WriteLine("****************");

            Console.WriteLine(newToyota.HangiMarkaninAraci().ToString());
            Console.WriteLine(newToyota.KacTekerlektenOlusur().ToString());
            Console.WriteLine(newToyota.StandartRengiNe().ToString());

            Console.WriteLine("****************");

            Console.WriteLine(oneBeygir.HangiMarkaninAraci().ToString());
            Console.WriteLine(oneBeygir.KacTekerlektenOlusur().ToString());
            Console.WriteLine(oneBeygir.StandartRengiNe().ToString());
        }
    }
}
