using System;
using AbstractFactory.App;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    public class Program
    {
        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory;
            string company = "teste";

            if(company == "Uber")
            {   
                transportFactory = new UberTransport();
            }   
            else if (company == "99")
            {
                transportFactory = new NineNineTransport();
            }
            else
            {
                transportFactory = new LimeTransport();
            }

            app = new Application(transportFactory);

            return app;
        }

        public static void Main(string[] args)
        {
            Application app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
        }
    }
}