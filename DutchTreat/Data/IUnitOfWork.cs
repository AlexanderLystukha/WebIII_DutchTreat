using DutchTreat.Data.Interfaces;

namespace DutchTreat.Data
{
    public interface IUnitOfWork : IDisposable
    {        
        T GetRepository<T>() where T : class;
        //IDutchProductRepository ProductRepository { get; }
        //IDutchOrderRepository OrderRepository { get; }
        //IDutchOrderItemRepository OrderItemRepository { get; }
    }
}