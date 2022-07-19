using System.Threading.Tasks;
using VetApi.Repository.Interfaces;

namespace VetApi.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public Task Commit()
        {
            throw new System.NotImplementedException();
        }
    }
}