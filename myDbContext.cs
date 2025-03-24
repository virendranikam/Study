using Microsoft.EntityFrameworkCore;
using Study.Models;
using System.Diagnostics;
using System.Reflection;

namespace Study
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
        public DbSet<Myproducts> myProducts { get; set; }
    }
}
