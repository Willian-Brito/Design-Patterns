using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Landvehicles;
using AbstractFactory.Aircrafts;

namespace AbstractFactory.Factories
{
    public class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAirCraft()
        {
            return new Drone();
        }

        public ILandvehicles CreateTransportLandVehicles()
        {
            return new Bike();
        }
    }
}