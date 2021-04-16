using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusNetwork.Datas
{
    public class Route : IPresenceUniqueNumber
    {
        public int Number { get; private set; }
        public Queue<Bus> Buses { get; private set; } 

        public Route(int number)
        {
            Number = number;
        }

        public void AddBus(Bus bus)
        {
            throw new NotImplementedException();
        }

        public int BusCount()
        {
            throw new NotImplementedException();
        }
    }
}
