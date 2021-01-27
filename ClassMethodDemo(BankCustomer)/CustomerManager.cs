using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo_BankCustomer_
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.surName + " isimli müşteri eklenmiştir");
                    }

        public void ListCustomers(Customer[] customer)
        {
            foreach (Customer listCustomer in customer)
            {
                
                
                Console.WriteLine("Banka Müşteri Numarası : " + listCustomer.Id);
                Console.WriteLine("Müşteri Adı : " + listCustomer.Name);
                Console.WriteLine("Müşteri Soyadı : " + listCustomer.surName);
                Console.WriteLine("Müşteri Mesleği : " + listCustomer.Job);
                Console.WriteLine("Kaç Yıldır Müşteri : " + listCustomer.Time);
                Console.WriteLine("-------------------------");
                
            }
         }
       public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id + " numaralı " + customer.Name +" " + customer.surName + " isimli müşteri sistemden silinmiştir");
            
        }
    }
}
