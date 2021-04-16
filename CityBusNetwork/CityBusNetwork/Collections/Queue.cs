using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusNetwork.Collections
{
    public class Queue<T>
    {
        private List<T> elements = new List<T>();

        public int Count { get { return elements.Count; } }

        public void Push(T element)
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }
    }
}
