namespace PersonalFinance
{
    public class Transaction
    {
        public string AccountNumber { get; set; }
        public string OperationDate { get; set; }
        public string CurrencyExchangeDate { get; set; }
        public string PaymentNumber { get; set; }
        public string ReceiverAccountNumber { get; set; }
        public string ReceiverName { get; set; }
        public string DebitOrCredit { get; set; }
        public decimal Sum { get; set; }
        public string PayerCode { get; set; }
        public string BankLink { get; set; }
        public string OperationDetails { get; set; }
        public string Currency { get; set; }
        public string PersonOrCompanyCode { get; set; }
        public string AccountBalance { get; set; }
        public string PaymentCode { get; set; }
    }
}
