using CircleConnect.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CircleConnect.Data.Config
{
    public class MessageConfig : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasData
            (
                new Message
                {
                    Id = 1,
                    Content = "Hi, i am Kagan!",
                    CommunityId = 2,
                    UserId = 1
                },
                new Message
                {
                    Id = 2,
                    Content = "I am a Junior Software Developer.",
                    CommunityId = 1,
                    UserId = 3
                },
                new Message
                {
                    Id = 3,
                    Content = "I am passionate about technologies and love to learn new things.",
                    CommunityId = 3,
                    UserId = 2
                }
            );
        }
    }
}
