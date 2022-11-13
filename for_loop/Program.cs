using System;

namespace for_loop
{
    class Program
    {
        static void Main(String[] args)
        {
            // girilen sayıya kadar tek sayı toplama
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1 ; i <= sayac; i++)
            {
                if(i%2 == 1)
                Console.WriteLine(i);
            }
            // 1 ile 1000 arasında tek ve çift sayıların toplamları
            int tekToplam = 0;
            int ciftToplam = 0;
            for(int i=1; i<=1000; i++)
            {
                if(i%2 == 1)
                tekToplam += i;
                else
                ciftToplam += i;
            }
            Console.WriteLine("Tek Toplam: "+tekToplam);
            Console.WriteLine("Çift Toplam: "+ciftToplam);
            
            // break, continue
            for(int i=1; i<50; i++)
            {
                if(i==4)
                //break;//tamamen döngüyü sonlandırır
                continue;//sadece istenen değer atlanır
                Console.WriteLine(i);
            }
        }
    }
}