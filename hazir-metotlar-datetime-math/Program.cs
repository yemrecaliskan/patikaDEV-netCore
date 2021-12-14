using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*********** DateTime ***********");
            Console.WriteLine(DateTime.Now); //günün tarih ve saati getir.
            Console.WriteLine(DateTime.Now.Date); //sadece tarih getirir
            Console.WriteLine(DateTime.Now.Day); //sadece gün
            Console.WriteLine(DateTime.Now.Month); //sadece ay
            Console.WriteLine(DateTime.Now.Year); //sadece yıl
            Console.WriteLine(DateTime.Now.Hour); // sadece saat
            Console.WriteLine(DateTime.Now.Minute); //sadece dakika
            Console.WriteLine(DateTime.Now.Second); //sadece saniye

            Console.WriteLine(DateTime.Now.DayOfWeek); //haftanın hangi günü
            Console.WriteLine(DateTime.Now.DayOfYear); //yılın kaçıncı günü

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //14
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sal
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Salı

            Console.WriteLine(DateTime.Now.ToString("MM")); //12
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Ara
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Aralık

            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyy")); //2021

            //MATH
            Console.WriteLine("*********** Math ***********");
            Console.WriteLine(Math.Abs(-25)); //pozitife çevirir.
            Console.WriteLine(Math.Sin(10)); //sin hesaplar
            Console.WriteLine(Math.Cos(10)); //cos hesaplar
            Console.WriteLine(Math.Tan(10)); //tan hesaplar.

            Console.WriteLine(Math.Ceiling(22.3)); //yukarı yuvarlar
            Console.WriteLine(Math.Round(22.3)); //yakına yuvarlar.
            Console.WriteLine(Math.Floor(22.7)); //aşağı yuvarlar.

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4));// 3^4 ü verir.
            Console.WriteLine(Math.Sqrt(9)); //karekök
            Console.WriteLine(Math.Log(9)); //9un e tabanındaki logoritmik karşılığı
            Console.WriteLine(Math.Exp(3)); //e üzeri 3
            Console.WriteLine(Math.Log10(10)); //10'un log10 tabanındaki karşılığı


            Console.ReadKey();
        }
    }
}
