using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    public class Car : ILandvehicles
    {
        public void GetCargo()
        {
            System.Console.WriteLine("Pegamos os passageiros, estamos prontos");
        }

        public void StartRoute()
        {
            GetCargo();
            System.Console.WriteLine("Iniciando o trageto.");
        }
    }
}