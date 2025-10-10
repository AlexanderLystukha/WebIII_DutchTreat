using DutchTreat.Data.Entities;
using DutchTreat.Data.Interfaces;

namespace DutchTreat.Data.Repositories
{
    public class DutchOrderRepository : DutchGenericRepository<Order>, IDutchOrderRepository
    {
        public DutchOrderRepository(ApplicationDbContext db, ILogger<DutchOrderRepository> logger) : base(db, logger)
        {
        }

        public IEnumerable<Order> GetByArtist(string artist)
        {
            throw new NotImplementedException();
        }
    }
}
