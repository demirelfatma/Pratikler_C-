
namespace kalitim
{
public class Bitkiler:Canli
{
    public void FotosentezYapmak()
    {
        Console.WriteLine("bitkiler fotosentez yapar");
    }
    public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("bitkiler temasa tepki verir");
        }
}
public class TohumluBitkiler:Bitkiler
{
    public void TohumlaCogalma()
{
    Console.WriteLine("Tohumlu Bitkiler tohumla çoğalır");
}
}
public class TohumsuzBitkiler:Bitkiler
{
    public void SporlalaCogalma()
{
    Console.WriteLine("Tohumlu Bitkiler sporla çoğalır");
}
}
}