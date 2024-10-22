using System.Collections.Generic;
using System.Threading.Tasks;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Services
{
    public class FirmManagerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FirmManagerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<FirmManager>> GetAllFirmsAsync()
        {
            return await _unitOfWork.FirmManagers.GetAllAsync();
        }

        public async Task<FirmManager> GetFirmByIdAsync(int id)
        {
            return await _unitOfWork.FirmManagers.GetByIdAsync(id);
        }

        public async Task CreateFirmAsync(FirmManager firm)
        {
            await _unitOfWork.FirmManagers.AddAsync(firm);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateFirmAsync(FirmManager firm)
        {
            _unitOfWork.FirmManagers.Update(firm);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteFirmAsync(int id)
        {
            var firm = await _unitOfWork.FirmManagers.GetByIdAsync(id);
            _unitOfWork.FirmManagers.Delete(firm);
            await _unitOfWork.CommitAsync();
        }
    }
}
