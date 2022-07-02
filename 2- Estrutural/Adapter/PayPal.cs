using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter
{
    public class PayPal : IPaypalPyment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            token = AuthToken();
            System.Console.WriteLine("Enviando pagamento com PayPal");
        }   

        public void PayPalReceive()
        {
            token = AuthToken();
            System.Console.WriteLine("Recebendo pagamento com PayPal");
        }
    }
}