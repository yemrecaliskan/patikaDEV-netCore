using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";
            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken," Merhaba!"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,true)); //Büyük küçük harf duyarlı
            Console.WriteLine(String.Compare(degisken,degisken2,false)); //Büyük küçük harf duyarsız

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS")); //ilk index
            Console.WriteLine(degisken.IndexOf("Yunus")); //bulamazsa -1 döner.

            //LastIndexOf
            Console.WriteLine(degisken.LastIndexOf("i")); //son index

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));

            //PadLeft,PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30)); //karakter sayısı + 30 boşluk
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*')); //karakter sayısı + 30 *
            Console.WriteLine(degisken.PadRight(50)+degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10)); //10.indexten sonrasını sil.
            Console.WriteLine(degisken.Remove(5,3)); //5.indexten sonra 3 karakter sil.
            Console.WriteLine(degisken.Remove(0,1)); //0.indexten sonra 1 karakter sil.

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]); //boşluğa göre diziye ekle 1.indexi getir.

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
            Console.ReadKey();
        }
    }
}
