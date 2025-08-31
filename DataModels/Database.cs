namespace Project48.DataModels
{
    /// <summary>
    /// Represents the root database object containing all data collections.
    /// </summary>
    public class Database
    {
        public DateTime DateCreated { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Account> Accounts { get; set; }
        public List<Reminder> Reminders { get; set; }
    }
}