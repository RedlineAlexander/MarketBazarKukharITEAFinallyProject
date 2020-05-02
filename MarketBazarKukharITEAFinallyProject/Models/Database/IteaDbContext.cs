
using Microsoft.EntityFrameworkCore;
using MarketBazarKukharITEAFinallyProject.Models.Entities;
namespace MarketBazarKukharITEAFinallyProject.Models.Database
{
    public class IteaDbContext : DbContext
    {
        public DbSet<Buyers> Buyers { get; set; }

        public DbSet<Consumers> Consumers { get; set; }

        public DbSet<Goods> Goods { get; set; }


        public DbSet<Departments> Departments { get; set; }
        
        public DbSet<Deliveries> Distributions { get; set; }

        public DbSet<Remotepandemicorders> remotepandemicorders { get; set; }


        public IteaDbContext(DbContextOptions<IteaDbContext> options) : base(options){
  


        }
    }
}
