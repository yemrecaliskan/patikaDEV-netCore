using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Yunus Emre";
            ogrenci.Soyisim = "Çalışkan";
            ogrenci.OgrenciNo = 224;
            ogrenci.Sinif = 4;
            ogrenci.OgrenciBilgileriniGetir();

            Console.WriteLine("\nSınıf Atlat");
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Console.WriteLine(" ");
            Ogrenci ogrenci1 = new Ogrenci("Aslıhan","Atıcı",365,1);
            ogrenci1.OgrenciBilgileriniGetir();

            Console.WriteLine("\nSınıf Düşür");
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
            
            Console.ReadKey();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        { 
            get { return isim; } 
            set { isim = value; } 
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get => sinif; 
            set {
                if(value < 1){
                    Console.WriteLine("Sınıf en az 1 Olabilir!");
                    sinif=1;
                }
                else
                    sinif = value;
                } 
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir(){
            Console.WriteLine("***** Öğrenci Bilgileri *****");
            Console.WriteLine("Öğrenci Adı    : {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No     : {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıf  : {0}", this.Sinif);
        }

        public void SinifAtlat(){
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur(){
            this.Sinif = this.Sinif - 1;
        }

    }
}
