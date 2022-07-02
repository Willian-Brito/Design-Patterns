using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge.Plataforms
{
    public class YouTube : IPlataform
    {
        public YouTube()
        {
            ConfigureRMTP();
            System.Console.WriteLine("Youtube: Transmissão iniciada");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            System.Console.WriteLine("Youtube: Configurando servidor RMTP");
        }

        public void AuthToken()
        {
            System.Console.WriteLine("Youtube: Autorizando aplicação");
        }
    }
}