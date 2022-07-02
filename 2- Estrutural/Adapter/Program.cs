using System;

namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // PayPal payment = new PayPal();
            Payonner payonner = new Payonner();
            MercadoPago mercadoPago = new MercadoPago();
            // IPaypalPyment payment = new PayonnerAdapter(payonner);
            IPaypalPyment payment = new MercadoPagoAdapter(mercadoPago);

            payment.PayPalPayment();
            payment.PayPalReceive();
            // payment.SendPayment();
            // payment.ReceivePayment();

            Console.ReadKey();
        }
    }
}