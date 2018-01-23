using System.Threading.Tasks;
using schoolreport.Core.IUnitOfWorks;

namespace schoolreport.Persistence.UnitOfWorks
{
    public class UnitOfWork :IUnitOfWork
    {
         private readonly SchoolRDbContext _context;

        public UnitOfWork(SchoolRDbContext context)
        {
            _context = context;
        }
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}