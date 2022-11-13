using System;

namespace degiskenler
{
    class Program
    {
        public static void Main(String[] args)
        {
            int deger = 2;
            string degisken = null;
            string alt_veri = "asdf";
            Console.WriteLine("Merhaba C#");
            byte b = 2;  // 1 byte
            sbyte b1 = 3; // 1 byte
            short s = 4; // 2 byte
            ushort us = 5; // 2 byte
        //    int16 i16 = 2; // 2 byte
            int i = 2; // 4 byte
        //    int32 i32 = 4; // 4 byte
        //    int64 i64 = 8; // 8 byte
            uint ui = 4; // 4 byte
            long l = 4; // 8 byte
            ulong ul = 8; // 8 byte
            float f = 4; // 4 byte
            double d = 3; // 8 byte
            decimal d2 = 1; // 16 byte
            char ch = 'c';  // 2 byte
            string str = "fatma"; // sınırsız
            bool b4 = true;
            bool b5 = false;
            DateTime dt = DateTime.Now;
            Console.WriteLine(str);
            object o = "x";
            object o2 = 'c';
            object o4 = 4;
            object o3 = 5.2;
            string ing = string.Empty;
            ing = "fatma demirel";
            string v = str+ " "+ing;
            int integer1 = 5;
            int integer2 = 6;
            int integer3 = integer1+integer2;
            bool bool1 = 10>3;
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20+int20.ToString();
            Console.WriteLine(yeniDeger);
        }
    }
}