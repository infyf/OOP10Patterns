namespace OOP
{
    public interface IPaymentSystem
    {
        void Pay(decimal amount);
        void Refund(decimal amount);
        bool CheckBalance();
        string GetTransactionStatus(int transactionId);
    }
}
}
