using System.Collections.Generic;
using System.Threading.Tasks;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Services
{
    public class HealthCheckerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public HealthCheckerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<HealthChecker>> GetAllHealthChecksAsync()
        {
            return await _unitOfWork.HealthCheckers.GetAllAsync();
        }

        public async Task<HealthChecker> GetHealthCheckByIdAsync(int id)
        {
            return await _unitOfWork.HealthCheckers.GetByIdAsync(id);
        }

        public async Task CreateHealthCheckAsync(HealthChecker healthCheck)
        {
            await _unitOfWork.HealthCheckers.AddAsync(healthCheck);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateHealthCheckAsync(HealthChecker healthCheck)
        {
            _unitOfWork.HealthCheckers.Update(healthCheck);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteHealthCheckAsync(int id)
        {
            var healthCheck = await _unitOfWork.HealthCheckers.GetByIdAsync(id);
            _unitOfWork.HealthCheckers.Delete(healthCheck);
            await _unitOfWork.CommitAsync();
        }
    }
}
