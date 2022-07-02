using System.Net.Http.Headers;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChainOfResponsability.Middlewares;

namespace ChainOfResponsability.Servers
{
    public class Server
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();
        private Middleware middleware;

        public void SetMiddleware(Middleware middleware)
        {
            this.middleware = middleware;
        }

        public bool Login(string email, string password)
        {
            if(middleware.Check(email, password))
            {
                System.Console.WriteLine("Usuário autorizado com sucesso!");
                System.Console.WriteLine("Seja bem-vindo!");
                return true;
            }

            return false;
        }

        public void RegisterUser(string email, string password)
        {
            users[email] = password;
        }

        public bool HasEmail(string email)
        {
            return users.ContainsKey(email);
        }

        public bool IsValidPassword(string email, string password)
        {
            var value = "";

            users.TryGetValue(email, out value);

            return password == value;
        }
    }
}