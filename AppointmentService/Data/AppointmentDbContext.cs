using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using AppointmentService.Models;

namespace AppointmentService.Data
{
    public class AppointmentDbContext : DbContext
    {
        public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options) : base(options)
        {

        }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");
                entity.HasKey(e => e.AppointmentId);
                entity.Property(e => e.AppointmentId)
           .HasDefaultValueSql("NEWID()");
            });
        }
    }
}
