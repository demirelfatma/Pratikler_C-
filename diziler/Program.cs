using System;

namespace diziler
{
    class Program
    {
        static void Main(String[] args)
        {
            // dizi tanımlama
            string[] renkler = new string[4];

            string[] hayvanlar = {"kedi","köpek","at","inek"};

            int[] sayilar;
            sayilar = new int[3];

            // dizi değer atama
            renkler[3]="mavi";

            sayilar[2]=10;

            Console.WriteLine(hayvanlar[2]);
            Console.WriteLine(renkler[3]);
            Console.WriteLine(sayilar[2]);

            // döngüler ile dizi tanımlaması 
            // klavyeden girilen a tane sayı için ortalama hesabı

            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunluğu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunluğu];

            for(int i=0; i<diziUzunluğu; i++)
            {
                Console.Write("Lütfen {0} sayısını giriniz: ", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
        
            foreach(var sayi in sayiDizisi)
            toplam += sayi;
            Console.WriteLine("ortamala: "+toplam/diziUzunluğu);
        }
    }
}
