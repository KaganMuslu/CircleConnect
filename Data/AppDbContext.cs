using CircleConnect.Data.Config;
using CircleConnect.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace CircleConnect.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<CommunityCategory> CommunityCategories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventParticipant> EventParticipants { get; set; }
        public DbSet<CommunityParticipant> CommunityParticipants { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<User> Users { get; set; }

        #region On Model Creating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Config Apply
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new CommunityConfig());
            modelBuilder.ApplyConfiguration(new EventConfig());
            modelBuilder.ApplyConfiguration(new MessageConfig());
            modelBuilder.ApplyConfiguration(new NotificationConfig());


            #region Many To Many Realtions

            // CommunityCategory
            modelBuilder.Entity<CommunityCategory>()
                .HasOne(c => c.Category)
                .WithMany(ca => ca.CommunityCategories)
                .HasForeignKey(ci => ci.CategoryId);

            modelBuilder.Entity<CommunityCategory>()
                .HasOne(c => c.Community)
                .WithMany(ca => ca.CommunityCategories)
                .HasForeignKey(ci => ci.CommunityId);

            // EventParticipant
            modelBuilder.Entity<EventParticipant>()
                .HasOne(c => c.Event)
                .WithMany(ca => ca.EventParticipants)
                .HasForeignKey(ci => ci.EventId);

            modelBuilder.Entity<EventParticipant>()
                .HasOne(c => c.User)
                .WithMany(ca => ca.EventParticipants)
                .HasForeignKey(ci => ci.UserId);

            // CommunityParticipant
            modelBuilder.Entity<CommunityParticipant>()
                .HasOne(c => c.Community)
                .WithMany(ca => ca.JoinedCommunities)
                .HasForeignKey(ci => ci.CommunityId);

            modelBuilder.Entity<CommunityParticipant>()
                .HasOne(c => c.User)
                .WithMany(ca => ca.JoinedCommunities)
                .HasForeignKey(ci => ci.UserId);

            #endregion

        }

        #endregion

    }
}
