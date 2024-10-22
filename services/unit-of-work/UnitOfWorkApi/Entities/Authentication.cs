namespace LawlfyUnitOfWork.Entities
{
    public class Authentication
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
