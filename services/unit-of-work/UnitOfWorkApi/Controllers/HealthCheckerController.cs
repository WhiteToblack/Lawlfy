using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;

using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckerController : GenericController<HealthChecker, HealthCheckerDbContext>
    {
        public HealthCheckerController(IUnitOfWork<HealthCheckerDbContext> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
