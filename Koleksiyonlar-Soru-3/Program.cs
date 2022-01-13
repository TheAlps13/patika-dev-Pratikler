using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cumle yaziniz lutfen...");
            string sesliHarfler = "aeıioöuü";

            ArrayList bulunanSesliHarfler = new ArrayList();

            string cumle = Console.ReadLine();
            foreach (char ch in cumle)
                if (sesliHarfler.Contains(ch))
                    bulunanSesliHarfler.Add(ch);

            Console.WriteLine("Cumlede bulunan sesli harfler: ");
            bulunanSesliHarfler.Sort();
            foreach (char ch in bulunanSesliHarfler)
                Console.WriteLine(ch);
        }
    }
}
