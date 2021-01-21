using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; //initialization
            while (a <=20) //condition
            {
                Console.WriteLine("a = {0}", a);

                a=a+2; //increment
            }

            int b = 0;
            while (true)
            {
                Console.WriteLine("b = {0}", b);
                b++;
                if (b > 15)
                    break;
            }
            int c = 1;
            while (c > 0)
            {
                Console.WriteLine("c = {0}", c);
                c++;
            }

        }
    }
}
