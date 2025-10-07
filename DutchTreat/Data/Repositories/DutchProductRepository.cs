using DutchTreat.Data.Entities;
using DutchTreat.Data.Interfaces;

namespace DutchTreat.Data.Repositories
{
    public class DutchProductRepository : DutchGenericRepository<Product>, IDutchProductRepository
    {
        public DutchProductRepository(ApplicationDbContext db, ILogger<DutchRepository> logger) : base(db, logger)
        {
        }
    }
}
