using System;
using System.Collections.Generic;
namespace GeekShopping.PaymentProcessor
{
    public class PaymentProcessor : IPaymentProcessor
    {
        bool IPaymentProcessor.PaymentProcessor()
        {
            return true; ;
        }
    }
}
