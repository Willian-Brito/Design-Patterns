using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    public class Drone : IAircraft
    {
        public void CheckWind()
        {
            System.Console.WriteLine("Verificando os ventos, 10KM");
        }

        public void GetCargo()
        {
            System.Console.WriteLine("Entrega ok. Ligando as helices do drone");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            System.Console.WriteLine("Iniciando a entrega por drone!!");
        }
    }
}