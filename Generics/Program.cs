using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehirler = new MyList<string>();
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            Console.WriteLine(sehirler.Count);
        }
    }
    class MyList<T> //Generic Class
    {
        T[] array;
        T[] tempArray;
        public MyList()
        {
            array = new T[0];
        }
        public void Add(T item)
        {
            tempArray = array;
            array = new T[array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }
            array[array.Length - 1] = item;
        }

        public int Count
        {
            get { return array.Length; }  
        }

    }
}
