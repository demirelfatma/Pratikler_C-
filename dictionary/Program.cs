using System;

using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(String[] args)
        {
            //System.Collections.Generic;
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(12,"fatma demirel");
            kullanıcılar.Add(32,"mehmet büyük");
            kullanıcılar.Add(17,"medeni erdem");
            kullanıcılar.Add(45,"meri alan");

            //dizinin elemanlarına erişim
            Console.WriteLine("**** elemanlara erişim ****");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
            Console.WriteLine(item);

            //count
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("zikriy ee"));

            //remove
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
            Console.WriteLine(item);

            //keys
            foreach (var item in kullanıcılar.Keys)
            Console.WriteLine(item);
            //values
            foreach (var item in kullanıcılar.Values)
            Console.WriteLine(item);
        }
    }
}
