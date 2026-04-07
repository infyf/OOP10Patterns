using System;
using OOP;

class Program
{
    static void Main()
    {
        IPaymentSystem paymentSystem =
            new BankPaymentAdapter(new LegacyBankPayment());

        paymentSystem.Pay(2500);
        paymentSystem.Refund(500);

        Console.WriteLine($"Balance available: {paymentSystem.CheckBalance()}");
        Console.WriteLine(
            paymentSystem.GetTransactionStatus(1)
        );
    }
}

 
