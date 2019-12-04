using Microsoft.EntityFrameworkCore;

namespace shopapp.Data
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options): base(options) {}
        public DbSet<Model.Product> product { get; set; } 
    }
}