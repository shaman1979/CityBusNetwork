using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusNetwork
{
    public class Bus
    {
        public string Number { get; private set; }

        public string LastNameDriver { get; private set; }
        
        public Bus(string number, string lastNameDriver)
        {
            Number = number;
            LastNameDriver = lastNameDriver;
        }
    }
}
