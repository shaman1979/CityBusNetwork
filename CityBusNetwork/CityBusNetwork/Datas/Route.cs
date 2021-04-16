using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusNetwork.Datas
{
    public class Route
    {
        public int Number { get; private set; }
        public Queue<Bus> Buses { get; private set; } 

        public Route(int number)
        {
            Number = number;
        }
    }
}
