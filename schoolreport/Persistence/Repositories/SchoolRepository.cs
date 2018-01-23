

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using schoolreport.Core.IRepositories;
using schoolreport.Models;

namespace schoolreport.Persistence.Repositories
{
    public class SchoolRepository:ISchoolRepository
    {
         private readonly SchoolRDbContext _context;

        public SchoolRepository(SchoolRDbContext context) 
        {
            _context = context;
        }
        public void Add(School school)
        {
            _context.Add(school);
        }

        public async Task<School> GetSchool(int id, bool includeRelated = true)
        {
            if (!includeRelated)
            {
                return await _context.Schools.FindAsync(id);
            }
            return await _context.Schools
                .Include(z => z.Zone)
                .ThenInclude(vf => vf.District)
                      .SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<School>> GetSchools()
        {
            var result = await _context.Schools
                .Include(x => x.Zone)
                .ThenInclude(s => s.District)
                .ToListAsync();

            return result;
        }
    }
}