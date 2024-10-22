using LawlfyUnitOfWork.Entities;

using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : GenericController<User, UserDbContext>
    {
        public UserController(IUnitOfWork<UserDbContext> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
