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

        /// <summary>
        /// Первый элемент 
        /// </summary>
        /// <returns></returns>
        public Bus FirstElement()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Последний элемент 
        /// </summary>
        /// <returns></returns>
        public Bus LastElement()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удаление элемента
        /// </summary>
        /// <param name="bus"></param>
        public void Remove(Bus bus)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }
    }
}
