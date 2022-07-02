using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge.Plataforms
{
    public interface IPlataform
    {
        void ConfigureRMTP();
        void AuthToken();
    }
}