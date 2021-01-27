using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("Bitki", "Lale");
            dictionary.Add("Hayvan", "Balina");
            Console.WriteLine(dictionary.Count);
           
        }
    }
}
