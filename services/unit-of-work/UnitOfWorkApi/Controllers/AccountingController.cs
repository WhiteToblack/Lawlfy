using LawlfyUnitOfWork.Entities;

using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Repositories;
namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingController : GenericController<Accounting, AccountingDbContext>
    {
        public AccountingController(IUnitOfWork<AccountingDbContext> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
