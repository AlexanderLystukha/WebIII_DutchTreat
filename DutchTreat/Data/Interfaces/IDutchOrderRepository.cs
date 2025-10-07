using DutchTreat.Data.Entities;

namespace DutchTreat.Data.Interfaces
{
    public interface IDutchOrderRepository : IDutchRepository<Order>
    {
        IEnumerable<Order> GetByArtist(string artist);
    }
}
