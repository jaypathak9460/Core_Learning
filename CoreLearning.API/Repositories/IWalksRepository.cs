using CoreLearning.API.Model.Domain;
using CoreLearning.API.Model.DTO;
using System.Globalization;

namespace CoreLearning.API.Repositories
{
    public interface IWalksRepository
    {
        Task<Walk> CreateAsync(Walk walk);
        Task<List<Walk>> GetAllAsync(string? filterOn = null,string? filterQuery = null, string? sortBy = null,bool isAscending = true,int pageNumber = 1, int pageSize = 100000000);
        Task<Walk?> GetByIdAsync(Guid id);
        Task<Walk?> UpdateAsync(Guid id, Walk walk);
        Task<Walk?> DeleteAsync(Guid id);


    }
}
