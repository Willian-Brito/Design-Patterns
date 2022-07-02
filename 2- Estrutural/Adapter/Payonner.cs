using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter
{
    public class Payonner : IPayonnerPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void SendPayment()
        {
            token = AuthToken();
            System.Console.WriteLine("Enviando pagamento com Payonner");
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            System.Console.WriteLine("Recebendo pagamento com Payonner");
        }
    }
}