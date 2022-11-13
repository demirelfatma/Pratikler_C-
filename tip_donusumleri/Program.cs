using System;

namespace tip_donusumleri
{
    class Program{
        static void Main(String[] args)
        {
            // implicit conversion bilinçsiz dönüşüm
            byte a = 5;
            sbyte b = 10;
            short c = 30;
            
            int d = a+b+c;
            Console.WriteLine("c: "+c);

            long e = d;
            Console.WriteLine("e: "+e);

            float i = e;
            Console.WriteLine("i: "+i);

            string s = "zikriye";
            char f = 'k';
            object g = s+f+d;
            Console.WriteLine("g: "+g);

            // explicit conversion bilinçli dönüşüm
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: "+y);

            int t = 200;
            byte z = (byte)t;
            Console.WriteLine("z: "+z);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: "+v);

            // tostring methodu
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: "+yy);

            string ss = 12.4f.ToString();
            Console.WriteLine("ss: "+ss);

            // system.convert
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("sayi1: "+sayi1);
            Console.WriteLine("sayi2: "+sayi2);

            Console.WriteLine("toplam: "+toplam);

            // parse
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.23";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1: "+rakam1);
            Console.WriteLine("double1: "+double1);
        }
    }
}
