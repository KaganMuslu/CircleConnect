namespace CircleConnect.Models
{
    public class Event : BaseEntity
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Location { get; set; }
        public required DateTime Date { get; set; }

        // Navigation Properties
        public int UserId { get; set; }
        public User? User { get; set; }

        public int CommunityId { get; set; }
        public Community? Community { get; set; }

        public List<EventParticipant>? EventParticipants { get; set; }
    }
}
