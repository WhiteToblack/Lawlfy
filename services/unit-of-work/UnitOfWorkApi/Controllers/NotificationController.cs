using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork.Services;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : GenericController<Notification, NotificationService>
    {
        public NotificationController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
