using System.Text.Json.Serialization;

namespace CircleConnect.Models
{
    public class Event : BaseEntity
    {
        [JsonIgnore]
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Location { get; set; }
        public required DateTime Date { get; set; }

        // Navigation Properties
        public int UserId { get; set; }
        [JsonIgnore]
        public User? User { get; set; }

        public int CommunityId { get; set; }
        [JsonIgnore]
        public Community? Community { get; set; }

        [JsonIgnore]
        public List<EventParticipant>? EventParticipants { get; set; }
    }
}
