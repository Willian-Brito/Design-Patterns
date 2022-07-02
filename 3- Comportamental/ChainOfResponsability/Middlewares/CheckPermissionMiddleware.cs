using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    public class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if(email.Equals("master@msystemsoftware.com.br"))
            {
                System.Console.WriteLine("Seja bem-vindo Administrador!");
                return true;
            }

            return CheckNext(email, password);
        }
    }   
}