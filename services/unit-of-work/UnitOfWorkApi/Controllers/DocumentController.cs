using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork.Services;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : GenericController<Document, DocumentService>
    {
        public DocumentController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
