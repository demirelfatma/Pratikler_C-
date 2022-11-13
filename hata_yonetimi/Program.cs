using System;

namespace hata_ayiklama
{
    class Program
    {
        static void Main(String[] args)
        {
            try
            {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Girmiş olduğunuz sayı: "+sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("hata: "+ex.Message.ToString());
            }
            try
            {
               // int a = int.Parse("test");
                int a = int.Parse("-2000000000000000");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("format uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya büyük bir değer girdiniz: ");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.Write("İşlem tamamlandı.");
            }
        }
    }
}
