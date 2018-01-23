using System.Threading.Tasks;

namespace schoolreport.Core.IUnitOfWorks
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}