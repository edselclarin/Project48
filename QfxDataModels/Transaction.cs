namespace Project48.QfxDataModels
{
    /// <summary>
    /// Represents a financial transaction in a QFX file.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Type of transaction (e.g., DEBIT, CREDIT).
        /// </summary>
        public string TRNTYPE { get; set; }
        /// <summary>
        /// Date the transaction was posted.
        /// </summary>
        public string DTPOSTED { get; set; }
        /// <summary>
        /// Date the transaction is available.
        /// </summary>
        public string DTAVAIL { get; set; }
        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// Financial institution transaction ID.
        /// </summary>
        public string FITID { get; set; }
        /// <summary>
        /// Name or description of the transaction.
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// Additional memo or notes for the transaction.
        /// </summary>
        public string MEMO { get; set; }
    }
}