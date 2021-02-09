using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo
{
    public interface ICustomerCheckService
    {
        bool CheckRealPerson(Customer customer);
    }
}
