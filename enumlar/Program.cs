
namespace enumlar
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine(Gunler.pazar);
            Console.WriteLine((int)Gunler.cuma);

            int sicaklik = 32;
            if(sicaklik <= (int)HavaSicakligi.Normal)
            {
                Console.WriteLine("dışarı çıkmayın hava soğuk!!");
            }else if(sicaklik == (int)HavaSicakligi.Sicak)
            {
                Console.WriteLine("dışarı çıkmayın hava çok sıcak!!");
            }else
            {
                Console.WriteLine("dışarı çıkabilirsiniz");
            }

        }
    }
    enum Gunler
    {
        pazartesi,
        sali=3,
        carsamba,
        persembe,
        cuma,
        cumartesi,
        pazar
    }
    enum HavaSicakligi
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 50,
        CokSicak = 100
    }
}
