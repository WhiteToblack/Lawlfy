namespace LawlfyUnitOfWork.Entities
{
    public class HealthChecker
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public bool IsHealthy { get; set; }
        public DateTime LastChecked { get; set; }
    }
}
