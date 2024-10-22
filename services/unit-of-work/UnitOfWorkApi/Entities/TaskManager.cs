namespace LawlfyUnitOfWork.Entities
{
    public class TaskManager
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
    }
}
