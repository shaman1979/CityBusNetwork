using CityBusNetwork.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusNetwork.Datas
{
    public class Network
    {
        private CircularLinkedList<Route> routes;

        public Network(CircularLinkedList<Route> routes)
        {
            this.routes = routes;
        }   

        public void AddRoute(Route route)
        {
            throw new NotImplementedException();
        }

        public void SetRoutes(CircularLinkedList<Route> routes)
        {
            throw new NotImplementedException();
        }

        public int GetBusCountOnRoute(int routeNumber)
        {
            throw new NotImplementedException();
        }

        public int GetAllBusCount()
        {
            throw new NotImplementedException();
        }
    }
}
