using System;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15;
            //switch statement
            switch (x)
            {
                case 5:
                    Console.WriteLine("Value of X is 5");
                    break;
                case 10:
                    Console.WriteLine("Value of X is 10");
                    break;
                case 15:
                    Console.WriteLine("Value of X is 15");
                    break;
                default:
                    Console.WriteLine("Unknown Value");
                    break;
            }

            //switch statement
            double y = 1209393;
            switch (y % 2)
            {
                case 0:
                    Console.WriteLine($"{y} is an even value"); //dolar işareti string'in kısaltılmış hali
                    break;
                case 1:
                    Console.WriteLine($"{y} is an odd value");
                    break;
            }

            //switch case
            string statementType = "ternary";
            switch (statementType)
            {
                case "if.else":
                    Console.WriteLine("if....else statement");
                    break;
                case "ternary":
                    Console.WriteLine("Ternary operator");
                    break;
                case "switch":
                    Console.WriteLine("switch statement");
                    break;
            }

            //multiple cases with break keyword
            int z = 3;
            switch (z)
            {
                case 1:
                    Console.WriteLine("z=1");
                    break;
                case 2:
                    Console.WriteLine("z=2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("z=3 or z=4");
                    break;
                default:
                    Console.WriteLine("z > 4");
                    break;
            }
            //multiple cases with return keyword
            {
                var t = 126;

                Console.Write(isOdd(t) ? "Even value" : "Odd value");
            }

            static bool isOdd(int t)
            {
                switch (t % 2)
                {
                    case 0:
                        return true;
                    case 1:
                        return false;
                }

                return false;
            }
        }   
            
           
    }
}
