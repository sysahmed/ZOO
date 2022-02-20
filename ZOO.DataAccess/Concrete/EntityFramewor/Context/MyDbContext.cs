using Microsoft.EntityFrameworkCore;
using ZOO.Entities.Concrete;

namespace ZOO.DataAccess.Concrete.EntityFramewor.Context
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DEVOPS\SQLEXPRESS;Database=MyCoreDb;Trusted_Connection=true");
        }

        public DbSet<BaseAnimal> Animals { get; set; }
       

    }
}
