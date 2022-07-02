using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    public class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            System.Console.WriteLine("Verificando os ventos, vento sudeste, ventos ok!");
        }

        public void GetCargo()
        {
            System.Console.WriteLine("Entrega ok. Ligando as helices");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            System.Console.WriteLine("Iniciando a decolagem!!");
        }
    }
}