using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntarfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomer(),
                new OracleServerCustomer(),
                new MysqlServerCustomer()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Update();
            }

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomer());
        }

        private static void IntarfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer()
            {
                Id = 2,
                FirstName = "engin",
                LastName = "bekir",
                Addres = "ankara"
            };
            //Console.WriteLine(customer.Addres);
            Student student = new Student()
            {
                Id = 2,
                FirstName = "ahmet",
                LastName = "derin",
                Department = "computer sciences"
            };
            manager.Add(student);
            manager.Add(customer);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer: IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Addres { get; set; }
    }
    class Student: IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class Worker:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
