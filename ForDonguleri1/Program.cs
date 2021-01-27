using System;

namespace ForDonguleri1
{
    class Program
    {
        static void Main(string[] args)
        {
            //class a ait objeleri oluşturuyoruz.
            Urun urun1 = new Urun();
            urun1.urunAdi = "Evony";
            urun1.urunKategorisi = "Sağlık";
            urun1.urunSatıcısı = "Hayat Kimya";
            urun1.urunFiyatı = 10.5;
            urun1.urunYorumları = "Başarılı";

            Urun urun2 = new Urun();
            urun2.urunAdi = "BMW";
            urun2.urunKategorisi = "Otomobil";
            urun2.urunSatıcısı = "Mengerler OTO";
            urun2.urunFiyatı = 100000.555;
            urun2.urunYorumları = "Güzel";

            //diziye bu objeleri atıyoruz foreachle her birini yazdırıyoruz.

            Urun[] urunler = new Urun[] { urun1, urun2 }; //Urun class ından liste oluşturduk. Listenin üyeleri yukarıda oluşturduğumuz nesneler
            foreach (var u in urunler)
            {
                Console.WriteLine("Ürün adı: "  + u.urunAdi + "\n" + "Ürün Kategorisi: " + u.urunKategorisi + "\n" + "Ürün Fiyatı: " + u.urunFiyatı +"\n" + "Ürünün Satıcısı:" + u.urunSatıcısı + "\n" + "Ürünün Yorumları: " + u.urunYorumları + "\n");
            }
            




        }
    }
    class Urun //burada yeni bir class oluşturuyoruz. urune ait özellikleri giriyoruz
    {
        public string urunAdi { get; set; }
        public string urunKategorisi { get; set; }
        public double urunFiyatı { get; set; }
        public string urunYorumları { get; set; }
        public string urunSatıcısı { get; set; }
    }
}
