using System.Collections.Generic;
using System.Threading.Tasks;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Services
{
    public class AuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthenticationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Authentication>> GetAllAuthenticationsAsync()
        {
            return await _unitOfWork.Authentications.GetAllAsync();
        }

        public async Task<Authentication> GetAuthenticationByIdAsync(int id)
        {
            return await _unitOfWork.Authentications.GetByIdAsync(id);
        }

        public async Task CreateAuthenticationAsync(Authentication authentication)
        {
            await _unitOfWork.Authentications.AddAsync(authentication);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAuthenticationAsync(Authentication authentication)
        {
            _unitOfWork.Authentications.Update(authentication);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAuthenticationAsync(int id)
        {
            var authentication = await _unitOfWork.Authentications.GetByIdAsync(id);
            _unitOfWork.Authentications.Delete(authentication);
            await _unitOfWork.CommitAsync();
        }
    }
}
