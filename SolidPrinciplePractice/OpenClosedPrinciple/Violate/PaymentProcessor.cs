using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplePractice.OpenClosedPrinciple.Violate
{
    public class PaymentProcessor
    {

        public void PaymentProcess(string paymentType)
        {
            if(paymentType == "CreditCard")
            {
                Console.WriteLine("Processing Credit card payment.....");
            }
            else if(paymentType == "Paypal")
            {
                Console.WriteLine("Processing Paypal payment.....");
            }
        }

    }
}
