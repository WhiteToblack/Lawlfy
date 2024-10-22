using System.Collections.Generic;
using System.Threading.Tasks;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork;

namespace LawlfyUnitOfWork.Services
{
    public class CampaignService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CampaignService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Campaign>> GetAllCampaignsAsync()
        {
            return await _unitOfWork.Campaigns.GetAllAsync();
        }

        public async Task<Campaign> GetCampaignByIdAsync(int id)
        {
            return await _unitOfWork.Campaigns.GetByIdAsync(id);
        }

        public async Task CreateCampaignAsync(Campaign campaign)
        {
            await _unitOfWork.Campaigns.AddAsync(campaign);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateCampaignAsync(Campaign campaign)
        {
            _unitOfWork.Campaigns.Update(campaign);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteCampaignAsync(int id)
        {
            var campaign = await _unitOfWork.Campaigns.GetByIdAsync(id);
            _unitOfWork.Campaigns.Delete(campaign);
            await _unitOfWork.CommitAsync();
        }
    }
}
