using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 1. Soru ***");
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            Console.Write("Pozitif bir sayı giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayısını giriniz: ", i + 1);  
                sayiDizisi[i] = int.Parse(Console.ReadLine()); 
            }
            foreach (var sayi in sayiDizisi)
            {
                if(sayi %2 == 0)
                    Console.WriteLine(sayi);               
            }  

            Console.WriteLine("*** 2. Soru ***");
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.Write("Pozitif bir sayı giriniz: ");
            Console.Write("Pozitif birinci sayıyı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Pozitif ikinci sayıyı giriniz: ");
            int m = int.Parse(Console.ReadLine());

            int[] nDizisi = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                nDizisi[i] = int.Parse(Console.ReadLine());
            }

            foreach (var nSayi in nDizisi)
            {
                if(nSayi % m == 0|| nSayi == m)
                    Console.WriteLine(nSayi);
            }

            Console.WriteLine("*** 3. Soru ***");
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.Write("Pozitif bir sayı giriniz: ");
            int adet = int.Parse(Console.ReadLine());
            Console.WriteLine($"{adet} adet kelime giriniz;");
            string[] kelimeler = new string[adet];
            for(int i = 0; i < adet; i++)
            {
                Console.Write("Lütfen {0}. kelimeyi giriniz: ", i + 1);
                kelimeler[i] = Console.ReadLine();
            }
            Array.Reverse(kelimeler);
            foreach (var kelime in kelimeler)
                Console.WriteLine(kelime);

            Console.WriteLine("*** 4. Soru ***");
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.Write("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            string[] cumleler = cumle.Split(" ");
            Console.WriteLine("Kelime Sayısı: " + cumleler.Length);
            int sayac = 0;
            foreach (var kelimeS in cumleler)
            { 
                sayac += kelimeS.Length;           
            }
            Console.WriteLine(sayac);
            
            Console.ReadKey();
        }
    }
}
