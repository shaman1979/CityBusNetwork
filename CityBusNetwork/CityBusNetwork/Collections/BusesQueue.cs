using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusNetwork.Collections
{
    /// <summary>
    /// Очередь
    /// </summary>
    public class BusesQueue
    {
        private List<Bus> buses = new List<Bus>();

        /// <summary>
        /// Возвращение количества автобусов
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Добавление автобуса в очередь
        /// </summary>
        /// <param name="element">Автобус</param>
        public void Enqueue(Bus bus)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Взятие автобуса из очереди
        /// </summary>
        /// <returns></returns>
        public Bus Dequeue()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Взятие автобуса из очереди без удаления 
        /// </summary>
        /// <returns></returns>
        public Bus Peek()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }
    }
}
