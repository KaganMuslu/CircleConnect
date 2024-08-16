using CircleConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace CircleConnect.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<CommunityCategory> CommunityCategories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventParticipant> EventParticipants { get; set; }
        public DbSet<JoinedCommunity> JoinedCommunities { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            // JoinedCommunity
            modelBuilder.Entity<JoinedCommunity>()
                .HasOne(c => c.Community)
                .WithMany(ca => ca.JoinedCommunities)
                .HasForeignKey(ci => ci.CommunityId);

            modelBuilder.Entity<JoinedCommunity>()
                .HasOne(c => c.User)
                .WithMany(ca => ca.JoinedCommunities)
                .HasForeignKey(ci => ci.UserId);
        }
    }
}
