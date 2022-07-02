using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChainOfResponsability.Servers;

namespace ChainOfResponsability.Middlewares
{
    public class CheckUserMiddleware : Middleware
    {
        private Server server;

        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }

        public override bool Check(string email, string password)
        {
            if(!server.HasEmail(email))
            {
                System.Console.WriteLine("Email inválido!");
                return false;
            }

            if(!server.IsValidPassword(email, password))
            {
                System.Console.WriteLine("E-mail e/ou Senha inválidos");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}