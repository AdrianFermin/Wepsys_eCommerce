using Microsoft.EntityFrameworkCore;

namespace Wepsys_eCommerce.Model
{
    public class ProductosContext : DbContext
    {
        public ProductosContext(DbContextOptions options) : base(options) { }

        public DbSet<Productos> Productos { get; set; }
    }

}
