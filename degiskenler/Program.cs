using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte by  = 4; // 1 Byte
            sbyte sby = -4; // 1 Byte
            bool trueStory = false; // 1 Byte

            char ch = 'a'; // 2 Byte
            short sh = -1; // 2 Byte
            ushort ush = 1; // 2 Byte
            Int16 i16 = 0; // 2 Byte
            
            int numb = 0; // 4 Byte
            uint uNumb = 0; // 4 Byte
            Int32 num32 = 0; // 4 Byte

            Int64 num64 = 0; // 8 Byte
            long longNumb = 0; // 8 Byte
            ulong uLongNumb = 0; // 8 Byte

            float f = 4.3f; // 4 Byte
            double dabil = 3; // 8 Byte
            decimal dec = 1; // 16 Byte

            string str = "Alper";

            DateTime date;


            object o1 = true;
            object o2 = "false";
            object o3 = 'c';
            object o4 = 3;
            object o5 = 4.3;

           //stringler

           string str2 = string.Empty;
           string isim = "Alper";
           string tamIsim = isim + "Tasci";

           //intler
           int i1 = 4;
           int i2 = 6;
           int i3 = i1 * i2;

           //boolean
           bool isEmpty = string.IsNullOrEmpty(isim);

           //Değişken dönüşümleri//

           string days = "days";
           int daysAsInt = 365;
           string aYearIs = days.Insert(0, daysAsInt.ToString() + " ");

           string one = "1";
           int anotherOne = int.Parse(one);
           Console.WriteLine(aYearIs);

           //DateTime
           string dateTime = DateTime.Now.ToString("dd.MM.yyyy") + "\n" + DateTime.Now.ToString("HH:mm");
           Console.WriteLine(dateTime);

        }
    }
}
