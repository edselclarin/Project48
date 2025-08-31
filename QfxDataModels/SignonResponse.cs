namespace Project48.QfxDataModels
{
    /// <summary>
    /// Contains sign-on response details.
    /// </summary>
    public class SignonResponse
    {
        /// <summary>
        /// Status of the sign-on response.
        /// </summary>
        public Status STATUS { get; set; }
        /// <summary>
        /// Date and time of the server response.
        /// </summary>
        public string DTSERVER { get; set; }
        /// <summary>
        /// Language of the response.
        /// </summary>
        public string LANGUAGE { get; set; }
        /// <summary>
        /// Financial institution information.
        /// </summary>
        public FI FI { get; set; }
        /// <summary>
        /// Intuit user ID.
        /// </summary>
        public string INTU_USERID { get; set; }
        /// <summary>
        /// Intuit bank ID.
        /// </summary>
        public string INTU_BID { get; set; }
    }
}