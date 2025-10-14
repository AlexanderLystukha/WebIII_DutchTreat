using DutchTreat.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DutchTreat.Data.Repositories.Helpers
{
    public interface IRepositoryProvider
    {
        ApplicationDbContext DbContext { get; set; }
        IDutchRepository<T>? GetRepositoryForEntityType<T>() where T : class;
        T GetRepository<T>(Func<ApplicationDbContext, object>? factory = null) where T : class;
        void SetRepository<T>(T repository) where T : class;
    }
}
