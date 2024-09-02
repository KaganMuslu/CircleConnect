using CircleConnect.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CircleConnect.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
                new Category
                {
                    Id = 1,
                    Name = "Technology",
                    Description = "General technology ideas"
                },
                new Category
                {
                    Id = 2,
                    Name = "Blockchain",
                    Description = "Blockchain knowledge and ideas"
                },
                new Category
                {
                    Id = 3,
                    Name = "Bussiness",
                    Description = "Bussiness ideas to investors"
                }
            );
        }
    }
}
