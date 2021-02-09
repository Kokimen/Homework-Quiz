using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerCheckService
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine("Saved to db: " + customer.FName );
        }

        public void CheckRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
