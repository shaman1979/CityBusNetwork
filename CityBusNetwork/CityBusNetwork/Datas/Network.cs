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
        private RouteCircularLinkedList routes;

        public Network(RouteCircularLinkedList routes)
        {
            this.routes = routes;
        }

        /// <summary>
        /// Добавление маршрута в сеть
        /// </summary>
        /// <param name="route">Маршрут</param>
        public void AddRoute(Route route)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Добавление маршрутов в сеть
        /// </summary>
        /// <param name="routes">Список маршрутов</param>
        public void SetRoutes(RouteCircularLinkedList routes)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Количество автобусов на определенном маршруте
        /// </summary>
        /// <param name="routeNumber">Номер маршрута</param>
        /// <returns>Количество автобусов</returns>
        public int GetBusCountOnRoute(int routeNumber)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Количество автобусов во всей сети
        /// </summary>
        /// <returns>Количество автобусов</returns>
        public int GetAllBusCount()
        {
            throw new NotImplementedException();
        }
    }
}
