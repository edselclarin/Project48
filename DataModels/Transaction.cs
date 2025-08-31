namespace Project48.DataModels
{
    /// <summary>
    /// Represents a single transaction record.
    /// </summary>
    public class Transaction
    {
        public Guid TrnsId { get; set; }
        public DateTime Date { get; set; }
        public string TrnsType { get; set; }
        public string? RefNum { get; set; }
        public string Payee { get; set; }
        public string? Memo { get; set; }
        public string State { get; set; }
        public decimal Amount { get; set; }
        public string ExtTrnsId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Guid AcctId { get; set; }
    }
}