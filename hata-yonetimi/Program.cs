using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz: ");
                int numb = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine(numb + " Sayisini girdiniz");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Hata: Deger bos birakilamaz!");
            }
            catch(FormatException ex)
            {
                System.Console.WriteLine("Hata: Yanlis veri tipi girildi");
            }
            catch(OverflowException ex)
            {
                System.Console.WriteLine("Hata: Girilebilecek maksimum deger asildi");
            }
            finally
            {
                Console.WriteLine("Bu kisim hata olsada olmasada calisir");
            }
        }
    }
}
