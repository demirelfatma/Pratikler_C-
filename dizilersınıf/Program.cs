using System;

namespace dizilersinif
{
    class Program
    {
        static void Main(String[] args)
        {
            // sort
            int[] sayiDizisi = {12,45,32,74,96,25,13};

            Console.WriteLine("*******sırasız dizi*******");
            foreach(var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            Console.WriteLine("*******sıralı dizi********");
            Array.Sort(sayiDizisi);

            foreach(var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            // clear
            Console.WriteLine("*****array clear******");
            // sayiDizisi elemanlarını kullanarak 2.indexten itibaren 3 sayıyı siler
            Array.Clear(sayiDizisi,2,3);

            foreach(var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            // reverse
            Console.WriteLine("*****array reverse******");
            Array.Reverse(sayiDizisi);

            foreach(var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            // indexOf
            Console.WriteLine("*****array IndexOf******");

            Console.WriteLine(Array.IndexOf(sayiDizisi,12));

            // resize
            Console.WriteLine("*****array reaize******");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8]=99;
            foreach(var sayi in sayiDizisi)
            Console.WriteLine(sayi);
        }
    }
}
