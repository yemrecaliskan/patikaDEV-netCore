using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //                    Canlılar
            //          |                            |
            //       Bitkiler                    Hayvanlar
            //   |           |                |            |
            // Tohumlu    Tohumsuz       Sürüngenler     Kuşlar
            
            Console.WriteLine("**** Tohumlu Bitki ****");
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("**** Martı ****");
            Kuslar marti = new Kuslar();
            marti.Ucmak();

            Console.ReadKey();
        }
    }
}
