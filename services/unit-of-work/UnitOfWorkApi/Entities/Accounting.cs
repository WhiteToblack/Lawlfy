namespace LawlfyUnitOfWork.Entities
{
    public class Accounting
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
