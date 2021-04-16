using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CityBusNetwork.Collections
{
    public class CircularLinkedList<T> : IEnumerable<T> where T : IPresenceUniqueNumber
    {
        private Node<T> head;
        private Node<T> tail;

        public void Add(T data)
        {
            throw new NotImplementedException();
        }

        public void Remove(T data)
        {
            throw new NotImplementedException();
        }

        public bool TryFindElement(int number, out T element)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private class Node<TData> where TData : IPresenceUniqueNumber
        {
            public Node(TData data)
            {
                Data = data;
            }
            public TData Data { get; set; }
            public Node<TData> Next { get; set; }
        }
    }
}
