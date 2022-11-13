using System;

namespace hazır_metotlar_math
{
    class Program
    {
        static void Main(String[] args)
        {
            
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Month);

            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.DayOfYear);
            
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddMinutes(30));
            Console.WriteLine(DateTime.Now.AddSeconds(50));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));
            Console.WriteLine(DateTime.Now.AddMonths(4));

            // Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//23
            Console.WriteLine(DateTime.Now.ToString("ddd"));//sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));//saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));//04
            Console.WriteLine(DateTime.Now.ToString("MMM"));//apr
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//april

            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-21));//21
            Console.WriteLine(Math.Sin(37));
            Console.WriteLine(Math.Cos(54));
            Console.WriteLine(Math.Tan(45));

            Console.WriteLine(Math.Ceiling(22.3));//23
            Console.WriteLine(Math.Round(22.3));//22
            Console.WriteLine(Math.Round(22.7));//23
            Console.WriteLine(Math.Floor(22.7));//22

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4));//3^4
            Console.WriteLine(Math.Sqrt(9));//3 kare alma işlemi
            Console.WriteLine(Math.Log(5));//5 in e tabanında log u
            Console.WriteLine(Math.Log10(5));//5 in log 10 u
            Console.WriteLine(Math.Exp(3));// e üzeri 3 ü verir
        
        }
    }
}