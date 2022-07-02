using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter
{
    public class MercadoPago : IMercadoPagoPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void Pay()
        {
            token = AuthToken();
            System.Console.WriteLine("Enviando pagamento com MercadoPago");
        }

        public void Receive()
        {
            token = AuthToken();
            System.Console.WriteLine("Recebendo pagamento com MercadoPago");
        }
    }
}