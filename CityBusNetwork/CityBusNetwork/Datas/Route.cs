using System;

namespace CityBusNetwork.Datas
{
    public class Route
    {

        public Bus[] buses;

        public Route(int countBus, Route next)
        {
            this.buses = new Bus[countBus];
            Next = next;
        }

        public Route Next { get; set; }

        public int index;

        public void AddBuses(Bus bus)
        {
            if (buses.Length < index)
            {
                Array.Resize(ref buses, buses.Length * 2);
            }

            buses[index] = bus;
            index++;
        }

        public Bus GetBus()
        {
            var currentBus = buses[0];
            Remove();
            return currentBus;
        }

        public void Remove()
        {
            for (int i = 0; i < buses.Length; i++)
            {
                if (i + 1 > buses.Length)
                    break;

                buses[i] = buses[i + 1];
            }

            index--;
        }
        
        public Bus LastBus()
        {
            return buses[index];
        }

        public Bus FirstBus()
        {
            return buses[0];
        }
        
        public int Count => index;
    }
}