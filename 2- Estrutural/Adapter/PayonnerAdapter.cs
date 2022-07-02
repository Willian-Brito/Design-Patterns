using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter
{
    public class PayonnerAdapter : IPaypalPyment
    {
        private Payonner payonner;

        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner;
            System.Console.WriteLine("Realizando adaptação de Payonner para os métodos do PayPal");
        }

        public Token AuthToken()
        {
            return this.payonner.AuthToken();
        }

        public void PayPalPayment()
        {
            this.payonner.SendPayment();
        }   

        public void PayPalReceive()
        {
            this.payonner.ReceivePayment();            
        }
    }
}