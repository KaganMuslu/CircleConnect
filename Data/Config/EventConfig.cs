using CircleConnect.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CircleConnect.Data.Config
{
    public class EventConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasData
            (
                new Event
                {
                    Id = 1,
                    Name = "Tech Community Meetup",
                    Description = "An event for tech enthusiasts to network and share knowledge.",
                    Location = "Tech Park, Room 302",
                    Date = new DateTime(2024, 9, 15, 10, 0, 0),
                    UserId = 1,
                    CommunityId = 3
                },
                new Event
                {
                    Id = 2,
                    Name = "AI and Machine Learning Workshop",
                    Description = "A hands-on workshop on AI and Machine Learning trends.",
                    Location = "Innovation Hub, Room 210",
                    Date = new DateTime(2024, 10, 10, 14, 0, 0),
                    UserId = 2,
                    CommunityId = 1
                },
                new Event
                {
                    Id = 3,
                    Name = "Startup Pitch Day",
                    Description = "A platform for startups to pitch their ideas to investors.",
                    Location = "Business Center, Main Hall",
                    Date = new DateTime(2024, 11, 5, 9, 0, 0),
                    UserId = 3,
                    CommunityId = 2
                }
            );
        }
    }
}
