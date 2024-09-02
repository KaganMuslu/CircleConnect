using CircleConnect.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CircleConnect.Data.Config
{
    public class CommunityConfig : IEntityTypeConfiguration<Community>
    {
        public void Configure(EntityTypeBuilder<Community> builder)
        {
            builder.HasData
                (
                    new Community
                    {
                        Id = 1,
                        Name = "Tech Enthusiasts",
                        Description = "A community for technology enthusiasts to discuss the latest trends.",
                        Location = "San Francisco",
                        IsPrivate = 0
                    },
                    new Community
                    {
                        Id = 2,
                        Name = "Book Club",
                        Description = "A group of book lovers sharing and discussing their favorite books.",
                        Location = "New York",
                        IsPrivate = 1
                    },
                    new Community
                    {
                        Id = 3,
                        Name = "Fitness and Health",
                        Description = "A community for people passionate about fitness and a healthy lifestyle.",
                        Location = "Los Angeles",
                        IsPrivate = 0
                    }
                );
        }
    }
}
