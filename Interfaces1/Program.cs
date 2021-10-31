using System;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmpolyeeManager());
        }
    }
    interface IPersonManager
    {
        void Add();
        void Update();
    }
    class CustomerManager: IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("musteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("musteri guncelledi");
        }
    }
    class EmpolyeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("personal eklendi");
        }

        public void Update()
        {
            Console.WriteLine("personal guncelledi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("stayjer guncelledi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }

}
