using System;

namespace netcore
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisiminizi giriniz:");
            string surname = Console.ReadLine();

            Console.WriteLine($"Merhaba {name} {surname}");
            
            Console.ReadKey();
        }
    }
}
