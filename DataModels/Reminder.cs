namespace Project48.DataModels
{
    /// <summary>
    /// Represents a reminder.
    /// </summary>
    public class Reminder
    {
        public int ReminderId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string? Notes { get; set; }
        public bool IsCompleted { get; set; }
    }
}