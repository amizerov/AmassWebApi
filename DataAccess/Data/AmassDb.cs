using AmassWebApi.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace AmassWebApi.DataAccess.Data
{
    public class AmassDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Tools.Secrets.GetConnectionString());
        }
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Income> Incomes => Set<Income>();

    }
}
