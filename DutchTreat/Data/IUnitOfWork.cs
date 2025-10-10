using DutchTreat.Data.Interfaces;

namespace DutchTreat.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IDutchOrderRepository OrderRepository { get; }
        IDutchProductRepository ProductRepository { get; }
    }
}