using System.Collections.Generic;
using System.Threading.Tasks;
using schoolreport.Models;

namespace schoolreport.Core.IRepositories
{
    public interface IZoneRepository
    {
         Task<IEnumerable<Zone>> GetZones();  
    }
}