using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("ahmet", 7);
            myDictionary.Add("ahmet", 7);
            myDictionary.Add("ahmet", 7);
            myDictionary.Add("ahmet", 7);
            myDictionary.Add("ahmet", 7);

            Console.WriteLine(myDictionary.Length());
        }
    }
}
