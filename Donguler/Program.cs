using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "c#";
            string kurs2 = "java";
            string kurs3 = "python";
            string kurs4 = "javascript";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            string[] kursler = new string[] {"c#","java","python","javascript","c++"};

            for (int i = 0; i < kursler.Length; i++)
            {
                Console.WriteLine(kursler[i]);
            }
            foreach (string kurs in kursler)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
