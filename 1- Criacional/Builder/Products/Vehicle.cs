using Builder.Components;

namespace Builder.Products
{
    public class Vehicle
    {
        #region Propriedades da Classe
        public eVehicleType vehicleType {get; set;}
        public int seats {get; set;}
        public Engine engine {get; set;}
        public Airbag airbag {get; set;}
        public eTransmission transmission {get; set;}
        #endregion
    }
}