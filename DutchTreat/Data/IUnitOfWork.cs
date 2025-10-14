using DutchTreat.Data.Interfaces;

namespace DutchTreat.Data
{
    public interface IUnitOfWork : IDisposable
    {        
        IDutchProductRepository ProductRepository { get; }
        IDutchOrderRepository OrderRepository { get; }
        IDutchOrderItemRepository OrderItemRepository { get; }
    }
}