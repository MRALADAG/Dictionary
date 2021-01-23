using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T>
    {
        T[] elements;
        public MyDictionary()
        {
            elements = new T[0];
        }
        public void Add(T element)
        {
            T[] tempArray = elements;
            elements = new T[elements.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                elements[i] = tempArray[i];
            }
            elements[elements.Length - 1] = element;

        }
    }
}
