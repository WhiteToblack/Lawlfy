using LawlfyUnitOfWork.Entities;

using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Repositories;
namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : GenericController<Authorization, AuthorizationDbContext>
    {
        public AuthorizationController(IUnitOfWork<AuthorizationDbContext> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
