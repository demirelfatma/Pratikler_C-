using System;
using System.Collections;

namespace array_list
{
    class Program
    {
        static void Main(String[] args)
        {
            //System.Collections namespace

             ArrayList liste = new ArrayList();
            // liste.Add("fatma");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            // //içerisindeki verilere erişim
            // Console.WriteLine(liste[1]);

            // foreach(var item in liste)
            // Console.WriteLine(item);

            // //AddRange
            // Console.WriteLine("***** Add Range *****");
            // string[] renkler = {"kırmızı","sarı","yeşil"};
            List<int> sayilar = new List<int>(){9,6,3,4,5,1,7,2};
            // liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach(var item in liste)
            Console.WriteLine(item);

            //sort
            Console.WriteLine("***** sort *****");
            liste.Sort();
            foreach(var item in liste)
            Console.WriteLine(item);

            //binary search
            Console.WriteLine("binary search");
            Console.WriteLine(liste.BinarySearch(9));

            //reverse
            Console.WriteLine("reverse");
            liste.Reverse();
            foreach(var item in liste)
            Console.WriteLine(item);

            //clear
            liste.Clear();
            foreach(var item in liste)
            Console.WriteLine(item);
        }
    }
}