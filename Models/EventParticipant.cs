namespace CircleConnect.Models
{
    public class EventParticipant : BaseEntity
    {
        public int Id { get; set; }

        public bool isAdmin { get; set; }

        // Navigation Properties
        public int UserId { get; set; }
        public User? User { get; set; }

        public int EventId { get; set; }
        public Event? Event { get; set; }
    }
}
