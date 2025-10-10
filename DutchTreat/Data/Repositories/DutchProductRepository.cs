using DutchTreat.Data.Entities;
using DutchTreat.Data.Interfaces;

namespace DutchTreat.Data.Repositories
{
    public class DutchProductRepository : DutchGenericRepository<Product>, IDutchProductRepository
    {
        public DutchProductRepository(ApplicationDbContext db, ILogger<DutchProductRepository> logger) : base(db, logger)
        {
        }
        
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _dbSet
                    .Where(p => p.Category == category)
                    .ToList();
        }
    }
}
