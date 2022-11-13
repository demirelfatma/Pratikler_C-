using System;

namespace operatorler
{
    class Program
    {
        static void Main(String[] args)
        {
            // atama ve işlemli atama
            int x = 3;
            int y = 5;
            y = y+2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 2;
            Console.WriteLine(y);
            y %= 2;
            Console.WriteLine(y);
            
            // mantıksal operatörler
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            Console.WriteLine("Perfect");

            if(isSuccess || isCompleted)
            Console.WriteLine("Great");

            if(isSuccess && !isCompleted)
            Console.WriteLine("Final");

            // ilişkisel operatörler
            // <, >, >=, <=, ==, !=
            int a = 3;
            int b = 4; 
            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            // aritmetik operatorler
            // +, -, *, /
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            int sayi3 = ++ sayi1;
            Console.WriteLine(sayi3);

            // % mod alma
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);
        }
    }
}
