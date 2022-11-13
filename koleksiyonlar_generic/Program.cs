using System;

namespace koleksiyonlar_generic
{
    class Program
    {
        static void Main(String[] args)
        {
            //List<T> class
            //System.Collection.Generic
            //T object türündendir

            List<int> sayiListesi = new List<int>{};
            sayiListesi.Add(25);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(52);
            
            List<string> renkListesi = new List<string>{};
            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("sarı");
            renkListesi.Add("yeşil");

            //count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.Foreach ile elemanlara erişim
            foreach(var sayi in sayiListesi)
            Console.WriteLine(sayi);

            foreach(var renk in renkListesi)
            Console.WriteLine(renk);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("yeşil");
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //liste içerisinde arama
            if(sayiListesi.Contains(10))
            
                Console.WriteLine("10 listede bulundu");
            
            //eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("turuncu"));

            //diziyi listeye çevirme
            string[] hayvanlar  = {"kedi","köpek","kuş"};

            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //listeyi nasıl temizleriz
            hayvanlarListesi.Clear();

            //list içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "ayşe";
            kullanici1.Soyisim = "yılmaz";
            kullanici1.Yas=12;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "bora";
            kullanici2.Soyisim = "demir";
            kullanici2.Yas=34;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){                
                Isim="deniz",
                Soyisim="yıldız",
                Yas=23
        });
        foreach ( var kullanici in kullaniciListesi)
        {
            Console.WriteLine("kullanıcı adı: "+kullanici.Isim);
            Console.WriteLine("kullanıcı soyadı: "+kullanici.Soyisim);
            Console.WriteLine("kullanici yaşı: "+kullanici.Yas);
        }
        }
    }
    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim{get => isim; set => isim=value;}

        public string Soyisim{get => soyisim; set => soyisim=value;}

        public int Yas{get => yas; set => yas=value;}
    }
}
