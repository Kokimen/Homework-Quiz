using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;


namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Add(new Customer { Birth = new DateTime(1994, 6, 17), FName = "Burak", SName = "Koktay", NationalityId = "12345678" });
            Console.ReadLine();
        }
    }
}
