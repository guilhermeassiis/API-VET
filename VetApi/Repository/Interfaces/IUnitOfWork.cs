using System.Threading.Tasks;

namespace VetApi.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        IAnimalsRepository AnimalsRepository { get; }
        Task Commit();
    }
}