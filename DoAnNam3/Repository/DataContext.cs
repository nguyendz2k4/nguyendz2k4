using DoAnNam3.Models;
using Microsoft.EntityFrameworkCore;

namespace DoAnNam3.Repository
{
    public class APSWeb1Context : DbContext
    {
        public APSWeb1Context(DbContextOptions<DbContext> options) :base(options) {
        
        }
        public DbSet<BrandModel> Brands { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> categoryModels { get; set; }
    }
}
