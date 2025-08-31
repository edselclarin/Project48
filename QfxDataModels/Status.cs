namespace Project48.QfxDataModels
{
    /// <summary>
    /// Represents the status of a response or transaction.
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Status code.
        /// </summary>
        public int CODE { get; set; }
        /// <summary>
        /// Severity of the status (e.g., INFO, ERROR).
        /// </summary>
        public string SEVERITY { get; set; }
    }
}