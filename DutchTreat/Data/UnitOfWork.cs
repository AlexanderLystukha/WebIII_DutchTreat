using DutchTreat.Data.Interfaces;
using DutchTreat.Data.Repositories;

namespace DutchTreat.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        private ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context, ILoggerFactory factory)
        {
            _context = context;
            _productLogger = new Logger<DutchProductRepository>(factory);
            _orderLogger = new Logger<DutchOrderRepository>(factory);
        }

        private IDutchProductRepository _productRepository;
        private readonly ILogger<DutchProductRepository> _productLogger;
        public IDutchProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                    this._productRepository = new DutchProductRepository(_context, _productLogger);
                return _productRepository;
            }

        }

        private IDutchOrderRepository _orderRepository;
        private bool disposedValue;
        private readonly ILogger<DutchOrderRepository> _orderLogger;

        public IDutchOrderRepository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                    this._orderRepository = new DutchOrderRepository(_context, _orderLogger);
                return this.OrderRepository;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
