using StoreApi.Models;

namespace StoreApi.Interfaces
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetAllAsyncSupplier();
        Task<Supplier> GetByIdAsyncSupplier(int id);
        Task<Supplier> AddAsyncSupplier(Supplier supplier);
        Task<Supplier> UpdateAsyncSupplier(Supplier supplier);
        Task DeleteAsyncSupplier(int id);
    }
}
