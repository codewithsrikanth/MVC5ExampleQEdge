using System.Data.Entity;

namespace CodeFirstEF.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext():base("name=ProductDBEntities")
        {            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}