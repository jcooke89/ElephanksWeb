using Microsoft.EntityFrameworkCore;

namespace ElephanksWeb.Repository
{
    public class TrunkContext : DbContext
    {
        public TrunkContext(DbContextOptions<TrunkContext> options) : base(options) { }
        public DbSet<Trunk> Trunks { get; set; }
    }
}