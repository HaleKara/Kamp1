using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Hale";
            musteri1.Soyadi = "Kara";
            musteri1.TcNo = "1234566";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "45645";
            musteri2.SirketAdi = "Kodlama";
            musteri2.VergiNo = "2343";



            //Gerçek-Tüzel Müşteri
            //SOLID
           // Hem gerçek hemde tüzel müşterinin referansını tutabilir.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);



        }
    }
}
