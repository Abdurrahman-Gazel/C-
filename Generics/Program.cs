using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<string> sehieler = new List<string>();
            sehieler.Add("ANKARA");
            sehieler.Add("ANKARA");
            sehieler.Add("ANKARA");
            sehieler.Add("ANKARA");
            Console.WriteLine(sehieler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            
            sehirler2.Add("ankara");
            sehirler2.Add("ANKARA");
            sehirler2.Add("ANKARA");
            sehirler2.Add("ANKARA");
            sehirler2.Add("ANKARA");
            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T> //Generic class
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length+1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[0] = _tempArray[0];
            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }


    }
}
