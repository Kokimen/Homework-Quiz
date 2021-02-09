using System;

namespace Inheritance //kalıtım, miras, yalnızca bir kere inheritance olur ama birden fazla interface olabilir, inheritance(miras) ile interface'nin farkı
{                     //interface- tek başına anlamı yoktur, inheritance tek başına anlamı vardır
                      //ne zaman inheritance, interface? - interface inheritance mantığıyla kullanılabilir, abstract classlarda inheritance büyük önem taşır
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FName="Hülya" }, new Student{FName="Mehmet" }, new Person{FName="Tarık" }
            };

            foreach (var person in persons)

            {
                Console.WriteLine(person.FName);
                
            }
            Console.ReadLine();
        }
    }
    class Person2
    {

    }

    class Person
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }

    }

    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {
        public string Departmant { get; set; }
    }
}
