using System.Linq;
using Microsoft.EntityFrameworkCore;
using VetApi.Context;
using VetApi.Models;
using VetApi.Repository.Interfaces;

namespace VetApi.Repository
{
    public class AnimalsRepository : Repository<Animal>, IAnimalsRepository
    {
        public AnimalsRepository(AppDbContext context) : base(context)
        {
        }

        public IQueryable<Animal> GetAll(int skip = 0, int take = 10)
        {
            skip = skip * take;
            return _context.Set<Animal>()
                     .Skip(skip)
                     .Take(take)
                     .AsNoTracking();
        }
    }
}