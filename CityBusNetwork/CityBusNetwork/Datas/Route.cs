using CityBusNetwork.Collections;
using System;
using System.Text;

namespace CityBusNetwork.Datas
{
    /// <summary>
    /// Маршрут
    /// </summary>
    public class Route
    {
        /// <summary>
        /// Номер маршрута
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// Очередь из автобусов 
        /// </summary>
        public BusesQueue Buses { get; private set; } 

        public Route(int number, BusesQueue buses)
        {
            Number = number;
            Buses = buses;
        }
        
        /// <summary>
        /// Добавить автобус на маршрут
        /// </summary>
        /// <param name="bus">Автобус</param>
        public void AddBus(Bus bus)
        {
            Buses.Enqueue(bus);
        }

        /// <summary>
        /// Первый автобус
        /// </summary>
        /// <returns></returns>
        public Bus GetFirstBus()
        {
            return Buses.FirstElement();
        }

        /// <summary>
        /// Последний автобус
        /// </summary>
        /// <returns></returns>
        public Bus GetLastBus()
        {
            return Buses.LastElement();
        }

        /// <summary>
        /// Удаление автобуса из маршрута
        /// </summary>
        /// <param name="bus"></param>
        public void Remove(Bus bus)
        {
            Buses.Remove(bus);
        }

        /// <summary>
        /// Общее количество автобусов на маршруте
        /// </summary>
        /// <returns>Количество</returns>
        public int BusCount()
        {
            return Buses.GetCount();
        }
    }
}
