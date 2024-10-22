using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork.Services;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmManagerController : GenericController<FirmManager, FirmManagerService>
    {
        public FirmManagerController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
