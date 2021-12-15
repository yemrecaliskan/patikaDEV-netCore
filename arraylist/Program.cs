using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namepace
            ArrayList liste = new ArrayList();
            // liste.Add("Yunus");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            //içerisindeki verilere erişim
            // Console.WriteLine(liste[1]);
            // foreach (var item in liste)
            //     Console.WriteLine(item);
            
            //AddRange
            Console.WriteLine("*** Add Range ***");
            //string[] renkler = {"Kırmızı","Sarı","Yeşil"};
            List<int> sayilar = new List<int>(){1,5,7,2,9,6,54};
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort
            Console.WriteLine("*** Sort ***");
            liste.Sort();
            foreach (var item in liste)
                Console.WriteLine(item);
            
            //Binary Search
            Console.WriteLine("*** Binary Search ***");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("*** Reverse ***");
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);
            
            //Clear
            Console.WriteLine("*** Clear ***");
            liste.Clear();
            foreach (var item in liste)
                Console.WriteLine(item);



            Console.ReadKey();
        }
    }
}
