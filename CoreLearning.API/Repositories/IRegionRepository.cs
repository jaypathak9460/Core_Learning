using CoreLearning.API.Model.Domain;

namespace CoreLearning.API.Repositories
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllAsync();
        Task<Region?> GetDetailsByIdAsync(Guid Id);
        Task<Region> CreateAsync(Region region);
        Task<Region?> UpdateAsync(Guid Id, Region region);

        Task<Region?> DeleteAsync(Guid Id);
    }
}
