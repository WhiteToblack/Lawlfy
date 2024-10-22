using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;

using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;


namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmManagerController : GenericController<FirmManager, FirmManagerDbContext>
    {
        public FirmManagerController(IUnitOfWork<FirmManagerDbContext> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
