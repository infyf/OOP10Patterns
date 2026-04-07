namespace OOP
{
    public class BankPaymentAdapter : IPaymentSystem
    {
        private LegacyBankPayment _bankPayment;

        public BankPaymentAdapter(LegacyBankPayment bankPayment)
        {
            _bankPayment = bankPayment;
        }

        public void Pay(decimal amount)
        {
            _bankPayment.MakePayment((double)amount);
        }

        public void Refund(decimal amount)
        {
            _bankPayment.MakeRefund((double)amount);
        }

        public bool CheckBalance()
        {
            return _bankPayment.GetAccountBalance() > 0;
        }

        public string GetTransactionStatus(int transactionId)
        {
            int code = _bankPayment.GetLastOperationCode();

            return code == 200
                ? "Transaction completed successfully"
                : "Transaction failed";
        }
    }
}
