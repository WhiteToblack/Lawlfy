using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;

using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : GenericController<Notification, NotificationDbContext>
    {
        public NotificationController(IUnitOfWork<NotificationDbContext> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
