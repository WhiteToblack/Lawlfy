namespace LawlfyUnitOfWork.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Receiver { get; set; }
        public DateTime SentDate { get; set; }
    }
}
