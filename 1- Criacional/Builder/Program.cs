using System;
using Builder.Builders;
using Builder.Directors;
using Builder.Products;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedanCar();
            Vehicle sedan = builder.GetVehicle();

            director.ConstructTruck();
            Vehicle truck = builder.GetVehicle();

            director.ConstructSUV();
            Vehicle suv = builder.GetVehicle();

            System.Console.WriteLine($"Criando um veículo do tipo {sedan.vehicleType}");
            System.Console.WriteLine($"Criando um veículo do tipo {truck.vehicleType}");
            System.Console.WriteLine($"Criando um veículo do tipo {suv.vehicleType}");

            Console.ReadKey();
        }
    }
}