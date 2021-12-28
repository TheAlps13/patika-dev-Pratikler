using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
           //Atama ve işlemli atama
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
        }
    }
}
