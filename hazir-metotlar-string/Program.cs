using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Hello people";
            string degisken2 = "Hello";

            // Lenghth
            Console.WriteLine(degisken.Length);

            // ToUpper, ToLower-
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            // Concat
            Console.WriteLine(String.Concat(degisken, "wassupp ?"));

            // Compare
            Console.WriteLine(degisken.CompareTo(degisken2)); // RETURNS 0 - 1 AND -1
            Console.WriteLine(String.Compare(degisken, degisken2, true));

            // Contains & EndsWith & StartsWith
            Console.WriteLine(degisken.Contains("Hello"));
            Console.WriteLine(degisken.StartsWith("Hello"));
            Console.WriteLine(degisken.EndsWith("Hello"));

            // IndexOf & LastIndexOf
            Console.WriteLine(degisken.IndexOf("every"));
            Console.WriteLine(degisken.LastIndexOf("everybody"));
            
            // Insert
            Console.WriteLine(degisken.Insert(5, " fellow"));

            // PadLeft, PadRight
            Console.WriteLine(degisken.PadLeft(25));
            Console.WriteLine(degisken.PadRight(25, '#'));

            // Remove
            Console.WriteLine(degisken.Remove(5, 5));

            // Replace
            Console.WriteLine(degisken.Replace("Hello", "Merhaba"));

            // Split
            Console.WriteLine(degisken.Split(' ')[1]);

            // Substring
            Console.WriteLine(degisken.Substring(6));
        }
    }
}
