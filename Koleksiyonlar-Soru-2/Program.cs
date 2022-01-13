using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int[] min_3_Arr = new int[3];
            int[] max_3_Arr = new int[3];

            Console.WriteLine("20 adet sayi giriniz...");
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    arr[i] = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hata ! Girisler sadece sayi olabilir !");
                    i = i > 0 ? i - 1 : 0;
                }
            }

            Array.Sort(arr);
            min_3_Arr = arr.FindMin_3();
            max_3_Arr = arr.FindMax_3();

            foreach (int i in min_3_Arr)
                Console.WriteLine("Girdiginiz sayilar arasindan en kucuk 3 sayi: " + i.ToString());
            foreach (int i in max_3_Arr)
                Console.WriteLine("Girdiginiz sayilar arasindan en buyuk 3 sayi: " + i.ToString());

            Console.WriteLine("En kucuk 3 sayinin ortalamasi: " + min_3_Arr.CalcAverage().ToString());
            Console.WriteLine("En buyuk 3 sayinin ortalamasi: " + max_3_Arr.CalcAverage().ToString());
            Console.WriteLine("Ortalamalarinin toplamlari : " + (min_3_Arr.CalcAverage() + max_3_Arr.CalcAverage()).ToString());
        }
    }

    public static class Operations
    {
        //Bu fonksiyonlar çağırılmadan önce Array Sort edilmelidir
        public static int[] FindMin_3(this int[] arr)
        {
            int[] resultArr = new int[3];
            resultArr[0] = arr[0];
            resultArr[1] = arr[1];
            resultArr[2] = arr[2];

            return resultArr;
        }

        public static int[] FindMax_3(this int[] arr)
        {
            int[] resultArr = new int[3];
            int lastIndexPos = arr.Length - 1;
            resultArr[2] = arr[lastIndexPos];
            resultArr[1] = arr[lastIndexPos - 1];
            resultArr[0] = arr[lastIndexPos - 2];

            return resultArr;
        }

        public static float CalcAverage(this int[] arr)
        {
            float sum = 0;
            foreach (int i in arr)
                sum += i;

            return sum / 2f;
        }
    }
}
