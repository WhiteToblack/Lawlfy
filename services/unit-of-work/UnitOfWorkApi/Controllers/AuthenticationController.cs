using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;

using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : GenericController<Authentication, AuthenticationDbContext>
    {
        public AuthenticationController(IUnitOfWork<AuthenticationDbContext> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
