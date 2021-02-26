using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(20);
            //Console.WriteLine(result);
            //Console.ReadLine();

            //int n1 = 20;
            //int n2 = 100;
            //var result2 = Add3(ref n1, n2); //out, metodun içinde set edilmiş olması yeterlidir, başka bir yerde değer girilmesine gerek duymaz
            //Console.WriteLine(result2);
            //Console.WriteLine(n1);
            //Console.ReadLine();

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2, 4, 4));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int n1 = 10, int n2 = 10) //void, git şunu yap, git şunu kaydet, yaz anlamına gelmektedir
                                                  //burada yazılan 10 default parametre olarak kalır yukarıda number2 için değer verilmezse, default değer 10 çalışır
        {
            var result = n1 + n2;
            return result;
        }

        static int Add3(ref int n1, int n2) //ref, değer tiplerinin referans tipi olarak kullanılmasını sağlar
        {
            n1 = 30;
            return n1 + n2;
        }

        static int Multiply(int n1, int n2) 
        {
            return n1 * n2;
        }
        static int Multiply(int n1, int n2,int n3) //aynı isimle kullanılabiliyorlar buna method overload denir, methodların aşırı yüklenmesi
        {
            return n1 * n2 * n3;
        }
        static int Add4(params int[] numbers) //istediğin kadar sayıya işlem uygular
        {
            return numbers.Sum(); //bu kod çalışmıyor, muhtemelen kitaplık yüklü değil
        }
    }
}
