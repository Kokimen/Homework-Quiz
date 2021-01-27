using System;

namespace Constructors
{
    class Program
    //constructor, yapıcı blok, bir classı newlediğimiz zaman bir defaya mahsusçalışan bloktur
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName="Engin", LastName="Demiroğ", City = "Ankara" };
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara"); //normal parantez varsa metot demek

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        public Customer() //bu customer1'in çalışmasını sağlar
        {

        }
        //default constructor
        public Customer(int id, string firstName, string lastName, string city) //bu customer2'nin çalışmasını sağlar
        {
            Console.WriteLine("Constructor Block Worked");
            FirstName = firstName; //classtan gelen FirstName'yi ctor'daki firstName'ye adresledik
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
