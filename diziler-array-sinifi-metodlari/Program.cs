using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Array Sort Metodu ***");
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};
            Console.WriteLine("*Sırasız Dizi*");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Sort: sayiDizisi elemanlarını küçükten büyüğe sıralar.
            Console.WriteLine("*Sıralı Dizi*");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("*** Array Clear Metodu ***");
            //Clear: sayiDizisi elemanlarını kullanarak 2.indexten itibaren 2 tane elemanı 0'lar.
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            Console.WriteLine("*** Array Reverse Metodu ***");
            //Reverse: sayiDizisi elemanlarını sırasını tersine çevirir.
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            Console.WriteLine("*** Array IndexOf Metodu ***");
            //IndexOf: sayiDizisi elemanlarından 23 olan elemanın indexini gösterir.
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            Console.WriteLine("*** Array Resize Metodu ***");
            //Resize: sayiDizisi boyutunu arttırarak yeni bir elemena eklemek.
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.ReadKey();
        }
    }
}
