namespace onlineBankingVo
{
    public class Account
    {
        public string accountGuid { get; set; }
        public string accountName { get; set; }
        public string accountType { get; set; }
        public string accountDescription { get; set; }
        public string accountNumber { get; set; }
        public string accountStatus { get; set; }
        public Decimal accountBalance { get; set; }

        public Account(string accountGuid, string accountName, string accountType, string accountDescription, string accountNumber, string accountStatus, decimal accountBalance)
        {
            this.accountGuid = accountGuid;
            this.accountName = accountName;
            this.accountType = accountType;
            this.accountDescription = accountDescription;
            this.accountNumber = accountNumber;
            this.accountStatus = accountStatus;
            this.accountBalance = accountBalance;
        }


    }
}
