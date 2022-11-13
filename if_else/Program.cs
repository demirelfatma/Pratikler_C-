using System;

namespace if_else
{
    class Program
    {
        static void Main(String[] args)
        {
            int time = DateTime.Now.Hour;
            
            if(time>=6 && time<11)
            Console.WriteLine("Günaydın");
            else if(time <= 18)
            Console.WriteLine("İyi günler");
            else
            Console.WriteLine("İyi geceler");

            string sonuc = time<=18 ? "iyi günler": time>=6 && time<11 ?
             "iyi geceler":"Günaydın";
            Console.WriteLine(sonuc);

        }
    }
}
