using CityBusNetwork.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusNetwork.Datas
{
    /// <summary>
    /// Сеть маршрутов
    /// </summary>
    public class Network
    {
        public Route Head { get; private set; }
        public Route Tail { get; private set; }

        public void Add(Route route)
        {
            if (Head == null)
            {
                Head = route;
                Tail = route;
                Tail.Next = Head;
            }
            else
            {
                Head.Next = Head;
                Tail.Next = route;
                Tail = route;
            }
        }

        public void Add(Route previous, Route route)
        {
            var current = Find(previous);
            if (current != null)
            {
                var tmp = current.Next;
                current.Next = route;
                route.Next = tmp;
            }
        }

        public bool Remove(Route route)
        {
            var current = Head;
            var previous = new Route();

            do
            {
                if (current.Equals(route))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current == Tail)
                            Tail = previous;
                    }
                    else
                    {
                        Head = current.Next;
                        Tail.Next = current.Next;
                    }
                    return true;
                }

                previous = current;
                current = current.Next;
            } while (current != Head);

            return false;
        }
        
        public Route Find(Route route)
        {
            var current = Head;
            
            while (!current.Equals(route))
            {
                if (current.Equals(Tail))
                {
                    return null;
                }
                
                current = current.Next;
            }

            return current;
        }

        public int GetAllBusesCount()
        {
            var current = Head;
            var sum = 0;
            
            while (current != null && current != Tail)
            {
                sum += current.Count;
            }

            return sum;
        }
    }
}