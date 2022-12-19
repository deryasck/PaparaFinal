using DomainLayer.Tablolar;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Contex
{
   
    public class SiteAppDbContext:DbContext
    {
        public SiteAppDbContext(DbContextOptions<SiteAppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //DbContexdeki tüm table configurationları bulup regiter eder.
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SiteAppDbContext).Assembly);
          
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Housing> Housings { get; set; }
        public DbSet<Dues> Dues { get; set; }  
        public DbSet<Message> Messages { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
       


    }
}
