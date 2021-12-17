﻿using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı : {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Yunus Emre","Çalışkan","Yazılım");
            Console.WriteLine("Çalışan Sayısı : {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Aslıhan","Atıcı","İK");
            Calisan calisan2 = new Calisan("Elif","Bektaş","Laboratuvar");
            Console.WriteLine("Çalışan Sayısı : {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu : {0}", Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu : {0}", Islemler.Cikar(500,100));

            Console.ReadKey();
        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi;}
        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calisan(){
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyisim, string departman){
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler{
        public static long Topla(int sayi1,int sayi2){
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1,int sayi2){
            return sayi1 - sayi2;
        }
    }
}
