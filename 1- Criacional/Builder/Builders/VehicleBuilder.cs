using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Builder.Products;
using Builder.Components;

namespace Builder.Builders
{
    public class VehicleBuilder : IBuilder
    {
        private Vehicle vehicle = new Vehicle();

        public void Reset()
        {
            vehicle = new Vehicle();
        }

        public Vehicle GetVehicle()
        {
            Vehicle vehiclePrevious = vehicle;
            Reset();

            return vehiclePrevious;
        }

        public void SetSeats(int seats)
        {
            vehicle.seats = seats;
        }
        public void SetEgine(Engine engine)
        {
            vehicle.engine = engine;
        }
        public void SetTransmission(eTransmission transmission)
        {
            vehicle.transmission = transmission;
        }
        public void SetVehicle(eVehicleType vehicleType)
        {
            vehicle.vehicleType = vehicleType;
        }

        public void SetAirbag(Airbag airbag)
        {
            vehicle.airbag = airbag;
        }
    }
}