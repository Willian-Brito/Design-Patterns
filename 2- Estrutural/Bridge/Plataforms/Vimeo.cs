using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge.Plataforms
{
    public class Vimeo : IPlataform
    {
        public Vimeo()
        {
            ConfigureRMTP();
            System.Console.WriteLine("Vimeo: Transmissão iniciada");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            System.Console.WriteLine("Vimeo: Configurando servidor RMTP");
        }

        public void AuthToken()
        {
            System.Console.WriteLine("Vimeo: Autorizando aplicação");
        }
    }
}