
namespace kalitim
{
    public class Hayvanlar:Canli
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon yapar");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("hayvanlar temasa tepki verir");
        }
    }
    public class Surungenler:Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
        }
        public void SurunerelHareketEdenler()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder");
        }
    }
    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            base.UyaranlaraTepki();
        }
        public void UcarakHareketEdenler()
        {
            Console.WriteLine("Kuşlar uçarak hareket eder");
        }
    }
}