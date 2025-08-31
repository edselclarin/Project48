namespace Project48.QfxDataModels
{
    /// <summary>
    /// Root object for the OFX response, containing sign-on and bank message responses.
    /// </summary>
    public class OFXRoot
    {
        public SignonMsgResponse SIGNONMSGSRSV1 { get; set; }
        public BankMsgResponse BANKMSGSRSV1 { get; set; }
    }
}