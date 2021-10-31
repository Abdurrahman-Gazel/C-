using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAnstractDemo.Abstract;
using InterfaceAnstractDemo.Adapters;
using InterfaceAnstractDemo.Concrete;
using InterfaceAnstractDemo.Entities;
using MernisServiceReference1;

namespace InterfaceAnstractDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer {
                Id = 1,
                FirstName = "abdurrahman",
                LastName = "gazel",
                NationalityId = "99253652708",
                DateOfBirth = new DateTime(1997, 9, 5)
            });
            Console.ReadLine();
        }
    }
}
