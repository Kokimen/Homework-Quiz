using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Update();
            }
        }
    }
}
