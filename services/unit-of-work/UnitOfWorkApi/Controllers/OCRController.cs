using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork.Services;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OCRController : GenericController<OCR, OCRService>
    {
        public OCRController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
