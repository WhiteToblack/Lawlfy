using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork.Services;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : GenericController<Authorization, AuthorizationService>
    {
        public AuthorizationController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
