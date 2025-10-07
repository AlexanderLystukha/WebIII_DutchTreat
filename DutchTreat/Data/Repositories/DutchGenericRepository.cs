using DutchTreat.Data.Interfaces;

namespace DutchTreat.Data.Repositories
{    
    public class DutchGenericRepository<T> : IDutchRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<DutchRepository> _logger;
        

        public DutchGenericRepository(ApplicationDbContext db, ILogger<DutchRepository> logger)
        {
            _db = db;
            _logger = logger;
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                _logger.LogInformation("GetAll was called...");

                return _db.Set<T>()                            
                            .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get products: {ex}");
                return null;
            }
        }
    }
}
