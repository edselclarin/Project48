namespace Project48.QfxDataModels
{
    /// <summary>
    /// Represents bank account information.
    /// </summary>
    public class BankAcctFrom
    {
        /// <summary>
        /// Bank identifier.
        /// </summary>
        public string BANKID { get; set; }
        /// <summary>
        /// Account identifier.
        /// </summary>
        public string ACCTID { get; set; }
        /// <summary>
        /// Type of account (e.g., CHECKING, SAVINGS).
        /// </summary>
        public string ACCTTYPE { get; set; }
    }
}