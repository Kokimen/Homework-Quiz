using System;

namespace TaxiQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            int kalmaSüre = 0;
            string aracTürü;
            double ödenecekTutar = 0;
            Console.WriteLine("Araç Türü: 1-Taksi, 2-Minibüs, 3-Ticari");
            Console.WriteLine("Lütfen Araç Türünü Giriniz");
            aracTürü = Console.ReadLine();
            Console.WriteLine("Lütfen Otopark Süresini Giriniz");
            kalmaSüre = Int32.Parse(Console.ReadLine());

            if (aracTürü=="1")
            {
                if (kalmaSüre>1)
                {
                    ödenecekTutar += kalmaSüre * 5 * 1.20;
                }
                
            }
            else if (aracTürü== "2")
            {
                ödenecekTutar += kalmaSüre * 6 * 1.215;
            }
            else if (aracTürü== "3")
            {
                ödenecekTutar += kalmaSüre * 6.5 * 1.25;
            }
            else
            {
                if (aracTürü=="1") 
                { 
                    ödenecekTutar = kalmaSüre * 5; 
                }
                else if (aracTürü=="2")
                {
                    ödenecekTutar = kalmaSüre * 6;
                }
                else if (aracTürü=="3")
                {
                    ödenecekTutar = kalmaSüre * 6.5;
                }
                
            }
            Console.WriteLine("Toplam Borcunuz:{0}", ödenecekTutar);
        }
            
    }
}
