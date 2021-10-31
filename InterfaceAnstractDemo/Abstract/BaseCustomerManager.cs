using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAnstractDemo.Abstract;
using InterfaceAnstractDemo.Adapters;
using InterfaceAnstractDemo.Entities;
using MernisServiceReference1;

namespace InterfaceAnstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomercheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("saved to db" + customer.FirstName);
        }

        public void save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
