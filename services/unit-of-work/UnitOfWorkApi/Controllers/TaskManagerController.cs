using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork.Services;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManagerController : GenericController<TaskManager, TaskManagerService>
    {
        public TaskManagerController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
