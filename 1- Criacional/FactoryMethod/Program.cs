using System;
using FactoryMethod.Factories;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Transport transport = null;
            int opcao;

            System.Console.WriteLine("=== UBER ===");
            System.Console.WriteLine("1- Carro");
            System.Console.WriteLine("2- Moto");
            System.Console.WriteLine("3- Bicicleta");
            opcao =  Convert.ToInt32(Console.ReadLine());


            if (opcao == 1)
            {
                transport = new CarTransport();
            } 
            else if(opcao == 2)
            {
                transport = new MotorcycleTransport();
            }
            else if(opcao == 3)
            {
                transport = new BikeTransport();
            }
            else
            {
                System.Console.WriteLine("Selecione o tipo de serviço.");
            }

            if(transport != null)
            {
                transport.StartTransport();
            }

            Console.ReadKey();
        }
    }    
}