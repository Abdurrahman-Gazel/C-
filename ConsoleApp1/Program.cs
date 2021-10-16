using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double dolarbugun = 9.12;
            Double dolardun = 9.14;

            if (dolarbugun>dolardun)
            {
                Console.WriteLine("azalmis butonu");
            }
            else if (dolarbugun <dolardun)
            {
                Console.WriteLine("artmis butonu");
            }
            else
            {
                Console.WriteLine("degimedi butonu");
            }

        }
    }
}
