using CityBusNetwork.Datas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CityBusNetwork.Collections
{
    public class RouteCircularLinkedList
    {
        private Node head;
        private Node tail;

        /// <summary>
        /// Добавить марштур в список
        /// </summary>
        /// <param name="data">Маршрут</param>
        public void Add(Route route)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Убрать маршрут из списка
        /// </summary>
        /// <param name="data">Маршрут</param>
        public void Remove(Route route)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Вернуть маршрут из списка
        /// </summary>
        /// <param name="number">Номер маршрута</param>
        /// <param name="element">Возвращаемый маршрут</param>
        /// <returns>true - если маршрут есть в списке, false - если маршрут отсутствует</returns>
        public bool TryFindElement(int number, out Route element)
        {
            throw new NotImplementedException();
        }

        private class Node
        {
            public Node(Route data)
            {
                Data = data;
            }
            public Route Data { get; set; }
            public Node Next { get; set; }
        }
    }
}
