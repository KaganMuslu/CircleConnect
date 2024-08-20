using System.Text.Json.Serialization;

namespace CircleConnect.Models
{
    public class Community : BaseEntity
    {
        [JsonIgnore]
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Location { get; set; }
        public int IsPrivate { get; set; }

        // Navigation Properties
        [JsonIgnore]
        public List<Event>? Events { get; set; }

        [JsonIgnore]
        public List<CommunityCategory>? CommunityCategories { get; set; }
        [JsonIgnore]
        public List<CommunityParticipant>? JoinedCommunities { get; set; }
        [JsonIgnore]
        public List<Message>? Messages { get; set; }
    }
}
