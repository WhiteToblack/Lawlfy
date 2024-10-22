using System.Collections.Generic;
using System.Threading.Tasks;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Services
{
    public class LogService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Log>> GetAllLogsAsync()
        {
            return await _unitOfWork.Logs.GetAllAsync();
        }

        public async Task<Log> GetLogByIdAsync(int id)
        {
            return await _unitOfWork.Logs.GetByIdAsync(id);
        }

        public async Task CreateLogAsync(Log log)
        {
            await _unitOfWork.Logs.AddAsync(log);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateLogAsync(Log log)
        {
            _unitOfWork.Logs.Update(log);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteLogAsync(int id)
        {
            var log = await _unitOfWork.Logs.GetByIdAsync(id);
            _unitOfWork.Logs.Delete(log);
            await _unitOfWork.CommitAsync();
        }
    }
}
