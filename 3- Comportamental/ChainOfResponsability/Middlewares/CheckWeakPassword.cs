using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    public class CheckWeakPassword : Middleware
    {
        public override bool Check(string email, string password)
        {
            if(password.Equals("123456"))
            {
                System.Console.WriteLine("Sua senha é insegura, por favor troque para uma senha mais segura!");
                return true;
            }

            System.Console.WriteLine("Seja bem-vindo");

            return CheckNext(email, password);
        }
    }
}