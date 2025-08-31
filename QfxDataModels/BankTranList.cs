namespace Project48.QfxDataModels
{
    /// <summary>
    /// Contains a list of transactions and their date range.
    /// </summary>
    public class BankTranList
    {
        /// <summary>
        /// Start date of the transaction list.
        /// </summary>
        public string DTSTART { get; set; }
        /// <summary>
        /// End date of the transaction list.
        /// </summary>
        public string DTEND { get; set; }
        /// <summary>
        /// List of statement transactions.
        /// </summary>
        public List<Transaction> STMTTRN { get; set; }
    }
}