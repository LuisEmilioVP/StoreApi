using Microsoft.EntityFrameworkCore;
using StoreApi.Context;
using StoreApi.Interfaces;
using StoreApi.Models;

namespace StoreApi.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllAsyncCategory()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetByIdAsyncCategory(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<Category> AddAsyncCategory(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }


        public async Task<Category> UpdateAsyncCategory(Category product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task DeleteAsyncCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if ( category != null )
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }

    }
}
