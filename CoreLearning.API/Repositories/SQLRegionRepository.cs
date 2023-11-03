using CoreLearning.API.Data;
using CoreLearning.API.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoreLearning.API.Repositories
{
    public class SqlRegionRepository : IRegionRepository
    {
        private readonly CoreLearningDBContext dBContext;
        public SqlRegionRepository(CoreLearningDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public async Task<List<Region>> GetAllAsync()
        {
            return await dBContext.Regions.ToListAsync();
        }

        public async Task<Region?> GetDetailsByIdAsync(Guid Id)
        {
            return await dBContext.Regions.FindAsync(Id);
        }
        public async Task<Region> CreateAsync(Region region)
        {
            await dBContext.Regions.AddAsync(region);
            await dBContext.SaveChangesAsync();
            return region;
        }

        public async Task<Region?> UpdateAsync(Guid Id, Region region)
        {
            var existingRegion = await dBContext.Regions.FindAsync(Id);
            if (existingRegion == null)
            {
                return null;
            }

            existingRegion.Code = region.Code;
            existingRegion.Name = region.Name;
            existingRegion.RegionImageUrl = region.RegionImageUrl;

            await dBContext.SaveChangesAsync();
            return existingRegion;
        }

        public async Task<Region?> DeleteAsync(Guid Id)
        {
            var region = await dBContext.Regions.FindAsync(Id);
            if (region == null)
            {
                return null;
            }
            dBContext.Regions.Remove(region);
            await dBContext.SaveChangesAsync();
            return region;
        }
    }
}
