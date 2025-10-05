using HospitalService.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalService.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {

        }
        public DbSet<Hospital> hospitals { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.ToTable("Hospital");
                entity.HasKey(e => e.HospitalId);
                entity.Property(e => e.HospitalId)
           .HasDefaultValueSql("NEWID()");
            });
        }
    }
}
