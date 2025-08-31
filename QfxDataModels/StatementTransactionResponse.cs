namespace Project48.QfxDataModels
{
    /// <summary>
    /// Contains a statement transaction response and its status.
    /// </summary>
    public class StatementTransactionResponse
    {
        /// <summary>
        /// Transaction unique identifier.
        /// </summary>
        public string TRNUID { get; set; }
        /// <summary>
        /// Status of the transaction.
        /// </summary>
        public Status STATUS { get; set; }
        /// <summary>
        /// Statement response details.
        /// </summary>
        public StatementResponse STMTRS { get; set; }
    }
}