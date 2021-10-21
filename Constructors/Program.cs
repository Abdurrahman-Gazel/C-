using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1 , FirstName="engin",LastName= "demo",City="ankara" };

            Customer customer2 = new Customer { Id = 2, FirstName = "engin", LastName = "demo", City = "ankara" };

            Customer customer3 = new Customer(2 , "demir", "kadri","istanbul");

            Console.WriteLine(customer3.LastName);
           
        }

    }

    class Customer
    {
        public Customer()
        {

        }
        //Default constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string City { get; set; }

    }
}
