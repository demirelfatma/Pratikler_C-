namespace sınıf_giris{
    class Program
    {
        static void Main(String[] args)
        {
            // söz dizimi
            // class SınıfAdı
            // {
                // erişim belirleyicisi  veri tipi  özellikAdi;
                // erişim belirleyici geri dönüş tipi MethodAdı(parametre listesi)
                //{
                // metot komutları
                //}
            // }

            // erişim belirleyiciler
            // public 
            // private
            // protected
            // internal
            Calisan calisan1 = new Calisan();
            calisan1.Ad="fatma";
            calisan1.Soyad="demirel";
            calisan1.No=1;
            calisan1.Departman="IT Department";
            calisan1.CalisanListesi();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanListesi()
        {
            Console.WriteLine("çalışanın adı:{0}", Ad);
            Console.WriteLine("çalışanın soyadı:{0}", Soyad);
            Console.WriteLine("çalışanın numarası:{0}", No);
            Console.WriteLine("çalışanın departmanı:{0}", Departman);
        }
    }
}
