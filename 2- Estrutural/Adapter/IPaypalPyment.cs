using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IPaypalPyment
    {
        Token AuthToken();
        void PayPalPayment();
        void PayPalReceive();
    }
}