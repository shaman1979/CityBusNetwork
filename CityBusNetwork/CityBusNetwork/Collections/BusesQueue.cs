using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusNetwork.Collections
{
    public class BusesQueue
    {
        private List<Bus> buses = new List<Bus>();

        public int Count { get { return buses.Count; } }

        /// <summary>
        /// Добавление автобуса в очередь
        /// </summary>
        /// <param name="element">Автобус</param>
        public void Push(Bus bus)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Взятие автобуса из очереди
        /// </summary>
        /// <returns></returns>
        public Bus Pop()
        {
            throw new NotImplementedException();
        }
    }
}
