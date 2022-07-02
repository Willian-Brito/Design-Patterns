using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Builder.Products;
using Builder.Components;

namespace Builder.Builders
{
    public interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();
        void SetSeats(int seats);
        void SetEgine(Engine engine);
        void SetTransmission(eTransmission transmission);
        void SetVehicle(eVehicleType vehicleType);        
        void SetAirbag(Airbag airbag);     
    }
}