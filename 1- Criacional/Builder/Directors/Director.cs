using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Builder.Builders;
using Builder.Components;

namespace Builder.Directors
{
    public class Director
    {
        IBuilder builder;        

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructSedanCar()
        {
            builder.SetVehicle(eVehicleType.SEDAN);
            builder.SetEgine(new Engine(2000));
            builder.SetSeats(5);
            builder.SetTransmission(eTransmission.AUTOMATIC);
        }

        public void ConstructTruck()
        {
            builder.SetVehicle(eVehicleType.TRUCK);
            builder.SetEgine(new Engine(4000));
            builder.SetSeats(2);
            builder.SetTransmission(eTransmission.MANUAL);
        }

        public void ConstructSUV()
        {
            builder.SetVehicle(eVehicleType.SUV);
            builder.SetEgine(new Engine(2600));
            builder.SetSeats(5);
            builder.SetTransmission(eTransmission.AUTOMATIC_SEQUENTIAL);
            builder.SetAirbag(new Airbag());
        }
    }
}