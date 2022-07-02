using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge.Plataforms
{
    public class TwitchTV : IPlataform
    {
        public TwitchTV()
        {
            ConfigureRMTP();
            System.Console.WriteLine("TwitchTV: Transmissão iniciada");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            System.Console.WriteLine("TwitchTV: Configurando servidor RMTP");
        }

        public void AuthToken()
        {
            System.Console.WriteLine("TwitchTV: Autorizando aplicação");
        }
    }
}