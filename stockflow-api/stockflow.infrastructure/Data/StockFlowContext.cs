using stockflow.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace stockflow.infrastructure.Data
{
    public class StockFlowContext : DbContext
    {
        public StockFlow(DbContextOptions<LibraryContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
