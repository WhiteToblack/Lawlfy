using System.Collections.Generic;
using System.Threading.Tasks;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Services
{
    public class DocumentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DocumentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Document>> GetAllDocumentsAsync()
        {
            return await _unitOfWork.Documents.GetAllAsync();
        }

        public async Task<Document> GetDocumentByIdAsync(int id)
        {
            return await _unitOfWork.Documents.GetByIdAsync(id);
        }

        public async Task CreateDocumentAsync(Document document)
        {
            await _unitOfWork.Documents.AddAsync(document);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateDocumentAsync(Document document)
        {
            _unitOfWork.Documents.Update(document);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteDocumentAsync(int id)
        {
            var document = await _unitOfWork.Documents.GetByIdAsync(id);
            _unitOfWork.Documents.Delete(document);
            await _unitOfWork.CommitAsync();
        }
    }
}
