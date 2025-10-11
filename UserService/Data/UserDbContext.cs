using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using UserService.Models;

namespace UserService.Data
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options):base(options) 
        {
                
        }
        public DbSet<User>Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
                entity.HasKey(e => e.UserId);
                entity.Property(e => e.UserId)
           .HasDefaultValueSql("NEWID()");
            });
        }
    }
}
