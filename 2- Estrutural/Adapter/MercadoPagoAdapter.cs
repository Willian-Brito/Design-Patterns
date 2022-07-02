using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter
{
    public class MercadoPagoAdapter : IPaypalPyment
    {
        private MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
            System.Console.WriteLine("Realizando adaptação de MercadoPago para os métodos do PayPal");
        }

        public Token AuthToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            this.mercadoPago.Pay();
        }   

        public void PayPalReceive()
        {
            this.mercadoPago.Receive();            
        }
    }
}