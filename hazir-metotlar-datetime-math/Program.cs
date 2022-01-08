using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            // O andaki tarihi getirir
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            // DayOfWeek & DayOf;
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            // ToLongDateString & ToShortDateString
            Console.WriteLine("");
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            // Add
            Console.WriteLine(DateTime.Now.AddYears(4));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            Console.WriteLine(DateTime.Now.AddDays(7));
            Console.WriteLine(DateTime.Now.AddHours(9));
            Console.WriteLine(DateTime.Now.AddMinutes(330));
            Console.WriteLine(DateTime.Now.AddSeconds(220));
            Console.WriteLine(DateTime.Now.AddMilliseconds(15));

            // DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));     // 08
            Console.WriteLine(DateTime.Now.ToString("ddd"));    // Sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));   // Saturday
            Console.WriteLine(DateTime.Now.ToString("MM"));     // 01
            Console.WriteLine(DateTime.Now.ToString("MMM"));    // Jan
            Console.WriteLine(DateTime.Now.ToString("MMMM"));   // January
            Console.WriteLine(DateTime.Now.ToString("yy"));     // 22
            Console.WriteLine(DateTime.Now.ToString("yyyy"));   // 2022

            Console.WriteLine(DateTime.Now.ToString("dddd " + " dd " + " MMM " + "yyyy")); // Saturday 08 Jan 2022

            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); // 25
            Console.WriteLine(Math.Sin(4));
            Console.WriteLine(Math.Cos(4));
            Console.WriteLine(Math.Tan(4));

            Console.WriteLine(Math.Ceiling(14.2));
            Console.WriteLine(Math.Round(22.7));
            Console.WriteLine(Math.Floor(11.7));

            Console.WriteLine(Math.Min(3,9));
            Console.WriteLine(Math.Max(7, 1));

            Console.WriteLine(Math.Pow(2, 5)); // 2^5 32
            Console.WriteLine(Math.Sqrt(9)); // Karekök 3
            Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logaritmik karşılığı
            Console.WriteLine(Math.Exp(7)); // e üzeri 7 i verir 
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı
        }
    }
}
