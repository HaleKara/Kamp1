using System;

namespace Kamp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] urunler = new string[] { "kalem", "kağıt","defter","yaprak" };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i]) ;
            }
            Console.WriteLine("for bitti");
            foreach (string  urun in urunler)
            {
                Console.WriteLine(urun);
            }
        }
    }
}
