
namespace kalitim
{
    class Program
    {
        static void Main(String[] args)
        {
        TohumluBitkiler tohumluBitki = new TohumluBitkiler();
        tohumluBitki.TohumlaCogalma();

        Kuslar marti = new Kuslar();
        marti.UcarakHareketEdenler();
    }
    }
}
