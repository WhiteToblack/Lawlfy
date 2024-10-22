using System.Collections.Generic;
using System.Threading.Tasks;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Services
{
    public class AuthorizationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthorizationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Authorization>> GetAllAuthorizationsAsync()
        {
            return await _unitOfWork.Authorizations.GetAllAsync();
        }

        public async Task<Authorization> GetAuthorizationByIdAsync(int id)
        {
            return await _unitOfWork.Authorizations.GetByIdAsync(id);
        }

        public async Task CreateAuthorizationAsync(Authorization authorization)
        {
            await _unitOfWork.Authorizations.AddAsync(authorization);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAuthorizationAsync(Authorization authorization)
        {
            _unitOfWork.Authorizations.Update(authorization);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAuthorizationAsync(int id)
        {
            var authorization = await _unitOfWork.Authorizations.GetByIdAsync(id);
            _unitOfWork.Authorizations.Delete(authorization);
            await _unitOfWork.CommitAsync();
        }
    }
}
