using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork.Services;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : GenericController<Authentication, AuthenticationService>
    {
        public AuthenticationController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
