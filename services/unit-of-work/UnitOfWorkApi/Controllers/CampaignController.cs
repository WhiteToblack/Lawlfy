using LawlfyUnitOfWork.Entities;

using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : GenericController<Campaign, CampaignDbContext>
    {
        public CampaignController(IUnitOfWork<CampaignDbContext> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
