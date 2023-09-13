using ApiLider.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiLider.ConnectBase
{
    public class ApplicationConnect : DbContext
    {
        public DbSet<StructureWeb> web { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constains.SqlConnectionIntegratedSecurity);
        }
    }
}
