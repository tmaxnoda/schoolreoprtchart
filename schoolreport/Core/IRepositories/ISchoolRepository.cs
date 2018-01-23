using System.Collections.Generic;
using System.Threading.Tasks;
using schoolreport.Models;

namespace schoolreport.Core.IRepositories
{
    public interface ISchoolRepository
    {
          void Add(School school);

        Task<School> GetSchool(int id, bool includeRelated = true);

        Task<IEnumerable<School>> GetSchools();
    }
}