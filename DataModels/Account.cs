namespace Project48.DataModels
{
    /// <summary>
    /// Represents an account.
    /// </summary>
    public class Account
    {
        public Guid AcctId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AcctType { get; set; }
        public decimal StartingBalance { get; set; }
        public decimal ReserveAmount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string ExtAcctId { get; set; }
        public string ExtBankId { get; set; }
        public decimal Balance { get; set; }
    }
}