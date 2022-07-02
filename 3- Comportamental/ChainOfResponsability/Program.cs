using System;
using ChainOfResponsability.Servers;
using ChainOfResponsability.Middlewares;

namespace ChainOfResponsability
{
    public class Program
    {
        private static Server server;

        public static void Main(string[] args)
        {
            Init();

            bool done;

            do
            {
                Console.Write("Digite o seu e-mail:");
                var email = Console.ReadLine();

                Console.Write("Digite sua senha:");
                var password = Console.ReadLine();

                done = server.Login(email, password);
            }
            while(!done);

            System.Console.ReadKey();
        }

        public static void Init()
        {
            server = new Server();
            server.RegisterUser("master@msystemsoftware.com.br", "fsfdsfdsf@#$%9545");
            server.RegisterUser("user@msystemsoftware.com.br", "123456");

            var middleware = new CheckUserMiddleware(server);

            middleware.LinkWith(new CheckPermissionMiddleware());
            middleware.LinkWith(new CheckWeakPassword());

            server.SetMiddleware(middleware);
        }
    }
}