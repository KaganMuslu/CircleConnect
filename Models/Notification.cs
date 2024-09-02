using System.Text.Json.Serialization;

namespace CircleConnect.Models
{
    public class Notification : BaseEntity
    {
        [JsonIgnore]
        public int Id { get; set; }

        public required string Content { get; set; }
        public required string Type { get; set; }
        public bool IsRead { get; set; }

        // Navigation Properties
        public int UserId { get; set; }
        [JsonIgnore]
        public User? User { get; set; }
    }
}
