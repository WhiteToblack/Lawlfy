using Microsoft.AspNetCore.Mvc;
using LawlfyUnitOfWork.Entities;

using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;


namespace LawlfyUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : GenericController<Document, DocumentDbContext>
    {
        public DocumentController(IUnitOfWork<DocumentDbContext> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
