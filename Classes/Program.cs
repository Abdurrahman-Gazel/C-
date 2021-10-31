using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            

            Customer customer = new Customer();
            customer.City = "ankara";
            customer.Id = 4;
            customer.FirstName = "ahmet";
            customer.LastName = "bekir";


            Customer customer2 = new Customer
            {
                 Id = 2 , City = "ankara", FirstName="derin", LastName="demo"
            };

            Console.WriteLine(customer2.LastName);
            Console.ReadLine();

        }
    }    
}
