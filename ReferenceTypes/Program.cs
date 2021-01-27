using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);

            Customer customer1 = new Customer();
            customer1.FirstName = "Salih";
            customer1.CreditCardNumber = "12345678";

            Person person3 = customer1;
            customer1.FirstName = "Ahmet";
            Console.WriteLine(((Customer)person3).CreditCardNumber); //boxing

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }
    }

    class Person //base class, temel sınıf, başka classlar bunun adresini referans olarak atayabilirler
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person //personın classtaki bilgilerini içerecek, buna inheritance denir, sınıftan miras almak
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee: Person //personın classtaki bilgilerini içerecek, buna inheritance denir, sınıftan miras almak
    { 
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) //hem customer gönderilir hem person gönderilir hem employee gönderilir, çünkü bütün classlar person mirasına sahip
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
