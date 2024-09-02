using System.Text.Json.Serialization;

namespace CircleConnect.Models
{
    public class User : BaseEntity
    {
        [JsonIgnore]
        public int Id { get; set; }

        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }

        // Navigation Properties
        [JsonIgnore]
        public List<Message>? Messages { get; set; }
        [JsonIgnore]
        public List<Notification>? Notifications { get; set; }
        [JsonIgnore]
        public List<EventParticipant>? EventParticipants { get; set; }
        [JsonIgnore]
        public List<CommunityParticipant>? JoinedCommunities { get; set; }
    }
}
