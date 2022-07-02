using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    public interface ITransportFactory
    {
        IAircraft CreateTransportAirCraft();
        ILandvehicles CreateTransportLandVehicles();
    }
}