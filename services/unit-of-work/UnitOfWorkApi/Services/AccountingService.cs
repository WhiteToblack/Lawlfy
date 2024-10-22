using System.Collections.Generic;
using System.Threading.Tasks;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Services
{
    public class AccountingService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Accounting>> GetAllInvoicesAsync()
        {
            return await _unitOfWork.Accountings.GetAllAsync();
        }

        public async Task<Accounting> GetInvoiceByIdAsync(int id)
        {
            return await _unitOfWork.Accountings.GetByIdAsync(id);
        }

        public async Task CreateInvoiceAsync(Accounting invoice)
        {
            await _unitOfWork.Accountings.AddAsync(invoice);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateInvoiceAsync(Accounting invoice)
        {
            _unitOfWork.Accountings.Update(invoice);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteInvoiceAsync(int id)
        {
            var invoice = await _unitOfWork.Accountings.GetByIdAsync(id);
            _unitOfWork.Accountings.Delete(invoice);
            await _unitOfWork.CommitAsync();
        }
    }
}
