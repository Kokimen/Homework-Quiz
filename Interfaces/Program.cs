using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            Student student = new Student();
            manager.Add(new Customer { Id = 1, FirstName = "Ekmek", LastName = "Çavdarlı" });
            manager.Add(new Student { Id = 1, FirstName = "Döner", LastName = "Tavuk", Departmant = "Fast Food" });
            Console.ReadLine();
        }

        interface IPerson //temel nesne oluşturup diğerlerine entegre edilir
        {
            int Id { get; set; } //bütün herkesin numarası vardır
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.LastName);
            }
        }
    }
}
