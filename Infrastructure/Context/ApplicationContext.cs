using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Account> Account { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
