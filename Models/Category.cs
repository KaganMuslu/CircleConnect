using System.Text.Json.Serialization;

namespace CircleConnect.Models
{
    public class Category : BaseEntity
    {
        [JsonIgnore]
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }


        // Navigation Properties
        [JsonIgnore] // Swagger'da bu alanın gösterilmemesi için kullanılır!
        public List<CommunityCategory>? CommunityCategories { get; set; }

    }
}
