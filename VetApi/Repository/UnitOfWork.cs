using System.Threading.Tasks;
using VetApi.Context;
using VetApi.Repository.Interfaces;

namespace VetApi.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private AnimalsRepository _AnimalsRepository;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public IAnimalsRepository AnimalsRepository 
        {
            get 
            {
                return _AnimalsRepository = _AnimalsRepository ?? new AnimalsRepository(_context); 
            }
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}