using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention. methodlar büyük 
        public void Ekle(Product urun)
        {
            Console.WriteLine( "Tebrikler. Sepete eklendi.: " + urun.Adi );
        }

        public void Ekle2(string urunAd,string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi.: " + urunAd);
        }
    }
}
