using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;

using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : GenericController<Log, LogDbContext>
    {
        public LogController(IUnitOfWork<LogDbContext> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
