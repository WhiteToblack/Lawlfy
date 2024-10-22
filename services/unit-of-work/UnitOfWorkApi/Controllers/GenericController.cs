using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using LawlfyUnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LawlfyUnitOfWork
{
    public class GenericController<TEntity, TContext> : ControllerBase
    where TEntity : class
    where TContext : DbContext
{
    private readonly IUnitOfWork<TContext> _unitOfWork;

    public GenericController(IUnitOfWork<TContext> unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await _unitOfWork.Repository<TEntity>().GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<TEntity> GetById(int id)
    {
        return await _unitOfWork.Repository<TEntity>().GetByIdAsync(id);
    }

    [HttpPost]
    public async Task<IActionResult> Create(TEntity entity)
    {
        await _unitOfWork.Repository<TEntity>().AddAsync(entity);
        await _unitOfWork.CommitAsync();
        return Ok(entity);
    }

    [HttpPut]
    public async Task<IActionResult> Update(TEntity entity)
    {
        _unitOfWork.Repository<TEntity>().Update(entity);
        await _unitOfWork.CommitAsync();
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var entity = await _unitOfWork.Repository<TEntity>().GetByIdAsync(id);
        if (entity == null) return NotFound();

        _unitOfWork.Repository<TEntity>().Delete(entity);
        await _unitOfWork.CommitAsync();
        return Ok();
    }
}

}
