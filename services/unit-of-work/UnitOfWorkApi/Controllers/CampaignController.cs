using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork.Services;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : GenericController<Campaign, CampaignService>
    {
        public CampaignController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
