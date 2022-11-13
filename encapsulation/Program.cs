
namespace encapsulation
{
    class Program
    {
        static void Main(String[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "heja";
            ogrenci1.Soyisim = "alp";
            ogrenci1.Sinif = 7;
            ogrenci1.No = 125;
            ogrenci1.OgrenciBilgiGoster();

            Ogrenci ogrenci2 = new Ogrenci("arda","art",1,1);
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgiGoster();

        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int no;
        private int sinif;

        public Ogrenci()
        {
        }

        public Ogrenci(string isim, string soyisim, int no, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            No = no;
            Sinif = sinif;
        }

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int No { get => no; set => no = value; }
        public int Sinif { get => sinif;
         set 
         {
            if(value<1)
            {
                Console.WriteLine(" sınıf en az 1 olabilir");
                sinif=1;
            }
            else
            {
                sinif=value;
            }
         }
         }

        public void OgrenciBilgiGoster()
        {
            Console.WriteLine("****** öğrenci bilgileri *******");
            Console.WriteLine("öğrenci adı        :{0}",this.Isim);
            Console.WriteLine("öğrenci soyadı     :{0}",this.Soyisim);
            Console.WriteLine("öğrenci no         :{0}",this.No);
            Console.WriteLine("öğrenci sınıfı     :{0}",this.Sinif);
        }
        public void SinifAtla()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }  
    }
}
