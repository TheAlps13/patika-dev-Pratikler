using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
           // Atama ve işlemli atama
            int x = 5;
            int y = 15;
            
            Console.WriteLine(y);
            y += x;
            Console.WriteLine(y);
            y -= x;
            Console.WriteLine(y);
            y *= x;
            Console.WriteLine(y);
            y /= x;
            Console.WriteLine(y);
            y %= x;
            Console.WriteLine(y);

            // Mantıksal operatörlerle işlemli atama
            bool yeaTrue = false;
            bool notTrue = true;
            // Mantıklı atama
            notTrue ^= yeaTrue; // xor
            notTrue |= yeaTrue; // or
            notTrue &= yeaTrue; // and
            // Tekrar ilk değerlerine dönüyoruz
            yeaTrue = true;
            notTrue = false;
            // Mantıksal operatörler
            Console.WriteLine("**Mantıksal Operatörler**");
            if(yeaTrue && notTrue)
                Console.WriteLine("Both are true");
            
            if(yeaTrue || notTrue)
                Console.WriteLine("One of us true");

            if(yeaTrue || !notTrue)
                Console.WriteLine("One of us is not true but we gave him a chance :)");
            if(yeaTrue ^ notTrue)
                Console.WriteLine("One of us different");


            Console.WriteLine("**İlişkisel Operatörler**");
            // İlişkisel operatörler
            // <, >, <=, >=, ==, !=
            bool sonuc = false;
            int a = 5, b = 4;

            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("**Aritmetik Operatörler**");
            // /, *, +, - , %

            int num1 = 10, num2 = 20, sonuc2 = num2 + num1;
            Console.WriteLine(sonuc2);

            sonuc2 = num1 - num2;
            Console.WriteLine(sonuc2);
            sonuc2 = num1 / num2;
            Console.WriteLine(sonuc2);
            sonuc2 = num1 * num2;
            Console.WriteLine(sonuc2);
            sonuc2 = num1 % num2;
            Console.WriteLine(sonuc2);
            
        }
    }
}
