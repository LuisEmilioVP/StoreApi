using StoreApi.Models;

namespace StoreApi.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsyncCategory();
        Task<Category> GetByIdAsyncCategory(int id);
        Task<Category> AddAsyncCategory(Category category);
        Task<Category> UpdateAsyncCategory(Category product);
        Task DeleteAsyncCategory(int id);
    }
}
