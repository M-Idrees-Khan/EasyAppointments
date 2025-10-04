using AuthService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace AuthService.Data
{
    public class AuthDbContext:DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options):base(options)
        {
                
        }
        public DbSet<Auth> Auths { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Auth>(entity =>
            {
                entity.ToTable("Auth");
                entity.HasKey((e => e.AdminId));
                entity.Property(e => e.AdminId)
           .HasDefaultValueSql("NEWID()");
            });
        }
    }
}
