using DutchTreat.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DutchTreat.Data.Repositories
{    
    public class DutchGenericRepository<T> : IDutchRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _db;
        protected readonly DbSet<T> _dbSet;
        protected readonly ILogger<DutchGenericRepository<T>> _logger;
        

        public DutchGenericRepository(ApplicationDbContext db, ILogger<DutchGenericRepository<T>> logger)
        {
            _db = db;
            _dbSet = db.Set<T>();
            _logger = logger;
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                _logger.LogInformation("GetAll was called...");

                return _dbSet.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get products: {ex}");
                return null;
            }
        }
    }
}
