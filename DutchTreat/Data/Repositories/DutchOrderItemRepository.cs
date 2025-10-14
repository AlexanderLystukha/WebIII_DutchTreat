using DutchTreat.Data.Entities;
using DutchTreat.Data.Interfaces;

namespace DutchTreat.Data.Repositories
{
    public class DutchOrderItemRepository : DutchGenericRepository<OrderItem>, IDutchOrderItemRepository
    {
        public DutchOrderItemRepository(ApplicationDbContext db, ILogger<DutchGenericRepository<OrderItem>> logger) : base(db, logger)
        {
        }
    }
}
