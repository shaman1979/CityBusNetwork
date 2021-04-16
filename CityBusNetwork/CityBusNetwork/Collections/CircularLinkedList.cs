using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusNetwork.Collections
{
    public class CircularLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        private class Node<TData>
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
