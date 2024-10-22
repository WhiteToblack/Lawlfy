using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork.Services;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckerController : GenericController<HealthChecker, HealthCheckerService>
    {
        public HealthCheckerController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
