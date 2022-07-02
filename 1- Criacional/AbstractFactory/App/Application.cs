using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;
using AbstractFactory.Factories;

namespace AbstractFactory.App
{
    public class Application
    {
        #region Propriedades da Classe
        private IAircraft airCraft;
        private ILandvehicles vehicle;
        #endregion

        #region Construtor
        public Application(ITransportFactory factory)
        {
            airCraft = factory.CreateTransportAirCraft();
            vehicle =  factory.CreateTransportLandVehicles();
        }
        #endregion

        #region Metodos
        public void StartRoute()
        {
            vehicle.StartRoute();
            airCraft.StartRoute();
        }
        #endregion        
    }
}