using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    public class Bike : IVehicle
    {
        public void GetCargo()
        {
            System.Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            System.Console.WriteLine("iniciamos a entrega utilizando uma bicicleta.");
        }
    }
}