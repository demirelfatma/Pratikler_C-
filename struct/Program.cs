using System;

namespace struct_a
{
    class Program
    {
        static void Main(String[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.kısaKenar=3;
            dikdortgen.uzunKenar=4;

            Console.WriteLine("class alan hesabı:  {0}", dikdortgen.AlanHesapla());

            Dikdortgen_struct dikdortgen_Struct= new Dikdortgen_struct(3,4);
            // dikdortgen_Struct.kısaKenar=3;
            // dikdortgen_Struct.uzunKenar=4;

            Console.WriteLine("struct alan hesabı:  {0}", dikdortgen_Struct.AlanHesapla());       
        }
    }
    class Dikdortgen
    {
        public int kısaKenar;
        public int uzunKenar;

        public Dikdortgen()
        {

        }

        public long AlanHesapla()
        {
            return this.kısaKenar*this.uzunKenar;
        }
    }
    struct Dikdortgen_struct
    {
        public int kısaKenar;
        public int uzunKenar;

        public Dikdortgen_struct(int kısaKenar, int uzunKenar)
        {
            this.kısaKenar = kısaKenar;
            this.uzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return this.kısaKenar*this.uzunKenar;
        }
    }
}
