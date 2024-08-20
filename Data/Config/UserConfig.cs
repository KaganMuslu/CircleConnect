using CircleConnect.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CircleConnect.Data.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new User
                {
                    Id = 1,
                    Username = "hako12",
                    Email = "hako12@circle.com",
                    Password = "a58f45g88jf85"
                },
                new User
                {
                    Id = 2,
                    Username = "fako15",
                    Email = "fako15@circle.com",
                    Password = "b58f45g88jf85"
                },
                new User
                {
                    Id = 3,
                    Username = "cako22",
                    Email = "cako22@circle.com",
                    Password = "c58f45g88jf85"
                }
            );
        }
    }
}
