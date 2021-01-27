using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
   

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Hale Kara";
            kurs1.IzlenmeOrani = 10;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Hale Kara";
            kurs2.IzlenmeOrani = 20;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Hale Burçin Kara";
            kurs3.IzlenmeOrani =30;

            //çok mantıklı değil
            //Console.WriteLine(kurs1.Egitmen +" "+ kurs1.KursAdi );

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kursun adi: " + kurs.KursAdi +  "\nEğitmeni : " + kurs.Egitmen + "\n");
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
}
}
