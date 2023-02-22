using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        public RegionRepository(NZWalksDBContext dBContext) => DBContext = dBContext;
        public NZWalksDBContext DBContext { get; }


        public async Task<IEnumerable<Region>> GetAllAsync() => await DBContext.Regions.ToListAsync();
    }
}
