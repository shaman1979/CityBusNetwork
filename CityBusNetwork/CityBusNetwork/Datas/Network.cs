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
    }
}
