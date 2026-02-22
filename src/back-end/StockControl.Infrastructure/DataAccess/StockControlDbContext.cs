using Microsoft.EntityFrameworkCore;
using StockControl.Domain.Entities;

namespace StockControl.Infrastructure.DataAccess
{
    public class StockControlDbContext : DbContext
    {
        public StockControlDbContext(DbContextOptions<StockControlDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }
    }
}
