using System;

namespace MethodDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrununAdi = "Elma";
            urun1.UrununFiyati = 10;
            urun1.UrununAciklamasi = "Konya Elması";

            Urun urun2 = new Urun();
            urun2.UrununAdi = "Kiraz";
            urun2.UrununFiyati = 15;
            urun2.UrununAciklamasi = "Ankara Kirazı";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (var x in urunler)
            {
                Console.WriteLine(x.UrununAdi + " " + x.UrununFiyati + " " + x.UrununAciklamasi );
            }

           
        }
    }
}
