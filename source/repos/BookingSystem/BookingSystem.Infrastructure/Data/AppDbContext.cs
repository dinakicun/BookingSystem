using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<ZoneFeature> ZoneFeatures { get; set; }
        public DbSet<WorkplaceFeature> WorkplaceFeatures { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<RecurringRule> RecurringRules { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Составной ключ для ZoneFeature
            builder.Entity<ZoneFeature>()
                .HasKey(zf => new { zf.ZoneId, zf.FeatureId });

            // Составной ключ для WorkplaceFeature
            builder.Entity<WorkplaceFeature>()
                .HasKey(wf => new { wf.WorkplaceId, wf.FeatureId });

            // Notification → User: запретить каскад
            builder.Entity<Notification>()
                .HasOne(n => n.User)
                .WithMany()
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Booking → User: запретить каскад
            builder.Entity<Booking>()
                .HasOne(b => b.User)
                .WithMany()
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
