using System;

namespace recursive_extention
{
    class Program
    {
        static void Main(String[] args)
        {
            //rekürsiv - özyinelemeli fonksiyon
            //3^4 3*3*3*3

            int result = 1;
            for(int i = 1; i<5; i++)
            result = result * 3;
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            // extension metotlar
            string ifade = "fatma demir el";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if(sonuc)
            Console.WriteLine(ifade.RemoveWhileSpace());
            Console.WriteLine(ifade.MakeLoverCase());
            Console.WriteLine(ifade.MakeUpperCase());

            int[] dizi = {7,4,9,5,1,8,6};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }
    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if(us<2)
            return sayi;
            return Expo(sayi, us-1)*sayi;
        }
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhileSpace(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*",dizi);
        }
        public static string MakeLoverCase(this string param)
        {
            return param.ToLower();
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach(int item in param)
            Console.WriteLine(item);
        }
        public static bool IsEvenNumber(this int param)
        {
            return param%2 == 0;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
