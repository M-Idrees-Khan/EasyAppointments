using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using DoctorService.Models;

namespace DoctorService.Data
{
    public class DoctorDbContext : DbContext
    {
        public DoctorDbContext(DbContextOptions<DoctorDbContext> options) : base(options)
        {

        }
        public DbSet<Doctor> Doctors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("Doctor");
                entity.HasKey(e => e.DoctorId);
                entity.Property(e => e.DoctorId)
           .HasDefaultValueSql("NEWID()");
            });
        }
    }
}
