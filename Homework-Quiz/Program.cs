using System;

namespace Homework_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 19 ;
            var result = x > y ? "X BÜYÜK" :
                x < y ? "Y BÜYÜK" :
                    x == y ? "X VE Y EŞİT" :
                    "HATA";

            Console.WriteLine(result);
        }
    }
}
