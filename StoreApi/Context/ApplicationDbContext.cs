using Microsoft.EntityFrameworkCore;
using StoreApi.Models;

namespace StoreApi.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuraciones adicionales y mapeos de relaciones pueden ir aquí

            // Ejemplo de configuración de clave primaria
            modelBuilder.Entity<Product>().HasKey(p => p.ProductId);
            modelBuilder.Entity<Category>().HasKey(c => c.CategoryId);
            modelBuilder.Entity<Supplier>().HasKey(s => s.SupplierId);

            // Configuraciones de relaciones
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Suppliers)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierId);
        }
    }
}
