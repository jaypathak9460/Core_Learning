using CoreLearning.API.Data;
using CoreLearning.API.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoreLearning.API.Repositories
{
    public class SQLWalkRepository : IWalksRepository
    {
        private readonly CoreLearningDBContext dBContext;

        public SQLWalkRepository(CoreLearningDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async Task<Walk> CreateAsync(Walk walk)
        {
            await dBContext.Walks.AddAsync(walk);
            await dBContext.SaveChangesAsync();
            return walk;
        }

        public async Task<List<Walk>> GetAllAsync()
        {
            return await dBContext.Walks.Include("Difficulty").Include("Region").ToListAsync();
        }

        public async Task<Walk?> GetByIdAsync(Guid Id)

        {
            return await dBContext.Walks.Include("Difficulty").Include("Region").FirstOrDefaultAsync(x => x.Id == Id);

        }

        public async Task<Walk?> UpdateAsync(Guid id, Walk walk)
        {
            var existingWalk = await dBContext.Walks.FirstOrDefaultAsync(x => x.Id == id);
            if (existingWalk == null)
            {
                return null;
            }
            existingWalk.Name = walk.Name;
            existingWalk.Description = walk.Description;
            existingWalk.WalkImageUrl = walk.WalkImageUrl;
            existingWalk.LengthInKm = walk.LengthInKm;
            existingWalk.DifficultyId = walk.DifficultyId;
            existingWalk.RegionId = walk.RegionId;
            await dBContext.SaveChangesAsync();
            return existingWalk;
        }

        public async Task<Walk?> DeleteAsync(Guid id)
        {
            var existingWalk = await dBContext.Walks.FirstOrDefaultAsync(x => x.Id == id);
            if (existingWalk == null)
            {
                return null;
            }
            dBContext.Walks.Remove(existingWalk);
            await dBContext.SaveChangesAsync();
            return existingWalk;
        }


    }
}
