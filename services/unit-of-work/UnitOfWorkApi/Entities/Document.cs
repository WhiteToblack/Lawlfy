namespace LawlfyUnitOfWork.Entities
{
    public class Document
    {
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public DateTime UploadedDate { get; set; }
    }
}
