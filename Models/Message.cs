using System.Text.Json.Serialization;

namespace CircleConnect.Models
{
    public class Message : BaseEntity
    {
        [JsonIgnore]
        public int Id { get; set; }

        public required string Content { get; set; }

        // Navigation Properties
        public int CommunityId { get; set; }
        [JsonIgnore]
        public Community? Community { get; set; }

        public int UserId { get; set; }
        [JsonIgnore]
        public User? User { get; set; }
    }
}
