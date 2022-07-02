using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge.Plataforms
{
    public class Facebook : IPlataform
    {
        public Facebook()
        {
            ConfigureRMTP();
            System.Console.WriteLine("Facebook: Transmissão iniciada");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            System.Console.WriteLine("Facebook: Configurando servidor RMTP");
        }

        public void AuthToken()
        {
            System.Console.WriteLine("Facebook: Autorizando aplicação");
        }
    }
}