using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,Y>
    {
        T[] key; Y[] value;
        T[] tempkey; Y[] tempvalue;

        public MyDictionary()
        {
            key = new T[0];
            value = new Y[0];
        }

        public void Add(T key, Y value)
        {
            tempkey = this.key;
            tempvalue = this.value;

            this.key = new T[this.key.Length + 1];
            this.value = new Y[this.value.Length + 1];

            for (int i = 0; i < tempvalue.Length; i++)
            {
                this.value[i] = tempvalue[i];
            }
            for (int i = 0; i < tempkey.Length; i++)
            {
                this.key[i] = tempkey[i];
            }
            this.key[this.key.Length - 1] = key;
            this.value[this.value.Length - 1] = value;

        }

        public int Length()
        {
            return this.key.Length;
        }

    }
}
