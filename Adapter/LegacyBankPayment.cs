using System;

namespace OOP
{
    public class LegacyBankPayment
    {
        public void MakePayment(double sum)
        {
            Console.WriteLine($"Bank payment completed: {sum} UAH");
        }

        public void MakeRefund(double sum)
        {
            Console.WriteLine($"Refund processed: {sum} UAH");
        }

        public double GetAccountBalance()
        {
            return 15000.50;
        }

        public int GetLastOperationCode()
        {
            return 200;
        }
    }
}

