using Microsoft.EntityFrameworkCore;
using Telemetry.Domain.Entities;

namespace Telemetry.Infrastructure.Data

{
    public class TelemetryDbContext : DbContext
    {
        public TelemetryDbContext (DbContextOptions<TelemetryDbContext> options):base(options) { }

        public DbSet<TelemetryEvent> TelemetryEvents => Set<TelemetryEvent>();

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<TelemetryEvent>(entity =>
            {

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Application)
                .IsRequired()
                .HasMaxLength(100);

                entity.Property(e => e.Message)
                .IsRequired();

                entity.Property(e => e.Level)
                .IsRequired();

                entity.Property(e => e.TimeStamp)
                    .IsRequired();

            });

        
        }
    }
}
