using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Konya Karpuzu";

            //liste oluşturduk.
            Product[] products = new Product[] { product1, product2 };
            foreach (var x in products)
            {
                Console.WriteLine(x.Adi + x.Fiyati);
            }
            Console.WriteLine("-----------------Metotlar----------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12); 
        }
    }
}
