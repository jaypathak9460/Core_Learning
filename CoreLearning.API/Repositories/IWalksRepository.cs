using CoreLearning.API.Model.Domain;
using CoreLearning.API.Model.DTO;

namespace CoreLearning.API.Repositories
{
    public interface IWalksRepository
    {
        Task<Walk> CreateAsync(Walk walk);
        Task<List<Walk>> GetAllAsync();
        Task<Walk?> GetByIdAsync(Guid id);
        Task<Walk?> UpdateAsync(Guid id, Walk walk);
        Task<Walk?> DeleteAsync(Guid id);


    }
}
