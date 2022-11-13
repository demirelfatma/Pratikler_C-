
namespace static_sinif
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("çalışan sayısı:   {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("ahmet","çevik","İK");
            Console.WriteLine("çalışan sayısı:   {0}", Calisan.CalisanSayisi);

            Console.WriteLine("toplama sonucu: {0}",Islemler.Topla(100,23));
            Console.WriteLine("toplama sonucu: {0}",Islemler.Cikar(100,23));
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}
        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }
    }
        static class Islemler
        {
            public static long Topla(int sayı1, int sayı2)
            {
                return sayı1+sayı2;
            }
            public static long Cikar(int sayı1, int sayı2)
            {
                return sayı1-sayı2;
            }
        }
    }

