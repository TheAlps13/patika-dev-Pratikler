using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion
            Console.WriteLine("\n***Implicit Conversions***\n");

            byte a = 10;
            sbyte b = -11;
            short c = 22;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + d);

            float f = h;
            Console.WriteLine("f: " + f);

            string name = "Alper";
            char ch = 'T';
            object obj = name + ch + d;
            Console.WriteLine("obj: " + obj);

            // Explicit conversion

            Console.WriteLine("\n***Explicit Conversions***\n");
            
            int x = 5;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 300;
            byte r = (byte)z; // Data loss
            Console.WriteLine("r: " + r);

            float flo = 32.13f;
            byte fb = (byte)flo; // Data loss also
            Console.WriteLine("fb: " + fb);

            // ToString Methodu

            Console.WriteLine("\n***ToString Methodu***\n");
            
            int x1 = 5;
            string sx = x1.ToString();
            Console.WriteLine("sx: " + sx);

            string zz = 23.3f.ToString();
            Console.WriteLine("zz: " + zz);

            // System.Convert

            Console.WriteLine("\n***System.Convert sınıfı***\n");

            string s1 = "10", s2 = "30";
            int num1, num2;
            int sum;

            num1 = Convert.ToInt32(s1);
            num2 = Convert.ToInt32(s2);

            sum = num1 + num2;
            Console.WriteLine("Toplam: " + sum);

            // Parse
            Console.WriteLine("\n*** Parse ***\n");

            string strSayi = "23";
            string strOndalik = "13.33";

            int sayi = Int32.Parse(strSayi);
            Console.WriteLine("sayi: "+ sayi);

            float fSayi = float.Parse(strOndalik);
            Console.WriteLine("fSayi: " + fSayi);
        }
    }
}
