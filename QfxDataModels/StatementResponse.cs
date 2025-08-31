namespace Project48.QfxDataModels
{
    /// <summary>
    /// Represents a statement response containing account and transaction details.
    /// </summary>
    public class StatementResponse
    {
        public string CURDEF { get; set; }
        public BankAcctFrom BANKACCTFROM { get; set; }
        public BankTranList BANKTRANLIST { get; set; }
    }
}