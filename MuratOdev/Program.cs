using System;

namespace MuratOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            int girilenSayi;
            Console.WriteLine("Bir Tek Sayı giriniz: ");
            girilenSayi = int.Parse(Console.ReadLine());
            if (girilenSayi % 2 == 0)
            {
                Console.WriteLine("Lütfen tek sayı giriniz: ");
            }
            else
            {
                for (int k = 1; k <= girilenSayi+1; k=k+2)
                {
                    for (int m = 0; m < k; m=m+2)
                    {
                        Console.Write(" ");
                    }
                    for (int i = girilenSayi+1; i > k; i--)
                    {
                        
                        Console.Write("*");
                    }

                    
                    Console.Write("\n");
                }







            }
        }
    }
}
