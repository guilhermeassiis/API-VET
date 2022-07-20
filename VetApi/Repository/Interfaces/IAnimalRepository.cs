using System.Linq;
using VetApi.Models;

namespace VetApi.Repository.Interfaces
{
    public interface IAnimalsRepository : IRepository<Animal>
    {
        IQueryable<Animal> GetAll(int skip = 0, int take = 10);
    }
}