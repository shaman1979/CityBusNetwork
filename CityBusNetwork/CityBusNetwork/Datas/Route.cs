using CityBusNetwork.Collections;
using System;
using System.Text;

namespace CityBusNetwork.Datas
{
    public class Route
    {
        public int Number { get; private set; }
        public BusesQueue Buses { get; private set; } 

        public Route(int number)
        {
            Number = number;
        }
        
        /// <summary>
        /// Добавить автобус на маршрут
        /// </summary>
        /// <param name="bus">Автобус</param>
        public void AddBus(Bus bus)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Общее количество автобусов на маршруте
        /// </summary>
        /// <returns>Количество</returns>
        public int BusCount()
        {
            throw new NotImplementedException();
        }
    }
}
