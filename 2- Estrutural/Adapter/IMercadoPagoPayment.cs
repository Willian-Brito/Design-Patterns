using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IMercadoPagoPayment
    {
        Token AuthToken();
        void Pay();
        void Receive();
    }
}