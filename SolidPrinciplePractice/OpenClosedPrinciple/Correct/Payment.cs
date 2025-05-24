using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplePractice.OpenClosedPrinciple.Correct
{
    public interface IPayment
    {
        public void PaymentProcess();
    }
    public class CreditCardPayment : IPayment
    {
        public void PaymentProcess()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }

    public class PaypalPayment : IPayment
    {
        public void PaymentProcess()
        {
            Console.WriteLine("Processing Paypal payment.....");
        }
    }

    public class PaymentProcessor
    {
        public void Process(IPayment payment)
        {
            payment.PaymentProcess();
        }
    }
}
