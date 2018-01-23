using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using schoolreport.Core.IRepositories;
using schoolreport.Models;

namespace schoolreport.Persistence.Repositories
{
    public class ZoneRepository : IZoneRepository
    {
        private readonly SchoolRDbContext _Context;

        public ZoneRepository(SchoolRDbContext context)
        {
            _Context = context;
        }
        public async Task<IEnumerable<Zone>> GetZones()
        {
            var result = await _Context.Zones.Include(x => x.District).ToListAsync();

            return result;
        }
    }
}