using System;

namespace ClassMethodDemo_BankCustomer_
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Id = 1;
            c1.Name = "Cahit";
            c1.surName = "Aydın";
            c1.Job = "Doktor";
            c1.Time = 9;

            Customer c2 = new Customer();
            c2.Id = 2;
            c2.Name = "Özlem";
            c2.surName = "Taştan";
            c2.Job = "Öğretmen";
            c2.Time = 3;

            Customer[] customers = new Customer[] { c1, c2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.ListCustomers(customers);
            Console.WriteLine("Müşteriler Listelenmiştir");
            customerManager.AddCustomer(c1);
            customerManager.DeleteCustomer(c2);
            

        }

        
    }
}
