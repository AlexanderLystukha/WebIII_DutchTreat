using DutchTreat.Data.Entities;

namespace DutchTreat.Data.Interfaces
{
    public interface IDutchRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        //IEnumerable<Product> GetAllProducts();
        //IEnumerable<Product> GetProductsByCategory(string category);
        //bool SaveAll();
    }
}