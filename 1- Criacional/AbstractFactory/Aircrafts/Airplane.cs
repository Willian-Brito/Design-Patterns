using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    public class Airplane : IAircraft
    {
        public void CheckWind()
        {
            System.Console.WriteLine("Verificando os ventos, a 25km, ventos ok!");
        }

        public void GetCargo()
        {
            System.Console.WriteLine("Passageiros a bordo, vôo autorizado");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            System.Console.WriteLine("Iniciando decolagem.");
        }
    }
}