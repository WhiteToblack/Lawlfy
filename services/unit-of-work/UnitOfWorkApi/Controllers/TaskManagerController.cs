using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;

using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManagerController : GenericController<TaskManager, TaskManagerDbContext>
    {
        public TaskManagerController(IUnitOfWork<TaskManagerDbContext> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
