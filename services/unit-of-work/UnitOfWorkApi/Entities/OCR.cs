namespace LawlfyUnitOfWork.Entities
{
    public class OCR
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ExtractedText { get; set; }
        public DateTime ProcessedDate { get; set; }
    }
}
