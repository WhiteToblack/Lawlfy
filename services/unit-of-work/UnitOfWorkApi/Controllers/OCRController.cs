using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;

using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OCRController : GenericController<OCR, OCRDbContext>
    {
        public OCRController(IUnitOfWork<OCRDbContext> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
