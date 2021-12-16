using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Çalışan 1 ******");
            Calisan calisan1 = new Calisan("Yunus Emre","Çalışkan",2342154,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("**** Çalışan 2 ******");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Aslıhan";
            calisan2.Soyad = "Atıcı";
            calisan2.No = 3453265;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine("**** Çalışan 3 ******");
            Calisan calisan3 = new Calisan("Elif","Bektaş");
            calisan3.CalisanBilgileri();

            Console.ReadKey();
        }
    }
    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman){
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        
        public Calisan(string ad, string soyad){
            this.Ad = ad;
            this.Soyad = soyad;
        }


        public Calisan(){}

        public void CalisanBilgileri(){
            Console.WriteLine("Çalışanın Adı: {0}",Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}",Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}",No);
            Console.WriteLine("Çalışanın Deparmanı: {0}",Departman);
        }
    }
}
