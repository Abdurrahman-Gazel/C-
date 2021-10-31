using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="engin"},
                new Student{FirstName="salih"},
                new Person{FirstName="derin"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string Addres { get; set; }
    }
    class Student:Person
    {
        public string Depertment { get; set; }
    }
}
