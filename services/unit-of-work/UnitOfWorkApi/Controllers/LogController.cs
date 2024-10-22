using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork.Services;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : GenericController<Log, LogService>
    {
        public LogController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
