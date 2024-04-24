using StoreApi.Interfaces;
using StoreApi.Models;
using StoreApi.Context;
using Microsoft.EntityFrameworkCore;

namespace StoreApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsyncProduct()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsyncProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> AddAsyncProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateAsyncProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return product;
        }
    
        public async Task DeleteAsyncProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if ( product != null )
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
    }
}
