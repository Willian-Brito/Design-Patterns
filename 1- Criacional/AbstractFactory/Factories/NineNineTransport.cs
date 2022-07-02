using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    public class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAirCraft()
        {
            return new Helicopter();
        }

        public ILandvehicles CreateTransportLandVehicles()
        {
            return new Motorcycle();
        }
    }
}