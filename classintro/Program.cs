using System;

namespace classintro
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Kursadi ="c#";
            kurs1.Egitmen = "engin demir";
            kurs1.Izlenmeorani = 70;

            Kurs kurs2 = new Kurs();
            kurs2.Kursadi = "java";
            kurs2.Egitmen = "ahmet alp";
            kurs2.Izlenmeorani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "python";
            kurs3.Egitmen = "sefa bekir";
            kurs3.Izlenmeorani = 80;

            Kurs[] kursler = new Kurs[]
            {
                kurs1,kurs2,kurs3
            };

            foreach (var kurs in kursler)
            {
                Console.WriteLine(kurs.Kursadi + " : " + kurs.Egitmen + " : " + kurs.Izlenmeorani);
            }
        }

        class Kurs
        {
            public string Kursadi { get; set; }
            public string Egitmen { get; set; }
            public int Izlenmeorani { get; set; }

        }
    }
}
