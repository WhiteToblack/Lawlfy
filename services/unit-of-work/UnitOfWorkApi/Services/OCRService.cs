using System.Collections.Generic;
using System.Threading.Tasks;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Services
{
    public class OCRService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OCRService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<OCR>> GetAllOCRsAsync()
        {
            return await _unitOfWork.OCRs.GetAllAsync();
        }

        public async Task<OCR> GetOCRByIdAsync(int id)
        {
            return await _unitOfWork.OCRs.GetByIdAsync(id);
        }

        public async Task CreateOCRAsync(OCR ocr)
        {
            await _unitOfWork.OCRs.AddAsync(ocr);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateOCRAsync(OCR ocr)
        {
            _unitOfWork.OCRs.Update(ocr);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteOCRAsync(int id)
        {
            var ocr = await _unitOfWork.OCRs.GetByIdAsync(id);
            _unitOfWork.OCRs.Delete(ocr);
            await _unitOfWork.CommitAsync();
        }
    }
}
