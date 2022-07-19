using System.Threading.Tasks;

namespace VetApi.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}