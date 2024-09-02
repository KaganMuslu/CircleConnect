using CircleConnect.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CircleConnect.Data.Config
{
    public class NotificationConfig : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasData
            (
                new Notification
                {
                    Id = 1,
                    Content = "Ankara Techno Meeting",
                    Type = "Meeting",
                    IsRead = true,
                    UserId = 1
                },
                new Notification
                {
                    Id = 2,
                    Content = "Sabanci Event",
                    Type = "Event",
                    IsRead = true,
                    UserId = 3
                },
                new Notification
                {
                    Id = 3,
                    Content = "Book Worms Istanbul",
                    Type = "Event",
                    IsRead = false,
                    UserId = 2
                }
            );
        }
    }
}
