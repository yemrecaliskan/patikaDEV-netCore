using System;
using System.Collections;

namespace odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Soru 1
            //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
            //*Negatif ve numeric olmayan girişleri engelleyin.
            //*Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //*Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            ArrayList asalOlanlar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i+1) + ". pozitif sayıyı giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi>0)
                {
                    if (sayi%2==1)
                    {
                        asalOlanlar.Add(sayi);
                    }
                    else
                    {
                        asalOlmayanlar.Add(sayi);
                    }
                        
                }
                else{
                    Console.WriteLine("Lütfen pozitif ve numeric giriş yapınız.");
                    i--;
                }
            }
            asalOlanlar.Sort();
            asalOlanlar.Reverse();
            asalOlmayanlar.Sort();
            asalOlmayanlar.Reverse();

            Console.WriteLine("*** Asal sayılar ***");
            int topAsalOlan = 0;
            foreach (var item in asalOlanlar)
            {
                Console.WriteLine(item);
                topAsalOlan+=(int)item;        
            }
            Console.WriteLine("*** Asal olmayan sayılar ***");
            int topAsalOlmayan = 0;
            foreach (var item in asalOlmayanlar){
                Console.WriteLine(item);
                topAsalOlmayan+=(int)item;
            }

            Console.WriteLine("Asal olanların sayısı: {0}",asalOlanlar.Count);
            Console.WriteLine("Asal olanların ortalaması: {0}",(topAsalOlan/asalOlanlar.Count));
            Console.WriteLine("Asal olmayanların sayısı: {0}",asalOlmayanlar.Count);
            Console.WriteLine("Asal olanların ortalaması: {0}",(topAsalOlmayan/asalOlmayanlar.Count));
            
            #endregion
            
            
            #region Soru2
            //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            ArrayList sayilar = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i+1) + ". sayıyı giriniz");
                int sayi = int.Parse(Console.ReadLine());
                sayilar.Add(sayi);
            }
            sayilar.Sort();
            
            ArrayList eBuyuk = new ArrayList();
            ArrayList eKucuk = new ArrayList();
            int sayac = 1;
            foreach (var item in sayilar)
            {
                if (sayac <= 3)
                    eKucuk.Add(item);
                else if(sayac >= 18)
                    eBuyuk.Add(item);
                sayac++;
            }
            Console.WriteLine("-- En küçük 3 sayı --");
            int eKucukToplam = 0;
            foreach (var item in eKucuk)
            {
                Console.WriteLine(item);
                eKucukToplam+=(int)item;
            }
            int eKucukOrt = eKucukToplam/eKucuk.Count;
            Console.WriteLine("En küçük 3 sayının ortalaması: {0}",eKucukOrt);

            Console.WriteLine("-- En büyük 3 sayı --");
            int eBuyukToplam = 0;
            foreach (var item in eBuyuk)
            {
                Console.WriteLine(item);
                eBuyukToplam+=(int)item;
            }
            int eBuyukOrt = eBuyukToplam/eBuyuk.Count;
            Console.WriteLine("En küçük 3 sayının ortalaması: {0}",eBuyukOrt);
            Console.WriteLine("En büyük ve en küçük 3 sayının ortalamalarının toplamı : {0}", (eKucukOrt+eBuyukOrt));            
            #endregion
            

            #region Soru 3
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            ArrayList cumleList = new ArrayList();
            Console.WriteLine("Bir cümle yazınız.");
            string cumle = Console.ReadLine();
            string sesli = "aeıioöuüAEIİOÖUÜ";
            int saySesli = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if (sesli.Contains(cumle[i]))
                {
                    saySesli++;
                    cumleList.Add(cumle[i]);
                }
            }
            Console.WriteLine("Cümlede bulunan sesli harf sayısı: {0}", cumleList.Count);
            Console.Write("Cümlede bulunan sesli harfler: ");
            foreach (var item in cumleList)
            {
                Console.Write(item);
            }

            #endregion
            Console.ReadKey();
        }
    }
}
