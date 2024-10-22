using System.Collections.Generic;
using System.Threading.Tasks;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Services
{
    public class TaskManagerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TaskManagerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<TaskManager>> GetAllTasksAsync()
        {
            return await _unitOfWork.TaskManagers.GetAllAsync();
        }

        public async Task<TaskManager> GetTaskByIdAsync(int id)
        {
            return await _unitOfWork.TaskManagers.GetByIdAsync(id);
        }

        public async Task CreateTaskAsync(TaskManager task)
        {
            await _unitOfWork.TaskManagers.AddAsync(task);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateTaskAsync(TaskManager task)
        {
            _unitOfWork.TaskManagers.Update(task);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteTaskAsync(int id)
        {
            var task = await _unitOfWork.TaskManagers.GetByIdAsync(id);
            _unitOfWork.TaskManagers.Delete(task);
            await _unitOfWork.CommitAsync();
        }
    }
}
