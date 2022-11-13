
namespace kalitim
{
    public class Canli
    {
        public void Beslenme()
        {
            Console.WriteLine("tüm canlılar beslenir");
        }
        public void Solunum()
        {
            Console.WriteLine("tüm canlılar solunum yapar");
        }
        public void Bosaltim()
        {
            Console.WriteLine("tüm canlılar boşaltım yapar");
        }
        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("canlılar uyaranlara tepki verir");
        }
    }
}