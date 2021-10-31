using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAnstractDemo.Abstract;
using InterfaceAnstractDemo.Adapters;
using InterfaceAnstractDemo.Entities;
using MernisServiceReference1;

namespace InterfaceAnstractDemo.Abstract
{
    public interface ICustomercheckService
    {
        public bool CheckIfRealPerson(Customer customer);
    }
}
