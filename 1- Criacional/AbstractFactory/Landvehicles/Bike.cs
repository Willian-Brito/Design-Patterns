using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    public class Bike : ILandvehicles
    {
        public void GetCargo()
        {
            System.Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            System.Console.WriteLine("Iniciando a entrega de bicicleta.");
        }
    }    
}