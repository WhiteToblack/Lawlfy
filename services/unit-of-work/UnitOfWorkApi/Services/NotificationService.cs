using System.Collections.Generic;
using System.Threading.Tasks;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Services
{
    public class NotificationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NotificationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Notification>> GetAllNotificationsAsync()
        {
            return await _unitOfWork.Notifications.GetAllAsync();
        }

        public async Task<Notification> GetNotificationByIdAsync(int id)
        {
            return await _unitOfWork.Notifications.GetByIdAsync(id);
        }

        public async Task CreateNotificationAsync(Notification notification)
        {
            await _unitOfWork.Notifications.AddAsync(notification);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateNotificationAsync(Notification notification)
        {
            _unitOfWork.Notifications.Update(notification);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteNotificationAsync(int id)
        {
            var notification = await _unitOfWork.Notifications.GetByIdAsync(id);
            _unitOfWork.Notifications.Delete(notification);
            await _unitOfWork.CommitAsync();
        }
    }
}
