using StoreApi.Models;

namespace StoreApi.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsyncProduct();
        Task<Product> GetByIdAsyncProduct(int id);
        Task<Product> AddAsyncProduct(Product product);
        Task<Product> UpdateAsyncProduct(Product product);
        Task DeleteAsyncProduct(int id);
    }
}
