using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork.Services;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingController : GenericController<Accounting, AccountingService>
    {
        public AccountingController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
