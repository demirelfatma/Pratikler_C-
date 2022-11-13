using System;

namespace donguler_while
{
    class Program
    {
        static void Main(String[] args)
        {
            // while
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac<=sayi)
            {
                toplam += sayac;
                sayac ++;

            }
            Console.WriteLine(toplam/sayi);

            // a dan z ye kadar tüm harfleri consola yaz
            char karakter = 'a';
            while( karakter<'z')
            {
                Console.WriteLine(karakter);
                karakter ++;
            }
            Console.Write("*****foreach******");
            string[] arabalar = ("toyoto","bmw","mersedes","ford");
            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
