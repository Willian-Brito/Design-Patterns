using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bridge.Plataforms;

namespace Bridge.Tranmissions
{
    public class Live : ITransmission
    {
        protected IPlataform plataform;

        public Live(IPlataform plataform)
        {
            this.plataform = plataform;
        }

        public void Broadcasting()
        {
            System.Console.WriteLine($"Iniciando a transmissão na {plataform}");
        }

        public void ResultTransmissions()
        {
            System.Console.WriteLine("**** ON AIR ****");
        }
    }
}