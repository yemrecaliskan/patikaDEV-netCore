using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            // {
            //     [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            //     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //     {
            //         Metot Kommutları
            //     }
            // }
            //Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Yunus Emre";
            calisan1.Soyad = "Çalışkan";
            calisan1.No = 2342154;
            calisan1.Deparman = "İnsan Kaynakaları";
            calisan1.CalisanBilgileri();

            Console.WriteLine("**********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Aslıhan";
            calisan2.Soyad = "Atıcı";
            calisan2.No = 3453265;
            calisan2.Deparman = "Satın Alma";
            calisan2.CalisanBilgileri();

            Console.ReadKey();
        }
    }

    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Deparman;
        public void CalisanBilgileri(){
            Console.WriteLine("Çalışanın Adı: {0}",Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}",Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}",No);
            Console.WriteLine("Çalışanın Deparmanı: {0}",Deparman);
        }
    }
}
